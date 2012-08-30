using MonoMac.Foundation;
using MonoMac.ObjCRuntime;
using MonoMac.AppKit;
using GLfloat = System.Single;
using GLubyte = System.Byte;
using CGFloat = System.Double;
using GLenum = System.Int16;
using System;
using System.Runtime.InteropServices;

namespace Cocos2D
{
#if FALSE
	public class PointerToArray :  IDisposable
	{
		IntPtr pNativePtrToArray = IntPtr.Zero;

		public IntPtr AppendArgs<T>(params T[] args)
		{
			if (args == null)
				return IntPtr.Zero;

		   	var pNativePtrToArray = Marshal.AllocHGlobal(T.Length * IntPtr.Size);
		    for (int i = 1; i < T.Length; ++i)
		        Marshal.WriteIntPtr (pNativePtrToArray, (i - 1) * IntPtr.Size, T[i].Handle);

		    // Null termination
		    Marshal.WriteIntPtr (pNativePtrToArray, (T.Length - 1) * IntPtr.Size, IntPtr.Zero);

		    // the signature for this method has gone from (IntPtr, IntPtr) to (Worker, IntPtr)
		    WorkerManager.AppendWorkers(workers[0], pNativeArr);
		    Marshal.FreeHGlobal(pNativeArr);
		}

		private void FreeArgs (IntPtr pNativeArr)
		{
			Marshal.FreeHGlobal(pNativeArr);
		}

		public void Dispose (bool disposing)
		{
			if (disposing && pNativePtrToArray != IntPtr.Zero) {
				Marshal.FreeHGlobal (pNativePtrToArray);
				pNativePtrToArray = IntPtr.Zero;
			}
		}
		#region IDisposable implementation
		void IDisposable.Dispose ()
		{
			Dispose (true);
			GC.SuppressFinalize (this);
		}
		#endregion

	}
#endif

	public struct ccArray {
		uint num, max;
		NSObject arr;
	} 
	public struct ccGridSize
	{
		public ccGridSize (int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public int  x;
		public int  y;
	}


	public struct ccVertex3F
	{
		float  x;
		float  y;
		float  z;
	}

	public struct ccColor3B
	{
		public ccColor3B(GLubyte r, GLubyte g, GLubyte b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
		}
		GLubyte	r;
		GLubyte	g;
		GLubyte b;
	}

	public struct ccColor4B
	{
		GLubyte	r;
		GLubyte	g;
		GLubyte	b;
		GLubyte a;
	}

	public struct ccColor4F {
	GLfloat r;
	GLfloat g;
	GLfloat b;
	GLfloat a;
	}

	public struct ccQuad3 {
		ccVertex3F		bl;
		ccVertex3F		br;
		ccVertex3F		tl;
		ccVertex3F		tr;
	} 

	public struct ccV3F_C4B_T2F_Quad
	{
		//! top left
		//ccV3F_C4B_T2F	tl;
		//! bottom left
		//ccV3F_C4B_T2F	bl;
		//! top right
		//ccV3F_C4B_T2F	tr;
		//! bottom right
		//ccV3F_C4B_T2F	br;
	}

	public enum ccTMXTileFlags : long {
		kCCTMXTileHorizontalFlag		= 0x80000000,
		kCCTMXTileVerticalFlag			= 0x40000000,
		kCCTMXTileDiagonalFlag			= 0x20000000,

		kCCFlipedAll					= (kCCTMXTileHorizontalFlag|kCCTMXTileVerticalFlag|kCCTMXTileDiagonalFlag),
		kCCFlippedMask					= ~(kCCFlipedAll),
	}

	public enum tCCImageFormat
	{
		kCCImageFormatJPEG = 0,
		kCCImageFormatPNG = 1,
	} 

	public enum ccGLServerState {
	//	CC_GL_SCISSOR_TEST = 1 << 0,
	//	CC_GL_STENCIL_TEST = 1 << 1,
	//	CC_GL_DEPTH_TEST = 1 << 2,
		CC_GL_BLEND = 1 << 3,
	//	CC_GL_DITHER = 1 << 4,

	//	CC_GL_ALL = ( CC_GL_SCISSOR_TEST | CC_GL_STENCIL_TEST | CC_GL_DEPTH_TEST | CC_GL_BLEND | CC_GL_DITHER ),
		CC_GL_ALL = ( CC_GL_BLEND ),

	} 

	public enum CCProgressTimerType
	{
		/// Radial Counter-Clockwise
		kCCProgressTimerTypeRadial,
		/// Bar
		kCCProgressTimerTypeBar,
	} 


	public enum ccDirectorProjection {
		/// sets a 2D projection (orthogonal projection).
		kCCDirectorProjection2D,

		/// sets a 3D projection with a fovy=60, znear=0.5f and zfar=1500.
		kCCDirectorProjection3D,

