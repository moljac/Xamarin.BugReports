// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace HelloWorld.MonoTouch
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonSerializeXml { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSeralizeBinarySizeOptimized { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton buttonSerializeBinaryBurst { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonSerializeXml != null) {
				buttonSerializeXml.Dispose ();
				buttonSerializeXml = null;
			}

			if (buttonSeralizeBinarySizeOptimized != null) {
				buttonSeralizeBinarySizeOptimized.Dispose ();
				buttonSeralizeBinarySizeOptimized = null;
			}

			if (buttonSerializeBinaryBurst != null) {
				buttonSerializeBinaryBurst.Dispose ();
				buttonSerializeBinaryBurst = null;
			}
		}
	}
}
