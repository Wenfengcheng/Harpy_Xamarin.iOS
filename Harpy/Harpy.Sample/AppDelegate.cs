using Foundation;
using UIKit;
using Harpy;

namespace Harpy.Sample
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            this.Window.MakeKeyAndVisible();

            Harpy.SharedInstance.PresentingViewController = this.Window.RootViewController;
            Harpy.SharedInstance.WeakDelegate = this;
            //Harpy.SharedInstance.AlertType = HarpyAlertType.Skip;
            Harpy.SharedInstance.PatchUpdateAlertType = HarpyAlertType.Option;
            Harpy.SharedInstance.MinorUpdateAlertType = HarpyAlertType.Skip;
            Harpy.SharedInstance.MajorUpdateAlertType = HarpyAlertType.Force;
            Harpy.SharedInstance.RevisionUpdateAlertType = HarpyAlertType.Option;
            Harpy.SharedInstance.DebugEnabled = true;
            Harpy.SharedInstance.CountryCode = "CN";
            Harpy.SharedInstance.ForceLanguageLocalization = Constants.HarpyLanguageChineseSimplified;

            Harpy.SharedInstance.CheckVersion();
            return true;
        }

        public override void OnActivated(UIApplication application)
        {

            /*
             Perform daily check for new version of your app
             Useful if user returns to you app from background after extended period of time
             Place in applicationDidBecomeActive:

             Also, performs version check on first launch.
            */
            //Harpy.SharedInstance.CheckVersionDaily();

            /*
             Perform weekly check for new version of your app
             Useful if you user returns to your app from background after extended period of time
             Place in applicationDidBecomeActive:

             Also, performs version check on first launch.
            */
            //Harpy.SharedInstance.CheckVersionWeekly();
        }

    }
}

