using Android.App;
using MvvmCross.Droid.Views;

namespace LeakCanaryMVVM6.Droid.Views
{
    [Activity(Label = "MainView")]
    public class MainView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Main);
        }
    }
}
