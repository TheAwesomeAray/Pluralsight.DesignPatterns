using System;
using System.ComponentModel;

namespace Pluralsight.DesignPatterns.MVVM
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private DateTime _UpdatedDate;

        public DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set
            {
                _UpdatedDate = value;
                OnPropertyChanged("UpdatedDate");
            }
        }

        public string Error => null;

        public string this[string columnName] => string.IsNullOrEmpty(_FirstName) ? "First Name is required." : string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
