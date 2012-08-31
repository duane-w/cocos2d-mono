using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using Cocos2d;

[assembly: MonoMac.RequiredFramework("cocos2d.dylib")]
namespace EmptyProject
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		public AppDelegate ()
		{
			Type t = typeof(CCDirector);
			MonoMac.ObjCRuntime.Runtime.RegisterAssembly(t.Assembly); 
		}

		public override void FinishedLaunching (NSObject notification)
		{
			CCDirector director = CCDirector.SharedDirector ();

			director.View = glView;
			director.DisplayStats = true;

			CCScene scene =  new CCScene();

			CCLabelTTF label = new CCLabelTTF("Hello World", "Marker Felt", 64);
			SizeF size = director.WinSize ();
			label.Position = new PointF(size.Width/2, size.Height/2);
			scene.AddChild(label);

			director.RunWithScene(scene);
		}
	}
}

