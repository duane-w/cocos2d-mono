//
// NOT FOR USE IN PRODUCTION
// 
// THIS IS SAMPLE CODE, IT WILL HELP YOU GET STARTED, BUT NOT MUCH MORE THAN THAT
//
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Mono.Options;

class SourceStream : Stream
{
    Stream source;

    public SourceStream(Stream source)
    {
        this.source = source;
    }

    public override bool CanRead { get { return true; } }
    public override bool CanWrite { get { return false; } }
    public override bool CanSeek { get { return false; } }
    public override long Length { get { return source.Length; } }
    public override long Position { get { throw new Exception(); } set { throw new Exception(); } }
    public override void Flush() { throw new Exception(); }

    public override int Read(byte[] buf, int offset, int count)
    {
        int n = 0;

        for (int i = 0; i < count; i++)
        {
            int c = ReadByte();
            if (c == -1)
                return n;
            buf[offset + n] = (byte)c;
            n++;
        }
        return n;
    }

    public override long Seek(long p, SeekOrigin o)
    {
        throw new Exception();
    }

    public override void SetLength(long l)
    {
        throw new Exception();
    }

    public override void Write(byte[] b, int a, int c)
    {
        throw new Exception();
    }

    public override int ReadByte()
    {
    restart:
        int n = source.ReadByte();
        if (n == -1)
            return -1;

        if (n == '/')
        {
            int p = source.ReadByte();
            if (p == '/')
            {
                while (true)
                {
                    n = source.ReadByte();
                    if (n == -1)
                        return -1;
                    if (n == '\n')
                        return n;
                }
            }
            else if (p == '*')
            {
                while (true)
                {
                    n = source.ReadByte();
                    if (n == -1)
                        return -1;
                    while (n == '*')
                    {
                        n = source.ReadByte();
                        if (n == -1)
                            return -1;
                        if (n == '/')
                            goto restart;
                    }
                }
            }
            source.Position = source.Position - 1;
            return '/';
        }
        return n;
    }
}

class Declaration
{
	public string selector, retval, parameters, signature, getter, type;
    public bool is_abstract, is_static, appearance, hasBlock;
	public bool is_protocol, setter, is_property;

	public Declarations Parent;

	// For interface method
    public Declaration(string selector, string retval, string parameters, bool is_abstract, bool is_static, 
	                   bool appearance, bool hasBlock, string line, bool is_protocol)
    {
		this.is_protocol = is_protocol;

        this.selector = selector;
        this.retval = retval;
        this.parameters = parameters;
        this.is_abstract = is_abstract;
        this.is_static = is_static;
        this.appearance = appearance;
        this.hasBlock = hasBlock;
		this.signature = line;
    }	
	// For properties
	public Declaration (string selector, bool appearance, string type, string getter, bool setter, bool is_abstract, string line)
	{
		is_property = true;

		this.selector = selector;
		this.appearance = appearance;
		this.getter = getter;
		this.setter = setter;
		this.signature = line;
		if (type.Contains("void"))
			type = "IntPtr";
		this.type = type;
		this.is_abstract = is_abstract;
	}


}

class Declarations
{
    public List<Declaration> decls = new List<Declaration>();
    public StringBuilder gencs;
    public string ClassName;
	public string ParentClassName;
	public string Definition;
	public bool IsProtocol = false;
	public StringBuilder partialClass = new StringBuilder();

	public List<string> Protocols;

    public Declarations(StringBuilder gencs)
    {
        this.gencs = gencs;
    }

    public void Add(Declaration d)
    {
        if (d == null)
            return;

		d.Parent = this;
        decls.Add(d);
    }

    int Count(string s, char k)
    {
        int count = 0;
        foreach (char c in s)
            if (c == k)
                count++;
        return count;
    }

    string HasGetter(string getter1, string getter2)
    {
        if (HasGetter(getter1))
            return getter1;
        if (HasGetter(getter2))
            return getter2;
        return null;
    }

    bool HasGetter(string getter)
    {
        var found = (from d in decls
                     let sel = d.selector
                     where Count(sel, ':') == 0 && sel == getter && d.is_property == false
                     select d).FirstOrDefault();
        return found != null;
    }

    bool Remove(string sel)
    {
        ignore.Add(sel);
        return true;
    }

	private void AddParentConstructors ()
	{
		string parentClass = ParentClassName;
		while (string.IsNullOrEmpty(parentClass) == false && parentClass != "NSObject") {

			Declarations parentDecl;
			if (TrivialParser.interfaceCache.TryGetValue (parentClass, out parentDecl) == false)
				break;

			var ctors = (from c in parentDecl.decls
			             where c.is_property == false &&
			             c.retval == "NSObject" &&
			             c.selector.StartsWith("init")
			             select c).ToList();

			foreach (var c in ctors)
			{
				var existingCtor = decls.Where(f => f.retval == "NSObject" && f.selector == c.selector).FirstOrDefault();
				if (existingCtor == null)
					decls.Add(c);
			}

			parentClass = parentDecl.ParentClassName;
		}
	}

    List<string> ignore = new List<string>();

	static List<string> createdDelegates = new List<string>();

    private string GenerateBlockDelegates (Declaration block)
	{
		int iOfBegin = block.parameters.IndexOf ("BEGINBLOCK");
		int iOfEnd = block.parameters.IndexOf ("ENDBLOCK");
		string delegateSignature = block.parameters.Substring (iOfBegin, iOfEnd + 8 - iOfBegin);
		delegateSignature = delegateSignature.Replace ("BEGINBLOCK", "").Replace ("ENDBLOCK", "");

		string name;
		if (TrivialParser.renameDelegateByParameters.TryGetValue (delegateSignature, out name) == false)
			name = ClassName + "Delegate" + TrivialParser.AsMethod (block.selector).Replace (":", "");

		string newName;
		if (TrivialParser.renameDelegate.TryGetValue (name, out newName) == true)
			name = newName;

		string newDelegateSignature;
		if (TrivialParser.changeSignatureForSelector.TryGetValue (name, out newDelegateSignature) == true)
			delegateSignature = newDelegateSignature;

		if (createdDelegates.Contains (name) == false) {
			TrivialParser.gencs.WriteLine (string.Format ("\t\tdelegate void {0} ({1});", name, delegateSignature));
			createdDelegates.Add (name);
		}
        return name;
    }

