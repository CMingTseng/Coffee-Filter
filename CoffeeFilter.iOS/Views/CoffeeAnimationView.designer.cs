// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CoffeeFilter.iOS
{
	[Register ("CoffeeAnimationView")]
	partial class CoffeeAnimationView
	{
		[Outlet]
		UIKit.UIImageView CoffeeImage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CoffeeImage != null) {
				CoffeeImage.Dispose ();
				CoffeeImage = null;
			}
		}
	}
}
