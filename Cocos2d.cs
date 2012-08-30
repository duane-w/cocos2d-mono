
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;
using MonoMac.AppKit;
using System;
using System.Drawing;
using ccTime = System.Single;
using GLfloat = System.Single;
using GLshort = System.Int16;
using GLushort = System.UInt16;
using GLubyte = System.Byte;
using GLuint = System.UInt32;
using GLint = System.Int32;
using uint32_t = System.UInt32;
using CGImageRef = System.IntPtr;
using GLvoid = System.IntPtr;
using UITouch = System.IntPtr;
using UIImage = System.IntPtr;
using CGAffineTransform = MonoMac.CoreGraphics.CGAffineTransform;

namespace CCocos2D
{
	//@protocol CCRGBAProtocol <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCRGBAProtocol {


		//From Generated Property
		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		[Abstract]
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		[Abstract]
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		//Detected properties
		[Abstract]
		[Export ("color")]
		ccColor3B Color { get; set; }

		[Abstract]
		[Export ("opacity")]
		GLubyte Opacity { get; set; }


	}
	//@protocol CCBlendProtocol <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCBlendProtocol {


		//From Generated Property
		//Detected properties
		[Abstract]
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set; }


	}
	//@protocol CCTextureProtocol <CCBlendProtocol>
	[BaseType (typeof (CCBlendProtocol))]
	[Model]
	interface CCTextureProtocol {


		//From Generated Property
		//Detected properties
		[Abstract]
		[Export ("texture")]
		CCTexture2D Texture { get; set; }


	}
	//@protocol CCLabelProtocol <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCLabelProtocol {


		//From Generated Property
		//@optional-(void) setCString:(char*)label;
		[Abstract]
		[Export ("setCString:")]
		void SetCString (char label);

		//Detected properties
		[Abstract]
		[Export ("string")]
		string String { get; set; }


	}
	//@protocol CCDirectorDelegate <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCDirectorDelegate {


		//From Generated Property
		//@optional-(void) updateProjection;
		[Abstract]
		[Export ("updateProjection")]
		void UpdateProjection ();


	}
	//@protocol CCTransitionEaseScene <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCTransitionEaseScene {


		//From Generated Property
		//-(CCActionInterval*) easeActionWithAction:(CCActionInterval*)action;
		[Abstract]
		[Export ("easeActionWithAction:")]
		CCActionInterval EaseActionWithAction (CCActionInterval action);


	}
	//@protocol CCMouseEventDelegate <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCMouseEventDelegate {


		//From Generated Property
		//-(BOOL) ccMouseDown:(NSEvent*)event;
		[Export ("ccMouseDown:")]
		bool CcMouseDown (NSEvent evt);

		//-(BOOL) ccMouseDragged:(NSEvent*)event;
		[Export ("ccMouseDragged:")]
		bool CcMouseDragged (NSEvent evt);

		//-(BOOL) ccMouseMoved:(NSEvent*)event;
		[Export ("ccMouseMoved:")]
		bool CcMouseMoved (NSEvent evt);

		//-(BOOL) ccMouseUp:(NSEvent*)event;
		[Export ("ccMouseUp:")]
		bool CcMouseUp (NSEvent evt);

		//-(BOOL) ccRightMouseDown:(NSEvent*)event;
		[Export ("ccRightMouseDown:")]
		bool CcRightMouseDown (NSEvent evt);

		//-(BOOL) ccRightMouseDragged:(NSEvent*)event;
		[Export ("ccRightMouseDragged:")]
		bool CcRightMouseDragged (NSEvent evt);

		//-(BOOL) ccRightMouseUp:(NSEvent*)event;
		[Export ("ccRightMouseUp:")]
		bool CcRightMouseUp (NSEvent evt);

		//-(BOOL) ccOtherMouseDown:(NSEvent*)event;
		[Export ("ccOtherMouseDown:")]
		bool CcOtherMouseDown (NSEvent evt);

		//-(BOOL) ccOtherMouseDragged:(NSEvent*)event;
		[Export ("ccOtherMouseDragged:")]
		bool CcOtherMouseDragged (NSEvent evt);

		//-(BOOL) ccOtherMouseUp:(NSEvent*)event;
		[Export ("ccOtherMouseUp:")]
		bool CcOtherMouseUp (NSEvent evt);

		//- (BOOL)ccScrollWheel:(NSEvent *)theEvent;
		[Export ("ccScrollWheel:")]
		bool CcScrollWheel (NSEvent theEvent);

		//- (void)ccMouseEntered:(NSEvent *)theEvent;
		[Export ("ccMouseEntered:")]
		void CcMouseEntered (NSEvent theEvent);

		//- (void)ccMouseExited:(NSEvent *)theEvent;
		[Export ("ccMouseExited:")]
		void CcMouseExited (NSEvent theEvent);


	}
	//@protocol CCKeyboardEventDelegate <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCKeyboardEventDelegate {


		//From Generated Property
		//-(BOOL) ccKeyUp:(NSEvent*)event;
		[Export ("ccKeyUp:")]
		bool CcKeyUp (NSEvent evt);

		//-(BOOL) ccKeyDown:(NSEvent*)event;
		[Export ("ccKeyDown:")]
		bool CcKeyDown (NSEvent evt);

		//-(BOOL) ccFlagsChanged:(NSEvent*)event;
		[Export ("ccFlagsChanged:")]
		bool CcFlagsChanged (NSEvent evt);


	}
	//@protocol CCTouchEventDelegate <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCTouchEventDelegate {


		//From Generated Property
		//- (BOOL)ccTouchesBeganWithEvent:(NSEvent *)event;
		[Export ("ccTouchesBeganWithEvent:")]
		bool CcTouchesBeganWithEvent (NSEvent evt);

		//- (BOOL)ccTouchesMovedWithEvent:(NSEvent *)event;
		[Export ("ccTouchesMovedWithEvent:")]
		bool CcTouchesMovedWithEvent (NSEvent evt);

		//- (BOOL)ccTouchesEndedWithEvent:(NSEvent *)event;
		[Export ("ccTouchesEndedWithEvent:")]
		bool CcTouchesEndedWithEvent (NSEvent evt);

		//- (BOOL)ccTouchesCancelledWithEvent:(NSEvent *)event;
		[Export ("ccTouchesCancelledWithEvent:")]
		bool CcTouchesCancelledWithEvent (NSEvent evt);


	}
	//@protocol CCEventDelegate <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	interface CCEventDelegate {


		//From Generated Property
		//- (void)mouseDown:(NSEvent *)theEvent;
		[Abstract]
		[Export ("mouseDown:")]
		void MouseDown (NSEvent theEvent);

		//- (void)mouseUp:(NSEvent *)theEvent;
		[Abstract]
		[Export ("mouseUp:")]
		void MouseUp (NSEvent theEvent);

		//- (void)mouseMoved:(NSEvent *)theEvent;
		[Abstract]
		[Export ("mouseMoved:")]
		void MouseMoved (NSEvent theEvent);

		//- (void)mouseDragged:(NSEvent *)theEvent;
		[Abstract]
		[Export ("mouseDragged:")]
		void MouseDragged (NSEvent theEvent);

		//- (void)rightMouseDown:(NSEvent*)event;
		[Abstract]
		[Export ("rightMouseDown:")]
		void RightMouseDown (NSEvent evt);

		//- (void)rightMouseDragged:(NSEvent*)event;
		[Abstract]
		[Export ("rightMouseDragged:")]
		void RightMouseDragged (NSEvent evt);

		//- (void)rightMouseUp:(NSEvent*)event;
		[Abstract]
		[Export ("rightMouseUp:")]
		void RightMouseUp (NSEvent evt);

		//- (void)otherMouseDown:(NSEvent*)event;
		[Abstract]
		[Export ("otherMouseDown:")]
		void OtherMouseDown (NSEvent evt);

		//- (void)otherMouseDragged:(NSEvent*)event;
		[Abstract]
		[Export ("otherMouseDragged:")]
		void OtherMouseDragged (NSEvent evt);

		//- (void)otherMouseUp:(NSEvent*)event;
		[Abstract]
		[Export ("otherMouseUp:")]
		void OtherMouseUp (NSEvent evt);

		//- (void)scrollWheel:(NSEvent *)theEvent;
		[Abstract]
		[Export ("scrollWheel:")]
		void ScrollWheel (NSEvent theEvent);

		//- (void)mouseEntered:(NSEvent *)theEvent;
		[Abstract]
		[Export ("mouseEntered:")]
		void MouseEntered (NSEvent theEvent);

		//- (void)mouseExited:(NSEvent *)theEvent;
		[Abstract]
		[Export ("mouseExited:")]
		void MouseExited (NSEvent theEvent);

		//- (void)keyDown:(NSEvent *)theEvent;
		[Abstract]
		[Export ("keyDown:")]
		void KeyDown (NSEvent theEvent);

		//- (void)keyUp:(NSEvent *)theEvent;
		[Abstract]
		[Export ("keyUp:")]
		void KeyUp (NSEvent theEvent);

		//- (void)flagsChanged:(NSEvent *)theEvent;
		[Abstract]
		[Export ("flagsChanged:")]
		void FlagsChanged (NSEvent theEvent);

		//- (void)touchesBeganWithEvent:(NSEvent *)event;
		[Abstract]
		[Export ("touchesBeganWithEvent:")]
		void TouchesBeganWithEvent (NSEvent evt);

		//- (void)touchesMovedWithEvent:(NSEvent *)event;
		[Abstract]
		[Export ("touchesMovedWithEvent:")]
		void TouchesMovedWithEvent (NSEvent evt);

		//- (void)touchesEndedWithEvent:(NSEvent *)event;
		[Abstract]
		[Export ("touchesEndedWithEvent:")]
		void TouchesEndedWithEvent (NSEvent evt);

		//- (void)touchesCancelledWithEvent:(NSEvent *)event;
		[Abstract]
		[Export ("touchesCancelledWithEvent:")]
		void TouchesCancelledWithEvent (NSEvent evt);


	}

	//@interface CCAction : NSObject <NSCopying>
	[BaseType (typeof (NSObject))]
	interface CCAction {

		//From Generated Property
		//}@property (nonatomic,readonly,assign) id target;
		[Export ("target")]
		NSObject Target { get;  }

		//@property (nonatomic,readonly,assign) id originalTarget;
		[Export ("originalTarget")]
		NSObject OriginalTarget { get;  }

		//@property (nonatomic,readwrite,assign) NSInteger tag;
		[Export ("tag")]
		int Tag { get; set;  }

		//+(id) action;
		[Static]
		[Export ("action")]
		NSObject Action ();

		//-(BOOL) isDone;
		[Export ("isDone")]
		bool IsDone ();

		//-(void) startWithTarget:(id)target;
		[Export ("startWithTarget:")]
		void StartWithTarget (NSObject target);

		//-(void) stop;
		[Export ("stop")]
		void Stop ();

		//-(void) step: (ccTime) dt;
		[Export ("step:")]
		void Step (ccTime dt);

		//-(void) update: (ccTime) time;
		[Export ("update:")]
		void Update (ccTime time);


	}

	//@interface CCFiniteTimeAction : CCAction <NSCopying>
	[BaseType (typeof (CCAction))]
	interface CCFiniteTimeAction {

		//From Generated Property
		//}@property (nonatomic,readwrite) ccTime duration;
		[Export ("duration")]
		ccTime Duration { get; set;  }

		//- (CCFiniteTimeAction*) reverse;
		[Export ("reverse")]
		CCFiniteTimeAction Reverse ();


	}

	//@interface CCRepeatForever : CCAction <NSCopying>
	[BaseType (typeof (CCAction))]
	interface CCRepeatForever {

		//From Generated Property
		//}@property (nonatomic, readwrite, retain) CCActionInterval *innerAction;
		[Export ("innerAction")]
		CCActionInterval InnerAction { get; set;  }

		//+(id) actionWithAction: (CCActionInterval*) action;
		[Static]
		[Export ("actionWithAction:")]
		NSObject ActionWithAction (CCActionInterval action);

		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);


	}

	//@interface CCSpeed : CCAction <NSCopying>
	[BaseType (typeof (CCAction))]
	interface CCSpeed {

		//From Generated Property
		//}@property (nonatomic,readwrite) float speed;
		[Export ("speed")]
		float Speed { get; set;  }

		//@property (nonatomic, readwrite, retain) CCActionInterval *innerAction;
		[Export ("innerAction")]
		CCActionInterval InnerAction { get; set;  }

		//+(id) actionWithAction: (CCActionInterval*) action speed:(float)value;
		[Static]
		[Export ("actionWithAction:speed:")]
		NSObject ActionWithAction (CCActionInterval action,float speed);

		//-(id) initWithAction: (CCActionInterval*) action speed:(float)value;
		[Export ("initWithAction:speed:")]
		IntPtr Constructor (CCActionInterval action,float speed);


	}

	//@interface CCFollow : CCAction <NSCopying>
	[BaseType (typeof (CCAction))]
	interface CCFollow {

		//From Generated Property
		//}@property (nonatomic,readwrite) BOOL boundarySet;
		[Export ("boundarySet")]
		bool BoundarySet { get; set;  }

		//+(id) actionWithTarget:(CCNode *)followedNode;
		[Static]
		[Export ("actionWithTarget:")]
		NSObject ActionWithTarget (CCNode followedNode);

		//+(id) actionWithTarget:(CCNode *)followedNode worldBoundary:(CGRect)rect;
		[Static]
		[Export ("actionWithTarget:worldBoundary:")]
		NSObject ActionWithTarget (CCNode followedNode,RectangleF worldBoundary);

		//-(id) initWithTarget:(CCNode *)followedNode;
		[Export ("initWithTarget:")]
		IntPtr Constructor (CCNode followedNode);

		//-(id) initWithTarget:(CCNode *)followedNode worldBoundary:(CGRect)rect;
		[Export ("initWithTarget:worldBoundary:")]
		IntPtr Constructor (CCNode followedNode,RectangleF worldBoundary);


	}

	//@interface CCActionCamera : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCActionCamera {

		//From Generated Property
		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCOrbitCamera : CCActionCamera <NSCopying>
	[BaseType (typeof (CCActionCamera))]
	interface CCOrbitCamera {

		//From Generated Property
		//+(id) actionWithDuration:(float) t radius:(float)r deltaRadius:(float) dr angleZ:(float)z deltaAngleZ:(float)dz angleX:(float)x deltaAngleX:(float)dx;
		[Static]
		[Export ("actionWithDuration:radius:deltaRadius:angleZ:deltaAngleZ:angleX:deltaAngleX:")]
		NSObject ActionWithDuration (float t,float radius,float deltaRadius,float angleZ,float deltaAngleZ,float angleX,float deltaAngleX);

		//-(id) initWithDuration:(float) t radius:(float)r deltaRadius:(float) dr angleZ:(float)z deltaAngleZ:(float)dz angleX:(float)x deltaAngleX:(float)dx;
		[Export ("initWithDuration:radius:deltaRadius:angleZ:deltaAngleZ:angleX:deltaAngleX:")]
		IntPtr Constructor (float t,float radius,float deltaRadius,float angleZ,float deltaAngleZ,float angleX,float deltaAngleX);

		//-(void) sphericalRadius:(float*) r zenith:(float*) zenith azimuth:(float*) azimuth;
		[Export ("sphericalRadius:zenith:azimuth:")]
		void SphericalRadius (float r,float zenith,float azimuth);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCPointArray : NSObject <NSCopying>
	[BaseType (typeof (NSObject))]
	interface CCPointArray {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain) NSMutableArray *controlPoints;
		[Export ("controlPoints")]
		NSMutableArray ControlPoints { get; set;  }

		// +(id) arrayWithCapacity:(NSUInteger)capacity;
		[Export ("arrayWithCapacity:")]
		NSObject ArrayWithCapacity (uint capacity);

		//-(id) initWithCapacity:(NSUInteger)capacity;
		[Export ("initWithCapacity:")]
		IntPtr Constructor (uint capacity);

		//-(void) addControlPoint:(CGPoint)controlPoint;
		[Export ("addControlPoint:")]
		void AddControlPoint (PointF controlPoint);

		//-(void) insertControlPoint:(CGPoint)controlPoint atIndex:(NSUInteger)index;
		[Export ("insertControlPoint:atIndex:")]
		void InsertControlPoint (PointF controlPoint,uint atIndex);

		//-(void) replaceControlPoint:(CGPoint)controlPoint atIndex:(NSUInteger)index;
		[Export ("replaceControlPoint:atIndex:")]
		void ReplaceControlPoint (PointF controlPoint,uint atIndex);

		//-(CGPoint) getControlPointAtIndex:(NSInteger)index;
		[Export ("getControlPointAtIndex:")]
		PointF GetControlPointAtIndex (int index);

		//-(void) removeControlPointAtIndex:(NSUInteger)index;
		[Export ("removeControlPointAtIndex:")]
		void RemoveControlPointAtIndex (uint index);

		//-(NSUInteger) count;
		[Export ("count")]
		uint Count ();

		//-(CCPointArray*) reverse;
		[Export ("reverse")]
		CCPointArray Reverse ();

		//-(void) reverseInline;
		[Export ("reverseInline")]
		void ReverseInline ();


	}

	//@interface CCCardinalSplineTo : CCActionInterval
	[BaseType (typeof (CCActionInterval))]
	interface CCCardinalSplineTo {

		//From Generated Property
		//} @property (nonatomic,readwrite,retain) CCPointArray *points;
		[Export ("points")]
		CCPointArray Points { get; set;  }

		//+(id) actionWithDuration:(ccTime)duration points:(CCPointArray*)points tension:(CGFloat)tension;
		[Static]
		[Export ("actionWithDuration:points:tension:")]
		NSObject ActionWithDuration (ccTime duration,CCPointArray points,float tension);

		//-(id) initWithDuration:(ccTime)duration points:(CCPointArray*)points tension:(CGFloat)tension;
		[Export ("initWithDuration:points:tension:")]
		IntPtr Constructor (ccTime duration,CCPointArray points,float tension);


	}

	//@interface CCCardinalSplineBy : CCCardinalSplineTo
	[BaseType (typeof (CCCardinalSplineTo))]
	interface CCCardinalSplineBy {

		//From Generated Property

	}

	//@interface CCCatmullRomTo : CCCardinalSplineTo
	[BaseType (typeof (CCCardinalSplineTo))]
	interface CCCatmullRomTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)dt points:(CCPointArray*)points;
		[Static]
		[Export ("actionWithDuration:points:")]
		NSObject ActionWithDuration (ccTime dt,CCPointArray points);

		//-(id) initWithDuration:(ccTime)dt points:(CCPointArray*)points;
		[Export ("initWithDuration:points:")]
		IntPtr Constructor (ccTime dt,CCPointArray points);


	}

	//@interface CCCatmullRomBy : CCCardinalSplineBy
	[BaseType (typeof (CCCardinalSplineBy))]
	interface CCCatmullRomBy {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)dt points:(CCPointArray*)points;
		[Static]
		[Export ("actionWithDuration:points:")]
		NSObject ActionWithDuration (ccTime dt,CCPointArray points);

		//-(id) initWithDuration:(ccTime)dt points:(CCPointArray*)points;
		[Export ("initWithDuration:points:")]
		IntPtr Constructor (ccTime dt,CCPointArray points);


	}

	//@interface CCActionEase : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCActionEase {

		//From Generated Property
		//+(id) actionWithAction: (CCActionInterval*) action;
		[Static]
		[Export ("actionWithAction:")]
		NSObject ActionWithAction (CCActionInterval action);

		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseRateAction : CCActionEase <NSCopying>
	[BaseType (typeof (CCActionEase))]
	interface CCEaseRateAction {

		//From Generated Property
		//}@property (nonatomic,readwrite,assign) float rate;
		[Export ("rate")]
		float Rate { get; set;  }

		//+(id) actionWithAction: (CCActionInterval*) action rate:(float)rate;
		[Static]
		[Export ("actionWithAction:rate:")]
		NSObject ActionWithAction (CCActionInterval action,float rate);

		//-(id) initWithAction: (CCActionInterval*) action rate:(float)rate;
		[Export ("initWithAction:rate:")]
		IntPtr Constructor (CCActionInterval action,float rate);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseIn : CCEaseRateAction <NSCopying> {} @end
	[BaseType (typeof (CCEaseRateAction))]
	interface CCEaseIn {

		//From Generated Property
		// Constructor from 'CCEaseRateAction'
		//-(id) initWithAction: (CCActionInterval*) action rate:(float)rate;
		[Export ("initWithAction:rate:")]
		IntPtr Constructor (CCActionInterval action,float rate);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseOut : CCEaseRateAction <NSCopying> {} @end
	[BaseType (typeof (CCEaseRateAction))]
	interface CCEaseOut {

		//From Generated Property
		// Constructor from 'CCEaseRateAction'
		//-(id) initWithAction: (CCActionInterval*) action rate:(float)rate;
		[Export ("initWithAction:rate:")]
		IntPtr Constructor (CCActionInterval action,float rate);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseInOut : CCEaseRateAction <NSCopying> {} @end
	[BaseType (typeof (CCEaseRateAction))]
	interface CCEaseInOut {

		//From Generated Property
		// Constructor from 'CCEaseRateAction'
		//-(id) initWithAction: (CCActionInterval*) action rate:(float)rate;
		[Export ("initWithAction:rate:")]
		IntPtr Constructor (CCActionInterval action,float rate);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseExponentialIn : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseExponentialIn {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseExponentialOut : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseExponentialOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseExponentialInOut : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseExponentialInOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseSineIn : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseSineIn {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseSineOut : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseSineOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseSineInOut : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseSineInOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseElastic : CCActionEase <NSCopying>
	[BaseType (typeof (CCActionEase))]
	interface CCEaseElastic {

		//From Generated Property
		//}@property (nonatomic,readwrite) float period;
		[Export ("period")]
		float Period { get; set;  }

		//+(id) actionWithAction: (CCActionInterval*) action period:(float)period;
		[Static]
		[Export ("actionWithAction:period:")]
		NSObject ActionWithAction (CCActionInterval action,float period);

		//-(id) initWithAction: (CCActionInterval*) action period:(float)period;
		[Export ("initWithAction:period:")]
		IntPtr Constructor (CCActionInterval action,float period);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseElasticIn : CCEaseElastic <NSCopying> {} @end
	[BaseType (typeof (CCEaseElastic))]
	interface CCEaseElasticIn {

		//From Generated Property
		// Constructor from 'CCEaseElastic'
		//-(id) initWithAction: (CCActionInterval*) action period:(float)period;
		[Export ("initWithAction:period:")]
		IntPtr Constructor (CCActionInterval action,float period);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseElasticOut : CCEaseElastic <NSCopying> {} @end
	[BaseType (typeof (CCEaseElastic))]
	interface CCEaseElasticOut {

		//From Generated Property
		// Constructor from 'CCEaseElastic'
		//-(id) initWithAction: (CCActionInterval*) action period:(float)period;
		[Export ("initWithAction:period:")]
		IntPtr Constructor (CCActionInterval action,float period);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseElasticInOut : CCEaseElastic <NSCopying> {} @end
	[BaseType (typeof (CCEaseElastic))]
	interface CCEaseElasticInOut {

		//From Generated Property
		// Constructor from 'CCEaseElastic'
		//-(id) initWithAction: (CCActionInterval*) action period:(float)period;
		[Export ("initWithAction:period:")]
		IntPtr Constructor (CCActionInterval action,float period);

		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseBounce : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseBounce {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseBounceIn : CCEaseBounce <NSCopying> {} @end
	[BaseType (typeof (CCEaseBounce))]
	interface CCEaseBounceIn {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseBounceOut : CCEaseBounce <NSCopying> {} @end
	[BaseType (typeof (CCEaseBounce))]
	interface CCEaseBounceOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseBounceInOut : CCEaseBounce <NSCopying> {} @end
	[BaseType (typeof (CCEaseBounce))]
	interface CCEaseBounceInOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseBackIn : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseBackIn {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseBackOut : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseBackOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCEaseBackInOut : CCActionEase <NSCopying> {} @end
	[BaseType (typeof (CCActionEase))]
	interface CCEaseBackInOut {

		//From Generated Property
		// Constructor from 'CCActionEase'
		//-(id) initWithAction: (CCActionInterval*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCActionInterval action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCGridAction : CCActionInterval
	[BaseType (typeof (CCActionInterval))]
	interface CCGridAction {

		//From Generated Property
		//}@property (nonatomic,readwrite) ccGridSize gridSize;
		[Export ("gridSize")]
		ccGridSize GridSize { get; set;  }

		//+(id) actionWithSize:(ccGridSize)size duration:(ccTime)d;
		[Static]
		[Export ("actionWithSize:duration:")]
		NSObject ActionWithSize (ccGridSize size,ccTime duration);

		//-(id) initWithSize:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithSize:duration:")]
		IntPtr Constructor (ccGridSize gridSize,ccTime duration);

		//-(CCGridBase *)grid;
		[Export ("grid")]
		CCGridBase Grid ();


	}

	//@interface CCGrid3DAction : CCGridAction
	[BaseType (typeof (CCGridAction))]
	interface CCGrid3DAction {

		//From Generated Property
		//-(ccVertex3F)vertex:(ccGridSize)pos;
		[Export ("vertex:")]
		ccVertex3F Vertex (ccGridSize pos);

		//-(ccVertex3F)originalVertex:(ccGridSize)pos;
		[Export ("originalVertex:")]
		ccVertex3F OriginalVertex (ccGridSize pos);

		//-(void)setVertex:(ccGridSize)pos vertex:(ccVertex3F)vertex;
		[Export ("setVertex:vertex:")]
		void SetVertex (ccGridSize pos,ccVertex3F vertex);


	}

	//@interface CCTiledGrid3DAction : CCGridAction
	[BaseType (typeof (CCGridAction))]
	interface CCTiledGrid3DAction {

		//From Generated Property
		//-(ccQuad3)tile:(ccGridSize)pos;
		[Export ("tile:")]
		ccQuad3 Tile (ccGridSize pos);

		//-(ccQuad3)originalTile:(ccGridSize)pos;
		[Export ("originalTile:")]
		ccQuad3 OriginalTile (ccGridSize pos);

		//-(void)setTile:(ccGridSize)pos coords:(ccQuad3)coords;
		[Export ("setTile:coords:")]
		void SetTile (ccGridSize pos,ccQuad3 coords);


	}

	//@interface CCAccelDeccelAmplitude : CCActionInterval
	[BaseType (typeof (CCActionInterval))]
	interface CCAccelDeccelAmplitude {

		//From Generated Property
		//}@property (nonatomic,readwrite) float rate;
		[Export ("rate")]
		float Rate { get; set;  }

		//+(id)actionWithAction:(CCAction*)action duration:(ccTime)d;
		[Static]
		[Export ("actionWithAction:duration:")]
		NSObject ActionWithAction (CCAction action,ccTime duration);

		//-(id)initWithAction:(CCAction*)action duration:(ccTime)d;
		[Export ("initWithAction:duration:")]
		IntPtr Constructor (CCAction action,ccTime duration);


	}

	//@interface CCAccelAmplitude : CCActionInterval
	[BaseType (typeof (CCActionInterval))]
	interface CCAccelAmplitude {

		//From Generated Property
		//}@property (nonatomic,readwrite) float rate;
		[Export ("rate")]
		float Rate { get; set;  }

		//+(id)actionWithAction:(CCAction*)action duration:(ccTime)d;
		[Static]
		[Export ("actionWithAction:duration:")]
		NSObject ActionWithAction (CCAction action,ccTime duration);

		//-(id)initWithAction:(CCAction*)action duration:(ccTime)d;
		[Export ("initWithAction:duration:")]
		IntPtr Constructor (CCAction action,ccTime duration);


	}

	//@interface CCDeccelAmplitude : CCActionInterval
	[BaseType (typeof (CCActionInterval))]
	interface CCDeccelAmplitude {

		//From Generated Property
		//}@property (nonatomic,readwrite) float rate;
		[Export ("rate")]
		float Rate { get; set;  }

		//+(id)actionWithAction:(CCAction*)action duration:(ccTime)d;
		[Static]
		[Export ("actionWithAction:duration:")]
		NSObject ActionWithAction (CCAction action,ccTime duration);

		//-(id)initWithAction:(CCAction*)action duration:(ccTime)d;
		[Export ("initWithAction:duration:")]
		IntPtr Constructor (CCAction action,ccTime duration);


	}

	//@interface CCStopGrid : CCActionInstant
	[BaseType (typeof (CCActionInstant))]
	interface CCStopGrid {

		//From Generated Property

	}

	//@interface CCReuseGrid : CCActionInstant
	[BaseType (typeof (CCActionInstant))]
	interface CCReuseGrid {

		//From Generated Property
		//+(id) actionWithTimes: (int) times;
		[Static]
		[Export ("actionWithTimes:")]
		NSObject ActionWithTimes (int times);

		//-(id) initWithTimes: (int) times;
		[Export ("initWithTimes:")]
		IntPtr Constructor (int times);


	}

	//@interface CCWaves3D : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCWaves3D {

		//From Generated Property
		//}@property (nonatomic,readwrite) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set;  }

		//@property (nonatomic,readwrite) float amplitudeRate;
		[Export ("amplitudeRate")]
		float AmplitudeRate { get; set;  }

		//+(id)actionWithWaves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithWaves:amplitude:grid:duration:")]
		NSObject ActionWithWaves (int wav,float amplitude,ccGridSize grid,ccTime duration);

		//-(id)initWithWaves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithWaves:amplitude:grid:duration:")]
		IntPtr Constructor (int wav,float amplitude,ccGridSize grid,ccTime duration);


	}

	//@interface CCFlipX3D : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCFlipX3D {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)d;
		[Static]
		[Export ("actionWithDuration:")]
		NSObject ActionWithDuration (ccTime d);

		//-(id) initWithDuration:(ccTime)d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCFlipY3D : CCFlipX3D
	[BaseType (typeof (CCFlipX3D))]
	interface CCFlipY3D {

		//From Generated Property

	}

	//@interface CCLens3D : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCLens3D {

		//From Generated Property
		//}@property (nonatomic,readwrite) float lensEffect;
		[Export ("lensEffect")]
		float LensEffect { get; set;  }

		//@property (nonatomic,readwrite) CGPoint position;
		[Export ("position")]
		PointF Position { get; set;  }

		//+(id)actionWithPosition:(CGPoint)pos radius:(float)r grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithPosition:radius:grid:duration:")]
		NSObject ActionWithPosition (PointF pos,float radius,ccGridSize grid,ccTime duration);

		//-(id)initWithPosition:(CGPoint)pos radius:(float)r grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithPosition:radius:grid:duration:")]
		IntPtr Constructor (PointF pos,float radius,ccGridSize grid,ccTime duration);


	}

	//@interface CCRipple3D : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCRipple3D {

		//From Generated Property
		//}@property (nonatomic,readwrite) CGPoint position;
		[Export ("position")]
		PointF Position { get; set;  }

		//@property (nonatomic,readwrite) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set;  }

		//@property (nonatomic,readwrite) float amplitudeRate;
		[Export ("amplitudeRate")]
		float AmplitudeRate { get; set;  }

		//+(id)actionWithPosition:(CGPoint)pos radius:(float)r waves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithPosition:radius:waves:amplitude:grid:duration:")]
		NSObject ActionWithPosition (PointF pos,float radius,int waves,float amplitude,ccGridSize grid,ccTime duration);

		//-(id)initWithPosition:(CGPoint)pos radius:(float)r waves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithPosition:radius:waves:amplitude:grid:duration:")]
		IntPtr Constructor (PointF pos,float radius,int waves,float amplitude,ccGridSize grid,ccTime duration);


	}

	//@interface CCShaky3D : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCShaky3D {

		//From Generated Property
		//+(id)actionWithRange:(int)range shakeZ:(BOOL)shakeZ grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithRange:shakeZ:grid:duration:")]
		NSObject ActionWithRange (int range,bool shakeZ,ccGridSize grid,ccTime duration);

		//-(id)initWithRange:(int)range shakeZ:(BOOL)shakeZ grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithRange:shakeZ:grid:duration:")]
		IntPtr Constructor (int range,bool shakeZ,ccGridSize grid,ccTime duration);


	}

	//@interface CCLiquid : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCLiquid {

		//From Generated Property
		//}@property (nonatomic,readwrite) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set;  }

		//@property (nonatomic,readwrite) float amplitudeRate;
		[Export ("amplitudeRate")]
		float AmplitudeRate { get; set;  }

		//+(id)actionWithWaves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithWaves:amplitude:grid:duration:")]
		NSObject ActionWithWaves (int wav,float amplitude,ccGridSize grid,ccTime duration);

		//-(id)initWithWaves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithWaves:amplitude:grid:duration:")]
		IntPtr Constructor (int wav,float amplitude,ccGridSize grid,ccTime duration);


	}

	//@interface CCWaves : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCWaves {

		//From Generated Property
		//}@property (nonatomic,readwrite) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set;  }

		//@property (nonatomic,readwrite) float amplitudeRate;
		[Export ("amplitudeRate")]
		float AmplitudeRate { get; set;  }

		//+(id)actionWithWaves:(int)wav amplitude:(float)amp horizontal:(BOOL)h vertical:(BOOL)v grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithWaves:amplitude:horizontal:vertical:grid:duration:")]
		NSObject ActionWithWaves (int wav,float amplitude,bool horizontal,bool vertical,ccGridSize grid,ccTime duration);

		//-(id)initWithWaves:(int)wav amplitude:(float)amp horizontal:(BOOL)h vertical:(BOOL)v grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithWaves:amplitude:horizontal:vertical:grid:duration:")]
		IntPtr Constructor (int wav,float amplitude,bool horizontal,bool vertical,ccGridSize grid,ccTime duration);


	}

	//@interface CCTwirl : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCTwirl {

		//From Generated Property
		//}@property (nonatomic,readwrite) CGPoint position;
		[Export ("position")]
		PointF Position { get; set;  }

		//@property (nonatomic,readwrite) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set;  }

		//@property (nonatomic,readwrite) float amplitudeRate;
		[Export ("amplitudeRate")]
		float AmplitudeRate { get; set;  }

		//+(id)actionWithPosition:(CGPoint)pos twirls:(int)t amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithPosition:twirls:amplitude:grid:duration:")]
		NSObject ActionWithPosition (PointF pos,int twirls,float amplitude,ccGridSize grid,ccTime duration);

		//-(id)initWithPosition:(CGPoint)pos twirls:(int)t amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithPosition:twirls:amplitude:grid:duration:")]
		IntPtr Constructor (PointF pos,int twirls,float amplitude,ccGridSize grid,ccTime duration);


	}

	//@interface CCActionInstant : CCFiniteTimeAction <NSCopying>
	[BaseType (typeof (CCFiniteTimeAction))]
	interface CCActionInstant {

		//From Generated Property

	}

	//@interface CCShow : CCActionInstant
	[BaseType (typeof (CCActionInstant))]
	interface CCShow {

		//From Generated Property

	}

	//@interface CCHide : CCActionInstant
	[BaseType (typeof (CCActionInstant))]
	interface CCHide {

		//From Generated Property

	}

	//@interface CCToggleVisibility : CCActionInstant
	[BaseType (typeof (CCActionInstant))]
	interface CCToggleVisibility {

		//From Generated Property

	}

	//@interface CCFlipX : CCActionInstant
	[BaseType (typeof (CCActionInstant))]
	interface CCFlipX {

		//From Generated Property
		//+(id) actionWithFlipX:(BOOL)x;
		[Static]
		[Export ("actionWithFlipX:")]
		NSObject ActionWithFlipX (bool x);

		//-(id) initWithFlipX:(BOOL)x;
		[Export ("initWithFlipX:")]
		IntPtr Constructor (bool x);


	}

	//@interface CCFlipY : CCActionInstant
	[BaseType (typeof (CCActionInstant))]
	interface CCFlipY {

		//From Generated Property
		//+(id) actionWithFlipY:(BOOL)y;
		[Static]
		[Export ("actionWithFlipY:")]
		NSObject ActionWithFlipY (bool y);

		//-(id) initWithFlipY:(BOOL)y;
		[Export ("initWithFlipY:")]
		IntPtr Constructor (bool y);


	}

	//@interface CCPlace : CCActionInstant <NSCopying>
	[BaseType (typeof (CCActionInstant))]
	interface CCPlace {

		//From Generated Property
		//+(id) actionWithPosition: (CGPoint) pos;
		[Static]
		[Export ("actionWithPosition:")]
		NSObject ActionWithPosition (PointF pos);

		//-(id) initWithPosition: (CGPoint) pos;
		[Export ("initWithPosition:")]
		IntPtr Constructor (PointF pos);


	}

	//@interface CCCallFunc : CCActionInstant <NSCopying>
	[BaseType (typeof (CCActionInstant))]
	interface CCCallFunc {

		//From Generated Property
		//}@property (nonatomic, readwrite, retain) id targetCallback;
		[Export ("targetCallback")]
		NSObject TargetCallback { get; set;  }

		//+(id) actionWithTarget: (id) t selector:(SEL) s;
		[Static]
		[Export ("actionWithTarget:selector:")]
		NSObject ActionWithTarget (NSObject t,Selector selector);

		//-(id) initWithTarget: (id) t selector:(SEL) s;
		[Export ("initWithTarget:selector:")]
		IntPtr Constructor (NSObject t,Selector selector);

		//-(void) execute;
		[Export ("execute")]
		void Execute ();


	}

	//@interface CCCallFuncN : CCCallFunc
	[BaseType (typeof (CCCallFunc))]
	interface CCCallFuncN {

		//From Generated Property

	}

	//@interface CCCallFuncND : CCCallFuncN
	[BaseType (typeof (CCCallFuncN))]
	interface CCCallFuncND {

		//From Generated Property
		//+(id) actionWithTarget: (id) t selector:(SEL) s data:(void*)d;
		[Static]
		[Export ("actionWithTarget:selector:data:")]
		NSObject ActionWithTarget (NSObject t,Selector selector,IntPtr data);

		//-(id) initWithTarget:(id) t selector:(SEL) s data:(void*) d;
		[Export ("initWithTarget:selector:data:")]
		IntPtr Constructor (NSObject t,Selector selector,IntPtr data);


	}

	//@interface CCCallFuncO : CCCallFunc
	[BaseType (typeof (CCCallFunc))]
	interface CCCallFuncO {

		//From Generated Property
		//}@property (nonatomic, readwrite, retain) id object;
		[Export ("object")]
		NSObject Object { get; set;  }

		//+(id) actionWithTarget: (id) t selector:(SEL) s object:(id)object;
		[Static]
		[Export ("actionWithTarget:selector:object:")]
		NSObject ActionWithTarget (NSObject t,Selector selector,NSObject obj);

		//-(id) initWithTarget:(id) t selector:(SEL) s object:(id)object;
		[Export ("initWithTarget:selector:object:")]
		IntPtr Constructor (NSObject t,Selector selector,NSObject obj);


	}
		delegate void CCGenericCallback ();

	//@interface CCCallBlock : CCActionInstant<NSCopying>
	[BaseType (typeof (CCActionInstant))]
	interface CCCallBlock {

		//From Generated Property
		//+(id) actionWithBlock:(void(^)())block;
		[Static]
		[Export ("actionWithBlock:")]
		NSObject ActionWithBlock (CCGenericCallback _delegate);

		//-(id) initWithBlock:(void(^)())block;
		[Export ("initWithBlock:")]
		IntPtr Constructor (CCGenericCallback _delegate);

		//-(void) execute;
		[Export ("execute")]
		void Execute ();


	}
		delegate void CCNodeCallback (CCNode node);

	//@interface CCCallBlockN : CCActionInstant<NSCopying>
	[BaseType (typeof (CCActionInstant))]
	interface CCCallBlockN {

		//From Generated Property
		//+(id) actionWithBlock:(void(^)(CCNode *node))block;
		[Static]
		[Export ("actionWithBlock:")]
		NSObject ActionWithBlock (CCNodeCallback _delegate);

		//-(id) initWithBlock:(void(^)(CCNode *node))block;
		[Export ("initWithBlock:")]
		IntPtr Constructor (CCNodeCallback _delegate);

		//-(void) execute;
		[Export ("execute")]
		void Execute ();


	}
		delegate void CCCallBlockODelegateActionWithBlockobject (NSObject obj);
		delegate void CCCallBlockODelegateInitWithBlockobject (NSObject obj);

	//@interface CCCallBlockO : CCActionInstant<NSCopying>
	[BaseType (typeof (CCActionInstant))]
	interface CCCallBlockO {

		//From Generated Property
		//}@property (nonatomic,retain) id object;
		[Export ("object")]
		NSObject Object { get; set;  }

		//+(id) actionWithBlock:(void(^)(id object))block object:(id)object;
		[Static]
		[Export ("actionWithBlock:object:")]
		NSObject ActionWithBlock (CCCallBlockODelegateActionWithBlockobject _delegate,NSObject obj1);

		//-(id) initWithBlock:(void(^)(id object))block object:(id)object;
		[Export ("initWithBlock:object:")]
		IntPtr Constructor (CCCallBlockODelegateInitWithBlockobject _delegate,NSObject obj1);

		//-(void) execute;
		[Export ("execute")]
		void Execute ();


	}

	//@interface CCActionInterval : CCFiniteTimeAction <NSCopying>
	[BaseType (typeof (CCFiniteTimeAction))]
	interface CCActionInterval {

		//From Generated Property
		//}@property (nonatomic,readonly) ccTime elapsed;
		[Export ("elapsed")]
		ccTime Elapsed { get;  }

		//+(id) actionWithDuration: (ccTime) d;
		[Static]
		[Export ("actionWithDuration:")]
		NSObject ActionWithDuration (ccTime d);

		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);

		//-(BOOL) isDone;
		[Export ("isDone")]
		bool IsDone ();

		//- (CCActionInterval*) reverse;
		[Export ("reverse")]
		CCActionInterval Reverse ();


	}

	//@interface CCSequence : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCSequence {

		//From Generated Property
		//+(id) actions: (CCFiniteTimeAction*) action1, ... NS_REQUIRES_NIL_TERMINATION;
		[Static]
		[Internal]
		[Export ("actions:")]
		NSObject Actions (CCFiniteTimeAction action1,IntPtr NS_REQUIRES_NIL_TERMINATION);

		//+(id) actionWithArray: (NSArray*) arrayOfActions;
		[Static]
		[Export ("actionWithArray:")]
		NSObject ActionWithArray (NSArray arrayOfActions);

		//+(id) actionOne:(CCFiniteTimeAction*)actionOne two:(CCFiniteTimeAction*)actionTwo;
		[Static]
		[Export ("actionOne:two:")]
		NSObject ActionOne (CCFiniteTimeAction actionOne,CCFiniteTimeAction two);

		//-(id) initOne:(CCFiniteTimeAction*)actionOne two:(CCFiniteTimeAction*)actionTwo;
		[Export ("initOne:two:")]
		IntPtr Constructor (CCFiniteTimeAction actionOne,CCFiniteTimeAction two);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCRepeat : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCRepeat {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain) CCFiniteTimeAction *innerAction;
		[Export ("innerAction")]
		CCFiniteTimeAction InnerAction { get; set;  }

		//+(id) actionWithAction:(CCFiniteTimeAction*)action times: (NSUInteger)times;
		[Static]
		[Export ("actionWithAction:times:")]
		NSObject ActionWithAction (CCFiniteTimeAction action,uint times);

		//-(id) initWithAction:(CCFiniteTimeAction*)action times: (NSUInteger)times;
		[Export ("initWithAction:times:")]
		IntPtr Constructor (CCFiniteTimeAction action,uint times);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCSpawn : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCSpawn {

		//From Generated Property
		//+(id) actions: (CCFiniteTimeAction*) action1, ... NS_REQUIRES_NIL_TERMINATION;
		[Static]
		[Internal]
		[Export ("actions:")]
		NSObject Actions (CCFiniteTimeAction action1,IntPtr NS_REQUIRES_NIL_TERMINATION);

		//+(id) actionWithArray: (NSArray*) arrayOfActions;
		[Static]
		[Export ("actionWithArray:")]
		NSObject ActionWithArray (NSArray arrayOfActions);

		//+(id) actionOne: (CCFiniteTimeAction*) one two:(CCFiniteTimeAction*) two;
		[Static]
		[Export ("actionOne:two:")]
		NSObject ActionOne (CCFiniteTimeAction one,CCFiniteTimeAction two);

		//-(id) initOne: (CCFiniteTimeAction*) one two:(CCFiniteTimeAction*) two;
		[Export ("initOne:two:")]
		IntPtr Constructor (CCFiniteTimeAction one,CCFiniteTimeAction two);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCRotateTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCRotateTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration angle:(float)angle;
		[Static]
		[Export ("actionWithDuration:angle:")]
		NSObject ActionWithDuration (ccTime duration,float angle);

		//-(id) initWithDuration:(ccTime)duration angle:(float)angle;
		[Export ("initWithDuration:angle:")]
		IntPtr Constructor (ccTime duration,float angle);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCRotateBy : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCRotateBy {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration angle:(float)deltaAngle;
		[Static]
		[Export ("actionWithDuration:angle:")]
		NSObject ActionWithDuration (ccTime duration,float angle);

		//-(id) initWithDuration:(ccTime)duration angle:(float)deltaAngle;
		[Export ("initWithDuration:angle:")]
		IntPtr Constructor (ccTime duration,float angle);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCMoveTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCMoveTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration position:(CGPoint)position;
		[Static]
		[Export ("actionWithDuration:position:")]
		NSObject ActionWithDuration (ccTime duration,PointF position);

		//-(id) initWithDuration:(ccTime)duration position:(CGPoint)position;
		[Export ("initWithDuration:position:")]
		IntPtr Constructor (ccTime duration,PointF position);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCMoveBy : CCMoveTo <NSCopying>
	[BaseType (typeof (CCMoveTo))]
	interface CCMoveBy {

		//From Generated Property
		//+(id) actionWithDuration: (ccTime)duration position:(CGPoint)deltaPosition;
		[Static]
		[Export ("actionWithDuration:position:")]
		NSObject ActionWithDuration (ccTime duration,PointF position);

		//-(id) initWithDuration: (ccTime)duration position:(CGPoint)deltaPosition;
		[Export ("initWithDuration:position:")]
		IntPtr Constructor (ccTime duration,PointF position);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCSkewTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCSkewTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)t skewX:(float)sx skewY:(float)sy;
		[Static]
		[Export ("actionWithDuration:skewX:skewY:")]
		NSObject ActionWithDuration (ccTime t,float skewX,float skewY);

		//-(id) initWithDuration:(ccTime)t skewX:(float)sx skewY:(float)sy;
		[Export ("initWithDuration:skewX:skewY:")]
		IntPtr Constructor (ccTime t,float skewX,float skewY);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCSkewBy : CCSkewTo <NSCopying>
	[BaseType (typeof (CCSkewTo))]
	interface CCSkewBy {

		//From Generated Property
		// Constructor from 'CCSkewTo'
		//-(id) initWithDuration:(ccTime)t skewX:(float)sx skewY:(float)sy;
		[Export ("initWithDuration:skewX:skewY:")]
		IntPtr Constructor (ccTime t,float skewX,float skewY);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCJumpBy : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCJumpBy {

		//From Generated Property
		//+(id) actionWithDuration: (ccTime)duration position:(CGPoint)position height:(ccTime)height jumps:(NSUInteger)jumps;
		[Static]
		[Export ("actionWithDuration:position:height:jumps:")]
		NSObject ActionWithDuration (ccTime duration,PointF position,ccTime height,uint jumps);

		//-(id) initWithDuration: (ccTime)duration position:(CGPoint)position height:(ccTime)height jumps:(NSUInteger)jumps;
		[Export ("initWithDuration:position:height:jumps:")]
		IntPtr Constructor (ccTime duration,PointF position,ccTime height,uint jumps);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCJumpTo : CCJumpBy <NSCopying>
	[BaseType (typeof (CCJumpBy))]
	interface CCJumpTo {

		//From Generated Property
		// Constructor from 'CCJumpBy'
		//-(id) initWithDuration: (ccTime)duration position:(CGPoint)position height:(ccTime)height jumps:(NSUInteger)jumps;
		[Export ("initWithDuration:position:height:jumps:")]
		IntPtr Constructor (ccTime duration,PointF position,ccTime height,uint jumps);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCBezierBy : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCBezierBy {

		//From Generated Property
		//+(id) actionWithDuration: (ccTime) t bezier:(ccBezierConfig) c;
		[Static]
		[Export ("actionWithDuration:bezier:")]
		NSObject ActionWithDuration (ccTime t,ccBezierConfig bezier);

		//-(id) initWithDuration: (ccTime) t bezier:(ccBezierConfig) c;
		[Export ("initWithDuration:bezier:")]
		IntPtr Constructor (ccTime t,ccBezierConfig bezier);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCBezierTo : CCBezierBy
	[BaseType (typeof (CCBezierBy))]
	interface CCBezierTo {

		//From Generated Property

	}

	//@interface CCScaleTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCScaleTo {

		//From Generated Property
		//+(id) actionWithDuration: (ccTime)duration scale:(float) s;
		[Static]
		[Export ("actionWithDuration:scale:")]
		NSObject ActionWithDuration (ccTime duration,float scale);

		//-(id) initWithDuration: (ccTime)duration scale:(float) s;
		[Export ("initWithDuration:scale:")]
		IntPtr Constructor (ccTime duration,float scale);

		//+(id) actionWithDuration: (ccTime)duration scaleX:(float) sx scaleY:(float)sy;
		[Static]
		[Export ("actionWithDuration:scaleX:scaleY:")]
		NSObject ActionWithDuration (ccTime duration,float scaleX,float scaleY);

		//-(id) initWithDuration: (ccTime)duration scaleX:(float) sx scaleY:(float)sy;
		[Export ("initWithDuration:scaleX:scaleY:")]
		IntPtr Constructor (ccTime duration,float scaleX,float scaleY);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCScaleBy : CCScaleTo <NSCopying>
	[BaseType (typeof (CCScaleTo))]
	interface CCScaleBy {

		//From Generated Property
		// Constructor from 'CCScaleTo'
		//-(id) initWithDuration: (ccTime)duration scale:(float) s;
		[Export ("initWithDuration:scale:")]
		IntPtr Constructor (ccTime duration,float scale);

		// Constructor from 'CCScaleTo'
		//-(id) initWithDuration: (ccTime)duration scaleX:(float) sx scaleY:(float)sy;
		[Export ("initWithDuration:scaleX:scaleY:")]
		IntPtr Constructor (ccTime duration,float scaleX,float scaleY);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCBlink : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCBlink {

		//From Generated Property
		//+(id) actionWithDuration: (ccTime)duration blinks:(NSUInteger)blinks;
		[Static]
		[Export ("actionWithDuration:blinks:")]
		NSObject ActionWithDuration (ccTime duration,uint blinks);

		//-(id) initWithDuration: (ccTime)duration blinks:(NSUInteger)blinks;
		[Export ("initWithDuration:blinks:")]
		IntPtr Constructor (ccTime duration,uint blinks);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCFadeIn : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCFadeIn {

		//From Generated Property
		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCFadeOut : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCFadeOut {

		//From Generated Property
		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCFadeTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCFadeTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration opacity:(GLubyte)opactiy;
		[Static]
		[Export ("actionWithDuration:opacity:")]
		NSObject ActionWithDuration (ccTime duration,GLubyte opacity);

		//-(id) initWithDuration:(ccTime)duration opacity:(GLubyte)opacity;
		[Export ("initWithDuration:opacity:")]
		IntPtr Constructor (ccTime duration,GLubyte opacity);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCTintTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCTintTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration red:(GLubyte)red green:(GLubyte)green blue:(GLubyte)blue;
		[Static]
		[Export ("actionWithDuration:red:green:blue:")]
		NSObject ActionWithDuration (ccTime duration,GLubyte red,GLubyte green,GLubyte blue);

		//-(id) initWithDuration:(ccTime)duration red:(GLubyte)red green:(GLubyte)green blue:(GLubyte)blue;
		[Export ("initWithDuration:red:green:blue:")]
		IntPtr Constructor (ccTime duration,GLubyte red,GLubyte green,GLubyte blue);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCTintBy : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCTintBy {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration red:(GLshort)deltaRed green:(GLshort)deltaGreen blue:(GLshort)deltaBlue;
		[Static]
		[Export ("actionWithDuration:red:green:blue:")]
		NSObject ActionWithDuration (ccTime duration,GLshort red,GLshort green,GLshort blue);

		//-(id) initWithDuration:(ccTime)duration red:(GLshort)deltaRed green:(GLshort)deltaGreen blue:(GLshort)deltaBlue;
		[Export ("initWithDuration:red:green:blue:")]
		IntPtr Constructor (ccTime duration,GLshort red,GLshort green,GLshort blue);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCDelayTime : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCDelayTime {

		//From Generated Property
		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCReverseTime : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCReverseTime {

		//From Generated Property
		//+(id) actionWithAction: (CCFiniteTimeAction*) action;
		[Static]
		[Export ("actionWithAction:")]
		NSObject ActionWithAction (CCFiniteTimeAction action);

		//-(id) initWithAction: (CCFiniteTimeAction*) action;
		[Export ("initWithAction:")]
		IntPtr Constructor (CCFiniteTimeAction action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCAnimate : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCAnimate {

		//From Generated Property
		//}@property (readwrite,nonatomic,retain) CCAnimation * animation;
		[Export ("animation")]
		CCAnimation Animation { get; set;  }

		//+(id) actionWithAnimation:(CCAnimation*)animation;
		[Static]
		[Export ("actionWithAnimation:")]
		NSObject ActionWithAnimation (CCAnimation animation);

		//-(id) initWithAnimation:(CCAnimation*)animation;
		[Export ("initWithAnimation:")]
		IntPtr Constructor (CCAnimation animation);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCTargetedAction : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCTargetedAction {

		//From Generated Property
		//}@property(readwrite,nonatomic,retain) id forcedTarget;
		[Export ("forcedTarget")]
		NSObject ForcedTarget { get; set;  }

		//+ (id) actionWithTarget:(id) target action:(CCFiniteTimeAction*) action;
		[Static]
		[Export ("actionWithTarget:action:")]
		NSObject ActionWithTarget (NSObject target,CCFiniteTimeAction action);

		//- (id) initWithTarget:(id) target action:(CCFiniteTimeAction*) action;
		[Export ("initWithTarget:action:")]
		IntPtr Constructor (NSObject target,CCFiniteTimeAction action);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCActionManager : NSObject
	[BaseType (typeof (NSObject))]
	interface CCActionManager {

		//From Generated Property
		//-(void) addAction: (CCAction*) action target:(id)target paused:(BOOL)paused;
		[Export ("addAction:target:paused:")]
		void AddAction (CCAction action,NSObject target,bool paused);

		//-(void) removeAllActions;
		[Export ("removeAllActions")]
		void RemoveAllActions ();

		//-(void) removeAllActionsFromTarget:(id)target;
		[Export ("removeAllActionsFromTarget:")]
		void RemoveAllActionsFromTarget (NSObject target);

		//-(void) removeAction: (CCAction*) action;
		[Export ("removeAction:")]
		void RemoveAction (CCAction action);

		//-(void) removeActionByTag:(NSInteger)tag target:(id)target;
		[Export ("removeActionByTag:target:")]
		void RemoveActionByTag (int tag,NSObject target);

		//-(CCAction*) getActionByTag:(NSInteger) tag target:(id)target;
		[Export ("getActionByTag:target:")]
		CCAction GetActionByTag (int tag,NSObject target);

		//-(NSUInteger) numberOfRunningActionsInTarget:(id)target;
		[Export ("numberOfRunningActionsInTarget:")]
		uint NumberOfRunningActionsInTarget (NSObject target);

		//-(void) pauseTarget:(id)target;
		[Export ("pauseTarget:")]
		void PauseTarget (NSObject target);

		//-(void) resumeTarget:(id)target;
		[Export ("resumeTarget:")]
		void ResumeTarget (NSObject target);

		//-(NSSet *) pauseAllRunningActions;
		[Export ("pauseAllRunningActions")]
		NSSet PauseAllRunningActions ();

		//-(void) resumeTargets:(NSSet *)targetsToResume;
		[Export ("resumeTargets:")]
		void ResumeTargets (NSSet targetsToResume);


	}

	//@interface CCPageTurn3D : CCGrid3DAction
	[BaseType (typeof (CCGrid3DAction))]
	interface CCPageTurn3D {

		//From Generated Property

	}

	//@interface CCProgressTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCProgressTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration percent:(float)percent;
		[Static]
		[Export ("actionWithDuration:percent:")]
		NSObject ActionWithDuration (ccTime duration,float percent);

		//-(id) initWithDuration:(ccTime)duration percent:(float)percent;
		[Export ("initWithDuration:percent:")]
		IntPtr Constructor (ccTime duration,float percent);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCProgressFromTo : CCActionInterval <NSCopying>
	[BaseType (typeof (CCActionInterval))]
	interface CCProgressFromTo {

		//From Generated Property
		//+(id) actionWithDuration:(ccTime)duration from:(float)fromPercentage to:(float) toPercentage;
		[Static]
		[Export ("actionWithDuration:from:to:")]
		NSObject ActionWithDuration (ccTime duration,float from,float to);

		//-(id) initWithDuration:(ccTime)duration from:(float)fromPercentage to:(float) toPercentage;
		[Export ("initWithDuration:from:to:")]
		IntPtr Constructor (ccTime duration,float from,float to);

		// Constructor from 'CCActionInterval'
		//-(id) initWithDuration: (ccTime) d;
		[Export ("initWithDuration:")]
		IntPtr Constructor (ccTime d);


	}

	//@interface CCShakyTiles3D : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCShakyTiles3D {

		//From Generated Property
		//+(id)actionWithRange:(int)range shakeZ:(BOOL)shakeZ grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithRange:shakeZ:grid:duration:")]
		NSObject ActionWithRange (int range,bool shakeZ,ccGridSize grid,ccTime duration);

		//-(id)initWithRange:(int)range shakeZ:(BOOL)shakeZ grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithRange:shakeZ:grid:duration:")]
		IntPtr Constructor (int range,bool shakeZ,ccGridSize grid,ccTime duration);


	}

	//@interface CCShatteredTiles3D : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCShatteredTiles3D {

		//From Generated Property
		//+(id)actionWithRange:(int)range shatterZ:(BOOL)shatterZ grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithRange:shatterZ:grid:duration:")]
		NSObject ActionWithRange (int range,bool shatterZ,ccGridSize grid,ccTime duration);

		//-(id)initWithRange:(int)range shatterZ:(BOOL)shatterZ grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithRange:shatterZ:grid:duration:")]
		IntPtr Constructor (int range,bool shatterZ,ccGridSize grid,ccTime duration);


	}

	//@interface CCShuffleTiles : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCShuffleTiles {

		//From Generated Property
		//+(id)actionWithSeed:(int)s grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithSeed:grid:duration:")]
		NSObject ActionWithSeed (int s,ccGridSize grid,ccTime duration);

		//-(id)initWithSeed:(int)s grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithSeed:grid:duration:")]
		IntPtr Constructor (int s,ccGridSize grid,ccTime duration);


	}

	//@interface CCFadeOutTRTiles : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCFadeOutTRTiles {

		//From Generated Property

	}

	//@interface CCFadeOutBLTiles : CCFadeOutTRTiles
	[BaseType (typeof (CCFadeOutTRTiles))]
	interface CCFadeOutBLTiles {

		//From Generated Property

	}

	//@interface CCFadeOutUpTiles : CCFadeOutTRTiles
	[BaseType (typeof (CCFadeOutTRTiles))]
	interface CCFadeOutUpTiles {

		//From Generated Property

	}

	//@interface CCFadeOutDownTiles : CCFadeOutUpTiles
	[BaseType (typeof (CCFadeOutUpTiles))]
	interface CCFadeOutDownTiles {

		//From Generated Property

	}

	//@interface CCTurnOffTiles : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCTurnOffTiles {

		//From Generated Property
		//+(id)actionWithSeed:(int)s grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithSeed:grid:duration:")]
		NSObject ActionWithSeed (int s,ccGridSize grid,ccTime duration);

		//-(id)initWithSeed:(int)s grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithSeed:grid:duration:")]
		IntPtr Constructor (int s,ccGridSize grid,ccTime duration);


	}

	//@interface CCWavesTiles3D : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCWavesTiles3D {

		//From Generated Property
		//}@property (nonatomic,readwrite) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set;  }

		//@property (nonatomic,readwrite) float amplitudeRate;
		[Export ("amplitudeRate")]
		float AmplitudeRate { get; set;  }

		//+(id)actionWithWaves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithWaves:amplitude:grid:duration:")]
		NSObject ActionWithWaves (int wav,float amplitude,ccGridSize grid,ccTime duration);

		//-(id)initWithWaves:(int)wav amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithWaves:amplitude:grid:duration:")]
		IntPtr Constructor (int wav,float amplitude,ccGridSize grid,ccTime duration);


	}

	//@interface CCJumpTiles3D : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCJumpTiles3D {

		//From Generated Property
		//}@property (nonatomic,readwrite) float amplitude;
		[Export ("amplitude")]
		float Amplitude { get; set;  }

		//@property (nonatomic,readwrite) float amplitudeRate;
		[Export ("amplitudeRate")]
		float AmplitudeRate { get; set;  }

		//+(id)actionWithJumps:(int)j amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Static]
		[Export ("actionWithJumps:amplitude:grid:duration:")]
		NSObject ActionWithJumps (int j,float amplitude,ccGridSize grid,ccTime duration);

		//-(id)initWithJumps:(int)j amplitude:(float)amp grid:(ccGridSize)gridSize duration:(ccTime)d;
		[Export ("initWithJumps:amplitude:grid:duration:")]
		IntPtr Constructor (int j,float amplitude,ccGridSize grid,ccTime duration);


	}

	//@interface CCSplitRows : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCSplitRows {

		//From Generated Property
		//+(id)actionWithRows:(int)rows duration:(ccTime)duration;
		[Static]
		[Export ("actionWithRows:duration:")]
		NSObject ActionWithRows (int rows,ccTime duration);

		//-(id)initWithRows:(int)rows duration:(ccTime)duration;
		[Export ("initWithRows:duration:")]
		IntPtr Constructor (int rows,ccTime duration);


	}

	//@interface CCSplitCols : CCTiledGrid3DAction
	[BaseType (typeof (CCTiledGrid3DAction))]
	interface CCSplitCols {

		//From Generated Property
		//+(id)actionWithCols:(int)cols duration:(ccTime)duration;
		[Static]
		[Export ("actionWithCols:duration:")]
		NSObject ActionWithCols (int cols,ccTime duration);

		//-(id)initWithCols:(int)cols duration:(ccTime)duration;
		[Export ("initWithCols:duration:")]
		IntPtr Constructor (int cols,ccTime duration);


	}

	//@interface CCActionTween : CCActionInterval
	[BaseType (typeof (CCActionInterval))]
	interface CCActionTween {

		//From Generated Property
		//+ (id)actionWithDuration:(ccTime)aDuration key:(NSString *)key from:(float)from to:(float)to;
		[Static]
		[Export ("actionWithDuration:key:from:to:")]
		NSObject ActionWithDuration (ccTime aDuration,string key,float from,float to);

		//- (id)initWithDuration:(ccTime)aDuration key:(NSString *)key from:(float)from to:(float)to;
		[Export ("initWithDuration:key:from:to:")]
		IntPtr Constructor (ccTime aDuration,string key,float from,float to);


	}

	//@interface CCAnimationFrame : NSObject <NSCopying>
	[BaseType (typeof (NSObject))]
	interface CCAnimationFrame {

		//From Generated Property
		//}@property (nonatomic, readwrite, retain) CCSpriteFrame* spriteFrame;
		[Export ("spriteFrame")]
		CCSpriteFrame SpriteFrame { get; set;  }

		//@property (nonatomic, readwrite) float delayUnits;
		[Export ("delayUnits")]
		float DelayUnits { get; set;  }

		//@property (nonatomic, readwrite, retain) NSDictionary *userInfo;
		[Export ("userInfo")]
		NSDictionary UserInfo { get; set;  }

		//-(id) initWithSpriteFrame:(CCSpriteFrame*)spriteFrame delayUnits:(float)delayUnits userInfo:(NSDictionary*)userInfo;
		[Export ("initWithSpriteFrame:delayUnits:userInfo:")]
		IntPtr Constructor (CCSpriteFrame spriteFrame,float delayUnits,NSDictionary userInfo);


	}

	//@interface CCAnimation : NSObject <NSCopying>
	[BaseType (typeof (NSObject))]
	interface CCAnimation {

		//From Generated Property
		//}@property (nonatomic, readonly) float totalDelayUnits;
		[Export ("totalDelayUnits")]
		float TotalDelayUnits { get;  }

		//@property (nonatomic, readwrite) float delayPerUnit;
		[Export ("delayPerUnit")]
		float DelayPerUnit { get; set;  }

		//@property (nonatomic,readonly) float duration;
		[Export ("duration")]
		float Duration { get;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *frames;
		[Export ("frames")]
		NSMutableArray Frames { get; set;  }

		//@property (nonatomic,readwrite) BOOL restoreOriginalFrame;
		[Export ("restoreOriginalFrame")]
		bool RestoreOriginalFrame { get; set;  }

		//@property (nonatomic, readwrite) NSUInteger loops;
		[Export ("loops")]
		uint Loops { get; set;  }

		//+(id) animation;
		[Static]
		[Export ("animation")]
		NSObject Animation ();

		//+(id) animationWithSpriteFrames:(NSArray*)arrayOfSpriteFrameNames;
		[Static]
		[Export ("animationWithSpriteFrames:")]
		NSObject AnimationWithSpriteFrames (NSArray arrayOfSpriteFrameNames);

		//+(id) animationWithSpriteFrames:(NSArray*)arrayOfSpriteFrameNames delay:(float)delay;
		[Static]
		[Export ("animationWithSpriteFrames:delay:")]
		NSObject AnimationWithSpriteFrames (NSArray arrayOfSpriteFrameNames,float delay);

		//+(id) animationWithAnimationFrames:(NSArray*)arrayOfAnimationFrames delayPerUnit:(float)delayPerUnit loops:(NSUInteger)loops;
		[Static]
		[Export ("animationWithAnimationFrames:delayPerUnit:loops:")]
		NSObject AnimationWithAnimationFrames (NSArray arrayOfAnimationFrames,float delayPerUnit,uint loops);

		//-(id) initWithSpriteFrames:(NSArray*)arrayOfSpriteFrameNames;
		[Export ("initWithSpriteFrames:")]
		IntPtr Constructor (NSArray arrayOfSpriteFrameNames);

		//-(id) initWithSpriteFrames:(NSArray *)arrayOfSpriteFrameNames delay:(float)delay;
		[Export ("initWithSpriteFrames:delay:")]
		IntPtr Constructor (NSArray arrayOfSpriteFrameNames,float delay);

		//-(id) initWithAnimationFrames:(NSArray*)arrayOfAnimationFrames delayPerUnit:(float)delayPerUnit loops:(NSUInteger)loops;
		[Export ("initWithAnimationFrames:delayPerUnit:loops:")]
		IntPtr Constructor (NSArray arrayOfAnimationFrames,float delayPerUnit,uint loops);

		//-(void) addSpriteFrame:(CCSpriteFrame*)frame;
		[Export ("addSpriteFrame:")]
		void AddSpriteFrame (CCSpriteFrame frame);

		//-(void) addSpriteFrameWithFilename:(NSString*)filename;
		[Export ("addSpriteFrameWithFilename:")]
		void AddSpriteFrameWithFilename (string filename);

		//-(void) addSpriteFrameWithTexture:(CCTexture2D*)texture rect:(CGRect)rect;
		[Export ("addSpriteFrameWithTexture:rect:")]
		void AddSpriteFrameWithTexture (CCTexture2D texture,RectangleF rect);


	}

	//@interface CCAnimationCache : NSObject
	[BaseType (typeof (NSObject))]
	interface CCAnimationCache {

		//From Generated Property
		//+ (CCAnimationCache *) sharedAnimationCache;
		[Static]
		[Export ("sharedAnimationCache")]
		CCAnimationCache SharedAnimationCache ();

		//+(void)purgeSharedAnimationCache;
		[Static]
		[Export ("purgeSharedAnimationCache")]
		void PurgeSharedAnimationCache ();

		//-(void) addAnimation:(CCAnimation*)animation name:(NSString*)name;
		[Export ("addAnimation:name:")]
		void AddAnimation (CCAnimation animation,string name);

		//-(void) removeAnimationByName:(NSString*)name;
		[Export ("removeAnimationByName:")]
		void RemoveAnimationByName (string name);

		//-(CCAnimation*) animationByName:(NSString*)name;
		[Export ("animationByName:")]
		CCAnimation AnimationByName (string name);

		//-(void)addAnimationsWithDictionary:(NSDictionary *)dictionary;
		[Export ("addAnimationsWithDictionary:")]
		void AddAnimationsWithDictionary (NSDictionary dictionary);

		//-(void)addAnimationsWithFile:(NSString *)plist;
		[Export ("addAnimationsWithFile:")]
		void AddAnimationsWithFile (string plist);


	}

	//@interface CCAtlasNode : CCNode <CCRGBAProtocol, CCTextureProtocol>
	[BaseType (typeof (CCNode))]
	interface CCAtlasNode {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain) CCTextureAtlas *textureAtlas;
		[Export ("textureAtlas")]
		CCTextureAtlas TextureAtlas { get; set;  }

		//@property (nonatomic,readwrite) ccBlendFunc blendFunc;
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set;  }

		//@property (nonatomic,readwrite) GLubyte opacity;
		[Export ("opacity")]
		GLubyte Opacity { get; set;  }

		//@property (nonatomic,readwrite) ccColor3B color;
		[Export ("color")]
		ccColor3B Color { get; set;  }

		//@property (nonatomic,readwrite) NSUInteger quadsToDraw;
		[Export ("quadsToDraw")]
		uint QuadsToDraw { get; set;  }

		//+(id) atlasWithTileFile:(NSString*)tile tileWidth:(NSUInteger)w tileHeight:(NSUInteger)h itemsToRender: (NSUInteger) c;
		[Static]
		[Export ("atlasWithTileFile:tileWidth:tileHeight:itemsToRender:")]
		NSObject AtlasWithTileFile (string tile,uint tileWidth,uint tileHeight,uint itemsToRender);

		//-(id) initWithTileFile:(NSString*)tile tileWidth:(NSUInteger)w tileHeight:(NSUInteger)h itemsToRender: (NSUInteger) c;
		[Export ("initWithTileFile:tileWidth:tileHeight:itemsToRender:")]
		IntPtr Constructor (string tile,uint tileWidth,uint tileHeight,uint itemsToRender);

		//-(void) updateAtlasValues;
		[Export ("updateAtlasValues")]
		void UpdateAtlasValues ();

		//-(void) setColor:(ccColor3B)color;
		// From protocol 'CCRGBAProtocol'
		[Export ("setColor:")]
		void SetColor (ccColor3B color);

		//-(void) setOpacity: (GLubyte) opacity;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacity:")]
		void SetOpacity (GLubyte opacity);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		//Detected properties
		// From protocol 'CCTextureProtocol'
		[Export ("texture")]
		CCTexture2D Texture { get; set; }


	}

	//@interface CCCamera : NSObject
	[BaseType (typeof (NSObject))]
	interface CCCamera {

		//From Generated Property
		//}@property (nonatomic,readwrite) BOOL dirty;
		[Export ("dirty")]
		bool Dirty { get; set;  }

		//+(float) getZEye;
		[Static]
		[Export ("getZEye")]
		float GetZEye ();

		//-(void) restore;
		[Export ("restore")]
		void Restore ();

		//-(void) locate;
		[Export ("locate")]
		void Locate ();

		//-(void) setEyeX: (float)x eyeY:(float)y eyeZ:(float)z;
		[Export ("setEyeX:eyeY:eyeZ:")]
		void SetEyeX (float x,float eyeY,float eyeZ);

		//-(void) setCenterX: (float)x centerY:(float)y centerZ:(float)z;
		[Export ("setCenterX:centerY:centerZ:")]
		void SetCenterX (float x,float centerY,float centerZ);

		//-(void) setUpX: (float)x upY:(float)y upZ:(float)z;
		[Export ("setUpX:upY:upZ:")]
		void SetUpX (float x,float upY,float upZ);

		//-(void) eyeX:(float*)x eyeY:(float*)y eyeZ:(float*)z;
		[Export ("eyeX:eyeY:eyeZ:")]
		void EyeX (float x,float eyeY,float eyeZ);

		//-(void) centerX:(float*)x centerY:(float*)y centerZ:(float*)z;
		[Export ("centerX:centerY:centerZ:")]
		void CenterX (float x,float centerY,float centerZ);

		//-(void) upX:(float*)x upY:(float*)y upZ:(float*)z;
		[Export ("upX:upY:upZ:")]
		void UpX (float x,float upY,float upZ);


	}

	//@interface CCConfiguration : NSObject {
	[BaseType (typeof (NSObject))]
	interface CCConfiguration {

		//From Generated Property
		//@property (nonatomic, readonly) GLint maxTextureSize;
		[Export ("maxTextureSize")]
		GLint MaxTextureSize { get;  }

		//@property (nonatomic, readonly) GLint maxModelviewStackDepth;
		[Export ("maxModelviewStackDepth")]
		GLint MaxModelviewStackDepth { get;  }

		//@property (nonatomic, readonly) GLint maxTextureUnits;
		[Export ("maxTextureUnits")]
		GLint MaxTextureUnits { get;  }

		//@property (nonatomic, readonly) BOOL supportsNPOT;
		[Export ("supportsNPOT")]
		bool SupportsNPOT { get;  }

		//@property (nonatomic, readonly) BOOL supportsPVRTC;
		[Export ("supportsPVRTC")]
		bool SupportsPVRTC { get;  }

		//@property (nonatomic, readonly) BOOL supportsBGRA8888;
		[Export ("supportsBGRA8888")]
		bool SupportsBGRA8888 { get;  }

		//@property (nonatomic, readonly) BOOL supportsDiscardFramebuffer;
		[Export ("supportsDiscardFramebuffer")]
		bool SupportsDiscardFramebuffer { get;  }

		//@property (nonatomic, readonly) BOOL supportsShareableVAO;
		[Export ("supportsShareableVAO")]
		bool SupportsShareableVAO { get;  }

		//@property (nonatomic, readonly) uint OSVersion;
		[Export ("OSVersion")]
		uint OSVersion { get;  }

		//+(CCConfiguration *) sharedConfiguration;
		[Static]
		[Export ("sharedConfiguration")]
		CCConfiguration SharedConfiguration ();

		//- (BOOL) checkForGLExtension:(NSString *)searchName;
		[Export ("checkForGLExtension:")]
		bool CheckForGLExtension (string searchName);


	}

	//@interface CCDirector : CC_VIEWCONTROLLER
	[BaseType (typeof (NSObject))]
	interface CCDirector {

		//From Generated Property
		//}@property (readonly, nonatomic ) NSThread *runningThread;
		[Export ("runningThread")]
		NSThread RunningThread { get;  }

		//@property (nonatomic,readonly) CCScene* runningScene;
		[Export ("runningScene")]
		CCScene RunningScene { get;  }

		//@property (nonatomic,readwrite, assign) NSTimeInterval animationInterval;
		[Export ("animationInterval")]
		double AnimationInterval { get; set;  }

		//@property (nonatomic, readwrite, assign) BOOL displayStats;
		[Export ("displayStats")]
		bool DisplayStats { get; set;  }

		//@property (nonatomic,readwrite,assign) BOOL nextDeltaTimeZero;
		[Export ("nextDeltaTimeZero")]
		bool NextDeltaTimeZero { get; set;  }

		//@property (nonatomic,readonly) BOOL isPaused;
		[Export ("isPaused")]
		bool IsPaused { get;  }

		//@property (nonatomic,readonly) BOOL isAnimating;
		[Export ("isAnimating")]
		bool IsAnimating { get;  }

		//@property (nonatomic,readwrite) ccDirectorProjection projection;
		[Export ("projection")]
		ccDirectorProjection Projection { get; set;  }

		//@property (nonatomic,readonly) NSUInteger	totalFrames;
		[Export ("totalFrames")]
		uint TotalFrames { get;  }

		//@property (nonatomic, readonly) ccTime secondsPerFrame;
		[Export ("secondsPerFrame")]
		ccTime SecondsPerFrame { get;  }

		//@property (nonatomic, readonly) BOOL sendCleanupToScene;
		[Export ("sendCleanupToScene")]
		bool SendCleanupToScene { get;  }

		//@property (nonatomic, readwrite, retain) id	notificationNode;
		[Export ("notificationNode")]
		NSObject NotificationNode { get; set;  }

		//@property (nonatomic, readwrite, retain) id delegate;
		[Export ("delegate")]
		NSObject Delegate { get; set;  }

		//@property (nonatomic,readwrite,retain) CCScheduler *scheduler;
		[Export ("scheduler")]
		CCScheduler Scheduler { get; set;  }

		//@property (nonatomic,readwrite,retain) CCActionManager *actionManager;
		[Export ("actionManager")]
		CCActionManager ActionManager { get; set;  }

		//+(CCDirector*)sharedDirector;
		[Static]
		[Export ("sharedDirector")]
		CCDirector SharedDirector ();

		//- (CGSize) winSize;
		[Export ("winSize")]
		SizeF WinSize ();

		//- (CGSize) winSizeInPixels;
		[Export ("winSizeInPixels")]
		SizeF WinSizeInPixels ();

		//-(void) reshapeProjection:(CGSize)newWindowSize;
		[Export ("reshapeProjection:")]
		void ReshapeProjection (SizeF newWindowSize);

		//-(CGPoint) convertToGL: (CGPoint) p;
		[Export ("convertToGL:")]
		PointF ConvertToGL (PointF p);

		//-(CGPoint) convertToUI:(CGPoint)p;
		[Export ("convertToUI:")]
		PointF ConvertToUI (PointF p);

		//-(float) getZEye;
		[Export ("getZEye")]
		float GetZEye ();

		//- (void) runWithScene:(CCScene*) scene;
		[Export ("runWithScene:")]
		void RunWithScene (CCScene scene);

		//- (void) pushScene:(CCScene*) scene;
		[Export ("pushScene:")]
		void PushScene (CCScene scene);

		//- (void) popScene;
		[Export ("popScene")]
		void PopScene ();

		//- (void) popToRootScene;
		[Export ("popToRootScene")]
		void PopToRootScene ();

		//-(void) replaceScene: (CCScene*) scene;
		[Export ("replaceScene:")]
		void ReplaceScene (CCScene scene);

		//-(void) end;
		[Export ("end")]
		void End ();

		//-(void) pause;
		[Export ("pause")]
		void Pause ();

		//-(void) resume;
		[Export ("resume")]
		void Resume ();

		//-(void) stopAnimation;
		[Export ("stopAnimation")]
		void StopAnimation ();

		//-(void) startAnimation;
		[Export ("startAnimation")]
		void StartAnimation ();

		//-(void) drawScene;
		[Export ("drawScene")]
		void DrawScene ();

		//-(void) purgeCachedData;
		[Export ("purgeCachedData")]
		void PurgeCachedData ();

		//-(void) setGLDefaultValues;
		[Export ("setGLDefaultValues")]
		void SetGLDefaultValues ();

		//- (void) setAlphaBlending: (BOOL) on;
		[Export ("setAlphaBlending:")]
		void SetAlphaBlending (bool on);

		//- (void) setDepthTest: (BOOL) on;
		[Export ("setDepthTest:")]
		void SetDepthTest (bool on);

		//-(void) createStatsLabel;
		[Export ("createStatsLabel")]
		void CreateStatsLabel ();

		//-(CGPoint) convertEventToGL:(NSEvent*)event;
		[Export ("convertEventToGL:")]
		PointF ConvertEventToGL (NSEvent evt);

		//Detected properties
		[Export ("view")]
		CCGLView View { get; set; }


	}

	//@interface CCGLProgram : NSObject
	[BaseType (typeof (NSObject))]
	interface CCGLProgram {

		//From Generated Property
		//- (id)initWithVertexShaderFilename:(NSString *)vShaderFilename fragmentShaderFilename:(NSString *)fShaderFilename;
		[Export ("initWithVertexShaderFilename:fragmentShaderFilename:")]
		IntPtr Constructor (string vShaderFilename,string fragmentShaderFilename);

		//- (void)addAttribute:(NSString *)attributeName index:(GLuint)index;
		[Export ("addAttribute:index:")]
		void AddAttribute (string attributeName,GLuint index);

		//- (BOOL)link;
		[Export ("link")]
		bool Link ();

		//- (void)use;
		[Export ("use")]
		void Use ();

		//- (void) updateUniforms;
		[Export ("updateUniforms")]
		void UpdateUniforms ();

		//-(void) setUniformLocation:(NSUInteger)location withI1:(GLint)i1;
		[Export ("setUniformLocation:withI1:")]
		void SetUniformLocation (uint location,GLint withI1);

		//-(void) setUniformLocation:(NSUInteger)location withF1:(GLfloat)f1;
		[Export ("setUniformLocation:withF1:")]
		void SetUniformLocation (uint location,float withF1);

		//-(void) setUniformLocation:(NSUInteger)location withF1:(GLfloat)f1 f2:(GLfloat)f2;
		[Export ("setUniformLocation:withF1:f2:")]
		void SetUniformLocation (uint location,float withF1,float f2);

		//-(void) setUniformLocation:(NSUInteger)location withF1:(GLfloat)f1 f2:(GLfloat)f2 f3:(GLfloat)f3;
		[Export ("setUniformLocation:withF1:f2:f3:")]
		void SetUniformLocation (uint location,float withF1,float f2,float f3);

		//-(void) setUniformLocation:(NSUInteger)location withF1:(GLfloat)f1 f2:(GLfloat)f2 f3:(GLfloat)f3 f4:(GLfloat)f4;
		[Export ("setUniformLocation:withF1:f2:f3:f4:")]
		void SetUniformLocation (uint location,float withF1,float f2,float f3,float f4);

		//-(void) setUniformLocation:(NSUInteger)location with2fv:(GLfloat*)floats count:(NSUInteger)numberOfArrays;
		[Export ("setUniformLocation:with2fv:count:")]
		void SetUniformLocation (uint location,float with2fv,uint count);

		//-(void) setUniformLocation:(NSUInteger)location with3fv:(GLfloat*)floats count:(NSUInteger)numberOfArrays;
		[Export ("setUniformLocation:with3fv:count:")]
		void SetUniformLocationWith3fv (uint location,float with3fv,uint count);

		//-(void) setUniformLocation:(NSUInteger)location with4fv:(GLvoid*)floats count:(NSUInteger)numberOfArrays;
		[Export ("setUniformLocation:with4fv:count:")]
		void SetUniformLocationWith4fv (uint location,GLvoid with4fv,uint count);

		//-(void) setUniformLocation:(NSUInteger)location withMatrix4fv:(GLvoid*)matrix_array count:(NSUInteger)numberOfMatrix;
		[Export ("setUniformLocation:withMatrix4fv:count:")]
		void SetUniformLocation (uint location,GLvoid withMatrix4fv,uint count);

		//-(void) setUniformForModelViewProjectionMatrix;
		[Export ("setUniformForModelViewProjectionMatrix")]
		void SetUniformForModelViewProjectionMatrix ();

		//- (NSString *)vertexShaderLog;
		[Export ("vertexShaderLog")]
		string VertexShaderLog ();

		//- (NSString *)fragmentShaderLog;
		[Export ("fragmentShaderLog")]
		string FragmentShaderLog ();

		//- (NSString *)programLog;
		[Export ("programLog")]
		string ProgramLog ();


	}

	//@interface CCGrabber : NSObject
	[BaseType (typeof (NSObject))]
	interface CCGrabber {

		//From Generated Property
		//-(void)grab:(CCTexture2D*)texture;
		[Export ("grab:")]
		void Grab (CCTexture2D texture);

		//-(void)beforeRender:(CCTexture2D*)texture;
		[Export ("beforeRender:")]
		void BeforeRender (CCTexture2D texture);

		//-(void)afterRender:(CCTexture2D*)texture;
		[Export ("afterRender:")]
		void AfterRender (CCTexture2D texture);


	}

	//@interface CCGridBase : NSObject
	[BaseType (typeof (NSObject))]
	interface CCGridBase {

		//From Generated Property
		//}@property (nonatomic,readwrite) BOOL active;
		[Export ("active")]
		bool Active { get; set;  }

		//@property (nonatomic,readwrite) int reuseGrid;
		[Export ("reuseGrid")]
		int ReuseGrid { get; set;  }

		//@property (nonatomic,readonly) ccGridSize gridSize;
		[Export ("gridSize")]
		ccGridSize GridSize { get;  }

		//@property (nonatomic,readwrite) CGPoint step;
		[Export ("step")]
		PointF Step { get; set;  }

		//@property (nonatomic, retain) CCTexture2D *texture;
		[Export ("texture")]
		CCTexture2D Texture { get; set;  }

		//@property (nonatomic, retain) CCGrabber *grabber;
		[Export ("grabber")]
		CCGrabber Grabber { get; set;  }

		//@property (nonatomic, readwrite) BOOL isTextureFlipped;
		[Export ("isTextureFlipped")]
		bool IsTextureFlipped { get; set;  }

		//@property (nonatomic, readwrite, assign) CCGLProgram *shaderProgram;
		[Export ("shaderProgram")]
		CCGLProgram ShaderProgram { get; set;  }

		//+(id) gridWithSize:(ccGridSize)gridSize texture:(CCTexture2D*)texture flippedTexture:(BOOL)flipped;
		[Static]
		[Export ("gridWithSize:texture:flippedTexture:")]
		NSObject GridWithSize (ccGridSize gridSize,CCTexture2D texture,bool flippedTexture);

		//+(id) gridWithSize:(ccGridSize)gridSize;
		[Static]
		[Export ("gridWithSize:")]
		NSObject GridWithSize (ccGridSize gridSize);

		//-(id) initWithSize:(ccGridSize)gridSize texture:(CCTexture2D*)texture flippedTexture:(BOOL)flipped;
		[Export ("initWithSize:texture:flippedTexture:")]
		IntPtr Constructor (ccGridSize gridSize,CCTexture2D texture,bool flippedTexture);

		//-(id)initWithSize:(ccGridSize)gridSize;
		[Export ("initWithSize:")]
		IntPtr Constructor (ccGridSize gridSize);

		//-(void)beforeDraw;
		[Export ("beforeDraw")]
		void BeforeDraw ();

		//-(void)afterDraw:(CCNode*)target;
		[Export ("afterDraw:")]
		void AfterDraw (CCNode target);

		//-(void)blit;
		[Export ("blit")]
		void Blit ();

		//-(void)reuse;
		[Export ("reuse")]
		void Reuse ();

		//-(void)calculateVertexPoints;
		[Export ("calculateVertexPoints")]
		void CalculateVertexPoints ();


	}

	//@interface CCGrid3D : CCGridBase
	[BaseType (typeof (CCGridBase))]
	interface CCGrid3D {

		//From Generated Property
		//-(ccVertex3F)vertex:(ccGridSize)pos;
		[Export ("vertex:")]
		ccVertex3F Vertex (ccGridSize pos);

		//-(ccVertex3F)originalVertex:(ccGridSize)pos;
		[Export ("originalVertex:")]
		ccVertex3F OriginalVertex (ccGridSize pos);

		//-(void)setVertex:(ccGridSize)pos vertex:(ccVertex3F)vertex;
		[Export ("setVertex:vertex:")]
		void SetVertex (ccGridSize pos,ccVertex3F vertex);


	}

	//@interface CCTiledGrid3D : CCGridBase
	[BaseType (typeof (CCGridBase))]
	interface CCTiledGrid3D {

		//From Generated Property
		//-(ccQuad3)tile:(ccGridSize)pos;
		[Export ("tile:")]
		ccQuad3 Tile (ccGridSize pos);

		//-(ccQuad3)originalTile:(ccGridSize)pos;
		[Export ("originalTile:")]
		ccQuad3 OriginalTile (ccGridSize pos);

		//-(void)setTile:(ccGridSize)pos coords:(ccQuad3)coords;
		[Export ("setTile:coords:")]
		void SetTile (ccGridSize pos,ccQuad3 coords);


	}

	//@interface CCLabelAtlas : CCAtlasNode <CCLabelProtocol>
	[BaseType (typeof (CCAtlasNode))]
	interface CCLabelAtlas {

		//From Generated Property
		//+(id) labelWithString:(NSString*) string charMapFile: (NSString*) charmapfile itemWidth:(NSUInteger)w itemHeight:(NSUInteger)h startCharMap:(NSUInteger)firstElement;
		[Static]
		[Export ("labelWithString:charMapFile:itemWidth:itemHeight:startCharMap:")]
		NSObject LabelWithString (string str,string charMapFile,uint itemWidth,uint itemHeight,uint startCharMap);

		//+(id) labelWithString:(NSString*) string fntFile:(NSString*)fontFile;
		[Static]
		[Export ("labelWithString:fntFile:")]
		NSObject LabelWithString (string str,string fntFile);

		//-(id) initWithString:(NSString*) string charMapFile: (NSString*) charmapfile itemWidth:(NSUInteger)w itemHeight:(NSUInteger)h startCharMap:(NSUInteger)firstElement;
		[Export ("initWithString:charMapFile:itemWidth:itemHeight:startCharMap:")]
		IntPtr Constructor (string str,string charMapFile,uint itemWidth,uint itemHeight,uint startCharMap);

		//-(id) initWithString:(NSString*) string fntFile:(NSString*)fontFile;
		[Export ("initWithString:fntFile:")]
		IntPtr Constructor (string str,string fntFile);

		//@optional-(void) setCString:(char*)label;
		// From protocol 'CCLabelProtocol'
		[Export ("setCString:")]
		void SetCString (char label);

		// Constructor from 'CCAtlasNode'
		//-(id) initWithTileFile:(NSString*)tile tileWidth:(NSUInteger)w tileHeight:(NSUInteger)h itemsToRender: (NSUInteger) c;
		[Export ("initWithTileFile:tileWidth:tileHeight:itemsToRender:")]
		IntPtr Constructor (string tile,uint tileWidth,uint tileHeight,uint itemsToRender);

		//Detected properties
		// From protocol 'CCLabelProtocol'
		[Export ("string")]
		string String { get; set; }


	}

	//@interface CCBMFontConfiguration : NSObject
	[BaseType (typeof (NSObject))]
	interface CCBMFontConfiguration {

		//From Generated Property
		//}@property (nonatomic, readwrite, retain) NSString *atlasName;
		[Export ("atlasName")]
		string AtlasName { get; set;  }

		//+(id) configurationWithFNTFile:(NSString*)FNTfile;
		[Static]
		[Export ("configurationWithFNTFile:")]
		NSObject ConfigurationWithFNTFile (string FNTfile);

		//-(id) initWithFNTfile:(NSString*)FNTfile;
		[Export ("initWithFNTfile:")]
		IntPtr Constructor (string FNTfile);


	}

	//@interface CCLabelBMFont : CCSpriteBatchNode <CCLabelProtocol, CCRGBAProtocol>
	[BaseType (typeof (CCSpriteBatchNode))]
	interface CCLabelBMFont {

		//From Generated Property
		//@property (nonatomic,assign,readonly) CCTextAlignment alignment;
		[Export ("alignment")]
		CCTextAlignment Alignment { get;  }

		//@property (nonatomic,retain) NSString* fntFile;
		[Export ("fntFile")]
		string FntFile { get; set;  }

		//@property (nonatomic,readwrite) GLubyte opacity;
		[Export ("opacity")]
		GLubyte Opacity { get; set;  }

		//@property (nonatomic,readwrite) ccColor3B color;
		[Export ("color")]
		ccColor3B Color { get; set;  }

		//+(void) purgeCachedData;
		[Static]
		[Export ("purgeCachedData")]
		void PurgeCachedData ();

		//+(id) labelWithString:(NSString*)string fntFile:(NSString*)fntFile;
		[Static]
		[Export ("labelWithString:fntFile:")]
		NSObject LabelWithString (string str,string fntFile);

		//+(id) labelWithString:(NSString*)string fntFile:(NSString*)fntFile width:(float)width alignment:(CCTextAlignment)alignment;
		[Static]
		[Export ("labelWithString:fntFile:width:alignment:")]
		NSObject LabelWithString (string str,string fntFile,float width,CCTextAlignment alignment);

		//+(id) labelWithString:(NSString*)string fntFile:(NSString*)fntFile width:(float)width alignment:(CCTextAlignment)alignment imageOffset:(CGPoint)offset;
		[Static]
		[Export ("labelWithString:fntFile:width:alignment:imageOffset:")]
		NSObject LabelWithString (string str,string fntFile,float width,CCTextAlignment alignment,PointF imageOffset);

		//-(id) initWithString:(NSString*)string fntFile:(NSString*)fntFile;
		[Export ("initWithString:fntFile:")]
		IntPtr Constructor (string str,string fntFile);

		//-(id) initWithString:(NSString*)string fntFile:(NSString*)fntFile width:(float)width alignment:(CCTextAlignment)alignment;
		[Export ("initWithString:fntFile:width:alignment:")]
		IntPtr Constructor (string str,string fntFile,float width,CCTextAlignment alignment);

		//-(id) initWithString:(NSString*)string fntFile:(NSString*)fntFile width:(float)width alignment:(CCTextAlignment)alignment imageOffset:(CGPoint)offset;
		[Export ("initWithString:fntFile:width:alignment:imageOffset:")]
		IntPtr Constructor (string str,string fntFile,float width,CCTextAlignment alignment,PointF imageOffset);

		//-(void) createFontChars;
		[Export ("createFontChars")]
		void CreateFontChars ();

		//- (void)setWidth:(float)width;
		[Export ("setWidth:")]
		void SetWidth (float width);

		//- (void)setAlignment:(CCTextAlignment)alignment;
		[Export ("setAlignment:")]
		void SetAlignment (CCTextAlignment alignment);

		//@optional-(void) setCString:(char*)label;
		// From protocol 'CCLabelProtocol'
		[Export ("setCString:")]
		void SetCString (char label);

		//-(void) setColor:(ccColor3B)color;
		// From protocol 'CCRGBAProtocol'
		[Export ("setColor:")]
		void SetColor (ccColor3B color);

		//-(void) setOpacity: (GLubyte) opacity;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacity:")]
		void SetOpacity (GLubyte opacity);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		// Constructor from 'CCSpriteBatchNode'
		//-(id)initWithTexture:(CCTexture2D *)tex capacity:(NSUInteger)capacity;
		[Export ("initWithTexture:capacity:")]
		IntPtr Constructor (CCTexture2D tex,uint capacity);

		// Constructor from 'CCSpriteBatchNode'
		//-(id)initWithFile:(NSString*)fileImage capacity:(NSUInteger)capacity;
		[Export ("initWithFile:capacity:")]
		IntPtr Constructor (string fileImage,uint capacity);

		//Detected properties
		// From protocol 'CCLabelProtocol'
		[Export ("string")]
		string String { get; set; }


	}

	//@interface CCLabelTTF : CCSprite <CCLabelProtocol>
	[BaseType (typeof (CCSprite))]
	interface CCLabelTTF {

		//From Generated Property
		//}@property (nonatomic,retain) NSString* fontName;
		[Export ("fontName")]
		string FontName { get; set;  }

		//@property (nonatomic,assign) float fontSize;
		[Export ("fontSize")]
		float FontSize { get; set;  }

		//@property (nonatomic,assign) CGSize dimensions;
		[Export ("dimensions")]
		SizeF Dimensions { get; set;  }

		//@property (nonatomic,assign) CCTextAlignment horizontalAlignment;
		[Export ("horizontalAlignment")]
		CCTextAlignment HorizontalAlignment { get; set;  }

		//@property (nonatomic,assign) CCVerticalTextAlignment verticalAlignment;
		[Export ("verticalAlignment")]
		CCVerticalTextAlignment VerticalAlignment { get; set;  }

		//+ (id) labelWithString:(NSString*)string fontName:(NSString*)name fontSize:(CGFloat)size;
		[Static]
		[Export ("labelWithString:fontName:fontSize:")]
		NSObject LabelWithString (string str,string fontName,float fontSize);

		//+ (id) labelWithString:(NSString*)string dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment fontName:(NSString*)name fontSize:(CGFloat)size;
		[Static]
		[Export ("labelWithString:dimensions:hAlignment:fontName:fontSize:")]
		NSObject LabelWithString (string str,SizeF dimensions,CCTextAlignment hAlignment,string fontName,float fontSize);

		//+ (id) labelWithString:(NSString*)string dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment lineBreakMode:(CCLineBreakMode)lineBreakMode fontName:(NSString*)name fontSize:(CGFloat)size;
		[Static]
		[Export ("labelWithString:dimensions:hAlignment:lineBreakMode:fontName:fontSize:")]
		NSObject LabelWithString (string str,SizeF dimensions,CCTextAlignment hAlignment,CCLineBreakMode lineBreakMode,string fontName,float fontSize);

		//+ (id) labelWithString:(NSString*)string dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment vAlignment:(CCVerticalTextAlignment)vertAlignment lineBreakMode:(CCLineBreakMode)lineBreakMode fontName:(NSString*)name fontSize:(CGFloat)size;
		[Static]
		[Export ("labelWithString:dimensions:hAlignment:vAlignment:lineBreakMode:fontName:fontSize:")]
		NSObject LabelWithString (string str,SizeF dimensions,CCTextAlignment hAlignment,CCVerticalTextAlignment vAlignment,CCLineBreakMode lineBreakMode,string fontName,float fontSize);

		//+ (id) labelWithString:(NSString*)string dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment vAlignment:(CCVerticalTextAlignment)vertAlignment fontName:(NSString*)name fontSize:(CGFloat)size;
		[Static]
		[Export ("labelWithString:dimensions:hAlignment:vAlignment:fontName:fontSize:")]
		NSObject LabelWithString (string str,SizeF dimensions,CCTextAlignment hAlignment,CCVerticalTextAlignment vAlignment,string fontName,float fontSize);

		//- (id) initWithString:(NSString*)string  fontName:(NSString*)name fontSize:(CGFloat)size;
		[Export ("initWithString:fontName:fontSize:")]
		IntPtr Constructor (string str,string fontName,float fontSize);

		//- (id) initWithString:(NSString*)string dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment fontName:(NSString*)name fontSize:(CGFloat)size;
		[Export ("initWithString:dimensions:hAlignment:fontName:fontSize:")]
		IntPtr Constructor (string str,SizeF dimensions,CCTextAlignment hAlignment,string fontName,float fontSize);

		//- (id) initWithString:(NSString*)str dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment lineBreakMode:(CCLineBreakMode)lineBreakMode fontName:(NSString*)name fontSize:(CGFloat)size;
		[Export ("initWithString:dimensions:hAlignment:lineBreakMode:fontName:fontSize:")]
		IntPtr Constructor (string str,SizeF dimensions,CCTextAlignment hAlignment,CCLineBreakMode lineBreakMode,string fontName,float fontSize);

		//- (id) initWithString:(NSString*)string dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment vAlignment:(CCVerticalTextAlignment)vertAlignment fontName:(NSString*)name fontSize:(CGFloat)size;
		[Export ("initWithString:dimensions:hAlignment:vAlignment:fontName:fontSize:")]
		IntPtr Constructor (string str,SizeF dimensions,CCTextAlignment hAlignment,CCVerticalTextAlignment vAlignment,string fontName,float fontSize);

		//- (id) initWithString:(NSString*)str dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment vAlignment:(CCVerticalTextAlignment)vAlignment lineBreakMode:(CCLineBreakMode)lineBreakMode fontName:(NSString*)name fontSize:(CGFloat)size;
		[Export ("initWithString:dimensions:hAlignment:vAlignment:lineBreakMode:fontName:fontSize:")]
		IntPtr Constructor (string str,SizeF dimensions,CCTextAlignment hAlignment,CCVerticalTextAlignment vAlignment,CCLineBreakMode lineBreakMode,string fontName,float fontSize);

		//@optional-(void) setCString:(char*)label;
		// From protocol 'CCLabelProtocol'
		[Export ("setCString:")]
		void SetCString (char label);

		// Constructor from 'CCSprite'
		//-(id) initWithTexture:(CCTexture2D*)texture;
		[Export ("initWithTexture:")]
		IntPtr Constructor (CCTexture2D texture);

		// Constructor from 'CCSprite'
		//-(id) initWithTexture:(CCTexture2D*)texture rect:(CGRect)rect;
		[Export ("initWithTexture:rect:")]
		IntPtr Constructor (CCTexture2D texture,RectangleF rect);

		// Constructor from 'CCSprite'
		//- (id)initWithTexture:(CCTexture2D *)texture rect:(CGRect)rect rotated:(BOOL)rotated;
		[Export ("initWithTexture:rect:rotated:")]
		IntPtr Constructor (CCTexture2D texture,RectangleF rect,bool rotated);

		// Constructor from 'CCSprite'
		//-(id) initWithSpriteFrame:(CCSpriteFrame*)spriteFrame;
		[Export ("initWithSpriteFrame:")]
		IntPtr Constructor (CCSpriteFrame spriteFrame);

		// Constructor from 'CCSprite'
		//-(id) initWithSpriteFrameName:(NSString*)spriteFrameName;
		[Export ("initWithSpriteFrameName:")]
		IntPtr Constructor (string spriteFrameName);

		// Constructor from 'CCSprite'
		//-(id) initWithFile:(NSString*)filename;
		[Export ("initWithFile:")]
		IntPtr Constructor (string filename, bool withFile);

		// Constructor from 'CCSprite'
		//-(id) initWithFile:(NSString*)filename rect:(CGRect)rect;
		[Export ("initWithFile:rect:")]
		IntPtr Constructor (string filename,RectangleF rect);

		// Constructor from 'CCSprite'
		//-(id) initWithCGImage:(CGImageRef)image key:(NSString*)key;
		[Export ("initWithCGImage:key:")]
		IntPtr Constructor (CGImageRef image,string key);

		//Detected properties
		// From protocol 'CCLabelProtocol'
		[Export ("string")]
		string String { get; set; }


	}

	//@interface CCLayer : CCNode <CCKeyboardEventDelegate, CCMouseEventDelegate, CCTouchEventDelegate>
	[BaseType (typeof (CCNode))]
	interface CCLayer {

		//From Generated Property
		//}@property (nonatomic, readwrite) BOOL isMouseEnabled;
		[Export ("isMouseEnabled")]
		bool IsMouseEnabled { get; set;  }

		//@property (nonatomic, readwrite) BOOL isKeyboardEnabled;
		[Export ("isKeyboardEnabled")]
		bool IsKeyboardEnabled { get; set;  }

		//@property (nonatomic, readwrite) BOOL isTouchEnabled;
		[Export ("isTouchEnabled")]
		bool IsTouchEnabled { get; set;  }

		//-(NSInteger) mouseDelegatePriority;
		[Export ("mouseDelegatePriority")]
		int MouseDelegatePriority ();

		//-(NSInteger) keyboardDelegatePriority;
		[Export ("keyboardDelegatePriority")]
		int KeyboardDelegatePriority ();

		//-(NSInteger) touchDelegatePriority;
		[Export ("touchDelegatePriority")]
		int TouchDelegatePriority ();

		//-(BOOL) ccKeyUp:(NSEvent*)event;
		[Export ("ccKeyUp:")]
		bool CcKeyUp (NSEvent evt);

		//-(BOOL) ccKeyDown:(NSEvent*)event;
		[Export ("ccKeyDown:")]
		bool CcKeyDown (NSEvent evt);

		//-(BOOL) ccFlagsChanged:(NSEvent*)event;
		[Export ("ccFlagsChanged:")]
		bool CcFlagsChanged (NSEvent evt);

		//-(BOOL) ccMouseDown:(NSEvent*)event;
		[Export ("ccMouseDown:")]
		bool CcMouseDown (NSEvent evt);

		//-(BOOL) ccMouseDragged:(NSEvent*)event;
		[Export ("ccMouseDragged:")]
		bool CcMouseDragged (NSEvent evt);

		//-(BOOL) ccMouseMoved:(NSEvent*)event;
		[Export ("ccMouseMoved:")]
		bool CcMouseMoved (NSEvent evt);

		//-(BOOL) ccMouseUp:(NSEvent*)event;
		[Export ("ccMouseUp:")]
		bool CcMouseUp (NSEvent evt);

		//-(BOOL) ccRightMouseDown:(NSEvent*)event;
		[Export ("ccRightMouseDown:")]
		bool CcRightMouseDown (NSEvent evt);

		//-(BOOL) ccRightMouseDragged:(NSEvent*)event;
		[Export ("ccRightMouseDragged:")]
		bool CcRightMouseDragged (NSEvent evt);

		//-(BOOL) ccRightMouseUp:(NSEvent*)event;
		[Export ("ccRightMouseUp:")]
		bool CcRightMouseUp (NSEvent evt);

		//-(BOOL) ccOtherMouseDown:(NSEvent*)event;
		[Export ("ccOtherMouseDown:")]
		bool CcOtherMouseDown (NSEvent evt);

		//-(BOOL) ccOtherMouseDragged:(NSEvent*)event;
		[Export ("ccOtherMouseDragged:")]
		bool CcOtherMouseDragged (NSEvent evt);

		//-(BOOL) ccOtherMouseUp:(NSEvent*)event;
		[Export ("ccOtherMouseUp:")]
		bool CcOtherMouseUp (NSEvent evt);

		//- (BOOL)ccScrollWheel:(NSEvent *)theEvent;
		[Export ("ccScrollWheel:")]
		bool CcScrollWheel (NSEvent theEvent);

		//- (void)ccMouseEntered:(NSEvent *)theEvent;
		[Export ("ccMouseEntered:")]
		void CcMouseEntered (NSEvent theEvent);

		//- (void)ccMouseExited:(NSEvent *)theEvent;
		[Export ("ccMouseExited:")]
		void CcMouseExited (NSEvent theEvent);

		//- (BOOL)ccTouchesBeganWithEvent:(NSEvent *)event;
		[Export ("ccTouchesBeganWithEvent:")]
		bool CcTouchesBeganWithEvent (NSEvent evt);

		//- (BOOL)ccTouchesMovedWithEvent:(NSEvent *)event;
		[Export ("ccTouchesMovedWithEvent:")]
		bool CcTouchesMovedWithEvent (NSEvent evt);

		//- (BOOL)ccTouchesEndedWithEvent:(NSEvent *)event;
		[Export ("ccTouchesEndedWithEvent:")]
		bool CcTouchesEndedWithEvent (NSEvent evt);

		//- (BOOL)ccTouchesCancelledWithEvent:(NSEvent *)event;
		[Export ("ccTouchesCancelledWithEvent:")]
		bool CcTouchesCancelledWithEvent (NSEvent evt);


	}

	//@interface CCLayerColor : CCLayer <CCRGBAProtocol, CCBlendProtocol>
	[BaseType (typeof (CCLayer))]
	interface CCLayerColor {

		//From Generated Property
		//@property (nonatomic,readonly) GLubyte opacity;
		[Export ("opacity")]
		GLubyte Opacity { get;  }

		//@property (nonatomic,readonly) ccColor3B color;
		[Export ("color")]
		ccColor3B Color { get;  }

		//@property (nonatomic,readwrite) ccBlendFunc blendFunc;
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set;  }

		//+ (id) layerWithColor: (ccColor4B)color width:(GLfloat)w height:(GLfloat)h;
		[Static]
		[Export ("layerWithColor:width:height:")]
		NSObject LayerWithColor (ccColor4B color,float width,float height);

		//+ (id) layerWithColor: (ccColor4B)color;
		[Static]
		[Export ("layerWithColor:")]
		NSObject LayerWithColor (ccColor4B color);

		//- (id) initWithColor:(ccColor4B)color width:(GLfloat)w height:(GLfloat)h;
		[Export ("initWithColor:width:height:")]
		IntPtr Constructor (ccColor4B color,float width,float height);

		//- (id) initWithColor:(ccColor4B)color;
		[Export ("initWithColor:")]
		IntPtr Constructor (ccColor4B color);

		//-(void) changeWidth: (GLfloat)w;
		[Export ("changeWidth:")]
		void ChangeWidth (float w);

		//-(void) changeHeight: (GLfloat)h;
		[Export ("changeHeight:")]
		void ChangeHeight (float h);

		//-(void) changeWidth:(GLfloat)w height:(GLfloat)h;
		[Export ("changeWidth:height:")]
		void ChangeWidth (float w,float height);

		//-(void) setColor:(ccColor3B)color;
		// From protocol 'CCRGBAProtocol'
		[Export ("setColor:")]
		void SetColor (ccColor3B color);

		//-(void) setOpacity: (GLubyte) opacity;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacity:")]
		void SetOpacity (GLubyte opacity);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		//-(void) setBlendFunc:(ccBlendFunc)blendFunc;
		// From protocol 'CCBlendProtocol'
		[Export ("setBlendFunc:")]
		void SetBlendFunc (ccBlendFunc blendFunc);


	}

	//@interface CCLayerGradient : CCLayerColor
	[BaseType (typeof (CCLayerColor))]
	interface CCLayerGradient {

		//From Generated Property
		//@property (nonatomic, readwrite) ccColor3B startColor;
		[Export ("startColor")]
		ccColor3B StartColor { get; set;  }

		//@property (nonatomic, readwrite) ccColor3B endColor;
		[Export ("endColor")]
		ccColor3B EndColor { get; set;  }

		//@property (nonatomic, readwrite) GLubyte startOpacity;
		[Export ("startOpacity")]
		GLubyte StartOpacity { get; set;  }

		//@property (nonatomic, readwrite) GLubyte endOpacity;
		[Export ("endOpacity")]
		GLubyte EndOpacity { get; set;  }

		//@property (nonatomic, readwrite) CGPoint vector;
		[Export ("vector")]
		PointF Vector { get; set;  }

		//@property (nonatomic, readwrite) BOOL compressedInterpolation;
		[Export ("compressedInterpolation")]
		bool CompressedInterpolation { get; set;  }

		//+ (id) layerWithColor: (ccColor4B) start fadingTo: (ccColor4B) end;
		[Static]
		[Export ("layerWithColor:fadingTo:")]
		NSObject LayerWithColor (ccColor4B start,ccColor4B fadingTo);

		//+ (id) layerWithColor: (ccColor4B) start fadingTo: (ccColor4B) end alongVector: (CGPoint) v;
		[Static]
		[Export ("layerWithColor:fadingTo:alongVector:")]
		NSObject LayerWithColor (ccColor4B start,ccColor4B fadingTo,PointF alongVector);

		//- (id) initWithColor: (ccColor4B) start fadingTo: (ccColor4B) end;
		[Export ("initWithColor:fadingTo:")]
		IntPtr Constructor (ccColor4B start,ccColor4B fadingTo);

		//- (id) initWithColor: (ccColor4B) start fadingTo: (ccColor4B) end alongVector: (CGPoint) v;
		[Export ("initWithColor:fadingTo:alongVector:")]
		IntPtr Constructor (ccColor4B start,ccColor4B fadingTo,PointF alongVector);


	}

	//@interface CCLayerMultiplex : CCLayer
	[BaseType (typeof (CCLayer))]
	interface CCLayerMultiplex {

		//From Generated Property
		//+(id) layerWithLayers: (CCLayer*) layer, ... NS_REQUIRES_NIL_TERMINATION;
		[Static]
		[Internal]
		[Export ("layerWithLayers:")]
		NSObject LayerWithLayers (CCLayer layer,IntPtr NS_REQUIRES_NIL_TERMINATION);

		//-(void) switchTo: (unsigned int) n;
		[Export ("switchTo:")]
		void SwitchTo (uint intArg);

		//-(void) switchToAndReleaseMe: (unsigned int) n;
		[Export ("switchToAndReleaseMe:")]
		void SwitchToAndReleaseMe (uint intArg);


	}

	//@interface CCMenu : CCLayer <CCRGBAProtocol>
	[BaseType (typeof (CCLayer))]
	interface CCMenu {

		//From Generated Property
		//}@property (nonatomic,readonly) GLubyte opacity;
		[Export ("opacity")]
		GLubyte Opacity { get;  }

		//@property (nonatomic,readonly) ccColor3B color;
		[Export ("color")]
		ccColor3B Color { get;  }

		//@property (nonatomic, readwrite) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set;  }

		//+ (id) menuWithItems: (CCMenuItem*) item, ... NS_REQUIRES_NIL_TERMINATION;
		[Static]
		[Internal]
		[Export ("menuWithItems:")]
		NSObject MenuWithItems (CCMenuItem item,IntPtr NS_REQUIRES_NIL_TERMINATION);

		//+ (id) menuWithArray:(NSArray*)arrayOfItems;
		[Static]
		[Export ("menuWithArray:")]
		NSObject MenuWithArray (NSArray arrayOfItems);

		//- (id) initWithArray:(NSArray*)arrayOfItems;
		[Export ("initWithArray:")]
		IntPtr Constructor (NSArray arrayOfItems);

		//-(void) alignItemsVertically;
		[Export ("alignItemsVertically")]
		void AlignItemsVertically ();

		//-(void) alignItemsVerticallyWithPadding:(float) padding;
		[Export ("alignItemsVerticallyWithPadding:")]
		void AlignItemsVerticallyWithPadding (float padding);

		//-(void) alignItemsHorizontally;
		[Export ("alignItemsHorizontally")]
		void AlignItemsHorizontally ();

		//-(void) alignItemsHorizontallyWithPadding: (float) padding;
		[Export ("alignItemsHorizontallyWithPadding:")]
		void AlignItemsHorizontallyWithPadding (float padding);

		//-(void) alignItemsInColumns: (NSNumber *) columns, ... NS_REQUIRES_NIL_TERMINATION;
		[Internal]
		[Export ("alignItemsInColumns:")]
		void AlignItemsInColumns (NSNumber columns,IntPtr NS_REQUIRES_NIL_TERMINATION);

		//-(void) alignItemsInRows: (NSNumber *) rows, ... NS_REQUIRES_NIL_TERMINATION;
		[Internal]
		[Export ("alignItemsInRows:")]
		void AlignItemsInRows (NSNumber rows,IntPtr NS_REQUIRES_NIL_TERMINATION);

		//-(void) setHandlerPriority:(NSInteger)newPriority;
		[Export ("setHandlerPriority:")]
		void SetHandlerPriority (int newPriority);

		//-(void) setColor:(ccColor3B)color;
		// From protocol 'CCRGBAProtocol'
		[Export ("setColor:")]
		void SetColor (ccColor3B color);

		//-(void) setOpacity: (GLubyte) opacity;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacity:")]
		void SetOpacity (GLubyte opacity);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();


	}
		delegate void CCSenderCallback (NSObject sender);

	//@interface CCMenuItem : CCNode
	[BaseType (typeof (CCNode))]
	interface CCMenuItem {

		//From Generated Property
		//}@property (nonatomic,readonly) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get;  }

		//+(id) itemWithTarget:(id)target selector:(SEL)selector;
		[Static]
		[Export ("itemWithTarget:selector:")]
		NSObject ItemWithTarget (NSObject target,Selector selector);

		//+(id) itemWithBlock:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithBlock:")]
		NSObject ItemWithBlock (CCSenderCallback _delegate);

		//-(id) initWithTarget:(id)target selector:(SEL)selector;
		[Export ("initWithTarget:selector:")]
		IntPtr Constructor (NSObject target,Selector selector);

		//-(id) initWithBlock:(void(^)(id sender))block;
		[Export ("initWithBlock:")]
		IntPtr Constructor (CCSenderCallback _delegate);

		//-(CGRect) rect;
		[Export ("rect")]
		RectangleF Rect ();

		//-(void) activate;
		[Export ("activate")]
		void Activate ();

		//-(void) selected;
		[Export ("selected")]
		void Selected ();

		//-(void) unselected;
		[Export ("unselected")]
		void Unselected ();

		//-(void) setBlock:(void(^)(id sender))block;
		[Export ("setBlock:")]
		void SetBlock (CCSenderCallback _delegate);

		//-(void) setTarget:(id)target selector:(SEL)selector;
		[Export ("setTarget:selector:")]
		void SetTarget (NSObject target,Selector selector);

		//-(void) cleanup;
		[Export ("cleanup")]
		void Cleanup ();

		//Detected properties
		[Export ("isEnabled")]
		bool Enabled { [Bind ("isEnabled")]get; set; }


	}

	//@interface CCMenuItemLabel : CCMenuItem <CCRGBAProtocol>
	[BaseType (typeof (CCMenuItem))]
	interface CCMenuItemLabel {

		//From Generated Property
		//}@property (nonatomic,readwrite) ccColor3B disabledColor;
		[Export ("disabledColor")]
		ccColor3B DisabledColor { get; set;  }

		//@property (nonatomic,readwrite,assign) CCNode* label;
		[Export ("label")]
		CCNode Label { get; set;  }

		//+(id) itemWithLabel:(CCNode<CCLabelProtocol,CCRGBAProtocol>*)label;
		[Static]
		[Export ("itemWithLabel:")]
		NSObject ItemWithLabel (CCNode label);

		//+(id) itemWithLabel:(CCNode<CCLabelProtocol,CCRGBAProtocol>*)label target:(id)target selector:(SEL)selector;
		[Static]
		[Export ("itemWithLabel:target:selector:")]
		NSObject ItemWithLabel (CCNode label,NSObject target,Selector selector);

		//+(id) itemWithLabel:(CCNode<CCLabelProtocol,CCRGBAProtocol>*)label block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithLabel:block:")]
		NSObject ItemWithLabel (CCNode label,CCSenderCallback _delegate);

		//-(id) initWithLabel:(CCNode<CCLabelProtocol,CCRGBAProtocol>*)label target:(id)target selector:(SEL)selector;
		[Export ("initWithLabel:target:selector:")]
		IntPtr Constructor (CCNode label,NSObject target,Selector selector);

		//-(id) initWithLabel:(CCNode<CCLabelProtocol,CCRGBAProtocol>*)label block:(void(^)(id sender))block;
		[Export ("initWithLabel:block:")]
		IntPtr Constructor (CCNode label,CCSenderCallback _delegate);

		//-(void) setString:(NSString*)label;
		[Export ("setString:")]
		void SetString (string label);

		//-(void) setIsEnabled: (BOOL)enabled;
		[Export ("setIsEnabled:")]
		void SetIsEnabled (bool enabled);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		// Constructor from 'CCMenuItem'
		//-(id) initWithTarget:(id)target selector:(SEL)selector;
		[Export ("initWithTarget:selector:")]
		IntPtr Constructor (NSObject target,Selector selector);

		// Constructor from 'CCMenuItem'
		//-(id) initWithBlock:(void(^)(id sender))block;
		[Export ("initWithBlock:")]
		IntPtr Constructor (CCSenderCallback _delegate);

		//Detected properties
		// From protocol 'CCRGBAProtocol'
		[Export ("color")]
		ccColor3B Color { get; set; }

		// From protocol 'CCRGBAProtocol'
		[Export ("opacity")]
		GLubyte Opacity { get; set; }


	}

	//@interface CCMenuItemAtlasFont : CCMenuItemLabel
	[BaseType (typeof (CCMenuItemLabel))]
	interface CCMenuItemAtlasFont {

		//From Generated Property
		//+(id) itemWithString: (NSString*) value charMapFile:(NSString*) charMapFile itemWidth:(int)itemWidth itemHeight:(int)itemHeight startCharMap:(char)startCharMap;
		[Static]
		[Export ("itemWithString:charMapFile:itemWidth:itemHeight:startCharMap:")]
		NSObject ItemWithString (string value,string charMapFile,int itemWidth,int itemHeight,char startCharMap);

		//+(id) itemWithString: (NSString*) value charMapFile:(NSString*) charMapFile itemWidth:(int)itemWidth itemHeight:(int)itemHeight startCharMap:(char)startCharMap target:(id)target selector:(SEL)selector;
		[Static]
		[Export ("itemWithString:charMapFile:itemWidth:itemHeight:startCharMap:target:selector:")]
		NSObject ItemWithString (string value,string charMapFile,int itemWidth,int itemHeight,char startCharMap,NSObject target,Selector selector);

		//-(id) initWithString: (NSString*) value charMapFile:(NSString*) charMapFile itemWidth:(int)itemWidth itemHeight:(int)itemHeight startCharMap:(char)startCharMap target:(id)target selector:(SEL)selector;
		[Export ("initWithString:charMapFile:itemWidth:itemHeight:startCharMap:target:selector:")]
		IntPtr Constructor (string value,string charMapFile,int itemWidth,int itemHeight,char startCharMap,NSObject target,Selector selector);

		//+(id) itemWithString: (NSString*) value charMapFile:(NSString*) charMapFile itemWidth:(int)itemWidth itemHeight:(int)itemHeight startCharMap:(char)startCharMap block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithString:charMapFile:itemWidth:itemHeight:startCharMap:block:")]
		NSObject ItemWithString (string value,string charMapFile,int itemWidth,int itemHeight,char startCharMap,CCSenderCallback _delegate);

		//-(id) initWithString: (NSString*) value charMapFile:(NSString*) charMapFile itemWidth:(int)itemWidth itemHeight:(int)itemHeight startCharMap:(char)startCharMap block:(void(^)(id sender))block;
		[Export ("initWithString:charMapFile:itemWidth:itemHeight:startCharMap:block:")]
		IntPtr Constructor (string value,string charMapFile,int itemWidth,int itemHeight,char startCharMap,CCSenderCallback _delegate);


	}

	//@interface CCMenuItemFont : CCMenuItemLabel
	[BaseType (typeof (CCMenuItemLabel))]
	interface CCMenuItemFont {

		//From Generated Property
		//+(id) itemWithString: (NSString*) value;
		[Static]
		[Export ("itemWithString:")]
		NSObject ItemWithString (string value);

		//+(id) itemWithString: (NSString*) value target:(id) r selector:(SEL) s;
		[Static]
		[Export ("itemWithString:target:selector:")]
		NSObject ItemWithString (string value,NSObject target,Selector selector);

		//+(id) itemWithString: (NSString*) value block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithString:block:")]
		NSObject ItemWithString (string value,CCSenderCallback _delegate);

		//-(id) initWithString: (NSString*) value target:(id) r selector:(SEL) s;
		[Export ("initWithString:target:selector:")]
		IntPtr Constructor (string value,NSObject target,Selector selector);

		//-(id) initWithString: (NSString*) value block:(void(^)(id sender))block;
		[Export ("initWithString:block:")]
		IntPtr Constructor (string value,CCSenderCallback _delegate);

		//Detected properties
		[Static]
		[Export ("fontSize")]
		uint DefaultFontSize { get; set; }

		[Static]
		[Export ("fontName")]
		string DefaultFontName { get; set; }

		[Export ("fontSize")]
		uint FontSize { get; set; }

		[Export ("fontName")]
		string FontName { get; set; }


	}

	//@interface CCMenuItemSprite : CCMenuItem <CCRGBAProtocol>
	[BaseType (typeof (CCMenuItem))]
	interface CCMenuItemSprite {

		//From Generated Property
		//}@property (nonatomic,readwrite,assign) CCNode *normalImage;
		[Export ("normalImage")]
		CCNode NormalImage { get; set;  }

		//@property (nonatomic,readwrite,assign) CCNode *selectedImage;
		[Export ("selectedImage")]
		CCNode SelectedImage { get; set;  }

		//@property (nonatomic,readwrite,assign) CCNode *disabledImage;
		[Export ("disabledImage")]
		CCNode DisabledImage { get; set;  }

		//+(id) itemWithNormalSprite:(CCNode<CCRGBAProtocol>*)normalSprite selectedSprite:(CCNode<CCRGBAProtocol>*)selectedSprite;
		[Static]
		[Export ("itemWithNormalSprite:selectedSprite:")]
		NSObject ItemWithNormalSprite (CCNode normalSprite,CCNode selectedSprite);

		//+(id) itemWithNormalSprite:(CCNode<CCRGBAProtocol>*)normalSprite selectedSprite:(CCNode<CCRGBAProtocol>*)selectedSprite target:(id)target selector:(SEL)selector;
		[Static]
		[Export ("itemWithNormalSprite:selectedSprite:target:selector:")]
		NSObject ItemWithNormalSprite (CCNode normalSprite,CCNode selectedSprite,NSObject target,Selector selector);

		//+(id) itemWithNormalSprite:(CCNode<CCRGBAProtocol>*)normalSprite selectedSprite:(CCNode<CCRGBAProtocol>*)selectedSprite disabledSprite:(CCNode<CCRGBAProtocol>*)disabledSprite target:(id)target selector:(SEL)selector;
		[Static]
		[Export ("itemWithNormalSprite:selectedSprite:disabledSprite:target:selector:")]
		NSObject ItemWithNormalSprite (CCNode normalSprite,CCNode selectedSprite,CCNode disabledSprite,NSObject target,Selector selector);

		//+(id) itemWithNormalSprite:(CCNode<CCRGBAProtocol>*)normalSprite selectedSprite:(CCNode<CCRGBAProtocol>*)selectedSprite block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithNormalSprite:selectedSprite:block:")]
		NSObject ItemWithNormalSprite (CCNode normalSprite,CCNode selectedSprite,CCSenderCallback _delegate);

		//+(id) itemWithNormalSprite:(CCNode<CCRGBAProtocol>*)normalSprite selectedSprite:(CCNode<CCRGBAProtocol>*)selectedSprite disabledSprite:(CCNode<CCRGBAProtocol>*)disabledSprite block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithNormalSprite:selectedSprite:disabledSprite:block:")]
		NSObject ItemWithNormalSprite (CCNode normalSprite,CCNode selectedSprite,CCNode disabledSprite,CCSenderCallback _delegate);

		//-(id) initWithNormalSprite:(CCNode<CCRGBAProtocol>*)normalSprite selectedSprite:(CCNode<CCRGBAProtocol>*)selectedSprite disabledSprite:(CCNode<CCRGBAProtocol>*)disabledSprite target:(id)target selector:(SEL)selector;
		[Export ("initWithNormalSprite:selectedSprite:disabledSprite:target:selector:")]
		IntPtr Constructor (CCNode normalSprite,CCNode selectedSprite,CCNode disabledSprite,NSObject target,Selector selector);

		//-(id) initWithNormalSprite:(CCNode<CCRGBAProtocol>*)normalSprite selectedSprite:(CCNode<CCRGBAProtocol>*)selectedSprite disabledSprite:(CCNode<CCRGBAProtocol>*)disabledSprite block:(void(^)(id sender))block;
		[Export ("initWithNormalSprite:selectedSprite:disabledSprite:block:")]
		IntPtr Constructor (CCNode normalSprite,CCNode selectedSprite,CCNode disabledSprite,CCSenderCallback _delegate);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		// Constructor from 'CCMenuItem'
		//-(id) initWithTarget:(id)target selector:(SEL)selector;
		[Export ("initWithTarget:selector:")]
		IntPtr Constructor (NSObject target,Selector selector);

		// Constructor from 'CCMenuItem'
		//-(id) initWithBlock:(void(^)(id sender))block;
		[Export ("initWithBlock:")]
		IntPtr Constructor (CCSenderCallback _delegate);

		//Detected properties
		// From protocol 'CCRGBAProtocol'
		[Export ("color")]
		ccColor3B Color { get; set; }

		// From protocol 'CCRGBAProtocol'
		[Export ("opacity")]
		GLubyte Opacity { get; set; }


	}

	//@interface CCMenuItemImage : CCMenuItemSprite
	[BaseType (typeof (CCMenuItemSprite))]
	interface CCMenuItemImage {

		//From Generated Property
		//+(id) itemWithNormalImage: (NSString*)value selectedImage:(NSString*) value2;
		[Static]
		[Export ("itemWithNormalImage:selectedImage:")]
		NSObject ItemWithNormalImage (string value,string selectedImage);

		//+(id) itemWithNormalImage: (NSString*)value selectedImage:(NSString*) value2 target:(id) r selector:(SEL) s;
		[Static]
		[Export ("itemWithNormalImage:selectedImage:target:selector:")]
		NSObject ItemWithNormalImage (string value,string selectedImage,NSObject target,Selector selector);

		//+(id) itemWithNormalImage: (NSString*)value selectedImage:(NSString*) value2 disabledImage:(NSString*) value3 target:(id) r selector:(SEL) s;
		[Static]
		[Export ("itemWithNormalImage:selectedImage:disabledImage:target:selector:")]
		NSObject ItemWithNormalImage (string value,string selectedImage,string disabledImage,NSObject target,Selector selector);

		//+(id) itemWithNormalImage: (NSString*)value selectedImage:(NSString*) value2 block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithNormalImage:selectedImage:block:")]
		NSObject ItemWithNormalImage (string value,string selectedImage,CCSenderCallback _delegate);

		//+(id) itemWithNormalImage: (NSString*)value selectedImage:(NSString*) value2 disabledImage:(NSString*) value3 block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithNormalImage:selectedImage:disabledImage:block:")]
		NSObject ItemWithNormalImage (string value,string selectedImage,string disabledImage,CCSenderCallback _delegate);

		//-(id) initWithNormalImage: (NSString*) value selectedImage:(NSString*)value2 disabledImage:(NSString*) value3 target:(id) r selector:(SEL) s;
		[Export ("initWithNormalImage:selectedImage:disabledImage:target:selector:")]
		IntPtr Constructor (string value,string selectedImage,[NullAllowed] string disabledImage,NSObject target,Selector selector);

		//-(id) initWithNormalImage: (NSString*) value selectedImage:(NSString*)value2 disabledImage:(NSString*) value3 block:(void(^)(id sender))block;
		[Export ("initWithNormalImage:selectedImage:disabledImage:block:")]
		IntPtr Constructor (string value,string selectedImage,[NullAllowed] string disabledImage,CCSenderCallback _delegate);

		//- (void) setNormalSpriteFrame:(CCSpriteFrame*)frame;
		[Export ("setNormalSpriteFrame:")]
		void SetNormalSpriteFrame (CCSpriteFrame frame);

		//- (void) setSelectedSpriteFrame:(CCSpriteFrame*)frame;
		[Export ("setSelectedSpriteFrame:")]
		void SetSelectedSpriteFrame (CCSpriteFrame frame);

		//- (void) setDisabledSpriteFrame:(CCSpriteFrame*)frame;
		[Export ("setDisabledSpriteFrame:")]
		void SetDisabledSpriteFrame (CCSpriteFrame frame);


	}
		delegate void CCMenuItemToggleDelegateInitWithItemsblock (NSObject obj);

	//@interface CCMenuItemToggle : CCMenuItem <CCRGBAProtocol>
	[BaseType (typeof (CCMenuItem))]
	interface CCMenuItemToggle {

		//From Generated Property
		//}@property (nonatomic,readonly) GLubyte opacity;
		[Export ("opacity")]
		GLubyte Opacity { get;  }

		//@property (nonatomic,readonly) ccColor3B color;
		[Export ("color")]
		ccColor3B Color { get;  }

		//@property (nonatomic,readwrite) NSUInteger selectedIndex;
		[Export ("selectedIndex")]
		uint SelectedIndex { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *subItems;
		[Export ("subItems")]
		NSMutableArray SubItems { get; set;  }

		//+(id) itemWithTarget:(id)target selector:(SEL)selector items:(CCMenuItem*) item, ... NS_REQUIRES_NIL_TERMINATION;
		[Static]
		[Internal]
		[Export ("itemWithTarget:selector:items:")]
		NSObject ItemWithTarget (NSObject target,Selector selector,CCMenuItem items,IntPtr NS_REQUIRES_NIL_TERMINATION);

		//+(id) itemWithItems:(NSArray*)arrayOfItems block:(void(^)(id sender))block;
		[Static]
		[Export ("itemWithItems:block:")]
		NSObject ItemWithItems (NSArray arrayOfItems,CCSenderCallback _delegate);

		//-(id) initWithItems:(NSArray*)arrayOfItems block:(void (^)(id))block;
		[Export ("initWithItems:block:")]
		IntPtr Constructor (NSArray arrayOfItems,CCMenuItemToggleDelegateInitWithItemsblock _delegate);

		//-(CCMenuItem*) selectedItem;
		[Export ("selectedItem")]
		CCMenuItem SelectedItem ();

		//-(void) setColor:(ccColor3B)color;
		// From protocol 'CCRGBAProtocol'
		[Export ("setColor:")]
		void SetColor (ccColor3B color);

		//-(void) setOpacity: (GLubyte) opacity;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacity:")]
		void SetOpacity (GLubyte opacity);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		// Constructor from 'CCMenuItem'
		//-(id) initWithTarget:(id)target selector:(SEL)selector;
		[Export ("initWithTarget:selector:")]
		IntPtr Constructor (NSObject target,Selector selector);

		// Constructor from 'CCMenuItem'
		//-(id) initWithBlock:(void(^)(id sender))block;
		[Export ("initWithBlock:")]
		IntPtr Constructor (CCSenderCallback _delegate);


	}

	//@interface CCMotionStreak : CCNode <CCTextureProtocol, CCRGBAProtocol>
	[BaseType (typeof (CCNode))]
	interface CCMotionStreak {

		//From Generated Property
		//}@property (nonatomic, readwrite, assign) ccBlendFunc blendFunc;
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set;  }

		//@property (nonatomic, readwrite, assign, getter = isFastMode) BOOL fastMode;
		[Export ("fastMode")]
		bool FastMode { get; set;  }

		//@property (nonatomic, retain) CCTexture2D *texture;
		[Export ("texture")]
		CCTexture2D Texture { get; set;  }

		//+ (id) streakWithFade:(float)fade minSeg:(float)minSeg width:(float)stroke color:(ccColor3B)color textureFilename:(NSString*)path;
		[Static]
		[Export ("streakWithFade:minSeg:width:color:textureFilename:")]
		NSObject StreakWithFade (float fade,float minSeg,float width,ccColor3B color,string textureFilename);

		//+ (id) streakWithFade:(float)fade minSeg:(float)minSeg width:(float)stroke color:(ccColor3B)color texture:(CCTexture2D*)texture;
		[Static]
		[Export ("streakWithFade:minSeg:width:color:texture:")]
		NSObject StreakWithFade (float fade,float minSeg,float width,ccColor3B color,CCTexture2D texture);

		//- (id) initWithFade:(float)fade minSeg:(float)minSeg width:(float)stroke color:(ccColor3B)color textureFilename:(NSString*)path;
		[Export ("initWithFade:minSeg:width:color:textureFilename:")]
		IntPtr Constructor (float fade,float minSeg,float width,ccColor3B color,string textureFilename);

		//- (id) initWithFade:(float)fade minSeg:(float)minSeg width:(float)stroke color:(ccColor3B)color texture:(CCTexture2D*)texture;
		[Export ("initWithFade:minSeg:width:color:texture:")]
		IntPtr Constructor (float fade,float minSeg,float width,ccColor3B color,CCTexture2D texture);

		//- (void) tintWithColor:(ccColor3B)colors;
		[Export ("tintWithColor:")]
		void TintWithColor (ccColor3B colors);

		//- (void) reset;
		[Export ("reset")]
		void Reset ();

		//-(void) setTexture:(CCTexture2D*)texture;
		// From protocol 'CCTextureProtocol'
		[Export ("setTexture:")]
		void SetTexture (CCTexture2D texture);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		//Detected properties
		// From protocol 'CCRGBAProtocol'
		[Export ("color")]
		ccColor3B Color { get; set; }

		// From protocol 'CCRGBAProtocol'
		[Export ("opacity")]
		GLubyte Opacity { get; set; }


	}

	//@interface CCNode (Debug)
	[BaseType (typeof (NSObject))]
	interface CCNode {

		//From Generated Property
		//}@property(nonatomic,assign) NSInteger zOrder;
		[Export ("zOrder")]
		int ZOrder { get; set;  }

		//@property (nonatomic,readwrite) float vertexZ;
		[Export ("vertexZ")]
		float VertexZ { get; set;  }

		//@property(nonatomic,readwrite,assign) float skewX;
		[Export ("skewX")]
		float SkewX { get; set;  }

		//@property(nonatomic,readwrite,assign) float skewY;
		[Export ("skewY")]
		float SkewY { get; set;  }

		//@property(nonatomic,readwrite,assign) float rotation;
		[Export ("rotation")]
		float Rotation { get; set;  }

		//@property(nonatomic,readwrite,assign) float scale;
		[Export ("scale")]
		float Scale { get; set;  }

		//@property(nonatomic,readwrite,assign) float scaleX;
		[Export ("scaleX")]
		float ScaleX { get; set;  }

		//@property(nonatomic,readwrite,assign) float scaleY;
		[Export ("scaleY")]
		float ScaleY { get; set;  }

		//@property(nonatomic,readwrite,assign) CGPoint position;
		[Export ("position")]
		PointF Position { get; set;  }

		//@property(nonatomic,readonly) CCCamera* camera;
		[Export ("camera")]
		CCCamera Camera { get;  }

		//@property(nonatomic,readonly) CCArray *children;
		[Export ("children")]
		CCArray Children { get;  }

		//@property(nonatomic,readwrite,retain) CCGridBase* grid;
		[Export ("grid")]
		CCGridBase Grid { get; set;  }

		//@property(nonatomic,readwrite,assign) BOOL visible;
		[Export ("visible")]
		bool Visible { get; set;  }

		//@property(nonatomic,readwrite) CGPoint anchorPoint;
		[Export ("anchorPoint")]
		PointF AnchorPoint { get; set;  }

		//@property(nonatomic,readonly) CGPoint anchorPointInPoints;
		[Export ("anchorPointInPoints")]
		PointF AnchorPointInPoints { get;  }

		//@property (nonatomic,readwrite) CGSize contentSize;
		[Export ("contentSize")]
		SizeF ContentSize { get; set;  }

		//@property(nonatomic,readonly) BOOL isRunning;
		[Export ("isRunning")]
		bool IsRunning { get;  }

		//@property(nonatomic,readwrite,assign) CCNode* parent;
		[Export ("parent")]
		CCNode Parent { get; set;  }

		//@property(nonatomic,readwrite,assign) BOOL ignoreAnchorPointForPosition;
		[Export ("ignoreAnchorPointForPosition")]
		bool IgnoreAnchorPointForPosition { get; set;  }

		//@property(nonatomic,readwrite,assign) NSInteger tag;
		[Export ("tag")]
		int Tag { get; set;  }

		//@property(nonatomic,readwrite,assign) void* userData;
		[Export ("userData")]
		IntPtr UserData { get; set;  }

		//@property(nonatomic,readwrite,retain) id userObject;
		[Export ("userObject")]
		NSObject UserObject { get; set;  }

		//@property(nonatomic,readwrite,retain) CCGLProgram *shaderProgram;
		[Export ("shaderProgram")]
		CCGLProgram ShaderProgram { get; set;  }

		//@property(nonatomic,readwrite) NSUInteger orderOfArrival;
		[Export ("orderOfArrival")]
		uint OrderOfArrival { get; set;  }

		//@property (nonatomic, readwrite) ccGLServerState glServerState;
		[Export ("glServerState")]
		ccGLServerState GlServerState { get; set;  }

		//@property (nonatomic, readwrite, retain) CCActionManager *actionManager;
		[Export ("actionManager")]
		CCActionManager ActionManager { get; set;  }

		//@property (nonatomic, readwrite, retain) CCScheduler *scheduler;
		[Export ("scheduler")]
		CCScheduler Scheduler { get; set;  }

		//-(void) walkSceneGraph:(NSUInteger)level;
		[Export ("walkSceneGraph:")]
		void WalkSceneGraph (uint level);

		//+(id) node;
		[Static]
		[Export ("node")]
		NSObject Node ();

		//-(void) onEnter;
		[Export ("onEnter")]
		void OnEnter ();

		//-(void) onEnterTransitionDidFinish;
		[Export ("onEnterTransitionDidFinish")]
		void OnEnterTransitionDidFinish ();

		//-(void) onExit;
		[Export ("onExit")]
		void OnExit ();

		//-(void) onExitTransitionDidStart;
		[Export ("onExitTransitionDidStart")]
		void OnExitTransitionDidStart ();

		//-(void) addChild: (CCNode*)node;
		[Export ("addChild:")]
		void AddChild (CCNode node);

		//-(void) addChild: (CCNode*)node z:(NSInteger)z;
		[Export ("addChild:z:")]
		void AddChild (CCNode node,int z);

		//-(void) addChild: (CCNode*)node z:(NSInteger)z tag:(NSInteger)tag;
		[Export ("addChild:z:tag:")]
		void AddChild (CCNode node,int z,int tag);

		//-(void) removeFromParentAndCleanup:(BOOL)cleanup;
		[Export ("removeFromParentAndCleanup:")]
		void RemoveFromParentAndCleanup (bool cleanup);

		//-(void) removeChild: (CCNode*)node cleanup:(BOOL)cleanup;
		[Export ("removeChild:cleanup:")]
		void RemoveChild (CCNode node,bool cleanup);

		//-(void) removeChildByTag:(NSInteger) tag cleanup:(BOOL)cleanup;
		[Export ("removeChildByTag:cleanup:")]
		void RemoveChildByTag (int tag,bool cleanup);

		//-(void) removeAllChildrenWithCleanup:(BOOL)cleanup;
		[Export ("removeAllChildrenWithCleanup:")]
		void RemoveAllChildrenWithCleanup (bool cleanup);

		//-(CCNode*) getChildByTag:(NSInteger) tag;
		[Export ("getChildByTag:")]
		CCNode GetChildByTag (int tag);

		//-(void) reorderChild:(CCNode*)child z:(NSInteger)zOrder;
		[Export ("reorderChild:z:")]
		void ReorderChild (CCNode child,int z);

		//- (void) sortAllChildren;
		[Export ("sortAllChildren")]
		void SortAllChildren ();

		//-(void) cleanup;
		[Export ("cleanup")]
		void Cleanup ();

		//-(void) draw;
		[Export ("draw")]
		void Draw ();

		//-(void) visit;
		[Export ("visit")]
		void Visit ();

		//-(void) transform;
		[Export ("transform")]
		void Transform ();

		//-(void) transformAncestors;
		[Export ("transformAncestors")]
		void TransformAncestors ();

		//- (CGRect) boundingBox;
		[Export ("boundingBox")]
		RectangleF BoundingBox ();

		//-(CCAction*) runAction: (CCAction*) action;
		[Export ("runAction:")]
		CCAction RunAction (CCAction action);

		//-(void) stopAllActions;
		[Export ("stopAllActions")]
		void StopAllActions ();

		//-(void) stopAction: (CCAction*) action;
		[Export ("stopAction:")]
		void StopAction (CCAction action);

		//-(void) stopActionByTag:(NSInteger) tag;
		[Export ("stopActionByTag:")]
		void StopActionByTag (int tag);

		//-(CCAction*) getActionByTag:(NSInteger) tag;
		[Export ("getActionByTag:")]
		CCAction GetActionByTag (int tag);

		//-(NSUInteger) numberOfRunningActions;
		[Export ("numberOfRunningActions")]
		uint NumberOfRunningActions ();

		//-(void) scheduleUpdate;
		[Export ("scheduleUpdate")]
		void ScheduleUpdate ();

		//-(void) scheduleUpdateWithPriority:(NSInteger)priority;
		[Export ("scheduleUpdateWithPriority:")]
		void ScheduleUpdateWithPriority (int priority);

		//-(void) unscheduleUpdate;
		[Export ("unscheduleUpdate")]
		void UnscheduleUpdate ();

		//-(void) schedule: (SEL) s;
		[Export ("schedule:")]
		void Schedule (Selector s);

		//-(void) schedule: (SEL) s interval:(ccTime)seconds;
		[Export ("schedule:interval:")]
		void Schedule (Selector s,ccTime interval);

		//-(void) schedule:(SEL)selector interval:(ccTime)interval repeat: (uint) repeat delay:(ccTime) delay;
		[Export ("schedule:interval:repeat:delay:")]
		void Schedule (Selector selector,ccTime interval,uint repeat,ccTime delay);

		//- (void) scheduleOnce:(SEL) selector delay:(ccTime) delay;
		[Export ("scheduleOnce:delay:")]
		void ScheduleOnce (Selector selector,ccTime delay);

		//-(void) unschedule: (SEL) s;
		[Export ("unschedule:")]
		void Unschedule (Selector s);

		//-(void) unscheduleAllSelectors;
		[Export ("unscheduleAllSelectors")]
		void UnscheduleAllSelectors ();

		//-(void) resumeSchedulerAndActions;
		[Export ("resumeSchedulerAndActions")]
		void ResumeSchedulerAndActions ();

		//-(void) pauseSchedulerAndActions;
		[Export ("pauseSchedulerAndActions")]
		void PauseSchedulerAndActions ();

		//- (CGAffineTransform)nodeToParentTransform;
		[Export ("nodeToParentTransform")]
		CGAffineTransform NodeToParentTransform ();

		//- (CGAffineTransform)parentToNodeTransform;
		[Export ("parentToNodeTransform")]
		CGAffineTransform ParentToNodeTransform ();

		//- (CGAffineTransform)nodeToWorldTransform;
		[Export ("nodeToWorldTransform")]
		CGAffineTransform NodeToWorldTransform ();

		//- (CGAffineTransform)worldToNodeTransform;
		[Export ("worldToNodeTransform")]
		CGAffineTransform WorldToNodeTransform ();

		//- (CGPoint)convertToNodeSpace:(CGPoint)worldPoint;
		[Export ("convertToNodeSpace:")]
		PointF ConvertToNodeSpace (PointF worldPoint);

		//- (CGPoint)convertToWorldSpace:(CGPoint)nodePoint;
		[Export ("convertToWorldSpace:")]
		PointF ConvertToWorldSpace (PointF nodePoint);

		//- (CGPoint)convertToNodeSpaceAR:(CGPoint)worldPoint;
		[Export ("convertToNodeSpaceAR:")]
		PointF ConvertToNodeSpaceAR (PointF worldPoint);

		//- (CGPoint)convertToWorldSpaceAR:(CGPoint)nodePoint;
		[Export ("convertToWorldSpaceAR:")]
		PointF ConvertToWorldSpaceAR (PointF nodePoint);

		//- (CGPoint)convertTouchToNodeSpace:(UITouch *)touch;
		[Export ("convertTouchToNodeSpace:")]
		PointF ConvertTouchToNodeSpace (UITouch touch);

		//- (CGPoint)convertTouchToNodeSpaceAR:(UITouch *)touch;
		[Export ("convertTouchToNodeSpaceAR:")]
		PointF ConvertTouchToNodeSpaceAR (UITouch touch);


	}

	//@interface CCParallaxNode : CCNode
	[BaseType (typeof (CCNode))]
	interface CCParallaxNode {

		//From Generated Property
		//}@property (nonatomic,readwrite) ccArray * parallaxArray;
		[Export ("parallaxArray")]
		ccArray ParallaxArray { get; set;  }

		//-(void) addChild: (CCNode*)node z:(NSInteger)z parallaxRatio:(CGPoint)c positionOffset:(CGPoint)positionOffset;
		[Export ("addChild:z:parallaxRatio:positionOffset:")]
		void AddChild (CCNode node,int z,PointF parallaxRatio,PointF positionOffset);


	}

	//@interface CCParticleBatchNode : CCNode <CCTextureProtocol> {
	[BaseType (typeof (CCNode))]
	interface CCParticleBatchNode {

		//From Generated Property
		//@property (nonatomic, retain) CCTextureAtlas* textureAtlas;
		[Export ("textureAtlas")]
		CCTextureAtlas TextureAtlas { get; set;  }

		//@property (nonatomic, readwrite) ccBlendFunc blendFunc;
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set;  }

		//+(id)batchNodeWithTexture:(CCTexture2D *)tex;
		[Static]
		[Export ("batchNodeWithTexture:")]
		NSObject BatchNodeWithTexture (CCTexture2D tex);

		//+(id)batchNodeWithFile:(NSString*) imageFile;
		[Static]
		[Export ("batchNodeWithFile:")]
		NSObject BatchNodeWithFile (string imageFile);

		//+(id)batchNodeWithTexture:(CCTexture2D *)tex capacity:(NSUInteger) capacity;
		[Static]
		[Export ("batchNodeWithTexture:capacity:")]
		NSObject BatchNodeWithTexture (CCTexture2D tex,uint capacity);

		//+(id)batchNodeWithFile:(NSString*)fileImage capacity:(NSUInteger)capacity;
		[Static]
		[Export ("batchNodeWithFile:capacity:")]
		NSObject BatchNodeWithFile (string fileImage,uint capacity);

		//-(id)initWithTexture:(CCTexture2D *)tex capacity:(NSUInteger)capacity;
		[Export ("initWithTexture:capacity:")]
		IntPtr Constructor (CCTexture2D tex,uint capacity);

		//-(id)initWithFile:(NSString *)fileImage capacity:(NSUInteger)capacity;
		[Export ("initWithFile:capacity:")]
		IntPtr Constructor (string fileImage,uint capacity);

		//-(void) addChild:(CCParticleSystem*)child z:(NSInteger)z tag:(NSInteger) aTag;
		[Export ("addChild:z:tag:")]
		void AddChild (CCParticleSystem child,int z,int tag);

		//-(void) insertChild:(CCParticleSystem*) pSystem inAtlasAtIndex:(NSUInteger)index;
		[Export ("insertChild:inAtlasAtIndex:")]
		void InsertChild (CCParticleSystem pSystem,uint inAtlasAtIndex);

		//-(void) removeChild:(CCParticleSystem*) pSystem cleanup:(BOOL)doCleanUp;
		[Export ("removeChild:cleanup:")]
		void RemoveChild (CCParticleSystem pSystem,bool cleanup);

		//-(void) disableParticle:(NSUInteger) particleIndex;
		[Export ("disableParticle:")]
		void DisableParticle (uint particleIndex);

		//Detected properties
		// From protocol 'CCTextureProtocol'
		[Export ("texture")]
		CCTexture2D Texture { get; set; }


	}

	//@interface CCParticleFire : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleFire {

		//From Generated Property

	}

	//@interface CCParticleFireworks : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleFireworks {

		//From Generated Property

	}

	//@interface CCParticleSun : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleSun {

		//From Generated Property

	}

	//@interface CCParticleGalaxy : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleGalaxy {

		//From Generated Property

	}

	//@interface CCParticleFlower : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleFlower {

		//From Generated Property

	}

	//@interface CCParticleMeteor : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleMeteor {

		//From Generated Property

	}

	//@interface CCParticleSpiral : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleSpiral {

		//From Generated Property

	}

	//@interface CCParticleExplosion : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleExplosion {

		//From Generated Property

	}

	//@interface CCParticleSmoke : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleSmoke {

		//From Generated Property

	}

	//@interface CCParticleSnow : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleSnow {

		//From Generated Property

	}

	//@interface CCParticleRain : CCParticleSystemQuad
	[BaseType (typeof (CCParticleSystemQuad))]
	interface CCParticleRain {

		//From Generated Property

	}

	//@interface CCParticleSystem : CCNode <CCTextureProtocol>
	[BaseType (typeof (CCNode))]
	interface CCParticleSystem {

		//From Generated Property
		//}@property (nonatomic,readonly) BOOL active;
		[Export ("active")]
		bool Active { get;  }

		//@property (nonatomic,readonly) NSUInteger	particleCount;
		[Export ("particleCount")]
		uint ParticleCount { get;  }

		//@property (nonatomic,readwrite,assign) float duration;
		[Export ("duration")]
		float Duration { get; set;  }

		//@property (nonatomic,readwrite,assign) CGPoint sourcePosition;
		[Export ("sourcePosition")]
		PointF SourcePosition { get; set;  }

		//@property (nonatomic,readwrite,assign) CGPoint posVar;
		[Export ("posVar")]
		PointF PosVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float life;
		[Export ("life")]
		float Life { get; set;  }

		//@property (nonatomic,readwrite,assign) float lifeVar;
		[Export ("lifeVar")]
		float LifeVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float angle;
		[Export ("angle")]
		float Angle { get; set;  }

		//@property (nonatomic,readwrite,assign) float angleVar;
		[Export ("angleVar")]
		float AngleVar { get; set;  }

		//@property (nonatomic,readwrite,assign) CGPoint gravity;
		[Export ("gravity")]
		PointF Gravity { get; set;  }

		//@property (nonatomic,readwrite,assign) float speed;
		[Export ("speed")]
		float Speed { get; set;  }

		//@property (nonatomic,readwrite,assign) float speedVar;
		[Export ("speedVar")]
		float SpeedVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float tangentialAccel;
		[Export ("tangentialAccel")]
		float TangentialAccel { get; set;  }

		//@property (nonatomic,readwrite,assign) float tangentialAccelVar;
		[Export ("tangentialAccelVar")]
		float TangentialAccelVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float radialAccel;
		[Export ("radialAccel")]
		float RadialAccel { get; set;  }

		//@property (nonatomic,readwrite,assign) float radialAccelVar;
		[Export ("radialAccelVar")]
		float RadialAccelVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float startRadius;
		[Export ("startRadius")]
		float StartRadius { get; set;  }

		//@property (nonatomic,readwrite,assign) float startRadiusVar;
		[Export ("startRadiusVar")]
		float StartRadiusVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float endRadius;
		[Export ("endRadius")]
		float EndRadius { get; set;  }

		//@property (nonatomic,readwrite,assign) float endRadiusVar;
		[Export ("endRadiusVar")]
		float EndRadiusVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float rotatePerSecond;
		[Export ("rotatePerSecond")]
		float RotatePerSecond { get; set;  }

		//@property (nonatomic,readwrite,assign) float rotatePerSecondVar;
		[Export ("rotatePerSecondVar")]
		float RotatePerSecondVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float startSize;
		[Export ("startSize")]
		float StartSize { get; set;  }

		//@property (nonatomic,readwrite,assign) float startSizeVar;
		[Export ("startSizeVar")]
		float StartSizeVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float endSize;
		[Export ("endSize")]
		float EndSize { get; set;  }

		//@property (nonatomic,readwrite,assign) float endSizeVar;
		[Export ("endSizeVar")]
		float EndSizeVar { get; set;  }

		//@property (nonatomic,readwrite,assign) ccColor4F startColor;
		[Export ("startColor")]
		ccColor4F StartColor { get; set;  }

		//@property (nonatomic,readwrite,assign) ccColor4F startColorVar;
		[Export ("startColorVar")]
		ccColor4F StartColorVar { get; set;  }

		//@property (nonatomic,readwrite,assign) ccColor4F endColor;
		[Export ("endColor")]
		ccColor4F EndColor { get; set;  }

		//@property (nonatomic,readwrite,assign) ccColor4F endColorVar;
		[Export ("endColorVar")]
		ccColor4F EndColorVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float startSpin;
		[Export ("startSpin")]
		float StartSpin { get; set;  }

		//@property (nonatomic,readwrite,assign) float startSpinVar;
		[Export ("startSpinVar")]
		float StartSpinVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float endSpin;
		[Export ("endSpin")]
		float EndSpin { get; set;  }

		//@property (nonatomic,readwrite,assign) float endSpinVar;
		[Export ("endSpinVar")]
		float EndSpinVar { get; set;  }

		//@property (nonatomic,readwrite,assign) float emissionRate;
		[Export ("emissionRate")]
		float EmissionRate { get; set;  }

		//@property (nonatomic,readwrite,assign) NSUInteger totalParticles;
		[Export ("totalParticles")]
		uint TotalParticles { get; set;  }

		//@property (nonatomic,readwrite, retain) CCTexture2D * texture;
		[Export ("texture")]
		CCTexture2D Texture { get; set;  }

		//@property (nonatomic,readwrite) ccBlendFunc blendFunc;
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set;  }

		//@property (nonatomic, readwrite, getter=doesOpacityModifyRGB, assign) BOOL opacityModifyRGB;
		[Export ("opacityModifyRGB")]
		bool OpacityModifyRGB { [Bind ("doesOpacityModifyRGB")] get; set;  }

		//@property (nonatomic,readwrite) BOOL blendAdditive;
		[Export ("blendAdditive")]
		bool BlendAdditive { get; set;  }

		//@property (nonatomic,readwrite) tCCPositionType positionType;
		[Export ("positionType")]
		tCCPositionType PositionType { get; set;  }

		//@property (nonatomic,readwrite) BOOL autoRemoveOnFinish;
		[Export ("autoRemoveOnFinish")]
		bool AutoRemoveOnFinish { get; set;  }

		//@property (nonatomic,readwrite) NSInteger emitterMode;
		[Export ("emitterMode")]
		int EmitterMode { get; set;  }

		//@property (nonatomic,readwrite,assign) CCParticleBatchNode *batchNode;
		[Export ("batchNode")]
		CCParticleBatchNode BatchNode { get; set;  }

		//@property (nonatomic,readwrite) NSUInteger atlasIndex;
		[Export ("atlasIndex")]
		uint AtlasIndex { get; set;  }

		//+(id) particleWithFile:(NSString*)plistFile;
		[Static]
		[Export ("particleWithFile:")]
		NSObject ParticleWithFile (string plistFile);

		//-(id) initWithFile:(NSString*) plistFile;
		[Export ("initWithFile:")]
		IntPtr Constructor (string plistFile);

		//-(id) initWithDictionary:(NSDictionary*)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dictionary);

		//-(id) initWithTotalParticles:(NSUInteger) numberOfParticles;
		[Export ("initWithTotalParticles:")]
		IntPtr Constructor (uint numberOfParticles);

		//-(void) stopSystem;
		[Export ("stopSystem")]
		void StopSystem ();

		//-(void) resetSystem;
		[Export ("resetSystem")]
		void ResetSystem ();

		//-(BOOL) isFull;
		[Export ("isFull")]
		bool IsFull ();

		//-(void) updateQuadWithParticle:(tCCParticle*)particle newPosition:(CGPoint)pos;
		[Export ("updateQuadWithParticle:newPosition:")]
		void UpdateQuadWithParticle (tCCParticle particle,PointF newPosition);

		//-(void) postStep;
		[Export ("postStep")]
		void PostStep ();

		//-(void) update: (ccTime) dt;
		[Export ("update:")]
		void Update (ccTime dt);

		//-(void) updateWithNoTime;
		[Export ("updateWithNoTime")]
		void UpdateWithNoTime ();

		//-(void) setTexture:(CCTexture2D*)texture;
		// From protocol 'CCTextureProtocol'
		[Export ("setTexture:")]
		void SetTexture (CCTexture2D texture);


	}

	//@interface CCParticleSystemQuad : CCParticleSystem
	[BaseType (typeof (CCParticleSystem))]
	interface CCParticleSystemQuad {

		//From Generated Property
		//-(void) initIndices;
		[Export ("initIndices")]
		void InitIndices ();

		//-(void) initTexCoordsWithRect:(CGRect)rect;
		[Export ("initTexCoordsWithRect:")]
		void InitTexCoordsWithRect (RectangleF rect);

		//-(void)setDisplayFrame:(CCSpriteFrame*)spriteFrame;
		[Export ("setDisplayFrame:")]
		void SetDisplayFrame (CCSpriteFrame spriteFrame);

		//-(void) setTexture:(CCTexture2D *)texture withRect:(CGRect)rect;
		[Export ("setTexture:withRect:")]
		void SetTexture (CCTexture2D texture,RectangleF withRect);


	}

	//@interface CCProgressTimer : CCNode<CCRGBAProtocol> {
	[BaseType (typeof (CCNode))]
	interface CCProgressTimer {

		//From Generated Property
		//@property (nonatomic) GLubyte opacity;
		[Export ("opacity")]
		GLubyte Opacity { get; set;  }

		//@property (nonatomic, readwrite) CCProgressTimerType type;
		[Export ("type")]
		CCProgressTimerType Type { get; set;  }

		//@property (nonatomic, readwrite) BOOL reverseDirection;
		[Export ("reverseDirection")]
		bool ReverseDirection { get; set;  }

		//@property (nonatomic, readonly) int vertexDataCount;
		[Export ("vertexDataCount")]
		int VertexDataCount { get;  }

		//@property (nonatomic, readwrite) CGPoint midpoint;
		[Export ("midpoint")]
		PointF Midpoint { get; set;  }

		//@property (nonatomic, readwrite) CGPoint barChangeRate;
		[Export ("barChangeRate")]
		PointF BarChangeRate { get; set;  }

		//@property (nonatomic, readwrite) float percentage;
		[Export ("percentage")]
		float Percentage { get; set;  }

		//@property (nonatomic, readwrite, retain) CCSprite *sprite;
		[Export ("sprite")]
		CCSprite Sprite { get; set;  }

		//+ (id) progressWithSprite:(CCSprite*) sprite;
		[Static]
		[Export ("progressWithSprite:")]
		NSObject ProgressWithSprite (CCSprite sprite);

		//- (id) initWithSprite:(CCSprite*) sprite;
		[Export ("initWithSprite:")]
		IntPtr Constructor (CCSprite sprite);

		//-(void) setOpacity: (GLubyte) opacity;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacity:")]
		void SetOpacity (GLubyte opacity);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		//Detected properties
		// From protocol 'CCRGBAProtocol'
		[Export ("color")]
		ccColor3B Color { get; set; }


	}

	//@interface CCRenderTexture : CCNode
	[BaseType (typeof (CCNode))]
	interface CCRenderTexture {

		//From Generated Property
		//}@property (nonatomic,readwrite, assign) CCSprite* sprite;
		[Export ("sprite")]
		CCSprite Sprite { get; set;  }

		//+(id)renderTextureWithWidth:(int)w height:(int)h pixelFormat:(CCTexture2DPixelFormat) format depthStencilFormat:(GLuint)depthStencilFormat;
		[Static]
		[Export ("renderTextureWithWidth:height:pixelFormat:depthStencilFormat:")]
		NSObject RenderTextureWithWidth (int w,int height,CCTexture2DPixelFormat pixelFormat,GLuint depthStencilFormat);

		//+(id)renderTextureWithWidth:(int)w height:(int)h pixelFormat:(CCTexture2DPixelFormat) format;
		[Static]
		[Export ("renderTextureWithWidth:height:pixelFormat:")]
		NSObject RenderTextureWithWidth (int w,int height,CCTexture2DPixelFormat pixelFormat);

		//+(id)renderTextureWithWidth:(int)w height:(int)h;
		[Static]
		[Export ("renderTextureWithWidth:height:")]
		NSObject RenderTextureWithWidth (int w,int height);

		//-(id)initWithWidth:(int)w height:(int)h pixelFormat:(CCTexture2DPixelFormat) format;
		[Export ("initWithWidth:height:pixelFormat:")]
		IntPtr Constructor (int w,int height,CCTexture2DPixelFormat pixelFormat);

		//- (id)initWithWidth:(int)w height:(int)h pixelFormat:(CCTexture2DPixelFormat)format depthStencilFormat:(GLuint)depthStencilFormat;
		[Export ("initWithWidth:height:pixelFormat:depthStencilFormat:")]
		IntPtr Constructor (int w,int height,CCTexture2DPixelFormat pixelFormat,GLuint depthStencilFormat);

		//-(void)begin;
		[Export ("begin")]
		void Begin ();

		//-(void)beginWithClear:(float)r g:(float)g b:(float)b a:(float)a;
		[Export ("beginWithClear:g:b:a:")]
		void BeginWithClear (float r,float g,float b,float a);

		//- (void)beginWithClear:(float)r g:(float)g b:(float)b a:(float)a depth:(float)depthValue;
		[Export ("beginWithClear:g:b:a:depth:")]
		void BeginWithClear (float r,float g,float b,float a,float depth);

		//- (void)beginWithClear:(float)r g:(float)g b:(float)b a:(float)a depth:(float)depthValue stencil:(int)stencilValue;
		[Export ("beginWithClear:g:b:a:depth:stencil:")]
		void BeginWithClear (float r,float g,float b,float a,float depth,int stencil);

		//-(void)end;
		[Export ("end")]
		void End ();

		//-(void)clear:(float)r g:(float)g b:(float)b a:(float)a;
		[Export ("clear:g:b:a:")]
		void Clear (float r,float g,float b,float a);

		//- (void)clearDepth:(float)depthValue;
		[Export ("clearDepth:")]
		void ClearDepth (float depthValue);

		//- (void)clearStencil:(int)stencilValue;
		[Export ("clearStencil:")]
		void ClearStencil (int stencilValue);

		//-(CGImageRef) newCGImage;
		[Export ("newCGImage")]
		CGImageRef NewCGImage ();

		//-(BOOL)saveToFile:(NSString*)name;
		[Export ("saveToFile:")]
		bool SaveToFile (string name);

		//-(BOOL)saveToFile:(NSString*)name format:(tCCImageFormat)format;
		[Export ("saveToFile:format:")]
		bool SaveToFile (string name,tCCImageFormat format);

		//-(UIImage *) getUIImage;
		[Export ("getUIImage")]
		UIImage GetUIImage ();

		//-(NSData*)getUIImageAsDataFromBuffer:(int) format UNAVAILABLE_ATTRIBUTE;
		[Export ("getUIImageAsDataFromBuffer:")]
		NSData GetUIImageAsDataFromBuffer (int format);


	}

	//@interface CCScene : CCNode
	[BaseType (typeof (CCNode))]
	interface CCScene {

		//From Generated Property

	}

	//@interface CCTimer : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTimer {

		//From Generated Property
		//}@property (nonatomic,readwrite,assign) ccTime interval;
		[Export ("interval")]
		ccTime Interval { get; set;  }

		//+(id) timerWithTarget:(id) t selector:(SEL)s;
		[Static]
		[Export ("timerWithTarget:selector:")]
		NSObject TimerWithTarget (NSObject t,Selector selector);

		//+(id) timerWithTarget:(id) t selector:(SEL)s interval:(ccTime)seconds;
		[Static]
		[Export ("timerWithTarget:selector:interval:")]
		NSObject TimerWithTarget (NSObject t,Selector selector,ccTime interval);

		// -(id) initWithTarget:(id) t selector:(SEL)s;
		[Export ("initWithTarget:selector:")]
		IntPtr Constructor (NSObject t,Selector selector);

		//-(id) initWithTarget:(id)t selector:(SEL)s interval:(ccTime) seconds repeat:(uint) r delay:(ccTime) d;
		[Export ("initWithTarget:selector:interval:repeat:delay:")]
		IntPtr Constructor (NSObject t,Selector selector,ccTime interval,uint repeat,ccTime delay);

		//-(void) update: (ccTime) dt;
		[Export ("update:")]
		void Update (ccTime dt);


	}

	//@interface CCScheduler : NSObject
	[BaseType (typeof (NSObject))]
	interface CCScheduler {

		//From Generated Property
		//}@property (nonatomic,readwrite) ccTime	timeScale;
		[Export ("timeScale")]
		ccTime TimeScale { get; set;  }

		//-(void) update:(ccTime)dt;
		[Export ("update:")]
		void Update (ccTime dt);

		//-(void) scheduleSelector:(SEL)selector forTarget:(id)target interval:(ccTime)interval paused:(BOOL)paused repeat: (uint) repeat delay: (ccTime) delay;
		[Export ("scheduleSelector:forTarget:interval:paused:repeat:delay:")]
		void ScheduleSelector (Selector selector,NSObject forTarget,ccTime interval,bool paused,uint repeat,ccTime delay);

		//-(void) scheduleSelector:(SEL)selector forTarget:(id)target interval:(ccTime)interval paused:(BOOL)paused;
		[Export ("scheduleSelector:forTarget:interval:paused:")]
		void ScheduleSelector (Selector selector,NSObject forTarget,ccTime interval,bool paused);

		//-(void) scheduleUpdateForTarget:(id)target priority:(NSInteger)priority paused:(BOOL)paused;
		[Export ("scheduleUpdateForTarget:priority:paused:")]
		void ScheduleUpdateForTarget (NSObject target,int priority,bool paused);

		//-(void) unscheduleSelector:(SEL)selector forTarget:(id)target;
		[Export ("unscheduleSelector:forTarget:")]
		void UnscheduleSelector (Selector selector,NSObject forTarget);

		//-(void) unscheduleUpdateForTarget:(id)target;
		[Export ("unscheduleUpdateForTarget:")]
		void UnscheduleUpdateForTarget (NSObject target);

		//-(void) unscheduleAllSelectorsForTarget:(id)target;
		[Export ("unscheduleAllSelectorsForTarget:")]
		void UnscheduleAllSelectorsForTarget (NSObject target);

		//-(void) unscheduleAllSelectors;
		[Export ("unscheduleAllSelectors")]
		void UnscheduleAllSelectors ();

		//-(void) unscheduleAllSelectorsWithMinPriority:(NSInteger)minPriority;
		[Export ("unscheduleAllSelectorsWithMinPriority:")]
		void UnscheduleAllSelectorsWithMinPriority (int minPriority);

		//-(void) pauseTarget:(id)target;
		[Export ("pauseTarget:")]
		void PauseTarget (NSObject target);

		//-(void) resumeTarget:(id)target;
		[Export ("resumeTarget:")]
		void ResumeTarget (NSObject target);

		//-(BOOL) isTargetPaused:(id)target;
		[Export ("isTargetPaused:")]
		bool IsTargetPaused (NSObject target);

		//-(NSSet*) pauseAllTargets;
		[Export ("pauseAllTargets")]
		NSSet PauseAllTargets ();

		//-(NSSet*) pauseAllTargetsWithMinPriority:(NSInteger)minPriority;
		[Export ("pauseAllTargetsWithMinPriority:")]
		NSSet PauseAllTargetsWithMinPriority (int minPriority);

		//-(void) resumeTargets:(NSSet *)targetsToResume;
		[Export ("resumeTargets:")]
		void ResumeTargets (NSSet targetsToResume);


	}

	//@interface CCShaderCache : NSObject {
	[BaseType (typeof (NSObject))]
	interface CCShaderCache {

		//From Generated Property
		//+ (CCShaderCache *)sharedShaderCache;
		[Static]
		[Export ("sharedShaderCache")]
		CCShaderCache SharedShaderCache ();

		//+(void)purgeSharedShaderCache;
		[Static]
		[Export ("purgeSharedShaderCache")]
		void PurgeSharedShaderCache ();

		//-(void) loadDefaultShaders;
		[Export ("loadDefaultShaders")]
		void LoadDefaultShaders ();

		//-(CCGLProgram *) programForKey:(NSString*)key;
		[Export ("programForKey:")]
		CCGLProgram ProgramForKey (string key);

		//- (void) addProgram:(CCGLProgram*)program forKey:(NSString*)key;
		[Export ("addProgram:forKey:")]
		void AddProgram (CCGLProgram program,string forKey);


	}

	//@interface CCSprite : CCNode <CCRGBAProtocol, CCTextureProtocol>
	[BaseType (typeof (CCNode))]
	interface CCSprite {

		//From Generated Property
		//}@property (nonatomic,readwrite) BOOL dirty;
		[Export ("dirty")]
		bool Dirty { get; set;  }

		//@property (nonatomic,readonly) ccV3F_C4B_T2F_Quad quad;
		[Export ("quad")]
		ccV3F_C4B_T2F_Quad Quad { get;  }

		//@property (nonatomic,readwrite) NSUInteger atlasIndex;
		[Export ("atlasIndex")]
		uint AtlasIndex { get; set;  }

		//@property (nonatomic,readonly) CGRect textureRect;
		[Export ("textureRect")]
		RectangleF TextureRect { get;  }

		//@property (nonatomic,readonly) BOOL textureRectRotated;
		[Export ("textureRectRotated")]
		bool TextureRectRotated { get;  }

		//@property (nonatomic,readwrite) BOOL flipX;
		[Export ("flipX")]
		bool FlipX { get; set;  }

		//@property (nonatomic,readwrite) BOOL flipY;
		[Export ("flipY")]
		bool FlipY { get; set;  }

		//@property (nonatomic,readwrite) GLubyte opacity;
		[Export ("opacity")]
		GLubyte Opacity { get; set;  }

		//@property (nonatomic,readwrite) ccColor3B color;
		[Export ("color")]
		ccColor3B Color { get; set;  }

		//@property (nonatomic,readwrite,assign) CCTextureAtlas *textureAtlas;
		[Export ("textureAtlas")]
		CCTextureAtlas TextureAtlas { get; set;  }

		//@property (nonatomic,readwrite,assign) CCSpriteBatchNode *batchNode;
		[Export ("batchNode")]
		CCSpriteBatchNode BatchNode { get; set;  }

		//@property (nonatomic,readonly) CGPoint	offsetPosition;
		[Export ("offsetPosition")]
		PointF OffsetPosition { get;  }

		//@property (nonatomic,readwrite) ccBlendFunc blendFunc;
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set;  }

		//+(id) spriteWithTexture:(CCTexture2D*)texture;
		[Static]
		[Export ("spriteWithTexture:")]
		NSObject SpriteWithTexture (CCTexture2D texture);

		//+(id) spriteWithTexture:(CCTexture2D*)texture rect:(CGRect)rect;
		[Static]
		[Export ("spriteWithTexture:rect:")]
		NSObject SpriteWithTexture (CCTexture2D texture,RectangleF rect);

		//+(id) spriteWithSpriteFrame:(CCSpriteFrame*)spriteFrame;
		[Static]
		[Export ("spriteWithSpriteFrame:")]
		NSObject SpriteWithSpriteFrame (CCSpriteFrame spriteFrame);

		//+(id) spriteWithSpriteFrameName:(NSString*)spriteFrameName;
		[Static]
		[Export ("spriteWithSpriteFrameName:")]
		NSObject SpriteWithSpriteFrameName (string spriteFrameName);

		//+(id) spriteWithFile:(NSString*)filename;
		[Static]
		[Export ("spriteWithFile:")]
		NSObject SpriteWithFile (string filename);

		//+(id) spriteWithFile:(NSString*)filename rect:(CGRect)rect;
		[Static]
		[Export ("spriteWithFile:rect:")]
		NSObject SpriteWithFile (string filename,RectangleF rect);

		//+(id) spriteWithCGImage: (CGImageRef)image key:(NSString*)key;
		[Static]
		[Export ("spriteWithCGImage:key:")]
		NSObject SpriteWithCGImage (CGImageRef image,string key);

		//-(id) initWithTexture:(CCTexture2D*)texture;
		[Export ("initWithTexture:")]
		IntPtr Constructor (CCTexture2D texture);

		//-(id) initWithTexture:(CCTexture2D*)texture rect:(CGRect)rect;
		[Export ("initWithTexture:rect:")]
		IntPtr Constructor (CCTexture2D texture,RectangleF rect);

		//- (id)initWithTexture:(CCTexture2D *)texture rect:(CGRect)rect rotated:(BOOL)rotated;
		[Export ("initWithTexture:rect:rotated:")]
		IntPtr Constructor (CCTexture2D texture,RectangleF rect,bool rotated);

		//-(id) initWithSpriteFrame:(CCSpriteFrame*)spriteFrame;
		[Export ("initWithSpriteFrame:")]
		IntPtr Constructor (CCSpriteFrame spriteFrame);

		//-(id) initWithSpriteFrameName:(NSString*)spriteFrameName;
		[Export ("initWithSpriteFrameName:")]
		IntPtr Constructor (string spriteFrameName);

		//-(id) initWithFile:(NSString*)filename;
		[Export ("initWithFile:")]
		IntPtr Constructor (string filename, bool withFile);

		//-(id) initWithFile:(NSString*)filename rect:(CGRect)rect;
		[Export ("initWithFile:rect:")]
		IntPtr Constructor (string filename,RectangleF rect);

		//-(id) initWithCGImage:(CGImageRef)image key:(NSString*)key;
		[Export ("initWithCGImage:key:")]
		IntPtr Constructor (CGImageRef image,string key);

		//-(void)updateTransform;
		[Export ("updateTransform")]
		void UpdateTransform ();

		//-(void) setTextureRect:(CGRect) rect;
		[Export ("setTextureRect:")]
		void SetTextureRect (RectangleF rect);

		//-(void) setTextureRect:(CGRect)rect rotated:(BOOL)rotated untrimmedSize:(CGSize)size;
		[Export ("setTextureRect:rotated:untrimmedSize:")]
		void SetTextureRect (RectangleF rect,bool rotated,SizeF untrimmedSize);

		//-(void)setVertexRect:(CGRect)rect;
		[Export ("setVertexRect:")]
		void SetVertexRect (RectangleF rect);

		//-(BOOL) isFrameDisplayed:(CCSpriteFrame*)frame;
		[Export ("isFrameDisplayed:")]
		bool IsFrameDisplayed (CCSpriteFrame frame);

		//-(void) setDisplayFrameWithAnimationName:(NSString*)animationName index:(int) frameIndex;
		[Export ("setDisplayFrameWithAnimationName:index:")]
		void SetDisplayFrameWithAnimationName (string animationName,int index);

		//-(void) setColor:(ccColor3B)color;
		// From protocol 'CCRGBAProtocol'
		[Export ("setColor:")]
		void SetColor (ccColor3B color);

		//-(void) setOpacity: (GLubyte) opacity;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacity:")]
		void SetOpacity (GLubyte opacity);

		//@optional-(void) setOpacityModifyRGB:(BOOL)boolean;
		// From protocol 'CCRGBAProtocol'
		[Export ("setOpacityModifyRGB:")]
		void SetOpacityModifyRGB (bool boolean);

		// -(BOOL) doesOpacityModifyRGB;
		// From protocol 'CCRGBAProtocol'
		[Export ("doesOpacityModifyRGB")]
		bool DoesOpacityModifyRGB ();

		//Detected properties
		[Export ("displayFrame")]
		CCSpriteFrame DisplayFrame { get; set; }

		// From protocol 'CCTextureProtocol'
		[Export ("texture")]
		CCTexture2D Texture { get; set; }


	}

	//@interface CCSpriteBatchNode : CCNode <CCTextureProtocol>
	[BaseType (typeof (CCNode))]
	interface CCSpriteBatchNode {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain) CCTextureAtlas * textureAtlas;
		[Export ("textureAtlas")]
		CCTextureAtlas TextureAtlas { get; set;  }

		//@property (nonatomic,readwrite) ccBlendFunc blendFunc;
		[Export ("blendFunc")]
		ccBlendFunc BlendFunc { get; set;  }

		//@property (nonatomic,readonly) CCArray *descendants;
		[Export ("descendants")]
		CCArray Descendants { get;  }

		//+(id)batchNodeWithTexture:(CCTexture2D *)tex;
		[Static]
		[Export ("batchNodeWithTexture:")]
		NSObject BatchNodeWithTexture (CCTexture2D tex);

		//+(id)batchNodeWithTexture:(CCTexture2D *)tex capacity:(NSUInteger)capacity;
		[Static]
		[Export ("batchNodeWithTexture:capacity:")]
		NSObject BatchNodeWithTexture (CCTexture2D tex,uint capacity);

		//+(id)batchNodeWithFile:(NSString*) fileImage;
		[Static]
		[Export ("batchNodeWithFile:")]
		NSObject BatchNodeWithFile (string fileImage);

		//+(id)batchNodeWithFile:(NSString*)fileImage capacity:(NSUInteger)capacity;
		[Static]
		[Export ("batchNodeWithFile:capacity:")]
		NSObject BatchNodeWithFile (string fileImage,uint capacity);

		//-(id)initWithTexture:(CCTexture2D *)tex capacity:(NSUInteger)capacity;
		[Export ("initWithTexture:capacity:")]
		IntPtr Constructor (CCTexture2D tex,uint capacity);

		//-(id)initWithFile:(NSString*)fileImage capacity:(NSUInteger)capacity;
		[Export ("initWithFile:capacity:")]
		IntPtr Constructor (string fileImage,uint capacity);

		//-(void) increaseAtlasCapacity;
		[Export ("increaseAtlasCapacity")]
		void IncreaseAtlasCapacity ();

		//-(void)removeChildAtIndex:(NSUInteger)index cleanup:(BOOL)doCleanup;
		[Export ("removeChildAtIndex:cleanup:")]
		void RemoveChildAtIndex (uint index,bool cleanup);

		//-(void)removeChild: (CCSprite *)sprite cleanup:(BOOL)doCleanup;
		[Export ("removeChild:cleanup:")]
		void RemoveChild (CCSprite sprite,bool cleanup);

		//-(void) insertChild:(CCSprite*)child inAtlasAtIndex:(NSUInteger)index;
		[Export ("insertChild:inAtlasAtIndex:")]
		void InsertChild (CCSprite child,uint inAtlasAtIndex);

		//-(void) appendChild:(CCSprite*)sprite;
		[Export ("appendChild:")]
		void AppendChild (CCSprite sprite);

		//-(void) removeSpriteFromAtlas:(CCSprite*)sprite;
		[Export ("removeSpriteFromAtlas:")]
		void RemoveSpriteFromAtlas (CCSprite sprite);

		//-(NSUInteger) rebuildIndexInOrder:(CCSprite*)parent atlasIndex:(NSUInteger)index;
		[Export ("rebuildIndexInOrder:atlasIndex:")]
		uint RebuildIndexInOrder (CCSprite parent,uint atlasIndex);

		//-(NSUInteger) atlasIndexForChild:(CCSprite*)sprite atZ:(NSInteger)z;
		[Export ("atlasIndexForChild:atZ:")]
		uint AtlasIndexForChild (CCSprite sprite,int atZ);

		//- (void) reorderBatch:(BOOL) reorder;
		[Export ("reorderBatch:")]
		void ReorderBatch (bool reorder);

		//-(void) addQuadFromSprite:(CCSprite*)sprite quadIndex:(NSUInteger)index;
		[Export ("addQuadFromSprite:quadIndex:")]
		void AddQuadFromSprite (CCSprite sprite,uint quadIndex);

		//Detected properties
		// From protocol 'CCTextureProtocol'
		[Export ("texture")]
		CCTexture2D Texture { get; set; }


	}

	//@interface CCSpriteFrame : NSObject <NSCopying>
	[BaseType (typeof (NSObject))]
	interface CCSpriteFrame {

		//From Generated Property
		//}@property (nonatomic,readwrite) CGRect rect;
		[Export ("rect")]
		RectangleF Rect { get; set;  }

		//@property (nonatomic,readwrite) CGRect rectInPixels;
		[Export ("rectInPixels")]
		RectangleF RectInPixels { get; set;  }

		//@property (nonatomic,readwrite) BOOL rotated;
		[Export ("rotated")]
		bool Rotated { get; set;  }

		//@property (nonatomic,readwrite) CGPoint offset;
		[Export ("offset")]
		PointF Offset { get; set;  }

		//@property (nonatomic,readwrite) CGPoint offsetInPixels;
		[Export ("offsetInPixels")]
		PointF OffsetInPixels { get; set;  }

		//@property (nonatomic,readwrite) CGSize originalSize;
		[Export ("originalSize")]
		SizeF OriginalSize { get; set;  }

		//@property (nonatomic,readwrite) CGSize originalSizeInPixels;
		[Export ("originalSizeInPixels")]
		SizeF OriginalSizeInPixels { get; set;  }

		//@property (nonatomic, retain, readwrite) CCTexture2D *texture;
		[Export ("texture")]
		CCTexture2D Texture { get; set;  }

		//@property (nonatomic, retain, readonly) NSString *textureFilename;
		[Export ("textureFilename")]
		string TextureFilename { get;  }

		//+(id) frameWithTexture:(CCTexture2D*)texture rect:(CGRect)rect;
		[Static]
		[Export ("frameWithTexture:rect:")]
		NSObject FrameWithTexture (CCTexture2D texture,RectangleF rect);

		//+(id) frameWithTextureFilename:(NSString*)filename rect:(CGRect)rect;
		[Static]
		[Export ("frameWithTextureFilename:rect:")]
		NSObject FrameWithTextureFilename (string filename,RectangleF rect);

		//+(id) frameWithTexture:(CCTexture2D*)texture rectInPixels:(CGRect)rect rotated:(BOOL)rotated offset:(CGPoint)offset originalSize:(CGSize)originalSize;
		[Static]
		[Export ("frameWithTexture:rectInPixels:rotated:offset:originalSize:")]
		NSObject FrameWithTexture (CCTexture2D texture,RectangleF rectInPixels,bool rotated,PointF offset,SizeF originalSize);

		//+(id) frameWithTextureFilename:(NSString*)filename rectInPixels:(CGRect)rect rotated:(BOOL)rotated offset:(CGPoint)offset originalSize:(CGSize)originalSize;
		[Static]
		[Export ("frameWithTextureFilename:rectInPixels:rotated:offset:originalSize:")]
		NSObject FrameWithTextureFilename (string filename,RectangleF rectInPixels,bool rotated,PointF offset,SizeF originalSize);

		//-(id) initWithTexture:(CCTexture2D*)texture rect:(CGRect)rect;
		[Export ("initWithTexture:rect:")]
		IntPtr Constructor (CCTexture2D texture,RectangleF rect);

		//-(id) initWithTextureFilename:(NSString*)filename rect:(CGRect)rect;
		[Export ("initWithTextureFilename:rect:")]
		IntPtr Constructor (string filename,RectangleF rect);

		//-(id) initWithTexture:(CCTexture2D*)texture rectInPixels:(CGRect)rect rotated:(BOOL)rotated offset:(CGPoint)offset originalSize:(CGSize)originalSize;
		[Export ("initWithTexture:rectInPixels:rotated:offset:originalSize:")]
		IntPtr Constructor (CCTexture2D texture,RectangleF rectInPixels,bool rotated,PointF offset,SizeF originalSize);

		//-(id) initWithTextureFilename:(NSString*)filename rectInPixels:(CGRect)rect rotated:(BOOL)rotated offset:(CGPoint)offset originalSize:(CGSize)originalSize;
		[Export ("initWithTextureFilename:rectInPixels:rotated:offset:originalSize:")]
		IntPtr Constructor (string filename,RectangleF rectInPixels,bool rotated,PointF offset,SizeF originalSize);


	}

	//@interface CCSpriteFrameCache : NSObject
	[BaseType (typeof (NSObject))]
	interface CCSpriteFrameCache {

		//From Generated Property
		//+ (CCSpriteFrameCache *) sharedSpriteFrameCache;
		[Static]
		[Export ("sharedSpriteFrameCache")]
		CCSpriteFrameCache SharedSpriteFrameCache ();

		//+(void)purgeSharedSpriteFrameCache;
		[Static]
		[Export ("purgeSharedSpriteFrameCache")]
		void PurgeSharedSpriteFrameCache ();

		//-(void) addSpriteFramesWithFile:(NSString*)plist;
		[Export ("addSpriteFramesWithFile:")]
		void AddSpriteFramesWithFile (string plist);

		//-(void) addSpriteFramesWithFile:(NSString*)plist textureFilename:(NSString*)filename;
		[Export ("addSpriteFramesWithFile:textureFilename:")]
		void AddSpriteFramesWithFile (string plist,string textureFilename);

		//-(void) addSpriteFramesWithFile:(NSString*)plist texture:(CCTexture2D*)texture;
		[Export ("addSpriteFramesWithFile:texture:")]
		void AddSpriteFramesWithFile (string plist,CCTexture2D texture);

		//-(void) addSpriteFrame:(CCSpriteFrame*)frame name:(NSString*)frameName;
		[Export ("addSpriteFrame:name:")]
		void AddSpriteFrame (CCSpriteFrame frame,string name);

		//-(void) removeSpriteFrames;
		[Export ("removeSpriteFrames")]
		void RemoveSpriteFrames ();

		//-(void) removeUnusedSpriteFrames;
		[Export ("removeUnusedSpriteFrames")]
		void RemoveUnusedSpriteFrames ();

		//-(void) removeSpriteFrameByName:(NSString*)name;
		[Export ("removeSpriteFrameByName:")]
		void RemoveSpriteFrameByName (string name);

		//- (void) removeSpriteFramesFromFile:(NSString*) plist;
		[Export ("removeSpriteFramesFromFile:")]
		void RemoveSpriteFramesFromFile (string plist);

		//- (void) removeSpriteFramesFromTexture:(CCTexture2D*) texture;
		[Export ("removeSpriteFramesFromTexture:")]
		void RemoveSpriteFramesFromTexture (CCTexture2D texture);

		//-(CCSpriteFrame*) spriteFrameByName:(NSString*)name;
		[Export ("spriteFrameByName:")]
		CCSpriteFrame SpriteFrameByName (string name);


	}

	//@interface CCTMXLayer : CCSpriteBatchNode
	[BaseType (typeof (CCSpriteBatchNode))]
	interface CCTMXLayer {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain) NSString *layerName;
		[Export ("layerName")]
		string LayerName { get; set;  }

		//@property (nonatomic,readwrite) CGSize layerSize;
		[Export ("layerSize")]
		SizeF LayerSize { get; set;  }

		//@property (nonatomic,readwrite) CGSize mapTileSize;
		[Export ("mapTileSize")]
		SizeF MapTileSize { get; set;  }

		//@property (nonatomic,readwrite) uint32_t *tiles;
		[Export ("tiles")]
		uint32_t Tiles { get; set;  }

		//@property (nonatomic,readwrite,retain) CCTMXTilesetInfo *tileset;
		[Export ("tileset")]
		CCTMXTilesetInfo Tileset { get; set;  }

		//@property (nonatomic,readwrite) NSUInteger layerOrientation;
		[Export ("layerOrientation")]
		uint LayerOrientation { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *properties;
		[Export ("properties")]
		NSMutableArray Properties { get; set;  }

		//+(id) layerWithTilesetInfo:(CCTMXTilesetInfo*)tilesetInfo layerInfo:(CCTMXLayerInfo*)layerInfo mapInfo:(CCTMXMapInfo*)mapInfo;
		[Static]
		[Export ("layerWithTilesetInfo:layerInfo:mapInfo:")]
		NSObject LayerWithTilesetInfo (CCTMXTilesetInfo tilesetInfo,CCTMXLayerInfo layerInfo,CCTMXMapInfo mapInfo);

		//-(id) initWithTilesetInfo:(CCTMXTilesetInfo*)tilesetInfo layerInfo:(CCTMXLayerInfo*)layerInfo mapInfo:(CCTMXMapInfo*)mapInfo;
		[Export ("initWithTilesetInfo:layerInfo:mapInfo:")]
		IntPtr Constructor (CCTMXTilesetInfo tilesetInfo,CCTMXLayerInfo layerInfo,CCTMXMapInfo mapInfo);

		//-(void) releaseMap;
		[Export ("releaseMap")]
		void ReleaseMap ();

		//-(CCSprite*) tileAt:(CGPoint)tileCoordinate;
		[Export ("tileAt:")]
		CCSprite TileAt (PointF tileCoordinate);

		//-(uint32_t) tileGIDAt:(CGPoint)tileCoordinate;
		[Export ("tileGIDAt:")]
		uint32_t TileGIDAt (PointF tileCoordinate);

		//-(uint32_t) tileGIDAt:(CGPoint)pos withFlags:(ccTMXTileFlags*)flags;
		[Export ("tileGIDAt:withFlags:")]
		uint32_t TileGIDAt (PointF pos,ccTMXTileFlags withFlags);

		//-(void) setTileGID:(uint32_t)gid at:(CGPoint)tileCoordinate;
		[Export ("setTileGID:at:")]
		void SetTileGID (uint32_t gid,PointF at);

		//-(void) setTileGID:(uint32_t)gid at:(CGPoint)pos withFlags:(ccTMXTileFlags)flags;
		[Export ("setTileGID:at:withFlags:")]
		void SetTileGID (uint32_t gid,PointF at,ccTMXTileFlags withFlags);

		//-(void) removeTileAt:(CGPoint)tileCoordinate;
		[Export ("removeTileAt:")]
		void RemoveTileAt (PointF tileCoordinate);

		//-(CGPoint) positionAt:(CGPoint)tileCoordinate;
		[Export ("positionAt:")]
		PointF PositionAt (PointF tileCoordinate);

		//-(id) propertyNamed:(NSString *)propertyName;
		[Export ("propertyNamed:")]
		NSObject PropertyNamed (string propertyName);

		//-(void) setupTiles;
		[Export ("setupTiles")]
		void SetupTiles ();

		//-(void) addChild: (CCNode*)node z:(NSInteger)z tag:(NSInteger)tag;
		[Export ("addChild:z:tag:")]
		void AddChild (CCNode node,int z,int tag);


	}

	//@interface CCTMXObjectGroup : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTMXObjectGroup {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain) NSString *groupName;
		[Export ("groupName")]
		string GroupName { get; set;  }

		//@property (nonatomic,readwrite,assign) CGPoint positionOffset;
		[Export ("positionOffset")]
		PointF PositionOffset { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *objects;
		[Export ("objects")]
		NSMutableArray Objects { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableDictionary *properties;
		[Export ("properties")]
		NSMutableDictionary Properties { get; set;  }

		//-(id) propertyNamed:(NSString *)propertyName;
		[Export ("propertyNamed:")]
		NSObject PropertyNamed (string propertyName);

		//-(NSMutableDictionary*) objectNamed:(NSString *)objectName;
		[Export ("objectNamed:")]
		NSMutableDictionary ObjectNamed (string objectName);


	}

	//@interface CCTMXTiledMap : CCNode
	[BaseType (typeof (CCNode))]
	interface CCTMXTiledMap {

		//From Generated Property
		//}@property (nonatomic,readonly) CGSize mapSize;
		[Export ("mapSize")]
		SizeF MapSize { get;  }

		//@property (nonatomic,readonly) CGSize tileSize;
		[Export ("tileSize")]
		SizeF TileSize { get;  }

		//@property (nonatomic,readonly) int mapOrientation;
		[Export ("mapOrientation")]
		int MapOrientation { get;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *objectGroups;
		[Export ("objectGroups")]
		NSMutableArray ObjectGroups { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableDictionary *properties;
		[Export ("properties")]
		NSMutableDictionary Properties { get; set;  }

		//+(id) tiledMapWithTMXFile:(NSString*)tmxFile;
		[Static]
		[Export ("tiledMapWithTMXFile:")]
		NSObject TiledMapWithTMXFile (string tmxFile);

		//+(id) tiledMapWithXML:(NSString*)tmxString resourcePath:(NSString*)resourcePath;
		[Static]
		[Export ("tiledMapWithXML:resourcePath:")]
		NSObject TiledMapWithXML (string tmxString,string resourcePath);

		//-(id) initWithTMXFile:(NSString*)tmxFile;
		[Export ("initWithTMXFile:")]
		IntPtr Constructor (string tmxFile);

		//-(id) initWithXML:(NSString*)tmxString resourcePath:(NSString*)resourcePath;
		[Export ("initWithXML:resourcePath:")]
		IntPtr Constructor (string tmxString,string resourcePath);

		//-(CCTMXLayer*) layerNamed:(NSString *)layerName;
		[Export ("layerNamed:")]
		CCTMXLayer LayerNamed (string layerName);

		//-(CCTMXObjectGroup*) objectGroupNamed:(NSString *)groupName;
		[Export ("objectGroupNamed:")]
		CCTMXObjectGroup ObjectGroupNamed (string groupName);

		//-(id) propertyNamed:(NSString *)propertyName;
		[Export ("propertyNamed:")]
		NSObject PropertyNamed (string propertyName);

		//-(NSDictionary*)propertiesForGID:(unsigned int)GID;
		[Export ("propertiesForGID:")]
		NSDictionary PropertiesForGID (uint intArg);


	}

	//@interface CCTMXLayerInfo : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTMXLayerInfo {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain)	NSString *name;
		[Export ("name")]
		string Name { get; set;  }

		//@property (nonatomic,readwrite)			CGSize layerSize;
		[Export ("layerSize")]
		SizeF LayerSize { get; set;  }

		//@property (nonatomic,readwrite)			uint *tiles;
		[Export ("tiles")]
		uint Tiles { get; set;  }

		//@property (nonatomic,readwrite)			BOOL visible;
		[Export ("visible")]
		bool Visible { get; set;  }

		//@property (nonatomic,readwrite)			byte opacity;
		[Export ("opacity")]
		byte Opacity { get; set;  }

		//@property (nonatomic,readwrite)			BOOL ownTiles;
		[Export ("ownTiles")]
		bool OwnTiles { get; set;  }

		//@property (nonatomic,readwrite)			uint minGID;
		[Export ("minGID")]
		uint MinGID { get; set;  }

		//@property (nonatomic,readwrite)			uint maxGID;
		[Export ("maxGID")]
		uint MaxGID { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableDictionary *properties;
		[Export ("properties")]
		NSMutableDictionary Properties { get; set;  }

		//@property (nonatomic,readwrite)			CGPoint offset;
		[Export ("offset")]
		PointF Offset { get; set;  }


	}

	//@interface CCTMXTilesetInfo : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTMXTilesetInfo {

		//From Generated Property
		//}@property (nonatomic,readwrite,retain) NSString *name;
		[Export ("name")]
		string Name { get; set;  }

		//@property (nonatomic,readwrite,assign) uint firstGid;
		[Export ("firstGid")]
		uint FirstGid { get; set;  }

		//@property (nonatomic,readwrite,assign) CGSize tileSize;
		[Export ("tileSize")]
		SizeF TileSize { get; set;  }

		//@property (nonatomic,readwrite,assign) uint spacing;
		[Export ("spacing")]
		uint Spacing { get; set;  }

		//@property (nonatomic,readwrite,assign) uint margin;
		[Export ("margin")]
		uint Margin { get; set;  }

		//@property (nonatomic,readwrite,retain) NSString *sourceImage;
		[Export ("sourceImage")]
		string SourceImage { get; set;  }

		//@property (nonatomic,readwrite,assign) CGSize imageSize;
		[Export ("imageSize")]
		SizeF ImageSize { get; set;  }

		//-(CGRect) rectForGID:(unsigned int)gid;
		[Export ("rectForGID:")]
		RectangleF RectForGID (uint intArg);


	}

	//@interface CCTMXMapInfo : NSObject <NSXMLParserDelegate>
	[BaseType (typeof (NSObject))]
	interface CCTMXMapInfo {

		//From Generated Property
		//}@property (nonatomic,readwrite,assign) int orientation;
		[Export ("orientation")]
		int Orientation { get; set;  }

		//@property (nonatomic,readwrite,assign) CGSize mapSize;
		[Export ("mapSize")]
		SizeF MapSize { get; set;  }

		//@property (nonatomic,readwrite,assign) CGSize tileSize;
		[Export ("tileSize")]
		SizeF TileSize { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *layers;
		[Export ("layers")]
		NSMutableArray Layers { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *tilesets;
		[Export ("tilesets")]
		NSMutableArray Tilesets { get; set;  }

		//@property (nonatomic,readwrite,retain) NSString *filename;
		[Export ("filename")]
		string Filename { get; set;  }

		//@property (nonatomic,readwrite,retain) NSString *resources;
		[Export ("resources")]
		string Resources { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableArray *objectGroups;
		[Export ("objectGroups")]
		NSMutableArray ObjectGroups { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableDictionary *properties;
		[Export ("properties")]
		NSMutableDictionary Properties { get; set;  }

		//@property (nonatomic,readwrite,retain) NSMutableDictionary *tileProperties;
		[Export ("tileProperties")]
		NSMutableDictionary TileProperties { get; set;  }

		//+(id) formatWithTMXFile:(NSString*)tmxFile;
		[Static]
		[Export ("formatWithTMXFile:")]
		NSObject FormatWithTMXFile (string tmxFile);

		//+(id) formatWithXML:(NSString*)tmxString resourcePath:(NSString*)resourcePath;
		[Static]
		[Export ("formatWithXML:resourcePath:")]
		NSObject FormatWithXML (string tmxString,string resourcePath);

		//-(id) initWithTMXFile:(NSString*)tmxFile;
		[Export ("initWithTMXFile:")]
		IntPtr Constructor (string tmxFile);

		//-(id) initWithXML:(NSString*)tmxString resourcePath:(NSString*)resourcePath;
		[Export ("initWithXML:resourcePath:")]
		IntPtr Constructor (string tmxString,string resourcePath);


	}

	//@interface CCTexture2D : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTexture2D {

		//From Generated Property
		//@property(nonatomic,readonly) CCTexture2DPixelFormat pixelFormat;
		[Export ("pixelFormat")]
		CCTexture2DPixelFormat PixelFormat { get;  }

		//@property(nonatomic,readonly) NSUInteger pixelsWide;
		[Export ("pixelsWide")]
		uint PixelsWide { get;  }

		//@property(nonatomic,readonly) NSUInteger pixelsHigh;
		[Export ("pixelsHigh")]
		uint PixelsHigh { get;  }

		//@property(nonatomic,readonly) GLuint name;
		[Export ("name")]
		GLuint Name { get;  }

		//@property(nonatomic,readonly, nonatomic) CGSize contentSizeInPixels;
		[Export ("contentSizeInPixels")]
		SizeF ContentSizeInPixels { get;  }

		//@property(nonatomic,readwrite) GLfloat maxS;
		[Export ("maxS")]
		float MaxS { get; set;  }

		//@property(nonatomic,readwrite) GLfloat maxT;
		[Export ("maxT")]
		float MaxT { get; set;  }

		//@property(nonatomic,readonly) BOOL hasPremultipliedAlpha;
		[Export ("hasPremultipliedAlpha")]
		bool HasPremultipliedAlpha { get;  }

		//@property(nonatomic,readwrite,retain) CCGLProgram *shaderProgram;
		[Export ("shaderProgram")]
		CCGLProgram ShaderProgram { get; set;  }

		//@property (nonatomic, readwrite) ccResolutionType resolutionType;
		[Export ("resolutionType")]
		ccResolutionType ResolutionType { get; set;  }

		//- (void) releaseData:(void*)data;
		[Export ("releaseData:")]
		void ReleaseData (IntPtr data);

		//- (void*) keepData:(void*)data length:(NSUInteger)length;
		[Export ("keepData:length:")]
		void KeepData (IntPtr data,uint length);

		//-(CGSize) contentSize;
		[Export ("contentSize")]
		SizeF ContentSize ();

		//- (void) drawInRect:(CGRect)rect;
		[Export ("drawInRect:")]
		void DrawInRect (RectangleF rect);

		//- (id) initWithCGImage:(CGImageRef)cgImage;
		[Export ("initWithCGImage:")]
		IntPtr Constructor (CGImageRef cgImage, bool withCGImage);

		//- (id) initWithString:(NSString*)string dimensions:(CGSize)dimensions hAlignment:(CCTextAlignment)alignment vAlignment:(CCVerticalTextAlignment) vertAlignment fontName:(NSString*)name fontSize:(CGFloat)size;
		[Export ("initWithString:dimensions:hAlignment:vAlignment:fontName:fontSize:")]
		IntPtr Constructor (string str,SizeF dimensions,CCTextAlignment hAlignment,CCVerticalTextAlignment vAlignment,string fontName,float fontSize);

		//- (id) initWithString:(NSString*)string fontName:(NSString*)name fontSize:(CGFloat)size;
		[Export ("initWithString:fontName:fontSize:")]
		IntPtr Constructor (string str,string fontName,float fontSize);

		//+(void) PVRImagesHavePremultipliedAlpha:(BOOL)haveAlphaPremultiplied;
		[Static]
		[Export ("PVRImagesHavePremultipliedAlpha:")]
		void PVRImagesHavePremultipliedAlpha (bool haveAlphaPremultiplied);

		//- (void) setAntiAliasTexParameters;
		[Export ("setAntiAliasTexParameters")]
		void SetAntiAliasTexParameters ();

		//- (void) setAliasTexParameters;
		[Export ("setAliasTexParameters")]
		void SetAliasTexParameters ();

		//-(void) generateMipmap;
		[Export ("generateMipmap")]
		void GenerateMipmap ();

		//+(CCTexture2DPixelFormat) defaultAlphaPixelFormat;
		[Static]
		[Export ("defaultAlphaPixelFormat")]
		CCTexture2DPixelFormat DefaultAlphaPixelFormat ();

		//-(NSUInteger) bitsPerPixelForFormat;
		[Export ("bitsPerPixelForFormat")]
		uint BitsPerPixelForFormat ();

		//-(NSString*) stringForFormat;
		[Export ("stringForFormat")]
		string StringForFormat ();

		//+(NSUInteger) bitsPerPixelForFormat:(CCTexture2DPixelFormat)format;
		[Static]
		[Export ("bitsPerPixelForFormat:")]
		uint BitsPerPixelForFormat (CCTexture2DPixelFormat format);


	}

	//@interface CCTextureAtlas : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTextureAtlas {

		//From Generated Property
		//}@property (nonatomic,readonly) NSUInteger totalQuads;
		[Export ("totalQuads")]
		uint TotalQuads { get;  }

		//@property (nonatomic,readonly) NSUInteger capacity;
		[Export ("capacity")]
		uint Capacity { get;  }

		//@property (nonatomic,retain) CCTexture2D *texture;
		[Export ("texture")]
		CCTexture2D Texture { get; set;  }

		//@property (nonatomic,readwrite) ccV3F_C4B_T2F_Quad *quads;
		[Export ("quads")]
		ccV3F_C4B_T2F_Quad Quads { get; set;  }

		//+(id) textureAtlasWithFile:(NSString*)file capacity:(NSUInteger)capacity;
		[Static]
		[Export ("textureAtlasWithFile:capacity:")]
		NSObject TextureAtlasWithFile (string file,uint capacity);

		//-(id) initWithFile: (NSString*) file capacity:(NSUInteger)capacity;
		[Export ("initWithFile:capacity:")]
		IntPtr Constructor (string file,uint capacity);

		//+(id) textureAtlasWithTexture:(CCTexture2D *)tex capacity:(NSUInteger)capacity;
		[Static]
		[Export ("textureAtlasWithTexture:capacity:")]
		NSObject TextureAtlasWithTexture (CCTexture2D tex,uint capacity);

		//-(id) initWithTexture:(CCTexture2D *)tex capacity:(NSUInteger)capacity;
		[Export ("initWithTexture:capacity:")]
		IntPtr Constructor (CCTexture2D tex,uint capacity);

		//-(void) updateQuad:(ccV3F_C4B_T2F_Quad*)quad atIndex:(NSUInteger)index;
		[Export ("updateQuad:atIndex:")]
		void UpdateQuad (ccV3F_C4B_T2F_Quad quad,uint atIndex);

		//-(void) insertQuad:(ccV3F_C4B_T2F_Quad*)quad atIndex:(NSUInteger)index;
		[Export ("insertQuad:atIndex:")]
		void InsertQuad (ccV3F_C4B_T2F_Quad quad,uint atIndex);

		//-(void) insertQuads:(ccV3F_C4B_T2F_Quad*)quads atIndex:(NSUInteger)index amount:(NSUInteger)amount;
		[Export ("insertQuads:atIndex:amount:")]
		void InsertQuads (ccV3F_C4B_T2F_Quad quads,uint atIndex,uint amount);

		//-(void) insertQuadFromIndex:(NSUInteger)fromIndex atIndex:(NSUInteger)newIndex;
		[Export ("insertQuadFromIndex:atIndex:")]
		void InsertQuadFromIndex (uint fromIndex,uint atIndex);

		//-(void) removeQuadAtIndex:(NSUInteger) index;
		[Export ("removeQuadAtIndex:")]
		void RemoveQuadAtIndex (uint index);

		//- (void) removeQuadsAtIndex:(NSUInteger) index amount:(NSUInteger) amount;
		[Export ("removeQuadsAtIndex:amount:")]
		void RemoveQuadsAtIndex (uint index,uint amount);

		//-(void) removeAllQuads;
		[Export ("removeAllQuads")]
		void RemoveAllQuads ();

		//-(BOOL) resizeCapacity: (NSUInteger) n;
		[Export ("resizeCapacity:")]
		bool ResizeCapacity (uint n);

		//- (void) increaseTotalQuadsWith:(NSUInteger) amount;
		[Export ("increaseTotalQuadsWith:")]
		void IncreaseTotalQuadsWith (uint amount);

		//-(void) moveQuadsFromIndex:(NSUInteger)oldIndex amount:(NSUInteger) amount atIndex:(NSUInteger)newIndex;
		[Export ("moveQuadsFromIndex:amount:atIndex:")]
		void MoveQuadsFromIndex (uint oldIndex,uint amount,uint atIndex);

		//- (void) moveQuadsFromIndex:(NSUInteger) index to:(NSUInteger) newIndex;
		[Export ("moveQuadsFromIndex:to:")]
		void MoveQuadsFromIndex (uint index,uint to);

		//- (void) fillWithEmptyQuadsFromIndex:(NSUInteger) index amount:(NSUInteger) amount;
		[Export ("fillWithEmptyQuadsFromIndex:amount:")]
		void FillWithEmptyQuadsFromIndex (uint index,uint amount);

		//-(void) drawNumberOfQuads: (NSUInteger) n;
		[Export ("drawNumberOfQuads:")]
		void DrawNumberOfQuads (uint n);

		//-(void) drawNumberOfQuads: (NSUInteger) n fromIndex: (NSUInteger) start;
		[Export ("drawNumberOfQuads:fromIndex:")]
		void DrawNumberOfQuads (uint n,uint fromIndex);

		//-(void) drawQuads;
		[Export ("drawQuads")]
		void DrawQuads ();


	}
		delegate void CCTextureCacheDelegateAddImageAsyncwithBlock (CCTexture2D tex);

	//@interface CCTextureCache : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTextureCache {

		//From Generated Property
		//+ (CCTextureCache *) sharedTextureCache;
		[Static]
		[Export ("sharedTextureCache")]
		CCTextureCache SharedTextureCache ();

		//+(void)purgeSharedTextureCache;
		[Static]
		[Export ("purgeSharedTextureCache")]
		void PurgeSharedTextureCache ();

		//-(CCTexture2D*) addImage: (NSString*) fileimage;
		[Export ("addImage:")]
		CCTexture2D AddImage (string fileimage);

		//-(void) addImageAsync:(NSString*) filename target:(id)target selector:(SEL)selector;
		[Export ("addImageAsync:target:selector:")]
		void AddImageAsync (string filename,NSObject target,Selector selector);

		//-(void) addImageAsync:(NSString*) filename withBlock:(void(^)(CCTexture2D *tex))block;
		[Export ("addImageAsync:withBlock:")]
		void AddImageAsync (string filename,CCTextureCacheDelegateAddImageAsyncwithBlock _delegate);

		//-(CCTexture2D*) addCGImage: (CGImageRef) image forKey: (NSString *)key;
		[Export ("addCGImage:forKey:")]
		CCTexture2D AddCGImage (CGImageRef image,string forKey);

		//-(CCTexture2D *) textureForKey:(NSString *)key;
		[Export ("textureForKey:")]
		CCTexture2D TextureForKey (string key);

		//-(void) removeAllTextures;
		[Export ("removeAllTextures")]
		void RemoveAllTextures ();

		//-(void) removeUnusedTextures;
		[Export ("removeUnusedTextures")]
		void RemoveUnusedTextures ();

		//-(void) removeTexture: (CCTexture2D*) tex;
		[Export ("removeTexture:")]
		void RemoveTexture (CCTexture2D tex);

		//-(void) removeTextureForKey: (NSString*) textureKeyName;
		[Export ("removeTextureForKey:")]
		void RemoveTextureForKey (string textureKeyName);

		//-(CCTexture2D*) addPVRImage:(NSString*) filename;
		[Export ("addPVRImage:")]
		CCTexture2D AddPVRImage (string filename);


	}

	//@interface CCTexturePVR : NSObject
	[BaseType (typeof (NSObject))]
	interface CCTexturePVR {

		//From Generated Property
		//@property (nonatomic,readonly) GLuint name;
		[Export ("name")]
		GLuint Name { get;  }

		//@property (nonatomic,readonly) uint32_t width;
		[Export ("width")]
		uint32_t Width { get;  }

		//@property (nonatomic,readonly) uint32_t height;
		[Export ("height")]
		uint32_t Height { get;  }

		//@property (nonatomic,readonly) BOOL hasAlpha;
		[Export ("hasAlpha")]
		bool HasAlpha { get;  }

		//@property (nonatomic, readonly) NSUInteger numberOfMipmaps;
		[Export ("numberOfMipmaps")]
		uint NumberOfMipmaps { get;  }

		//@property (nonatomic,readwrite) BOOL retainName;
		[Export ("retainName")]
		bool RetainName { get; set;  }

		//@property (nonatomic,readonly) CCTexture2DPixelFormat format;
		[Export ("format")]
		CCTexture2DPixelFormat Format { get;  }

		//- (id)initWithContentsOfFile:(NSString *)path;
		[Export ("initWithContentsOfFile:")]
		IntPtr Constructor (string path);

		//- (id)initWithContentsOfURL:(NSURL *)url;
		[Export ("initWithContentsOfURL:")]
		IntPtr Constructor (NSUrl url);

		//+ (id)pvrTextureWithContentsOfFile:(NSString *)path;
		[Static]
		[Export ("pvrTextureWithContentsOfFile:")]
		NSObject PvrTextureWithContentsOfFile (string path);

		//+ (id)pvrTextureWithContentsOfURL:(NSURL *)url;
		[Static]
		[Export ("pvrTextureWithContentsOfURL:")]
		NSObject PvrTextureWithContentsOfURL (NSUrl url);


	}

	//@interface CCTileMapAtlas : CCAtlasNode
	[BaseType (typeof (CCAtlasNode))]
	interface CCTileMapAtlas {

		//From Generated Property
		//}@property (nonatomic,readonly) tImageTGA *tgaInfo;
		[Export ("tgaInfo")]
		tImageTGA TgaInfo { get;  }

		//+(id) tileMapAtlasWithTileFile:(NSString*)tile mapFile:(NSString*)map tileWidth:(int)w tileHeight:(int)h;
		[Static]
		[Export ("tileMapAtlasWithTileFile:mapFile:tileWidth:tileHeight:")]
		NSObject TileMapAtlasWithTileFile (string tile,string mapFile,int tileWidth,int tileHeight);

		//-(id) initWithTileFile:(NSString*)tile mapFile:(NSString*)map tileWidth:(int)w tileHeight:(int)h;
		[Export ("initWithTileFile:mapFile:tileWidth:tileHeight:")]
		IntPtr Constructor (string tile,string mapFile,int tileWidth,int tileHeight);

		//-(ccColor3B) tileAt: (ccGridSize) position;
		[Export ("tileAt:")]
		ccColor3B TileAt (ccGridSize position);

		//-(void) setTile:(ccColor3B)tile at:(ccGridSize)position;
		[Export ("setTile:at:")]
		void SetTile (ccColor3B tile,ccGridSize at);

		//-(void) releaseMap;
		[Export ("releaseMap")]
		void ReleaseMap ();


	}

	//@interface CCTransitionScene : CCScene
	[BaseType (typeof (CCScene))]
	interface CCTransitionScene {

		//From Generated Property
		//+(id) transitionWithDuration:(ccTime) t scene:(CCScene*)s;
		[Static]
		[Export ("transitionWithDuration:scene:")]
		NSObject TransitionWithDuration (ccTime t,CCScene scene);

		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s;
		[Export ("initWithDuration:scene:")]
		IntPtr Constructor (ccTime t,CCScene scene);

		//-(void) finish;
		[Export ("finish")]
		void Finish ();

		//-(void) hideOutShowIn;
		[Export ("hideOutShowIn")]
		void HideOutShowIn ();


	}

	//@interface CCTransitionSceneOriented : CCTransitionScene
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionSceneOriented {

		//From Generated Property
		//+(id) transitionWithDuration:(ccTime) t scene:(CCScene*)s orientation:(tOrientation)o;
		[Static]
		[Export ("transitionWithDuration:scene:orientation:")]
		NSObject TransitionWithDuration (ccTime t,CCScene scene,tOrientation orientation);

		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s orientation:(tOrientation)o;
		[Export ("initWithDuration:scene:orientation:")]
		IntPtr Constructor (ccTime t,CCScene scene,tOrientation orientation);


	}

	//@interface CCTransitionRotoZoom : CCTransitionScene
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionRotoZoom {

		//From Generated Property

	}

	//@interface CCTransitionJumpZoom : CCTransitionScene
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionJumpZoom {

		//From Generated Property

	}

	//@interface CCTransitionMoveInL : CCTransitionScene <CCTransitionEaseScene>
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionMoveInL {

		//From Generated Property
		//-(void) initScenes;
		[Export ("initScenes")]
		void InitScenes ();

		//-(CCActionInterval*) action;
		[Export ("action")]
		CCActionInterval Action ();

		//-(CCActionInterval*) easeActionWithAction:(CCActionInterval*)action;
		// From protocol 'CCTransitionEaseScene'
		[Export ("easeActionWithAction:")]
		CCActionInterval EaseActionWithAction (CCActionInterval action);

		// Constructor from 'CCTransitionScene'
		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s;
		[Export ("initWithDuration:scene:")]
		IntPtr Constructor (ccTime t,CCScene scene);


	}

	//@interface CCTransitionMoveInR : CCTransitionMoveInL
	[BaseType (typeof (CCTransitionMoveInL))]
	interface CCTransitionMoveInR {

		//From Generated Property

	}

	//@interface CCTransitionMoveInT : CCTransitionMoveInL
	[BaseType (typeof (CCTransitionMoveInL))]
	interface CCTransitionMoveInT {

		//From Generated Property

	}

	//@interface CCTransitionMoveInB : CCTransitionMoveInL
	[BaseType (typeof (CCTransitionMoveInL))]
	interface CCTransitionMoveInB {

		//From Generated Property

	}

	//@interface CCTransitionSlideInL : CCTransitionScene <CCTransitionEaseScene>
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionSlideInL {

		//From Generated Property
		//-(void) initScenes;
		[Export ("initScenes")]
		void InitScenes ();

		//-(CCActionInterval*) action;
		[Export ("action")]
		CCActionInterval Action ();

		//-(CCActionInterval*) easeActionWithAction:(CCActionInterval*)action;
		// From protocol 'CCTransitionEaseScene'
		[Export ("easeActionWithAction:")]
		CCActionInterval EaseActionWithAction (CCActionInterval action);

		// Constructor from 'CCTransitionScene'
		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s;
		[Export ("initWithDuration:scene:")]
		IntPtr Constructor (ccTime t,CCScene scene);


	}

	//@interface CCTransitionSlideInR : CCTransitionSlideInL
	[BaseType (typeof (CCTransitionSlideInL))]
	interface CCTransitionSlideInR {

		//From Generated Property

	}

	//@interface CCTransitionSlideInB : CCTransitionSlideInL
	[BaseType (typeof (CCTransitionSlideInL))]
	interface CCTransitionSlideInB {

		//From Generated Property

	}

	//@interface CCTransitionSlideInT : CCTransitionSlideInL
	[BaseType (typeof (CCTransitionSlideInL))]
	interface CCTransitionSlideInT {

		//From Generated Property

	}

	//@interface CCTransitionShrinkGrow : CCTransitionScene <CCTransitionEaseScene>
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionShrinkGrow {

		//From Generated Property
		//-(CCActionInterval*) easeActionWithAction:(CCActionInterval*)action;
		// From protocol 'CCTransitionEaseScene'
		[Export ("easeActionWithAction:")]
		CCActionInterval EaseActionWithAction (CCActionInterval action);

		// Constructor from 'CCTransitionScene'
		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s;
		[Export ("initWithDuration:scene:")]
		IntPtr Constructor (ccTime t,CCScene scene);


	}

	//@interface CCTransitionFlipX : CCTransitionSceneOriented
	[BaseType (typeof (CCTransitionSceneOriented))]
	interface CCTransitionFlipX {

		//From Generated Property

	}

	//@interface CCTransitionFlipY : CCTransitionSceneOriented
	[BaseType (typeof (CCTransitionSceneOriented))]
	interface CCTransitionFlipY {

		//From Generated Property

	}

	//@interface CCTransitionFlipAngular : CCTransitionSceneOriented
	[BaseType (typeof (CCTransitionSceneOriented))]
	interface CCTransitionFlipAngular {

		//From Generated Property

	}

	//@interface CCTransitionZoomFlipX : CCTransitionSceneOriented
	[BaseType (typeof (CCTransitionSceneOriented))]
	interface CCTransitionZoomFlipX {

		//From Generated Property

	}

	//@interface CCTransitionZoomFlipY : CCTransitionSceneOriented
	[BaseType (typeof (CCTransitionSceneOriented))]
	interface CCTransitionZoomFlipY {

		//From Generated Property

	}

	//@interface CCTransitionZoomFlipAngular : CCTransitionSceneOriented
	[BaseType (typeof (CCTransitionSceneOriented))]
	interface CCTransitionZoomFlipAngular {

		//From Generated Property

	}

	//@interface CCTransitionFade : CCTransitionScene
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionFade {

		//From Generated Property
		//+(id) transitionWithDuration:(ccTime)duration scene:(CCScene*)scene withColor:(ccColor3B)color;
		[Static]
		[Export ("transitionWithDuration:scene:withColor:")]
		NSObject TransitionWithDuration (ccTime duration,CCScene scene,ccColor3B withColor);

		//-(id) initWithDuration:(ccTime)duration scene:(CCScene*)scene withColor:(ccColor3B)color;
		[Export ("initWithDuration:scene:withColor:")]
		IntPtr Constructor (ccTime duration,CCScene scene,ccColor3B withColor);


	}

	//@interface CCTransitionCrossFade : CCTransitionScene
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionCrossFade {

		//From Generated Property

	}

	//@interface CCTransitionTurnOffTiles : CCTransitionScene <CCTransitionEaseScene>
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionTurnOffTiles {

		//From Generated Property
		//-(CCActionInterval*) easeActionWithAction:(CCActionInterval*)action;
		// From protocol 'CCTransitionEaseScene'
		[Export ("easeActionWithAction:")]
		CCActionInterval EaseActionWithAction (CCActionInterval action);

		// Constructor from 'CCTransitionScene'
		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s;
		[Export ("initWithDuration:scene:")]
		IntPtr Constructor (ccTime t,CCScene scene);


	}

	//@interface CCTransitionSplitCols : CCTransitionScene <CCTransitionEaseScene>
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionSplitCols {

		//From Generated Property
		//-(CCActionInterval*) easeActionWithAction:(CCActionInterval*)action;
		// From protocol 'CCTransitionEaseScene'
		[Export ("easeActionWithAction:")]
		CCActionInterval EaseActionWithAction (CCActionInterval action);

		// Constructor from 'CCTransitionScene'
		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s;
		[Export ("initWithDuration:scene:")]
		IntPtr Constructor (ccTime t,CCScene scene);


	}

	//@interface CCTransitionSplitRows : CCTransitionSplitCols
	[BaseType (typeof (CCTransitionSplitCols))]
	interface CCTransitionSplitRows {

		//From Generated Property

	}

	//@interface CCTransitionFadeTR : CCTransitionScene <CCTransitionEaseScene>
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionFadeTR {

		//From Generated Property
		//-(CCActionInterval*) easeActionWithAction:(CCActionInterval*)action;
		// From protocol 'CCTransitionEaseScene'
		[Export ("easeActionWithAction:")]
		CCActionInterval EaseActionWithAction (CCActionInterval action);

		// Constructor from 'CCTransitionScene'
		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s;
		[Export ("initWithDuration:scene:")]
		IntPtr Constructor (ccTime t,CCScene scene);


	}

	//@interface CCTransitionFadeBL : CCTransitionFadeTR
	[BaseType (typeof (CCTransitionFadeTR))]
	interface CCTransitionFadeBL {

		//From Generated Property

	}

	//@interface CCTransitionFadeUp : CCTransitionFadeTR
	[BaseType (typeof (CCTransitionFadeTR))]
	interface CCTransitionFadeUp {

		//From Generated Property

	}

	//@interface CCTransitionFadeDown : CCTransitionFadeTR
	[BaseType (typeof (CCTransitionFadeTR))]
	interface CCTransitionFadeDown {

		//From Generated Property

	}

	//@interface CCTransitionPageTurn : CCTransitionScene
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionPageTurn {

		//From Generated Property
		//+(id) transitionWithDuration:(ccTime) t scene:(CCScene*)s backwards:(BOOL) back;
		[Static]
		[Export ("transitionWithDuration:scene:backwards:")]
		NSObject TransitionWithDuration (ccTime t,CCScene scene,bool backwards);

		//-(id) initWithDuration:(ccTime) t scene:(CCScene*)s backwards:(BOOL) back;
		[Export ("initWithDuration:scene:backwards:")]
		IntPtr Constructor (ccTime t,CCScene scene,bool backwards);

		//-(CCActionInterval*) actionWithSize:(ccGridSize) vector;
		[Export ("actionWithSize:")]
		CCActionInterval ActionWithSize (ccGridSize vector);


	}

	//@interface CCTransitionProgress : CCTransitionScene
	[BaseType (typeof (CCTransitionScene))]
	interface CCTransitionProgress {

		//From Generated Property

	}

	//@interface CCTransitionProgressRadialCCW : CCTransitionProgress
	[BaseType (typeof (CCTransitionProgress))]
	interface CCTransitionProgressRadialCCW {

		//From Generated Property

	}

	//@interface CCTransitionProgressHorizontal : CCTransitionProgress
	[BaseType (typeof (CCTransitionProgress))]
	interface CCTransitionProgressHorizontal {

		//From Generated Property

	}

	//@interface CCTransitionProgressInOut : CCTransitionProgress
	[BaseType (typeof (CCTransitionProgress))]
	interface CCTransitionProgressInOut {

		//From Generated Property

	}

	//@interface EAGLView : CCGLView
	[BaseType (typeof (CCGLView))]
	interface EAGLView {

		//From Generated Property

	}

	//@interface CCTouchDispatcher (Deprecated)
	[BaseType (typeof (NSObject))]
	interface CCTouchDispatcher {

		//From Generated Property

	}

	//@interface CCEventDispatcher (Deprecated)
	[BaseType (typeof (NSObject))]
	interface CCEventDispatcher {

		//From Generated Property
		//@property (nonatomic, readwrite) BOOL dispatchEvents;
		[Export ("dispatchEvents")]
		bool DispatchEvents { get; set;  }

		//-(void) addMouseDelegate:(id<CCMouseEventDelegate>) delegate priority:(NSInteger)priority;
		[Export ("addMouseDelegate:priority:")]
		void AddMouseDelegate (NSObject del,int priority);

		//-(void) removeMouseDelegate:(id) delegate;
		[Export ("removeMouseDelegate:")]
		void RemoveMouseDelegate (NSObject del);

		//-(void) removeAllMouseDelegates;
		[Export ("removeAllMouseDelegates")]
		void RemoveAllMouseDelegates ();

		//-(void) addKeyboardDelegate:(id<CCKeyboardEventDelegate>) delegate priority:(NSInteger)priority;
		[Export ("addKeyboardDelegate:priority:")]
		void AddKeyboardDelegate (NSObject del,int priority);

		//-(void) removeKeyboardDelegate:(id) delegate;
		[Export ("removeKeyboardDelegate:")]
		void RemoveKeyboardDelegate (NSObject del);

		//-(void) removeAllKeyboardDelegates;
		[Export ("removeAllKeyboardDelegates")]
		void RemoveAllKeyboardDelegates ();

		//- (void)addTouchDelegate:(id<CCTouchEventDelegate>)delegate priority:(NSInteger)priority;
		[Export ("addTouchDelegate:priority:")]
		void AddTouchDelegate (NSObject del,int priority);

		//- (void)removeTouchDelegate:(id) delegate;
		[Export ("removeTouchDelegate:")]
		void RemoveTouchDelegate (NSObject del);

		//- (void)removeAllTouchDelegates;
		[Export ("removeAllTouchDelegates")]
		void RemoveAllTouchDelegates ();

		//-(void) dispatchEvent:(CCEventObject*)event;
		[Export ("dispatchEvent:")]
		void DispatchEvent (CCEventObject evt);


	}

	//@interface CCFileUtils (Deprecated)
	[BaseType (typeof (NSObject))]
	interface CCFileUtils {

		//From Generated Property

	}

	//@interface CCDirectorMac : CCDirector
	[BaseType (typeof (CCDirector))]
	interface CCDirectorMac {

		//From Generated Property
		//}@property (nonatomic, readonly) BOOL isFullScreen;
		[Export ("isFullScreen")]
		bool IsFullScreen { get;  }

		//@property (nonatomic, readwrite) int resizeMode;
		[Export ("resizeMode")]
		int ResizeMode { get; set;  }

		//@property (nonatomic, readwrite) CGSize originalWinSize;
		[Export ("originalWinSize")]
		SizeF OriginalWinSize { get; set;  }

		//- (void) setFullScreen:(BOOL)fullscreen;
		[Export ("setFullScreen:")]
		void SetFullScreen (bool fullscreen);

		//- (CGPoint) convertToLogicalCoordinates:(CGPoint)coordinates;
		[Export ("convertToLogicalCoordinates:")]
		PointF ConvertToLogicalCoordinates (PointF coordinates);


	}

	//@interface CCDirectorDisplayLink : CCDirectorMac
	[BaseType (typeof (CCDirectorMac))]
	interface CCDirectorDisplayLink {

		//From Generated Property

	}

	//@interface CCEventObject : NSObject
	[BaseType (typeof (NSObject))]
	interface CCEventObject {

		//From Generated Property

	}

	//@interface CCGLView : NSOpenGLView {
	[BaseType (typeof (NSOpenGLView))]
	interface CCGLView {

		//From Generated Property
		//@property (nonatomic, readwrite, assign) id eventDelegate;
		[Export ("eventDelegate")]
		NSObject EventDelegate { get; set;  }

		//- (id) initWithFrame:(NSRect)frameRect shareContext:(NSOpenGLContext*)context;
		[Export ("initWithFrame:shareContext:")]
		IntPtr Constructor (RectangleF frameRect,NSOpenGLContext shareContext);

		//-(void) lockOpenGLContext;
		[Export ("lockOpenGLContext")]
		void LockOpenGLContext ();

		//-(void) unlockOpenGLContext;
		[Export ("unlockOpenGLContext")]
		void UnlockOpenGLContext ();

		//- (NSUInteger) depthFormat;
		[Export ("depthFormat")]
		uint DepthFormat ();

		//+(void) load_;
		[Static]
		[Export ("load_")]
		void Load_ ();


	}

	//@interface CCWindow : NSWindow
	[BaseType (typeof (NSWindow))]
	interface CCWindow {

		//From Generated Property
		//- (id) initWithFrame:(NSRect)frame fullscreen:(BOOL)fullscreen;
		[Export ("initWithFrame:fullscreen:")]
		IntPtr Constructor (RectangleF frame,bool fullscreen);


	}

	//@interface CCArray : NSObject <NSFastEnumeration, NSCoding, NSCopying>
	[BaseType (typeof (NSObject))]
	interface CCArray {

		//From Generated Property
		//+ (id) array;
		[Static]
		[Export ("array")]
		NSObject Array ();

		//+ (id) arrayWithCapacity:(NSUInteger)capacity;
		[Static]
		[Export ("arrayWithCapacity:")]
		NSObject ArrayWithCapacity (uint capacity);

		//+ (id) arrayWithArray:(CCArray*)otherArray;
		[Static]
		[Export ("arrayWithArray:")]
		NSObject ArrayWithArray (CCArray otherArray);

		//+ (id) arrayWithNSArray:(NSArray*)otherArray;
		[Static]
		[Export ("arrayWithNSArray:")]
		NSObject ArrayWithNSArray (NSArray otherArray);

		//- (id) initWithCapacity:(NSUInteger)capacity;
		[Export ("initWithCapacity:")]
		IntPtr Constructor (uint capacity);

		//- (id) initWithArray:(CCArray*)otherArray;
		[Export ("initWithArray:")]
		IntPtr Constructor (CCArray otherArray);

		//- (id) initWithNSArray:(NSArray*)otherArray;
		[Export ("initWithNSArray:")]
		IntPtr Constructor (NSArray otherArray);

		//- (NSUInteger) count;
		[Export ("count")]
		uint Count ();

		//- (NSUInteger) capacity;
		[Export ("capacity")]
		uint Capacity ();

		//- (NSUInteger) indexOfObject:(id)object;
		[Export ("indexOfObject:")]
		uint IndexOfObject (NSObject obj);

		//- (id) objectAtIndex:(NSUInteger)index;
		[Export ("objectAtIndex:")]
		NSObject ObjectAtIndex (uint index);

		//- (BOOL) containsObject:(id)object;
		[Export ("containsObject:")]
		bool ContainsObject (NSObject obj);

		//- (id) randomObject;
		[Export ("randomObject")]
		NSObject RandomObject ();

		//- (id) lastObject;
		[Export ("lastObject")]
		NSObject LastObject ();

		//- (NSArray*) getNSArray;
		[Export ("getNSArray")]
		NSArray GetNSArray ();

		//- (BOOL) isEqualToArray:(CCArray*)otherArray;
		[Export ("isEqualToArray:")]
		bool IsEqualToArray (CCArray otherArray);

		//- (void) addObject:(id)object;
		[Export ("addObject:")]
		void AddObject (NSObject obj);

		//- (void) addObjectsFromArray:(CCArray*)otherArray;
		[Export ("addObjectsFromArray:")]
		void AddObjectsFromArray (CCArray otherArray);

		//- (void) addObjectsFromNSArray:(NSArray*)otherArray;
		[Export ("addObjectsFromNSArray:")]
		void AddObjectsFromNSArray (NSArray otherArray);

		//- (void) insertObject:(id)object atIndex:(NSUInteger)index;
		[Export ("insertObject:atIndex:")]
		void InsertObject (NSObject obj,uint atIndex);

		//- (void) removeLastObject;
		[Export ("removeLastObject")]
		void RemoveLastObject ();

		//- (void) removeObject:(id)object;
		[Export ("removeObject:")]
		void RemoveObject (NSObject obj);

		//- (void) removeObjectAtIndex:(NSUInteger)index;
		[Export ("removeObjectAtIndex:")]
		void RemoveObjectAtIndex (uint index);

		//- (void) removeObjectsInArray:(CCArray*)otherArray;
		[Export ("removeObjectsInArray:")]
		void RemoveObjectsInArray (CCArray otherArray);

		//- (void) removeAllObjects;
		[Export ("removeAllObjects")]
		void RemoveAllObjects ();

		//- (void) fastRemoveObject:(id)object;
		[Export ("fastRemoveObject:")]
		void FastRemoveObject (NSObject obj);

		//- (void) fastRemoveObjectAtIndex:(NSUInteger)index;
		[Export ("fastRemoveObjectAtIndex:")]
		void FastRemoveObjectAtIndex (uint index);

		//- (void) exchangeObject:(id)object1 withObject:(id)object2;
		[Export ("exchangeObject:withObject:")]
		void ExchangeObject (NSObject object1,NSObject withObject);

		//- (void) exchangeObjectAtIndex:(NSUInteger)index1 withObjectAtIndex:(NSUInteger)index2;
		[Export ("exchangeObjectAtIndex:withObjectAtIndex:")]
		void ExchangeObjectAtIndex (uint index1,uint withObjectAtIndex);

		//- (void) replaceObjectAtIndex:(NSUInteger)index withObject:(id)anObject;
		[Export ("replaceObjectAtIndex:withObject:")]
		void ReplaceObjectAtIndex (uint index,NSObject withObject);

		//- (void) reverseObjects;
		[Export ("reverseObjects")]
		void ReverseObjects ();

		//- (void) reduceMemoryFootprint;
		[Export ("reduceMemoryFootprint")]
		void ReduceMemoryFootprint ();

		//- (void) insertionSort:(SEL)selector; 
		[Export ("insertionSort:")]
		void InsertionSort (Selector selector);

		//- (void) makeObjectsPerformSelector:(SEL)aSelector;
		[Export ("makeObjectsPerformSelector:")]
		void MakeObjectsPerformSelector (Selector aSelector);

		//- (void) makeObjectsPerformSelector:(SEL)aSelector withObject:(id)object;
		[Export ("makeObjectsPerformSelector:withObject:")]
		void MakeObjectsPerformSelector (Selector aSelector,NSObject withObject);

		//- (void) makeObjectPerformSelectorWithArrayObjects:(id)object selector:(SEL)aSelector; 
		[Export ("makeObjectPerformSelectorWithArrayObjects:selector:")]
		void MakeObjectPerformSelectorWithArrayObjects (NSObject obj,Selector selector);


	}
}
