using System;
using Cocos2d;
using CGSize = System.Drawing.SizeF;
using CCPoint = System.Drawing.PointF;
using ccTime = System.Single;
using MonoMac.Foundation;

namespace SceneTest
{
	public class Layer2 : CCLayerColor
	{
		float timeCounter = 0;

		public Layer2 ()
			: base (new ccColor4B (255,0,0,255))
		{
			CCMenuItemFont item1 = new CCMenuItemFont("replaceScene", OnReplaceScene);
			CCMenuItemFont item2 = new CCMenuItemFont("replaceScene w/transition", OnReplaceSceneTran);
			CCMenuItemFont item3 = new CCMenuItemFont("Go Back", OnGoBack);

			CCMenu menu = new CCMenu(item1, item2, item3);
			menu.AlignItemsVertically ();
			this.AddChild (menu);

			this.Schedule (new MonoMac.ObjCRuntime.Selector ("testDealloc:"));

			CGSize s = CCDirector.SharedDirector ().WinSize ();
			CCSprite sprite = new CCSprite("grossini.png", true);
			this.AddChild (sprite);
			sprite.Position = new CCPoint(40, s.Height / 2);
			var rotate = new CCRotateBy (2, 360);
			var repeat = new CCRepeatForever (rotate);
			sprite.RunAction (repeat);
		}

		[Export("testDealloc:")]
		void TestDealloc(ccTime dt)
		{
			Console.WriteLine ("Layer2:testDealloc");

			timeCounter += dt;
			if (timeCounter > 10)
				this.OnReplaceScene (this);
		}

		void OnReplaceScene(NSObject CCSenderCallback)
		{
			CCScene scene = new CCScene();
			scene.AddChild (new Layer3 (), 0);
			CCDirector.SharedDirector ().ReplaceScene (scene);
		}
		void OnReplaceSceneTran(NSObject CCSenderCallback)
		{
			CCScene scene = new CCScene();
			scene.AddChild (new Layer3 (), 0);
			CCDirector.SharedDirector ().ReplaceScene (new CCTransitionFlipX (2, scene));
		}
		void OnGoBack(NSObject CCSenderCallback)
		{
			CCDirector.SharedDirector ().PopScene ();
		}
	}
}

