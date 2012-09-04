using System;
using System.Runtime.InteropServices;
using MonoMac.Foundation;

namespace Cocos2d
{
	public class PointerToArray :  IDisposable
	{
		IntPtr pNativePtrToArray = IntPtr.Zero;

		public IntPtr AppendArgs<T>(T[] args) where T : NSObject
		{
			if (args == null)
				return IntPtr.Zero;

		   	pNativePtrToArray = Marshal.AllocHGlobal(args.Length * IntPtr.Size);
		    for (int i = 1; i < args.Length; ++i)
		        Marshal.WriteIntPtr (pNativePtrToArray, (i - 1) * IntPtr.Size, args[i].Handle);

		    // Null termination
		    Marshal.WriteIntPtr (pNativePtrToArray, (args.Length - 1) * IntPtr.Size, IntPtr.Zero);

		    // the signature for this method has gone from (IntPtr, IntPtr) to (Worker, IntPtr)
		    //WorkerManager.AppendWorkers(workers[0], pNativeArr);
		    //Marshal.FreeHGlobal(pNativeArr);
			return pNativePtrToArray;
		}

		public void Dispose (bool disposing)
		{
			if (disposing && pNativePtrToArray != IntPtr.Zero) {
				//Marshal.FreeHGlobal (pNativePtrToArray);
				pNativePtrToArray = IntPtr.Zero;
			}
		}
		#region IDisposable implementation
		void IDisposable.Dispose ()
		{
			Dispose (true);
			GC.SuppressFinalize (this);
		}
		#endregion
	}

	partial class CCSequence
	{
		static public CCFiniteTimeAction Actions (params CCFiniteTimeAction[] args)
		{
			NSArray ar = NSArray.FromObjects (args);
			return (CCFiniteTimeAction)CCSequence.ActionWithArray (ar);
		}
	}

	partial class CCMenu
	{
		public CCMenu (params CCMenuItem[] items)
		{
			using (var varArgs = new PointerToArray()) {
				IntPtr pArray = varArgs.AppendArgs (items);
				this.InitWithItems(items[0], pArray);
			}
		}
		public void AlignItemsInColumns (params NSNumber[] columns)
		{
			var pNativeArr = Marshal.AllocHGlobal (columns.Length * IntPtr.Size);
			Console.WriteLine ("pNativePtrA 0x{0}", pNativeArr.ToString ("x"));
			Console.WriteLine ("arg0 0x{0}", columns[0].Handle.ToString ("x"));
			for (int i = 1; i < columns.Length; ++i) {
				Marshal.WriteIntPtr (pNativeArr, (i - 1) * IntPtr.Size, columns [i].Handle);
				Console.WriteLine ("arg 0x{0}, {1}", (i - 1), columns[i].Handle.ToString ("x"));
			}
		    // Null termination
		    Marshal.WriteIntPtr (pNativeArr, (columns.Length - 1) * IntPtr.Size, IntPtr.Zero);
			Console.Out.Flush ();
		    // the signature for this method has gone from (IntPtr, IntPtr) to (Worker, IntPtr)
		    AlignItemsInColumnsVaList(columns[0], pNativeArr);
		    Marshal.FreeHGlobal(pNativeArr);
			//NSArray ar = NSArray.FromNSObjects (columns);
			//AlignItemsInColumns (columns[0], 
		}
	}
}