    public void Generate (string extraAttribute)
	{
		GenerateProperty (extraAttribute);

		if (Protocols != null) {
			foreach (string usedProto in Protocols) {
				Declarations proto;
				if (TrivialParser.protocolCache.TryGetValue (usedProto, out proto) == true) {
					foreach (var protoDecl in proto.decls) {
						var interfaceDecl = decls.Where (f => f.selector == protoDecl.selector).FirstOrDefault ();
						if (interfaceDecl == null)
							decls.Add (protoDecl);
					}
				}
			}
		}

		var copy = decls;
		var properties = (from d in copy
                          let sel = d.selector
                          where sel.StartsWith ("set") && sel.EndsWith (":") && Count (sel, ':') == 1 && d.is_property == false
                          let getter1 = Char.ToLower (sel [3]) + sel.Substring (4).Trim (':')
                          let getter2 = "is" + sel.Substring (3).Trim (':')
                          let getter = HasGetter (getter1, getter2)
                          where getter != null
                          let r = Remove (sel)
                          select new 
		                  { 
							getter = getter,
							decl = d }).ToList ();


		AddParentConstructors ();

        foreach (var d in decls)
        {
			if (d.is_property)
				continue;
            if (d.parameters != null && (d.parameters.Contains("^") || d.parameters.Contains("const")))
                continue;
            if (d.selector.Contains("DEPRECATED_ATTRIBUTE") ||
                string.IsNullOrEmpty(d.selector) == true ||
                d.selector.Contains("*"))
                continue;
            if (ignore.Contains(d.selector) || properties.FirstOrDefault(f => f.getter == d.selector) != null)
                continue;

			if (TrivialParser.skipSelector.FirstOrDefault (rl => d.signature.Contains(rl)) != null)
				continue;

			if (TrivialParser.skipSelectorByName.Contains (this.ClassName + "_" + d.selector))
				continue;

            string delegateName = "";
			string parameters = d.parameters;
            if (d.hasBlock)
            {
                delegateName = GenerateBlockDelegates(d);
                int iOfBegin = d.parameters.IndexOf("BEGINBLOCK");
                int iOfEnd = d.parameters.IndexOf("ENDBLOCK");
                string strToReplace = d.parameters.Substring(iOfBegin, iOfEnd + 8 - iOfBegin);
                parameters = d.parameters.Replace(strToReplace, delegateName + " _delegate");
            }

            string retVal = d.retval;
            string selector = d.selector;
            if ((d.retval == "NSObject" || d.retval == this.ClassName) && d.selector.StartsWith("init"))
            {
                retVal = "IntPtr";
				bool preserveConstructorAsMethod = TrivialParser.preserverConstructorAsMethod.Contains (this.ClassName + "_" + d.selector);
				if (preserveConstructorAsMethod == false)
                	selector = "Constructor";

                if (string.IsNullOrEmpty(parameters))
                    continue;
            }

			if (selector == "Constructor")
			{
				string extraArgs;
			 	if (TrivialParser.addArgToConstructor.TryGetValue(this.ClassName + "_" + d.selector, out extraArgs) == true)
					parameters += ", " + extraArgs;
			}

			if (d.Parent != this && selector == "Constructor")
			{
				gencs.AppendFormat("\t\t// Constructor from '{0}'", d.Parent.ClassName);
				gencs.AppendLine ();
			}

			gencs.AppendFormat("\t\t//{0}", d.signature);
			gencs.AppendLine ();

            if (extraAttribute != null)
            {
                gencs.AppendFormat("\t\t[{0}]", extraAttribute);
                gencs.AppendLine();
            }
            if (d.is_abstract)
            {
				if (this.IsProtocol)
                	gencs.AppendFormat("\t\t[Abstract]");
				else
					gencs.AppendFormat("\t\t// From protocol '{0}'", d.Parent.ClassName);
                gencs.AppendLine();
            }
            if (d.is_static)
            {
                gencs.AppendFormat("\t\t[Static]");
                gencs.AppendLine();
            }

			string methodNameSelector = null;
			if (TrivialParser.renameMethodForSelector.TryGetValue (this.ClassName + "_" + selector, out methodNameSelector) == false)
				methodNameSelector = selector;

			methodNameSelector = TrivialParser.AsMethod(TrivialParser.CleanSelector(methodNameSelector));

			foreach (var f in TrivialParser.makeSelectorInternalWith)  {
				if (d.signature.Contains(f)) {
					gencs.AppendLine("\t\t[Internal]");
					break;
				}
			}

			string newReturnType = null;
			if (TrivialParser.changeReturnType.TryGetValue (this.ClassName + "_" + selector, out newReturnType) == true)
				retVal = newReturnType;

            if (d.appearance)
                gencs.AppendLine("\t\t[Appearance]");
            gencs.AppendFormat("\t\t[Export (\"{0}\")]", d.selector);
            gencs.AppendLine();

            gencs.AppendFormat("\t\t{0} {1} ({2});", retVal, methodNameSelector, parameters);
            gencs.AppendLine();
            gencs.AppendLine();
        }

        if (properties.Count > 0)
            gencs.AppendLine("\t\t//Detected properties");

        foreach (var d in properties)
        {
            var decl = (from x in decls where x.selector == d.getter && x.is_property == false && x.is_static == d.decl.is_static select x).FirstOrDefault();
			//var decl = d.decl;
            var sel = decl.selector;
            if (sel.Contains("DEPRECATED_ATTRIBUTE") ||
                sel.Contains("*"))
                continue;

			if (TrivialParser.skipSelector.FirstOrDefault (rl => decl.signature.Contains(rl)) != null)
				continue;

			//gencs.AppendFormat("\t\t//{0}", d.signature);
			//gencs.AppendLine ();

            if (decl.is_abstract) {
				if (this.IsProtocol)
                	gencs.AppendLine("\t\t[Abstract]");
				else {
					gencs.AppendFormat("\t\t// From protocol '{0}'", decl.Parent.ClassName);
					gencs.AppendLine ();
				}
			}


            if (decl.is_static)
                gencs.AppendLine("\t\t[Static]");
            gencs.AppendFormat("\t\t[Export (\"{0}\")]", sel);
            gencs.AppendLine();

			if (sel.StartsWith("is"))
                sel = Char.ToLower(sel[2]) + sel.Substring(3);

			string methodName = TrivialParser.AsMethod(sel);
			string newVal;
			if (TrivialParser.renameProperty.TryGetValue(string.Format("{0}.{1}.{2}", 
			                                                       this.ClassName, methodName, decl.is_static ? "Static" : "NonStatic"), out newVal) == true)
			{
				methodName = newVal;
			}

			if (TrivialParser.allowNullProperty.Contains (this.ClassName + "_" + decl.selector) == true)
			{
				gencs.AppendLine("[NullAllowed]");
			}

            gencs.AppendFormat("\t\t{0} {1} {{ {2}get; set; }}", decl.retval, methodName,
                     d.getter.StartsWith("is") ? "[Bind (\"" + d.getter + "\")]" : "");
            gencs.AppendLine();
            gencs.AppendLine();
        }
    }

