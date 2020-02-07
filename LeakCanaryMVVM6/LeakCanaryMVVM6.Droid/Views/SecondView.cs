using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace LeakCanaryMVVM6.Droid.Views
{
    [Activity(Label = "View for SecondView")]
    public class SecondView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Second);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            // Dispose the activity itself
            Dispose();
        }
    }
}
