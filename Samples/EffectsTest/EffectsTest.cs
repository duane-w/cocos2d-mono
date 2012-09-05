using System;
using Cocos2d;
using System.Drawing;
using ccTime = System.Single;
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;
using System.Reflection;
using CGSize = System.Drawing.SizeF;
using CCPoint = System.Drawing.PointF;

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
		public static new Shaky3DDemo ActionWithDuration (ccTime t)
		{
			return new Shaky3DDemo (5, false, new ccGridSize (15, 10), t);
		}
	}
	internal class Waves3DDemo : CCWaves3D
	{
		internal Waves3DDemo (int wave, float amplitude, ccGridSize gs, float duration)
			: base (wave, amplitude, gs, duration)
		{
		}
		public static new Waves3DDemo ActionWithDuration (ccTime t)
		{
			return new Waves3DDemo (5, 40, new ccGridSize (15, 10), t);
		}
	}
	internal class FlipX3DDemo : CCFlipX3D
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var flipx = new CCFlipX3D (t);
			var flipx_back = flipx.Reverse ();
			var delay = new CCDelayTime (2);

			return (CCSequence) CCSequence.Actions (flipx, delay, flipx_back);
		}
	}
	internal class FlipY3DDemo : CCFlipY3D
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var flipy = new CCFlipY3D (t);
			var flipy_back = flipy.Reverse ();
			var delay = new CCDelayTime (2);

			return (CCSequence)CCSequence.Actions (flipy, delay, flipy_back);
		}
	}
	internal class Lens3DDemo : CCLens3D
	{
		internal Lens3DDemo (CCPoint pos, float radius, ccGridSize grid, ccTime duration)
			: base (pos, radius, grid, duration)
		{
		}
		public static new Lens3DDemo ActionWithDuration (ccTime t)
		{
			CGSize s = CCDirector.SharedDirector ().WinSize ();
			return new Lens3DDemo (new CCPoint (s.Width/2, s.Height/2), 240, new ccGridSize (15, 10), t);
		}
	}
	internal class Ripple3DDemo : CCRipple3D
	{
		internal Ripple3DDemo (CCPoint pos, float radius, int waves, float amplitude, ccGridSize grid, ccTime duration)
			: base (pos, radius, waves, amplitude, grid, duration)
		{
		}
		public static new Ripple3DDemo ActionWithDuration (ccTime t)
		{
			CGSize s = CCDirector.SharedDirector ().WinSize ();
			return new Ripple3DDemo (new CCPoint (s.Width/2, s.Height/2), 240, 4, 160, new ccGridSize (32, 24), t);
		}
	}
	internal class LiquidDemo : CCLiquid
	{
		internal LiquidDemo (int wav, float amplitude, ccGridSize grid, ccTime duration)
			: base (wav, amplitude, grid, duration)
		{
		}
		public static new LiquidDemo ActionWithDuration (ccTime t)
		{
			return new LiquidDemo (4, 20, new ccGridSize (16, 12), t);
		}
	}
	internal class WavesDemo : CCWaves
	{
		internal WavesDemo (int wav, float amplitude, bool horizontal, bool vertical, ccGridSize grid, ccTime duration)
			: base (wav, amplitude, horizontal, vertical, grid, duration)
		{
		}
		public static new WavesDemo ActionWithDuration (ccTime t)
		{
			return new WavesDemo (4, 20, true, true, new ccGridSize (16, 12), t);
		}
	}
	internal class TwirlDemo : CCTwirl
	{
		internal TwirlDemo (CCPoint pos, int twirls, float amplitude, ccGridSize grid, ccTime duration)
			: base (pos, twirls, amplitude, grid, duration)
		{
		}
		public static new TwirlDemo ActionWithDuration (ccTime t)
		{
			CGSize s = CCDirector.SharedDirector ().WinSize ();
			return new TwirlDemo (new CCPoint (s.Width/2, s.Height/2), 1, 2.5f, new ccGridSize (12, 8), t);
		}
	}
	internal class ShakyTiles3DDemo : CCShakyTiles3D
	{
		internal ShakyTiles3DDemo (int range, bool shake, ccGridSize gs, float duration)
			: base (range, shake, gs, duration)
		{
		}
		public static new ShakyTiles3DDemo ActionWithDuration (ccTime t)
		{
			return new ShakyTiles3DDemo (5, false, new ccGridSize (16, 12), t);
		}
	}
	internal class ShatteredTiles3DDemo : CCShatteredTiles3D
	{
		internal ShatteredTiles3DDemo (int range, bool shake, ccGridSize gs, float duration)
			: base (range, shake, gs, duration)
		{
		}
		public static new ShatteredTiles3DDemo ActionWithDuration (ccTime t)
		{
			return new ShatteredTiles3DDemo (5, false, new ccGridSize (15, 10), t);
		}
	}
	internal class ShuffleTilesDemo : CCShuffleTiles
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var shuffle = new CCShuffleTiles (25, new ccGridSize (16, 12), t);
			var shuffle_back = shuffle.Reverse ();
			var delay = new CCDelayTime (2);

			return (CCSequence)CCSequence.Actions (shuffle, delay, shuffle_back);
		}
	}
	internal class FadeOutTRTilesDemo : CCFadeOutTRTiles
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var fadeout = new CCFadeOutTRTiles (new ccGridSize (16, 12), t);
			var back = fadeout.Reverse ();
			var delay = new CCDelayTime (0.5f);

			return (CCSequence)CCSequence.Actions (fadeout, delay, back);
		}
	}
	internal class FadeOutBLTilesDemo : CCFadeOutBLTiles
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var fadeout = new CCFadeOutBLTiles (new ccGridSize (16, 12), t);
			var back = fadeout.Reverse ();
			var delay = new CCDelayTime (0.5f);

			return (CCSequence)CCSequence.Actions (fadeout, delay, back);
		}
	}
	internal class FadeOutUpTilesDemo : CCFadeOutUpTiles
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var fadeout = new CCFadeOutUpTiles (new ccGridSize (16, 12), t);
			var back = fadeout.Reverse ();
			var delay = new CCDelayTime (0.5f);

			return (CCSequence)CCSequence.Actions (fadeout, delay, back);
		}
	}
	internal class FadeOutDownTilesDemo : CCFadeOutDownTiles
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var fadeout = new CCFadeOutDownTiles (new ccGridSize (16, 12), t);
			var back = fadeout.Reverse ();
			var delay = new CCDelayTime (0.5f);

			return (CCSequence)CCSequence.Actions (fadeout, delay, back);
		}
	}
	internal class TurnOffTilesDemo : CCTurnOffTiles
	{
		public static new CCSequence ActionWithDuration (ccTime t)
		{
			var fadeout = new CCTurnOffTiles (25, new ccGridSize (48, 32), t);
			var back = fadeout.Reverse ();
			var delay = new CCDelayTime (0.5f);

			return (CCSequence)CCSequence.Actions (fadeout, delay, back);
		}
	}
	internal class WavesTiles3DDemo : CCWavesTiles3D
	{
		internal WavesTiles3DDemo (int wav, float amplitude, ccGridSize grid, ccTime duration)
			: base (wav, amplitude, grid, duration)
		{
		}
		public static new WavesTiles3DDemo ActionWithDuration (ccTime t)
		{
			return new WavesTiles3DDemo (4, 120, new ccGridSize (15, 10), t);
		}
	}
	internal class JumpTiles3DDemo : CCJumpTiles3D
	{
		internal JumpTiles3DDemo (int j, float amplitude, ccGridSize grid, ccTime duration)
			: base (j, amplitude, grid, duration)
		{
		}
		public static new JumpTiles3DDemo ActionWithDuration (ccTime t)
		{
			return new JumpTiles3DDemo (2, 30, new ccGridSize (15, 10), t);
		}
	}
	internal class SplitRowsDemo : CCSplitRows
	{
		internal SplitRowsDemo (int rows, ccTime duration)
			: base (rows, duration)
		{
		}
		public static new SplitRowsDemo ActionWithDuration (ccTime t)
		{
			return new SplitRowsDemo (9, t);
		}
	}
	internal class SplitColsDemo : CCSplitCols
	{
		internal SplitColsDemo (int rows, ccTime duration)
			: base (rows, duration)
		{
		}
		public static new SplitColsDemo ActionWithDuration (ccTime t)
		{
			return new SplitColsDemo (9, t);
		}
	}
	internal class PageTurn3DDemo : CCPageTurn3D
	{
		internal PageTurn3DDemo (ccGridSize gs, float duration)
			: base (gs, duration)
		{
		}
		public static new PageTurn3DDemo ActionWithDuration (ccTime t)
		{
			return new PageTurn3DDemo (new ccGridSize (15, 10), t);
		}
	}


	public class TextLayer : CCLayerColor
	{
		static int actionIdx = 0;
		string[] effectsList =
		{
			"Shaky3DDemo",
			"Waves3DDemo",
			"FlipX3DDemo",
			"FlipY3DDemo",
			"Lens3DDemo",
			"Ripple3DDemo",
			"LiquidDemo",
			"WavesDemo",
			"TwirlDemo",
			"ShakyTiles3DDemo",
			"ShatteredTiles3DDemo",
			"ShuffleTilesDemo",
			"FadeOutTRTilesDemo",
			"FadeOutBLTilesDemo",
			"FadeOutUpTilesDemo",
			"FadeOutDownTilesDemo",
			"TurnOffTilesDemo",
			"WavesTiles3DDemo",
			"JumpTiles3DDemo",
			"SplitRowsDemo",
			"SplitColsDemo",
			"PageTurn3DDemo",
		};

		public TextLayer () : base ()
		{
			SizeF s = CCDirector.SharedDirector ().WinSize ();
			float x = s.Width;
			float y = s.Height;

			CCNode node = new CCNode ();
			CCAction effectClass = RestartAction (3f);
			node.RunAction (effectClass);
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

			CCLabelTTF label = new CCLabelTTF (effectsList[actionIdx].Replace("Demo", ""), "Marker Felt", 32);
			label.Position = new PointF (x/2, y-80);
			this.AddChild (label);
			label.Tag = (int)EffectLayers.kTagLabel;

			//menu
			CCMenuItemImage item1 = new CCMenuItemImage ("b1.png", "b2.png", null, BackCallback);
			CCMenuItemImage item2 = new CCMenuItemImage ("r1.png", "r2.png", null, RestartCallback);
			CCMenuItemImage item3 = new CCMenuItemImage ("f1.png", "f2.png", null, NextCallback);

			CCMenu menu = new CCMenu (item1, item2, item3);
			menu.Position = PointF.Empty;
			item1.Position = new PointF(s.Width/2 - item2.ContentSize.Width*2, item2.ContentSize.Height/2);
			item2.Position = new PointF( s.Width/2, item2.ContentSize.Height/2);
			item3.Position = new PointF( s.Width/2 + item2.ContentSize.Width*2, item2.ContentSize.Height/2);
			this.AddChild (menu, 1);

			this.Schedule (new MonoMac.ObjCRuntime.Selector ("checkAnim:"));
		}

		CCAction RestartAction (float duration)
		{
			var actionType = Type.GetType (string.Format ("EffectsTest.{0}", effectsList[actionIdx]));

			MethodInfo inf = actionType.GetMethod ("ActionWithDuration");
			                                       //BindingFlags.Static | BindingFlags.Public, System.Type.DefaultBinder, new Type[] { typeof(float) }, null);
			return (CCAction)inf.Invoke ("", new object[] { duration });
		}

		void NewScene ()
		{
			CCScene s = new CCScene ();
			var child = new TextLayer ();
			s.AddChild (child);
			CCDirector.SharedDirector ().ReplaceScene (s);
		}
		void BackCallback (NSObject sender)
		{
			//BackAction ();
			actionIdx--;
			if (actionIdx < 0)
				actionIdx = effectsList.Length - 1;
			this.NewScene ();
		}

		void RestartCallback (NSObject sender)
		{
			this.NewScene ();
		}

		void NextCallback (NSObject sender)
		{
			//NextAction ();
			actionIdx++;
			if (actionIdx >= effectsList.Length)
				actionIdx = 0;

			this.NewScene ();
		}

		[Export("checkAnim:")]
		void CheckAnim (ccTime t)
		{
			CCNode s2 = this.GetChildByTag ((int)EffectLayers.kTagBackground);
			if (s2 != null && s2.NumberOfRunningActions () == 0 && s2.Grid != null)
				s2.Grid = null;
		}
	}
}