	public void GenerateProperty (string extraAttribute)
	{
		gencs.AppendLine("\t\t//From Generated Property");
		var properties = (from prop in decls
		                  where prop.is_property == true
		                  select prop).ToList ();

		foreach (var prop in properties) {

			if (TrivialParser.skipSelector.FirstOrDefault (rl => prop.signature.Contains(rl)) != null)
				continue;

			gencs.AppendFormat("\t\t//{0}",  prop.signature);
			gencs.AppendLine ();

			if (extraAttribute != null) {
				gencs.AppendFormat ("\t\t[{0}]", extraAttribute);
				gencs.AppendLine ();
			}
			if (prop.is_abstract)
				gencs.AppendLine("\t\t[Abstract]");
			if (prop.appearance)
				gencs.AppendLine ("\t\t[Appearance]");
			if (TrivialParser.allowNullProperty.Contains (this.ClassName + "_" + prop.selector) == true)
				gencs.AppendLine("\t\t[NullAllowed]");

			gencs.AppendFormat ("\t\t[Export (\"{0}\")]\n", prop.selector);

			gencs.AppendFormat ("\t\t{0} {1} {{ {2} {3} }}\n",
                 TrivialParser.RemapType (prop.type), TrivialParser.AsMethod (prop.selector),
                 prop.getter != null ? "[Bind (\"" + prop.getter + "\")] get;" : "get;",
                 prop.setter ? "" : "set; ");
			gencs.AppendLine ();
		}
	}

	private void ProcessRequiresNILTermination (Declaration decl, string internalMethodName)
	{
		string classTemplate = @"
	public RETURNTYPE METHODNAME (ARGS, params PARAMTYPE[] PARAMNAME)
	{
		using (PointerToArray pArray = new PointerToArray())
		{
			IntPtr pArgs = AppendArgs (args);

			VOIDRETURN this.ORIGMETHOD (ORIGARGLIST pArgs);
		}
	}";

		classTemplate = classTemplate.Replace ("METHODNAME", internalMethodName);
		string newArgs = decl.parameters.Replace (",IntPtr NS_REQUIRES_NIL_TERMINATION", "");
		string[] argList = newArgs.Split (new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
		List<string> paramList = argList.ToList ().Take (argList.Count () - 1).ToList ();
		string callArgs = "";
		foreach (string c in paramList) {
			callArgs += c.Split (new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)[1].Trim () + ",";
		}
		//if (string.IsNullOrEmpty (callArgs) == false)
		//	callArgs += ",";
		classTemplate = classTemplate.Replace ("ORIGARGLIST", callArgs);
		newArgs = string.Join (",", argList.ToList().Take(argList.Count() - 1).ToArray());
		if (string.IsNullOrEmpty(newArgs) == false)
			newArgs += ",";
		classTemplate = classTemplate.Replace("ARGS,", newArgs);
		string paramType = argList[argList.Count() -1].Split(' ')[0].Trim ();
		string paramName = argList[argList.Count() -1].Split(' ')[1].Trim ();
		classTemplate = classTemplate.Replace ("PARAMTYPE", paramType);
		classTemplate = classTemplate.Replace ("PARAMNAME", paramName);
		classTemplate = classTemplate.Replace ("ORIGMETHOD", internalMethodName);
		classTemplate = classTemplate.Replace ("RETURNTYPE", decl.retval);

		if (decl.retval == "void")
			classTemplate = classTemplate.Replace ("VOIDRETURN", "");
		else
			classTemplate = classTemplate.Replace ("VOIDRETURN", "");



	}
}

class TrivialParser
{
    static internal TextWriter gencs, other;
    //StringBuilder currentWork;
    StreamReader r;

    // Used to limit which APIs to include in the binding
    string limit;
    string extraAttribute;
    OptionSet options;

    ArrayList types = new ArrayList();