		/// it calls "updateProjection" on the projection delegate.
		kCCDirectorProjectionCustom,

		/// Detault projection is 3D projection
		kCCDirectorProjectionDefault = kCCDirectorProjection3D,

	} 

	public struct ccBlendFunc
	{
		//! source blend function
		GLenum src;
		//! destination blend function
		GLenum dst;
	} 

	public struct CGPoint {
	  CGFloat x;
	  CGFloat y;
	}

	public struct ccBezierConfig {
		//! end position of the bezier
		CGPoint endPosition;
		//! Bezier control point 1
		CGPoint controlPoint_1;
		//! Bezier control point 2
		CGPoint controlPoint_2;
	} 

	public enum tOrientation{
		/// An horizontal orientation where the Left is nearer
		kOrientationLeftOver = 0,
		/// An horizontal orientation where the Right is nearer
		kOrientationRightOver = 1,
		/// A vertical orientation where the Up is nearer
		kOrientationUpOver = 0,
		/// A vertical orientation where the Bottom is nearer
		kOrientationDownOver = 1,
	}

	public enum ccResolutionType
	{
		//! Unknonw resolution type
		kCCResolutionUnknown,

		//! Mac resolution type
		kCCResolutionMac,

		//! Mac RetinaDisplay resolution type (???)
		kCCResolutionMacRetinaDisplay,

	}

	public struct tImageTGA {
		int status;
		byte type, pixelDepth;

		/** map width */
		short width;

		/** map height */
		short height;

		/** raw data */
		byte imageData;
		int flipped;
	}

	public enum CCTexture2DPixelFormat {
	//! 32-bit texture: RGBA8888
	kCCTexture2DPixelFormat_RGBA8888,
	//! 32-bit texture without Alpha channel. Don't use it.
	kCCTexture2DPixelFormat_RGB888,
	//! 16-bit texture without Alpha channel
	kCCTexture2DPixelFormat_RGB565,
	//! 8-bit textures used as masks
	kCCTexture2DPixelFormat_A8,
	//! 8-bit intensity texture
	kCCTexture2DPixelFormat_I8,
	//! 16-bit textures used as masks
	kCCTexture2DPixelFormat_AI88,
	//! 16-bit textures: RGBA4444
	kCCTexture2DPixelFormat_RGBA4444,
	//! 16-bit textures: RGB5A1
	kCCTexture2DPixelFormat_RGB5A1,
	//! 4-bit PVRTC-compressed texture: PVRTC4
	kCCTexture2DPixelFormat_PVRTC4,
	//! 2-bit PVRTC-compressed texture: PVRTC2
	kCCTexture2DPixelFormat_PVRTC2,

	//! Default texture format: RGBA8888
	kCCTexture2DPixelFormat_Default = kCCTexture2DPixelFormat_RGBA8888,
	}

	public enum CCLineBreakMode{
		kCCLineBreakModeWordWrap,
		kCCLineBreakModeCharacterWrap,
		kCCLineBreakModeClip,
		kCCLineBreakModeHeadTruncation,
		kCCLineBreakModeTailTruncation,
		kCCLineBreakModeMiddleTruncation
	}

	public enum CCTextAlignment
	{
		kCCTextAlignmentLeft,
		kCCTextAlignmentCenter,
		kCCTextAlignmentRight,
	} 


	public enum CCVerticalTextAlignment
	{
	    kCCVerticalTextAlignmentTop,
	    kCCVerticalTextAlignmentCenter,
	    kCCVerticalTextAlignmentBottom,
	} 

	public struct CGAffineTransformX {
	  CGFloat a, b, c, d;
	  CGFloat tx, ty;
	}

	public enum tCCPositionType {
		/** Living particles are attached to the world and are unaffected by emitter repositioning. */
		kCCPositionTypeFree,

		/** Living particles are attached to the world but will follow the emitter repositioning.
		 Use case: Attach an emitter to an sprite, and you want that the emitter follows the sprite.
		 */
		kCCPositionTypeRelative,

		/** Living particles are attached to the emitter and are translated along with it. */
		kCCPositionTypeGrouped,
	}


	public struct tCCParticle {
		//CGPoint		pos;
		//CGPoint		startPos;

		//ccColor4F	color;
		//ccColor4F	deltaColor;

		//float		size;
		//float		deltaSize;

		//float		rotation;
		//float		deltaRotation;

		//ccTime		timeToLive;

		//NSUInteger	atlasIndex;

		//union {
			// Mode A: gravity, direction, radial accel, tangential accel
			//struct {
			//	CGPoint		dir;
			//	float		radialAccel;
			//	float		tangentialAccel;
			//} A;

			// Mode B: radius mode
			//struct {
			//	float		angle;
			//	float		degreesPerSecond;
			//	float		radius;
			//	float		deltaRadius;
			//} B;
		//} mode;

	}
}
