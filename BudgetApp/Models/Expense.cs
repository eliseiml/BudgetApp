using Prism.Mvvm;

namespace BudgetApp.Models
{
    public class Expense: BindableBase
    {
        private decimal _amount;

        public decimal Amount
        {
            get => _amount;
            set
            {
                SetProperty(ref _amount, value);
                RaisePropertyChanged(nameof(Amount));
            }
        }
        public string Name { get; set; }
    }
}