    Declaration ProcessProperty(string line, bool appearance, bool is_abstract)
    {
        bool ro = false;
        string getter = null;

        line = CleanDeclaration(line);
        if (line.Length == 0)
            return null;

        int ii = line.IndexOf("<");
        if (ii != -1)
        {
            int rr = line.IndexOf(">");
            string uu = line.Substring(ii, rr - ii + 1);
            line = line.Replace(uu, "");
        }

        line = line.Replace("unsigned int", "uint");
        line = line.Replace("unsigned char", "byte");

        int p = line.IndexOf(')');
        var sub = line.Substring(0, p + 1);
        if (sub.IndexOf("readonly") != -1)
        {
            ro = true;
        }
        int j = sub.IndexOf("getter=");
        if (j != -1)
        {
            int k = sub.IndexOfAny(new char[] { ',', ')' }, j + 1);
            //Console.WriteLine ("j={0} k={1} str={2}", j, k, sub);
            getter = sub.Substring(j + 7, k - (j + 7));
        }

        var type = new StringBuilder();
        int i = p + 1;
        for (; i < line.Length; i++)
        {
            char c = line[i];
            if (!Char.IsWhiteSpace(c))
                break;
        }
        for (; i < line.Length; i++)
        {
            char c = line[i];
            if (Char.IsWhiteSpace(c))
                break;
            type.Append(c);
        }

        for (; i < line.Length; i++)
        {
            char c = line[i];
            if (Char.IsWhiteSpace(c) || c == '*')
                continue;
            else
                break;
        }
        var selector = new StringBuilder();
        for (; i < line.Length; i++)
        {
            char c = line[i];
            if (Char.IsWhiteSpace(c) || c == ';')
                break;
            selector.Append(c);
        }
        /*if (extraAttribute != null)
        {
            currentWork.AppendFormat("\t\t[{0}]", extraAttribute);
            currentWork.AppendLine();
        }
        if (appearance)
            currentWork.AppendLine("\t\t[Appearance]");
        currentWork.AppendFormat("\t\t[Export (\"{0}\")]\n", selector);

        currentWork.AppendFormat("\t\t{0} {1} {{ {2} {3} }}\n",
                 RemapType(type.ToString()), AsMethod(selector.ToString()),
                 getter != null ? "[Bind (\"" + getter + "\")] get;" : "get;",
                 ro ? "" : "set; ");
        currentWork.AppendLine();*/

		return new Declaration(selector.ToString (), appearance, type.ToString (), getter, ro, is_abstract, line);
    }

    public static string AsMethod(string msg)
    {
        if (msg.Length == 0)
            return msg;

        return Char.ToUpper(msg[0]) + msg.Substring(1);
    }

    string MakeSelector (string sig)
	{
		if (sig.Contains ("actionWithBlock"))
			debugStop = true;
		if (sig.Contains ("^")) {
			sig = sig.Replace ("( ", "(").Replace (" (", "(").Replace (" )", ")").Replace (") ", ")");
			int blockStart = sig.IndexOf ("(void(^)");
			int blockStop = sig.IndexOf ("))");
			string blockRemove = sig.Substring (blockStart, blockStop - blockStart + 2);
			sig = sig.Replace (blockRemove, "(BLOCKDEF)");
		}

        StringBuilder sb = new StringBuilder();
        string[] xx = sig.Split('(');
        sb.Append(xx[0].Trim());
        if (xx.Count() > 1)
        {
            foreach (var y in xx.Skip(1))
            {
                if (y.Contains(':') == false)
                    break;
				string[] yy = y.Trim().Split(new char[] { ' ', ')' });
                if (yy.Count() == 1)
                    break;
                sb.Append(yy[yy.Length - 1].Trim());
            }
        }

        return sb.ToString();

        for (int i = 0; i < sig.Length; i++)
        {
            char c = sig[i];
            if (c == ' ')
                continue;
            if (c == ';')
                break;
            else if (c == ':')
            {
                sb.Append(c);
                i++;
                for (; i < sig.Length; i++)
                {
                    c = sig[i];
                    if (c == ')')
                    {
                        for (++i; i < sig.Length; i++)
                        {
                            if (!Char.IsLetterOrDigit(sig[i]))
                                break;
                        }
                        break;
                    }
                }
            }
            else
                sb.Append(c);
        }
        return sb.ToString();
    }

    enum State
    {
        SkipToType,
        EndOfType,
        Parameter,

    }

