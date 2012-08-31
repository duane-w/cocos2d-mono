// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;

namespace EffectsTest
{
	[Register ("AppDelegate")]
	partial class AppDelegate
	{
		[Outlet]
		Cocos2d.CCGLView glView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (glView != null) {
				glView.Dispose ();
				glView = null;
			}
		}
	}
}
