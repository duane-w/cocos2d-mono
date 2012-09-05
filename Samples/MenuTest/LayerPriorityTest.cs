using System;
using Cocos2d;
using MonoMac.Foundation;

namespace MenuTest
{
	public class LayerPriorityTest : CCLayer
	{
		public LayerPriorityTest ()
		{
			// Testing empty menu
			CCMenu menu1 = new CCMenu();
			CCMenu menu2 = new CCMenu();

			// Menu 1
			CCMenuItemFont.DefaultFontName = "Marker Felt";
			CCMenuItemFont.DefaultFontSize = 18;

			CCMenuItemFont item1 = new CCMenuItemFont ("Return to Main Menu", delegate {
				CCDirector.SharedDirector ().PopScene ();
			});

			CCMenuItemFont item2 = new CCMenuItemFont ("Disable menu for 5 seconds", delegate (NSObject ob) {
				menu1.Enabled = false;
				CCDelayTime wait = new CCDelayTime(5);
				CCCallBlockO enable = new CCCallBlockO (
					delegate (NSObject obj)  {
					CCMenu obj1 = (CCMenu)obj;
					obj1.Enabled = true;
				}, menu1);
				CCSequence seq = new CCSequence (wait, enable);
				menu1.RunAction (seq);
			});

			menu1.AddChild (item1);
			menu1.AddChild (item2);
			menu1.AlignItemsVerticallyWithPadding (2);

			this.AddChild (menu1);

			// Menu 2
			bool priority = true;
			CCMenuItemFont.DefaultFontSize = 48;
			item1 = new CCMenuItemFont("Toggle Priority", delegate {
				if (priority == true) {
					menu2.SetHandlerPriority (-128 + 20);
					priority = false;
				}
				else {
					menu2.SetHandlerPriority (-128 - 20);
					priority = true;
				}
			});

			item1.Color = new ccColor3B(0, 0, 255);
			menu2.AddChild (item1);
			this.AddChild (menu2);
		}
	}
}

