using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DCOMProductions.MvvmDemo.Models
{
    public class Customer : INotifyPropertyChanged, IDataErrorInfo
    {
        public Customer(String customerName)
        {
            Name = customerName;
        }
        private string name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region IDataErrorInfo Members
        public string Error
        {
            get;
            private set;
        }
        public string this[string columnName]
        {
            get
            {
                if (columnName == "Name")
                {
                    if (String.IsNullOrWhiteSpace(Name))
                    {
                        Error = "Name cannot be null or emplty";
                    }
                    else
                    {
                        Error = null;
                    }
                }
                return Error;
            }
        }
        #endregion
    }
}
