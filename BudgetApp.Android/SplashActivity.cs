using Android.App;
using Android.Content.PM;
using Android.OS;
using Java.Lang;

namespace BudgetApp.Droid
{
    [Activity(Label = "Budget App", 
        Icon = "@mipmap/icon", 
        Theme = "@style/SplashTheme", 
        MainLauncher = true,
        NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Thread.Sleep(1000);
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            OverridePendingTransition(0, 0);
        }
    }
}