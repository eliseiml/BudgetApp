using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetApp.DataTemplates
{
    public partial class ExpenseTile
    {
        public ExpenseTile()
        {
            InitializeComponent();
        }
        
        private void EditAmount_Tapped(object sender, EventArgs e)
        {
            Amount.Focus();
            Amount.CursorPosition = Amount.Text.Length;
        }
    }
}