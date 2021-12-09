using System;
using System.Diagnostics;
using BudgetApp.PageModels;
using BudgetApp.Pages;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace BudgetApp
{
    public partial class App
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }
        
        protected override async void OnInitialized()
        {
            InitializeComponent();
            
            var result = await NavigationService.NavigateAsync(nameof(MainPage));

            if (!result.Success)
            {
                Debugger.Break();
            }
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageModel>();
        }
    }
}
