using System;
using Cocos2d;
using MonoMac.Foundation;
using System.Drawing;

namespace MenuTest
{
	public class MenuTest
	{
		CCMenuItem disabledItem;

		public MenuTest ()
		{
		}

		public CCScene Scene ()
		{
			CCDirector director = CCDirector.SharedDirector ();
			CCScene scene = new CCScene ();
			SizeF size = director.WinSize ();
			CCMenu menu = null;

			CCSprite spriteNormal = new CCSprite ("menuitemsprite.png", new RectangleF (0, 23 * 2, 115, 23));
			CCSprite spriteSelected = new CCSprite ("menuitemsprite.png", new RectangleF (0, 23 * 1, 115, 23));
			CCSprite spriteDisabled = new CCSprite ("menuitemsprite.png", new RectangleF (0, 23 * 0, 115, 23));
			CCMenuItemSprite item1 = new CCMenuItemSprite (spriteNormal, spriteSelected, spriteDisabled, 
				delegate (NSObject sender) {
				CCScene scene1 = new CCScene ();
				scene1.AddChild (Layer2.Node());
				CCDirector.SharedDirector ().ReplaceScene (scene1);
			});

		
			CCMenuItemImage item2 = new CCMenuItemImage ("SendScoreButton.png", "SendScoreButtonPressed.png", null, cb);

			CCLabelAtlas labelAtlas = new CCLabelAtlas ("1992", "fps_images.png", 12, 32, '.');
			CCMenuItemLabel item3 = new CCMenuItemLabel(labelAtlas,
				delegate (NSObject sender) {
				((CCMenuItemLabel)sender).Rotation = 30f;
			});

			item3.DisabledColor = new ccColor3B (32, 32, 64);
			item3.Color = new ccColor3B (200, 200, 255);
			disabledItem = item3;

			CCMenuItemFont item4 = new CCMenuItemFont ("I toggle enabled items", 
				delegate {
				disabledItem.Enabled = !disabledItem.Enabled;
			}
			);
			item4.FontSize = 20;
			item4.FontName = "Marker Felt";

			CCLabelBMFont label = new CCLabelBMFont ("configuration", "bitmapFontTest3.fnt");
			CCMenuItemLabel item5 = new CCMenuItemLabel (label,
				delegate {
					
			});
			item5.Scale = 0.8f;

			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont item6 = new CCMenuItemFont ("Priority Test", 
				delegate (NSObject sender) {
					
			});
			        
			CCMenuItemFont.DefaultFontName = "Courier New";
			CCMenuItemFont.DefaultFontSize = 30;
			CCMenuItemFont item7 = new CCMenuItemFont ("Quit", 
				delegate {
				director.View.Window.Close ();
			});

			NSArray arr = NSArray.FromObjects (item1, item2, item3, item4, item5, item6, item7);
			menu = new CCMenu (arr);
			menu.AlignItemsVertically ();

			for (uint i = 0; i < menu.Children.Count(); i++) {
				CCNode child = (CCNode)menu.Children.ObjectAtIndex(i);
				PointF dstPoint = child.Position;
				int offset = (int)(size.Width/2) + 50;
				if (i % 2 == 0)
					offset = -offset;
				child.Position = new PointF(dstPoint.X + offset, dstPoint.Y);
				child.RunAction(new CCEaseElasticOut(
					new CCMoveBy(2, new PointF(dstPoint.X - offset, 0)), 0.35f));
			}

			menu.Position = new PointF(size.Width/2, size.Height/2);
			scene.AddChild(menu);

			return scene;
		}

		void cb(NSObject sender)
		{
			CCScene scene =  new CCScene();
			CCLabelTTF label = new CCLabelTTF("Goodbye World", "Marker Felt", 64);
			SizeF size = CCDirector.SharedDirector().WinSize ();
			label.Position = new PointF(size.Width/2, size.Height/2);
			scene.AddChild(label);
			CCDirector.SharedDirector().ReplaceScene(scene);
		}
	}
}
