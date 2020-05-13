using Foundation;
using System;
using UIKit;

namespace hundredDaysOf
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton590_TouchUpInside(UIButton sender)
        {
            challengeName.Text = "Your challenge for next 100 days is " + textForChallenge.Text;
            challengeName.Hidden = false;
        }

        partial void empty(UITextField sender)
        {
            textForChallenge.Text = String.Empty;
        }
    }
}