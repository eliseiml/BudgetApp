using System;
using BudgetApp.Controls;
using BudgetApp.PageModels;
using Xamarin.Forms;

namespace BudgetApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EditIncomeAmount_Tapped(object sender, EventArgs e)
        {
            MonthlyIncome.Focus();
            MonthlyIncome.CursorPosition = MonthlyIncome.Text.Length;
        }
        
    }
}