    string MakeParameters (string sig, string selector, string className)
	{
		if (sig.Contains("NS_REQUIRES_NIL_TERMINATION"))
			debugStop = true;
		List<string> usedParams = new List<string> ();
		string[] selectorParms = selector.Split(':');
		StringBuilder sb = new StringBuilder ();
		string st = null;
		string[] qq = sig.Split (':');
		string[] xx = sig.Split(':');
		int idx = 0;
		string typeName = null;
		string paramName = null;

		if (qq.Count () > 1) {

			foreach (string qqq in qq.Skip(1)) {

				bool isBlock = false;

				if (qqq.Contains("^"))  {

					isBlock = true;

					foreach (var y3 in qqq.Split(')').Skip(1))  {

						int r8 = y3.LastIndexOf('*');
                        if (r8 != -1)
                        {
							string[] jj = y3.Split(new char[] {' ', '*' }, StringSplitOptions.RemoveEmptyEntries);

							typeName = jj[0].Replace("(", "").Trim (); //y3.Substring(0, r8 + 1).Replace("((", "");
                            paramName = jj[1].Trim ();

                            //sb.Append(RemapType(r9) + " ");
                            //sb.Append(rA);

						}
                        else if (y3 == "(" || y3 == "")
                            break;
                        else
                        {
                            string[] y4 = y3.Split(' ');
                            typeName = y4[0].Replace ("(", "");
                            if (y4.Count() > 1)
                                paramName = y4[1];
                            else
                                paramName = "obj";
                            //sb.Append(RemapType(y4[0].Replace("(", "")) + " ");
                            //sb.Append(y4[1].Trim());
                        }
					}

					if (string.IsNullOrEmpty(typeName))
                	{
	                    //if (isBlock)
						{
							//sb.Append("BEGINBLOCKENDBLOCK");
							sb.Append ( "BEGINBLOCKENDBLOCK,");
							continue;
						}
					}
				}
				else  {

					string[] ww = qqq.Split (new char[] {'*', ')' });
					string[] dd = qqq.Split (new char[] {' ', ')', '*' }, StringSplitOptions.RemoveEmptyEntries);

					typeName = ww[0].Replace("(", "").Trim();
					paramName = dd[1].Replace (",", "").Trim ();
					if (idx > 0 && string.IsNullOrEmpty(selectorParms[idx]) == false)
						paramName = selectorParms[idx];
				}

				if (isBlock)
                    sb.Append("BEGINBLOCK");

                if (paramName == "object")
                    paramName = "obj";
                else if (paramName == "string")
                    paramName = "str";
                else if (paramName == "params")
                    paramName = "args";
				else if (paramName == "event")
					paramName = "evt";
				else if (paramName == "delegate")
					paramName = "del";
				else if (paramName == "int")
					paramName = "intArg";

                int cc = usedParams.Count(f => f == paramName);
                usedParams.Add(paramName);
                if (cc > 0)
                    paramName += cc.ToString();

				string nullArg = "";
				if (allowNullArg.TryGetValue (className + "_" + selector, out nullArg) == true && nullArg == paramName)
				{
					sb.Append("[NullAllowed] ");
				}

				if (typeName == "void")
					typeName = "IntPtr";
				sb.Append(RemapType(typeName) + " ");

				sb.Append(paramName);
				if (isBlock)
                    sb.Append("ENDBLOCK");
				sb.Append (",");

				idx++;
			}

			if (sig.Contains("NS_REQUIRES_NIL_TERMINATION"))
                sb.Append ("IntPtr NS_REQUIRES_NIL_TERMINATION,");

			st = sb.ToString().Substring(0, sb.Length - 1);

		}
		return st;

        //string[] xx = sig.Split(':');

        
        if (xx.Count() > 1)
        {
            foreach (var y in xx.Skip(1))
            {
                string[] yy = y.Split(')');
                typeName = "";
                paramName = "";
                bool isBlock = false;

                if (yy[0].Contains("^"))
                {
                    isBlock = true;
                    foreach (string y3 in yy.Skip(1))
                    {
                        int r8 = y3.LastIndexOf('*');
                        if (r8 != -1)
                        {
                            string r9 = y3.Substring(0, r8 + 1).Replace("((", "");
                            string rA = y3.Substring(r8 + 1);
                            typeName = r9;
                            paramName = rA;
                            //sb.Append(RemapType(r9) + " ");
                            //sb.Append(rA);
                        }
                        else if (y3 == "(" || y3 == "")
                            break;
                        else
                        {
                            string[] y4 = y3.Split(' ');
                            typeName = y4[0];
                            if (y4.Count() > 1)
                                paramName = y4[1];
                            else
                                paramName = "obj";
                            //sb.Append(RemapType(y4[0].Replace("(", "")) + " ");
                            //sb.Append(y4[1].Trim());
                        }
                    }
                }
                else
                {
                    typeName = yy[0];
                    paramName = yy[1];
                }

                if (string.IsNullOrEmpty(typeName))
                {
                    if (isBlock)
                    {
                        //sb.Append("BEGINBLOCKENDBLOCK");
                        return "BEGINBLOCKENDBLOCK";
                    }
                    return null;
                }

                if (isBlock)
                    sb.Append("BEGINBLOCK");
                sb.Append(RemapType(typeName.Replace("(", "").Trim()) + " ");
                string[] zz = paramName.Trim().Split(' ');

                paramName = zz[0].Trim();
                if (paramName == "object")
                    paramName = "obj";
                else if (paramName == "string")
                    paramName = "str";
                else if (paramName == "params")
                    paramName = "args";
				else if (paramName == "event")
					paramName = "evt";
				else if (paramName == "delegate")
					paramName = "del";

                int cc = usedParams.Count(f => f == paramName);
                usedParams.Add(paramName);
                if (cc > 0)
                    paramName += cc.ToString();

                sb.Append(paramName);
                if (isBlock)
                    sb.Append("ENDBLOCK");
                sb.Append(",");

                if (1 == 0)
                {
                    string[] iq = y.Replace("void(^)", "").Split(',');
                    foreach (string y2 in iq)
                    {
                        string y3 = y2.Replace("((", "").Replace("))block", "");
                        if (string.IsNullOrEmpty(y3))
                            break;
                        int r8 = y3.LastIndexOf('*');
                        if (r8 != -1)
                        {
                            string r9 = y3.Substring(0, r8 + 1).Replace("((", "");
                            string rA = y3.Substring(r8 + 1);
                            sb.Append(RemapType(r9) + " ");
                            sb.Append(rA);
                        }
                    }
                    return sb.ToString();
                }
            }

            st = sb.ToString().Substring(0, sb.Length - 1);

            if (sig.Contains("NS_REQUIRES_NIL_TERMINATION"))
                st += "IntPtr NS_REQUIRES_NIL_TERMINATION";
        }

        return st;
        int colon = sig.IndexOf(':');
        if (colon == -1)
            return "";

        var tsb = new StringBuilder();
        State state = State.SkipToType;
        for (int i = 0; i < sig.Length; i++)
        {
            char c = sig[i];

            switch (state)
            {
                case State.SkipToType:
                    if (Char.IsWhiteSpace(c))
                        continue;
                    if (c == '(')
                    {
                        tsb = new StringBuilder();
                        state = State.EndOfType;
                    }
                    break;
                case State.EndOfType:
                    if (c == ')')
                    {
                        state = State.Parameter;
                        sb.Append(RemapType(tsb.ToString()));
                        sb.Append(' ');
                    }
                    else
                    {
                        if (c != '*')
                            tsb.Append(c);
                    }
                    break;

                case State.Parameter:
                    if (Char.IsWhiteSpace(c))
                    {
                        state = State.SkipToType;
                        sb.Append(", ");
                    }
                    else
                    {
                        if (c != ';')
                            sb.Append(c);
                    }
                    break;
            }

        }

        //Console.WriteLine ("  -> {0}", sb);
        return sb.ToString();
    }

