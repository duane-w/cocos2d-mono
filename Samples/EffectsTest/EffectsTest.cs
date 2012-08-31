using System;
using Cocos2d;
using System.Drawing;
using ccTime = System.Single;
using MonoMac.Foundation;

namespace EffectsTest
{
	internal enum EffectLayers : int
	{
		kTagTextLayer = 1,

		kTagSprite1 = 1,
		kTagSprite2 = 2,

		kTagBackground = 1,
		kTagLabel = 2,
	}

	public class EffectsTest
	{
		public EffectsTest ()
		{
		}
	}

	internal class Shaky3DDemo : CCShaky3D
	{
		internal Shaky3DDemo (int range, bool shake, ccGridSize gs, float duration)
			: base (range, shake, gs, duration)
		{
		}
		internal new static Shaky3DDemo ActionWithDuration (ccTime t)
		{
			return new Shaky3DDemo (5, false, new ccGridSize (15, 10), t);
		}
	}

	public class TextLayer : CCLayerColor
	{
		public TextLayer () : base ()
		{
			SizeF s = CCDirector.SharedDirector ().WinSize ();
			float x = s.Width;
			float y = s.Height;

			CCNode node = new CCNode ();
			node.RunAction (Shaky3DDemo.ActionWithDuration(3));
			this.AddChild (node, 0, (int)EffectLayers.kTagBackground);

			CCSprite bg = new CCSprite ("background3.png", true);
			node.AddChild (bg, 0);
			bg.Position = new PointF(x/2, y/2);

			CCSprite grossini = new CCSprite ("grossinis_sister2.png", true);
			node.AddChild (grossini, 1);
			grossini.Position = new PointF(x/3, y/2);
			CCScaleBy sc = new CCScaleBy (2, 5);
			CCActionInterval sc_back = sc.Reverse ();
			grossini.RunAction (new CCRepeatForever (new CCSequence (sc, sc_back)));

			CCSprite tamara = new CCSprite ("grossinis_sister1.png", true);
			node.AddChild (tamara, 1, (int)EffectLayers.kTagSprite2);
			tamara.Position = new PointF (2*x/3, y/2);
			CCScaleBy sc2 = new CCScaleBy (2, 5);
			CCActionInterval sc2_back = sc2.Reverse ();
			tamara.RunAction (new CCRepeatForever (new CCSequence (sc2, sc2_back)));

		
			CCLabelTTF label = new CCLabelTTF ("EffectsTest", "Marker Felt", 32);
			label.Position = new PointF (x/2, y-80);
			this.AddChild (label);
			label.Tag = (int)EffectLayers.kTagLabel;
		}
	}
}

