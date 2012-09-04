using System;
using Cocos2d;
using MonoMac.ObjCRuntime;
using MonoMac.Foundation;
using System.Drawing;

namespace MenuTest
{
	public class Layer2 : CCLayer
	{
		public enum TagMenu {
			kTagMenu = 1,
			kTagMenu0 = 0,
			kTagMenu1 = 1,
		}

		PointF centeredMenu;
		bool alignedH;

		public Layer2 ()
		{
		}

		public static new Layer2 Node()
		{
			return new Layer2();
		}

		void alignMenusH ()
		{
			for(int i=0;i<2;i++) {
				CCMenu menu = (CCMenu)this.GetChildByTag (100+i);
				menu.Position = centeredMenu;
				if (i==0) {
					// TIP: if no padding, padding = 5
					menu.AlignItemsHorizontally();
					PointF p = menu.Position;
					menu.Position = new PointF(p.X, p.Y + 30);

				} else {
					// TIP: but padding is configurable
					menu.AlignItemsHorizontallyWithPadding(40);
					PointF p = menu.Position;
					menu.Position = new PointF(p.X , p.Y - 30);
				}
			}
		}

		void alignMenusV ()
		{
			for(int i=0;i<2;i++) {
				CCMenu menu = (CCMenu)this.GetChildByTag (100+i);
				menu.Position = centeredMenu;
				if (i==0) {
					// TIP: if no padding, padding = 5
					menu.AlignItemsVertically();
					PointF p = menu.Position;
					menu.Position = new PointF(p.X + 100, p.Y);

				} else {
					// TIP: but padding is configurable
					menu.AlignItemsVerticallyWithPadding(40);
					PointF p = menu.Position;
					menu.Position = new PointF(p.X - 100 , p.Y);
				}
			}
		}

		public override void OnEnter ()
		{
			base.OnEnter ();

			RemoveAllChildrenWithCleanup (true);

			for (int i = 0; i < 2; i++) {

				CCMenuItemImage item1 = new CCMenuItemImage("btn-play-normal.png", "btn-play-selected.png", null, 
				delegate {
					CCDirector.SharedDirector ().RunWithScene(MenuTest.Scene());
				});

				CCMenuItemImage item2 = new CCMenuItemImage("btn-highscores-normal.png", "btn-highscores-selected.png", null, 
				                                            this, new Selector ("menuCallbackOpacity:"));
				CCMenuItemImage item3 = new CCMenuItemImage("btn-about-normal.png", "btn-about-selected.png", null,
				delegate {
					alignedH = !alignedH;
					if (alignedH)
						alignMenusH ();
					else
						alignMenusV ();
				});

				item1.ScaleX = 1.5f;
				item2.ScaleY = 0.5f;
				item3.ScaleX = 0.5f;

				NSArray arr = NSArray.FromObjects (item1, item2, item3);
				CCMenu menu = new CCMenu (arr);

				SizeF s = CCDirector.SharedDirector().WinSize();
				menu.Position = new PointF(s.Width/2, s.Height/2);

				menu.Tag = (int)TagMenu.kTagMenu;

				this.AddChild (menu, 0, 100+i);
				centeredMenu = menu.Position;
			}

			alignedH = true;
			alignMenusH ();
		}
	}
}

