using System;
using Cocos2d;
using MonoMac.Foundation;
using CGSize = System.Drawing.SizeF;

namespace MenuTest
{
	public class Layer4 : CCLayer
	{
		public Layer4 ()
		{
			CCMenuItemFont.DefaultFontName = "American Typewriter";
			CCMenuItemFont.DefaultFontSize = 18;

			CCMenuItemFont title1 = CCMenuItemFont.ItemWithString ("Sound");
			title1.Enabled = false;

			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont.DefaultFontSize = 34;

			NSArray ar = NSArray.FromObjects (CCMenuItemFont.ItemWithString ("On"), CCMenuItemFont.ItemWithString ("Off"));
			CCMenuItemToggle item1 = new CCMenuItemToggle (ar, menuCallback);

			CCMenuItemFont.DefaultFontName = "American Typewriter";
			CCMenuItemFont.DefaultFontSize = 18;
			CCMenuItemFont title2 = CCMenuItemFont.ItemWithString ("Music");
			title2.Enabled = false;
			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont.DefaultFontSize = 34;
			NSArray ar1 = NSArray.FromObjects (CCMenuItemFont.ItemWithString ("On"), CCMenuItemFont.ItemWithString ("Off"));
			CCMenuItemToggle item2 = new CCMenuItemToggle (ar1, menuCallback);

			CCMenuItemFont.DefaultFontName = "American Typewriter";
			CCMenuItemFont.DefaultFontSize = 18;
			CCMenuItemFont title3 = CCMenuItemFont.ItemWithString ("Quality");
			title3.Enabled = false;
			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont.DefaultFontSize = 34;
			NSArray ar2 = NSArray.FromNSObjects (CCMenuItemFont.ItemWithString ("High"), CCMenuItemFont.ItemWithString ("Low"));
			CCMenuItemToggle item3 = new CCMenuItemToggle (ar2, menuCallback);

			CCMenuItemFont.DefaultFontName = "American Typewriter";
			CCMenuItemFont.DefaultFontSize = 18;
			CCMenuItemFont title4 = CCMenuItemFont.ItemWithString ("Orientation");
			title4.Enabled = false;
			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont.DefaultFontSize = 34;
			NSArray ar3 = NSArray.FromNSObjects (CCMenuItemFont.ItemWithString ("Off"));
			CCMenuItemToggle item4 = new CCMenuItemToggle (ar3, menuCallback);

			NSObject[] more_items = new NSObject[3];
			more_items[0] = CCMenuItemFont.ItemWithString ("33%");
			more_items[1] = CCMenuItemFont.ItemWithString ("66%");
			more_items[2] = CCMenuItemFont.ItemWithString ("100%");

			item4.SubItems.AddObjects (more_items);

			// you can change the one of the items by doing this
			item4.SelectedIndex = 2;

			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont.DefaultFontSize = 34;

			CCLabelBMFont label = new CCLabelBMFont("go back", "bitmapFontTest3.fnt");
			CCMenuItemLabel back = new CCMenuItemLabel (label, backCallback);

			CCMenu menu = new CCMenu(
				title1, title2, 
				item1, item2,
				title3, title4,
				item3, item4,
				back);

			menu.AlignItemsInColumns (NSNumber.FromUInt32(2),
			                          NSNumber.FromUInt32(2),
			                          NSNumber.FromUInt32(2),
			                          NSNumber.FromUInt32(2),
			                          NSNumber.FromUInt32 (1));
			this.AddChild (menu);
			CGSize s = CCDirector.SharedDirector ().WinSize ();
			menu.Position = new System.Drawing.PointF(s.Width / 2, s.Height / 2);
		}

		void backCallback (NSObject sender)
		{
			CCScene scene = new CCScene();
			scene.AddChild (MenuTest.Scene ());
			CCDirector.SharedDirector ().ReplaceScene (scene);
		}

		void menuCallback (CCMenuItemToggle sender)
		{
			Console.WriteLine ("selected item: {0} index:{1}", sender.SelectedItem (), sender.SelectedIndex );
		}
	}
}

