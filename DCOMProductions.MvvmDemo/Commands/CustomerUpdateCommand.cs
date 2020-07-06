using DCOMProductions.MvvmDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DCOMProductions.MvvmDemo.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }
        private CustomerViewModel ViewModel;
        #region ICommand Members

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }

        }

        public bool CanExecute(object parameter)
        {
            return String.IsNullOrWhiteSpace(ViewModel.Customer.Error);
        }

        public void Execute(object parameter)
        {
            ViewModel.SaveChanges();
        }
        #endregion
    }
}