    public static string RemapType(string type)
    {
        int ii = type.IndexOf("<");
        if (ii != -1)
        {
            int gg = type.IndexOf(">");
            string rr = type.Substring(ii, gg - ii + 1);
            type = type.Replace(rr, "");
        }
        if (type.EndsWith("*"))
            type = type.Substring(0, type.Length - 1);
        type = type.Trim();
        switch (type)
        {
            case "NSInteger":
                return "int";
            case "CGFloat":
            case "GLfloat":
                return "float";
            case "NSTextAlignment":
                return "uint";

            case "NSString":
            case "NSString *":
                return "string";
            case "NSSize":
            case "CGSize":
                return "SizeF";
            case "NSRect":
            case "CGRect":
                return "RectangleF";
            case "NSPoint":
            case "CGPoint":
                return "PointF";
            case "NSGlyph":
                return "uint";
            case "unsigned int":
            case "NSUInteger":
                return "uint";
            case "instancetype":
            case "id":
                return "NSObject";
            case "BOOL":
            case "GLboolean":
                return "bool";
            case "SEL":
                return "Selector";
            case "NSURL":
                return "NSUrl";
            case "NSTimeInterval":
                return "double";
            case "dispatch_queue_t":
                return "DispatchQueue";
            //case "void":
            //    return "IntPtr";
            case "va_list":
                return "IntPtr";
        }
        return type;
    }

    Regex rx = new Regex("(NS_AVAILABLE\\(.*\\)|NS_AVAILABLE_IOS\\([0-9_]+\\)|NS_AVAILABLE_MAC\\([0-9_]+\\)|__OSX_AVAILABLE_STARTING\\([_A-Z0-9,]+\\))");
    Regex rx2 = new Regex("AVAILABLE_MAC_OS_X_VERSION[_A-Z0-9]*");
    Regex rx3 = new Regex("AVAILABLE_MAC_OS_X_VERSION[_A-Z0-9]*");
    Regex rx4 = new Regex("UI_APPEARANCE_SELECTOR");

    string CleanDeclaration(string line)
    {
        return rx4.Replace(rx3.Replace(rx2.Replace(rx.Replace(line, ""), ""), ""), "");
    }

    public static string CleanSelector(string selector)
    {
		return selector.Split(':')[0];
        return selector.Replace(":", "");
    }

    public static bool HasLimitKeyword(string line)
    {
        return line.IndexOf("__OSX_AVAILABLE_STARTING") != -1 || line.IndexOf("NS_AVAILABLE") != -1;
    }

    Declaration ProcessDeclaration(bool isProtocol, string line, bool is_optional, string className)
    {
        bool debug = false;
        if (line.IndexOf("6_0") != -1)
            debug = true;

        if (limit != null)
        {
            if (!HasLimitKeyword(line))
                return null;

            if (line.IndexOf(limit) == -1)
                return null;
        }

        if (line.Contains("^"))
            debug = debug;

        var appearance = (line.IndexOf("UI_APPEARANCE_SELECTOR") != -1);
        line = CleanDeclaration(line);
        if (line.Length == 0)
            return null;

        bool is_abstract = isProtocol && !is_optional;

        if (line.Contains("@property"))
        {
            //if (is_abstract)
             //   currentWork.AppendLine("\t\t[Abstract]");

            return ProcessProperty(line, appearance, is_abstract);
        }
        if (line.Contains("DEPRECATED_ATTRIBUTE") == true)
            return null;

		if (line.Contains ("onEnter"))
			debug = true;

		if (line[0] == '}')
			line = line.Substring(1);

        //Console.WriteLine ("PROCESSING: {0}", line);
        bool is_static = line.StartsWith("+");
        int p, q;
        p = line.IndexOf('(');
        if (p == -1)
            return null;
        q = line.IndexOf(')');
        //Console.WriteLine ("->{0}\np={1} q-p={2}", line, p, q-p);
		string retClass = line.Substring(p + 1, q - p - 1);
		//if (retClass == "id")
			//retClass = className;
        string retval = RemapType(retClass);
        p = line.IndexOf(';');
        string signature = line.Substring(q + 1, p - q).Trim(new char[] { ' ', ';' });
        bool isBlock = (line.IndexOf('^') != -1);

        //Console.WriteLine ("SIG: {0} {1}", line, p);
        string selector = MakeSelector(signature);
        string parameters = MakeParameters(signature, selector, className);

		//string newReturnType = null;
		//if (changeReturnType.TryGetValue (className + "_" + selector, out newReturnType) == true)
			//retval = newReturnType;

        //Console.WriteLine ("signature: {0}", signature);
        //Console.WriteLine ("selector: {0}", selector);
        return new Declaration(selector, retval, parameters, is_abstract, is_static, appearance, isBlock, line, isProtocol);
    }
	bool debugStop = false;
    public static Dictionary<string, Declarations> interfaceCache = new Dictionary<string, Declarations>();
    void ProcessInterface (string iface)
	{
		if (iface.Contains ("interface CCTransitionSlideInT"))
			debugStop = true;

		iface = iface.Replace (":", " : ");
		iface = Regex.Replace (iface, " {2,}", " ");

		bool need_close = iface.IndexOf ("{") != -1;
		var cols = iface.Split ();
		string line;

		//Console.WriteLine ("**** {0} ", iface);
		types.Add (cols [1]);

		Declarations decl = null;
		StringBuilder interfaceSB = null;
		string typeString = null;

		if (interfaceCache.TryGetValue (cols [1], out decl) == false) {
			decl = new Declarations (interfaceSB) { ClassName = cols[1] };

			interfaceSB = new StringBuilder ();
			interfaceCache [cols [1]] = decl;
			interfaceSB.AppendLine ();
			interfaceSB.AppendFormat ("\t//{0}", iface);

			if (extraAttribute != null)
				interfaceSB.AppendFormat ("\n\t[{0}]", extraAttribute);
			if (cols.Length >= 4) {
				string[] temp1 = cols [3].Split ('<');
				typeString = temp1 [0];
			}
			else {
				typeString = "NSObject";
				//interfaceSB.AppendFormat ("\n\t[BaseType (typeof ({0}))]", "NSObject");
			}

			//interfaceSB.AppendFormat ("\n\t[BaseType (typeof ({0}))]", typeString);
			decl.ParentClassName = typeString;

			if (iface.Contains("<")) {

 				int ii = iface.IndexOf ("<");
				if (ii != -1) {
					int rr = iface.IndexOf (">");
					string uu = iface.Substring (ii, rr - ii + 1).Replace ("<", "").Replace(">", "");
					string[] oo = uu.Split (',');
					List<string> usedProtocols = new List<string> ();
					foreach (string ooo in oo)
						usedProtocols.Add (ooo.Trim ());
					decl.Protocols = usedProtocols;
				}
			}

			string newTypeString = null;
			if (changeClassBaseType.TryGetValue(decl.ClassName, out newTypeString) == true)
				typeString = newTypeString;
			interfaceSB.AppendFormat ("\n\t[BaseType (typeof ({0}))]", typeString);

			interfaceSB.AppendLine ();
			interfaceSB.AppendFormat ("\t{0}interface {1} {{", limit == null ? "" : "public partial ", cols [1]);
			interfaceSB.AppendLine ();

			decl.Definition = interfaceSB.ToString ();
		}
		//decl = new Declarations(interfaceSB) { ClassName = cols[1] };
		//currentWork = interfaceSB;

		bool haveEnd = false;
		if (iface.Contains ("@end")) {
			line = iface;
			haveEnd = true;
		}

        while (haveEnd == false && (line = r.ReadLine()) != null && (need_close && !line.StartsWith("}")))
        {
            if (line == "{")
                need_close = true;
        }

        while (haveEnd == true || !line.StartsWith("@end"))
        {
            if (line.StartsWith("#"))
                continue;
            string full = "";

            while (haveEnd == true || (line = r.ReadLine()) != null && !line.StartsWith("@end"))
            {
                if (line.StartsWith("#"))
                    continue;

                full += line;
                if (full.IndexOf(';') != -1)
                {
                    full = full.Replace('\n', ' ');
                    decl.Add(ProcessDeclaration(false, full, false, decl.ClassName));
                    full = "";
                }

				if (haveEnd)
					break;
            }
            break;
        }
        //decl.Generate(extraAttribute);
    }

