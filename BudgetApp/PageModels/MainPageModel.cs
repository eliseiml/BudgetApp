using System.Collections.ObjectModel;
using BudgetApp.Models;
using Prism.Commands;
using Prism.Navigation;

namespace BudgetApp.PageModels
{
    public class MainPageModel: BasePageModel
    {
        #region Fields & Properties

        private decimal _monthlyIncome;
        public decimal MonthlyIncome
        {
            get => _monthlyIncome;
            set
            {
                SetProperty(ref _monthlyIncome, value);
                RaisePropertyChanged(nameof(MonthlyIncome));
            }
        }

        private decimal _totalSpent;
        public decimal TotalSpent
        {
            get => _totalSpent;
            set
            {
                SetProperty(ref _totalSpent, value);
                RaisePropertyChanged(nameof(TotalSpent));
            }
        }

        private decimal _remainingBalance;
        public decimal RemainingBalance
        {
            get => _remainingBalance;
            set
            {
                SetProperty(ref _remainingBalance, value);
                RaisePropertyChanged(nameof(RemainingBalance));
            }
        }
        public ObservableCollection<Expense> Expenses { get; set; }
        public DelegateCommand CalculateCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }

        #endregion

        #region Constructors & Inits
        
        public MainPageModel(INavigationService navigationService) : base(navigationService)
        {
            MonthlyIncome = 0;
            InitExpenses();

            CalculateCommand = new DelegateCommand(OnCalculate);
            ClearCommand = new DelegateCommand(OnClear);
        }

        #endregion

        #region Public methods
        #endregion

        #region Private & Protected methods

        private void InitExpenses()
        {
            Expenses = new ObservableCollection<Expense>()
            {
                new Expense() {Name = "Food", Amount = 0},
                new Expense() {Name = "Family", Amount = 0},
                new Expense() {Name = "Home", Amount = 0},
                new Expense() {Name = "Office", Amount = 0},
                new Expense() {Name = "Health care", Amount = 0}
            };
        }
        
        private void OnCalculate()
        {
            TotalSpent = 0;
            foreach (var e in Expenses)
            {
                TotalSpent += e.Amount;
            }
            RemainingBalance = MonthlyIncome - TotalSpent;
        }
        private void OnClear()
        {
            MonthlyIncome = 0;
            foreach (var e in Expenses)
            {
                e.Amount = 0;
            }
            OnCalculate();
        }

        #endregion

    }
}