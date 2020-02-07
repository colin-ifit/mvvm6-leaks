using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace LeakCanaryMVVM6.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {

        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            _navigationService = navigationService;

            NavigateCommand = new MvxAsyncCommand(() => _navigationService.Navigate<SecondViewModel>());
        }

        public IMvxAsyncCommand NavigateCommand { get; private set; }
    }
}
