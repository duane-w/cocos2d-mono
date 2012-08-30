cocos2d-mono
============

Bindings for cocos2d to use with MonoTouch and MonoMac

Edit the makefile to specify the directories for:
MACCORE_DIR = ../MonoMac/monomac/src
COCOS2D_DIR = ../cocos2d-iphone/cocos2d/


The binding generator is currently setup to produce bindings to be used with MonoMac.  It should be
very straightforward to convert the generated Cocos2d.cs file for use with MonoTouch.

The binding generator uses the ruleslist.txt file to modify how the bindings are generated.  Again currently 
targeted for MonoMac.


Included is a Cocos2d.dll that can be used with MonoMac.  Also included here is cocos2d.dylib.

Create a new MonoMac application.  

Edit the MainMenu.xib.  Add a Window with an NSView with a CCGLView.
Create an outlet on the App Delegate named glView that points to the CCGLView.
Modify the attributes of the CCGLView to be color "32 bit RGBA 8 8 8 8".
Modify the attributes of the CCGLView to use double buffering.

Add the cocos2d.dylib to your MonoMac project with a build action of "Content".
You can remove references to MainWindow items from the project.

Modify the AppDelegate.cs file.  

```csharp
using Cocos2d;

[assembly: MonoMac.RequiredFramework("cocos2d.dylib")]
namespace YOURNAMESPACE
{
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