	public static Dictionary<string, Declarations> protocolCache = new Dictionary<string, Declarations>();
    void ProcessProtocol(string proto)
    {
        string[] d = proto.Split(new char[] { ' ', '<', '>' });
        string line;

        StringBuilder sbProtocol = new StringBuilder();
        types.Add(d[1]);

		Declarations decl = null;
 
        if (protocolCache.TryGetValue(d[1], out decl) == false)
        {
            sbProtocol = new StringBuilder();
			decl = new Declarations(sbProtocol) { ClassName = d[1], IsProtocol = true };
			protocolCache[d[1]] = decl;
			string typeString2 = "NSObject";

            if (extraAttribute != null)
                sbProtocol.AppendFormat("\n\t[{0}]", extraAttribute);
            if (d.Length >= 4)
            {
                typeString2 = d[3];
                int iii = typeString2.IndexOf("<");
                if (iii != -1)
                {
                    int rr = typeString2.IndexOf(">");
                    string uu = typeString2.Substring(iii, rr - iii + 1);
                    typeString2 = typeString2.Replace(uu, "");
                }
            }

			sbProtocol.AppendFormat("\t//{0}", proto);

			sbProtocol.AppendFormat("\n\t[BaseType (typeof ({0}))]", typeString2);
			sbProtocol.AppendLine();
			sbProtocol.AppendLine("\t[Model]");
        	sbProtocol.AppendFormat("\tinterface {0} {{\n", d[1]);
			sbProtocol.AppendLine();

			decl.Definition = sbProtocol.ToString ();
        }
        //currentWork = sbProtocol;

        bool optional = false;

        //var decl = new Declarations(sbProtocol);
        while ((line = r.ReadLine()) != null && !line.StartsWith("@end"))
        {
            if (line.StartsWith("@optional"))
                optional = true;

            string full = "";
            while ((line = r.ReadLine()) != null && !line.StartsWith("@end"))
            {
                full += line;
                if (full.IndexOf(';') != -1)
                {
                    full = full.Replace('\n', ' ');
                    decl.Add(ProcessDeclaration(true, full, optional, decl.ClassName));
                    full = "";
                }
            }
            if (line.StartsWith("@end"))
                break;
        }
        //decl.Generate(extraAttribute);
    }

    void ShowHelp()
    {
        options.WriteOptionDescriptions(Console.Out);

        Environment.Exit(0);
    }

    string Clean(string prefix, string line)
    {
        return line.Substring(line.IndexOf(prefix));
    }

    TrivialParser()
    {
#if false
		try {
			gencs = File.CreateText ("gen.cs");
		} catch {
			gencs = File.CreateText ("/tmp/gen.cs");
		}

		try {
			other = File.CreateText ("other.c");
		} catch {
			other = File.CreateText ("/tmp/other.c");
		}
#endif
        gencs = Console.Out;
        other = new StringWriter();

        options = new OptionSet() {
			{ "limit=", "Limit methods to methods for the specific API level (ex: 5_0)", arg => limit = arg },
			{ "extra=", "Extra attribute to add, for example: 'Since(6,0)'", arg => extraAttribute = arg },
			{ "rules=", "List of rules to apply to the beinding", arg => ruleListFile = arg },
			{ "help", "Shows the help", a => ShowHelp () }
		};
    }

