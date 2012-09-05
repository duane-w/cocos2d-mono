using System;
using System.Runtime.InteropServices;
using MonoMac.Foundation;

namespace Cocos2d
{
	internal class PointerToArray :  IDisposable
	{
		IntPtr pNativePtrToArray = IntPtr.Zero;

		internal IntPtr AppendArgs<T>(T[] args) where T : NSObject
		{
			if (args == null)
				return IntPtr.Zero;

		   	pNativePtrToArray = Marshal.AllocHGlobal(args.Length * IntPtr.Size);
		    for (int i = 1; i < args.Length; ++i)
		        Marshal.WriteIntPtr (pNativePtrToArray, (i - 1) * IntPtr.Size, args[i].Handle);

		    // Null termination
		    Marshal.WriteIntPtr (pNativePtrToArray, (args.Length - 1) * IntPtr.Size, IntPtr.Zero);

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
			using (var varArgs = new PointerToArray()) {
				IntPtr pArray = varArgs.AppendArgs (columns);
				this.AlignItemsInColumnsVaList(columns[0], pArray);
			}
		}
	}
}