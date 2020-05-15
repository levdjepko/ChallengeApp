// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace hundredDaysOf
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel challengeName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton selectChallengeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textForChallenge { get; set; }

        [Action ("empty:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void empty (UIKit.UITextField sender);

        [Action ("SelectChallengeButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SelectChallengeButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (challengeName != null) {
                challengeName.Dispose ();
                challengeName = null;
            }

            if (selectChallengeButton != null) {
                selectChallengeButton.Dispose ();
                selectChallengeButton = null;
            }

            if (textForChallenge != null) {
                textForChallenge.Dispose ();
                textForChallenge = null;
            }
        }
    }
}