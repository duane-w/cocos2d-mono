using System;
using Cocos2d;
using System.Drawing;
using MonoMac.Foundation;
using CGSize = System.Drawing.SizeF;
using CCPoint = System.Drawing.PointF;
using System.Runtime.InteropServices;

namespace MenuTest
{
	public class Layer3 : CCLayer
	{
		CCMenuItem disabledItem;

		public Layer3 ()
		{
			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont.DefaultFontSize = 28;

			CCLabelBMFont label = new CCLabelBMFont("Enable AtlasItem", "bitmapFontTest3.fnt");
			CCMenuItemLabel item1 = new CCMenuItemLabel(label, this, new MonoMac.ObjCRuntime.Selector("menuCallback2:"));
			CCMenuItemFont item2 = new CCMenuItemFont("--- Go Back ---", this, new MonoMac.ObjCRuntime.Selector("menuCallback:"));

			CCSprite spriteNormal = new CCSprite ("menuitemsprite.png", new RectangleF (0, 23 * 2, 115, 23));
			CCSprite spriteSelected = new CCSprite ("menuitemsprite.png", new RectangleF (0, 23 * 1, 115, 23));
			CCSprite spriteDisabled = new CCSprite ("menuitemsprite.png", new RectangleF (0, 23 * 0, 115, 23));

			CCMenuItemSprite item3 = new CCMenuItemSprite (spriteNormal, spriteSelected, spriteDisabled, this, new MonoMac.ObjCRuntime.Selector("menuCallback3:"));
			disabledItem = item3;
			disabledItem.Enabled = false;

			NSArray arrayOfItems = NSArray.FromObjects(item1, item2, item3);
			CCMenu menu = new CCMenu(arrayOfItems);

			CGSize s = CCDirector.SharedDirector().WinSize ();

			item1.Position = new CCPoint(s.Width/2 - 150, s.Height/2);
			item2.Position = new CCPoint(s.Width/2 - 200, s.Height/2);
			item3.Position = new CCPoint(s.Width/2, s.Height/2 - 100);

			var jump = new CCJumpBy(3, new CCPoint(400,0), 50, 4);
			item2.RunAction (new CCRepeatForever ((CCActionInterval)CCSequence.Actions (jump, jump.Reverse ())));
			var spin1 = new CCRotateBy (3, 360);
			var spin2 = (CCRotateBy)spin1.Copy ();
			var spin3 = (CCRotateBy)spin1.Copy ();

			item1.RunAction (new CCRepeatForever (spin1));
			item2.RunAction (new CCRepeatForever (spin2));
			item3.RunAction (new CCRepeatForever (spin3));

			this.AddChild (menu);
			menu.Position = new CCPoint(0, 0);
		}

		[Export("menuCallback:")]
		public void MenuCallback (NSObject sender)
		{
			CCScene scene = new CCScene ();
			scene.AddChild (MenuTest.Scene ());
			CCDirector.SharedDirector ().ReplaceScene (scene);

		}
		[Export("menuCallback2:")]
		void MenuCallback2 (NSObject sender)
		{
			disabledItem.Enabled = !disabledItem.Enabled;
			if (disabledItem.Enabled == false)
				disabledItem.StopAllActions ();
			else
				disabledItem.RunAction (new CCRepeatForever (new CCRotateBy (3, 360)));
		}
		[Export("menuCallback3:")]
		void MenuCallback3 (NSObject sender)
		{
			Console.WriteLine ("MenuItemSprite clicked");
		}
	}
}