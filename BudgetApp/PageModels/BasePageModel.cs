using Prism.Mvvm;
using Prism.Navigation;

namespace BudgetApp.PageModels
{
    public abstract class BasePageModel: BindableBase
    {
        private readonly INavigationService _navigationService;

        public BasePageModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}