	static string ruleListFile = null;
	List<string> ruleList = null;
	static public List<string> skipSelector = null;
	static public Dictionary<string,string> renameProperty = null;
	static public Dictionary<string, string> addArgToConstructor = null;
	static public Dictionary<string, string> changeClassBaseType = null;
	static public Dictionary<string, string> allowNullArg = null;
	static public Dictionary<string, string> renameMethodForSelector = null;
	static public Dictionary<string, string> renameDelegateByParameters = null;
	static public Dictionary<string, string> changeReturnType = null;
	static public Dictionary<string, string> changeSignatureForSelector = null;
	static public Dictionary<string, string> renameDelegate = null;
	static public List<string> makeSelectorInternalWith = null;
	static public List<string> preserverConstructorAsMethod = null;
	static public List<string> skipSelectorByName = null;
	static public List<string> allowNullProperty = null;

    void Run(string[] args)
    {
        List<string> sources = null;

        try
        {
            sources = options.Parse(args);
        }
        catch
        {
            Console.WriteLine("Error parsing argument");
            return;
        }
        if (sources.Count == 0)
            ShowHelp();
        gencs.WriteLine(@"
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;
using MonoMac.AppKit;
using System;
using System.Drawing;
using ccTime = System.Single;
using GLfloat = System.Single;
using GLshort = System.Int16;
using GLushort = System.UInt16;
using GLubyte = System.Byte;
using GLuint = System.UInt32;
using GLint = System.Int32;
using uint32_t = System.UInt32;
using CGImageRef = System.IntPtr;
using GLvoid = System.IntPtr;
using UITouch = System.IntPtr;
using UIImage = System.IntPtr;
using CGAffineTransform = MonoMac.CoreGraphics.CGAffineTransform;

namespace Cocos2d
{");
		ruleList = File.ReadAllLines(ruleListFile).ToList();
		var skipFiles = ruleList.Where (rl => rl.StartsWith ("SkipFile")).Select (rl => rl.Split(':')[1].Trim());
		var skipInterfaces = ruleList.Where (rl => rl.StartsWith ("SkipInterfaceWith")).Select (rl => rl.Split(':')[1].Trim());
		skipSelector = ruleList.Where (rl => rl.StartsWith ("SkipSelectorWith")).Select (rl => rl.Split(':')[1].Trim()).ToList();
		renameProperty = ruleList.Where (rl => rl.StartsWith ("RenameProperty")).Select (rl => rl.Split(':')[1].Trim())
			.ToDictionary (rl => rl.Split(' ')[0], rl => rl.Split(' ')[1]);
		addArgToConstructor = ruleList.Where (rl => rl.StartsWith ("AddArgToConstructor")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
		changeClassBaseType = ruleList.Where (rl => rl.StartsWith ("ChangeClassBaseType")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
		allowNullArg = ruleList.Where (rl => rl.StartsWith ("AllowNullArg")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
		renameMethodForSelector = ruleList.Where (rl => rl.StartsWith ("RenameMethodForSelector")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
  		renameDelegateByParameters = ruleList.Where (rl => rl.StartsWith ("RenameDelegateByParams")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
		changeReturnType = ruleList.Where (rl => rl.StartsWith ("ChangeReturnType")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
		changeSignatureForSelector = ruleList.Where (rl => rl.StartsWith ("ChangeSignatureForSelector")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
		renameDelegate = ruleList.Where (rl => rl.StartsWith ("RenameDelegate")).Select (rl => rl.Split('#')[1].Trim())
			.ToDictionary (rl => rl.Split('.')[0], rl => rl.Split('.')[1]);
		makeSelectorInternalWith = ruleList.Where (rl => rl.StartsWith ("MakeSelectorInternalWith")).Select (rl => rl.Split('#')[1].Trim()).ToList();
		preserverConstructorAsMethod = ruleList.Where (rl => rl.StartsWith ("PreserverConstructorAsMethod")).Select (rl => rl.Split('#')[1].Trim()).ToList();
		skipSelectorByName = ruleList.Where (rl => rl.StartsWith ("SkipSelectorByName")).Select (rl => rl.Split('#')[1].Trim()).ToList();
		allowNullProperty = ruleList.Where (rl => rl.StartsWith ("AllowNullProperty")).Select (rl => rl.Split('#')[1].Trim()).ToList();

		foreach (string f in sources)
        {
			if (skipFiles.FirstOrDefault(rl => f.Contains(rl)) != null)
				continue;
            using (var fs = File.OpenRead(f))
            {
                r = new StreamReader(new SourceStream(fs));
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    line = line.Replace("UIKIT_EXTERN_CLASS ", "");

                    if (line.StartsWith("#"))
                        continue;
                    if (line.Length == 0)
                        continue;
                    if (line.StartsWith("@class"))
                        continue;

                    if (line.IndexOf("UIKIT_CLASS_AVAILABLE") != -1)
                    {
                        int p = line.IndexOf('@');
                        if (p == -1)
                            continue;
                        line = line.Substring(p);
                    }

                    if (line.IndexOf("@interface") != -1) {

						if (skipInterfaces.FirstOrDefault(rl => line.Contains(rl)) != null)
							continue;
                        ProcessInterface(Clean("@interface", line));
					}
                    if (line.IndexOf("@protocol") != -1 && !line.EndsWith(";")) // && line.IndexOf ("<") != -1)
                        ProcessProtocol(Clean("@protocol", line));

                    other.WriteLine(line);
                }
            }
        }

		foreach (var d in protocolCache)
        {
			StringBuilder sb = new StringBuilder();
			d.Value.gencs = sb;
			sb.AppendLine(d.Value.Definition);

			d.Value.Generate(null);
            gencs.WriteLine(sb.ToString());
            gencs.WriteLine("\t}");
        }

        foreach (var d in interfaceCache)
        {
			StringBuilder sb = new StringBuilder();
			d.Value.gencs = sb;
			sb.AppendLine(d.Value.Definition);

			d.Value.Generate(null);
            gencs.WriteLine(sb.ToString());
            gencs.WriteLine("\t}");
        }

        gencs.WriteLine("}");
        gencs.Close();
        other.Close();
    }

    public static void Main(string[] args)
    {
        var tp = new TrivialParser();
        tp.Run(args);

    }
}
