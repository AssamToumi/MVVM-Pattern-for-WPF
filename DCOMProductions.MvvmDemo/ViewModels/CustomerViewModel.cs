using DCOMProductions.MvvmDemo.Commands;
using DCOMProductions.MvvmDemo.Models;
using DCOMProductions.MvvmDemo.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DCOMProductions.MvvmDemo.ViewModels
{
    internal class CustomerViewModel
    {
        private Customer customer;
        private CustomerInfoViewModel childViewModel;
        public CustomerViewModel()
        {
            customer = new Customer("Assam");
            childViewModel = new CustomerInfoViewModel() { Info = "Instantiated in CustomerViewModel() ctor." };
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        public Customer Customer
        {
            get
            {
                return customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }


        public void SaveChanges()
        {
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = childViewModel;

            //  childViewModel.Info = Customer.Name + " Was Updated in the database";
            view.ShowDialog();
        }
    }
}