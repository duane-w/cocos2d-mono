using System;
using Cocos2d;
using MonoMac.Foundation;
using CGSize = System.Drawing.SizeF;
using CCPoint = System.Drawing.PointF;
using ccTime = System.Single;

namespace SceneTest
{
	public class Layer1 : CCLayerColor
	{
		public Layer1 ()
			: base (new ccColor4B (0, 255, 0, 255))
		{
			CCMenuItemFont item1 = new CCMenuItemFont("Test pushScene", OnPushScene);
			CCMenuItemFont item2 = new CCMenuItemFont("Test pushScene w/transition", OnPushSceneTran);
			CCMenuItemFont item3 = new CCMenuItemFont("Quit", OnQuit);

			CCMenu menu = new CCMenu(item1, item2, item3);
			menu.AlignItemsVertically ();
			this.AddChild (menu);

			CGSize s = CCDirector.SharedDirector ().WinSize ();
			CCSprite sprite = new CCSprite("grossini.png", true);
			this.AddChild (sprite);
			sprite.Position = new CCPoint(s.Width-40, s.Height/2);
			var rotate = new CCRotateBy (2, 360);
			var repeat = new CCRepeatForever (rotate);
			sprite.RunAction (repeat);

			this.Schedule (new MonoMac.ObjCRuntime.Selector ("testDealloc:"));
		}

		[Export("testDealloc:")]
		void TestDealloc(ccTime dt)
		{
			Console.WriteLine ("Layer1:testDealloc");
		}

		void OnPushScene(NSObject CCSenderCallback)
		{
			CCScene scene = new CCScene();
			scene.AddChild (new Layer2 (), 0);
			CCDirector.SharedDirector ().PushScene (scene);
		}
		void OnPushSceneTran(NSObject CCSenderCallback)
		{
			CCScene scene = new CCScene();
			scene.AddChild (new Layer2 (), 0);
			CCDirector.SharedDirector ().PushScene (new CCTransitionSlideInT (1, scene));
		}
		void OnQuit(NSObject CCSenderCallback)
		{
			//CCDirector.SharedDirector ().PopScene ();
			// CCDirector.SharedDirector ().End ();
			CCDirector.SharedDirector ().View.Window.Close ();
		}
	}
}

