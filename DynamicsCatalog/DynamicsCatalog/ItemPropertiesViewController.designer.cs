// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DynamicsCatalog
{
    [Register ("ItemPropertiesViewController")]
    partial class ItemPropertiesViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView square1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView square2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (square1 != null) {
                square1.Dispose ();
                square1 = null;
            }

            if (square2 != null) {
                square2.Dispose ();
                square2 = null;
            }
        }
    }
}