using System;
using Cocos2d;
using CGSize = System.Drawing.SizeF;
using CCPoint = System.Drawing.PointF;
using ccTime = System.Single;
using MonoMac.Foundation;

namespace SceneTest
{
	public class Layer3 : CCLayerColor
	{
		public Layer3 ()
			: base (new ccColor4B (0,0,255,255))
		{
			CGSize s = CCDirector.SharedDirector ().WinSize ();
			CCMenuItemFont item0 = new CCMenuItemFont("Touch to pushScene (self)", delegate {
				CCScene newScene = new CCScene();
				newScene.AddChild (new Layer3 ());
				CCDirector.SharedDirector ().PushScene (new CCTransitionFade (0.5f, newScene, new ccColor3B (0, 255, 255)));
			});

			CCMenuItemFont item1 = new CCMenuItemFont("Touch to popScene", delegate {
				CCDirector.SharedDirector ().PopScene ();
			});

			CCMenuItemFont item2 = new CCMenuItemFont("Touch to popToRootScene", delegate {
				CCDirector.SharedDirector ().PopToRootScene ();
			});
	
			CCMenu menu = new CCMenu(item0, item1, item2);
			this.AddChild (menu);
			menu.AlignItemsVertically ();

			CCSprite sprite = new CCSprite("grossini.png", true);
			this.AddChild (sprite);
			sprite.Position = new CCPoint(s.Width / 2, 40);
			var rotate = new CCRotateBy (2, 360);
			var repeat = new CCRepeatForever (rotate);
			sprite.RunAction (repeat);
		}
	}
}

