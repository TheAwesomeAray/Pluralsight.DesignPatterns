using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Pluralsight.DesignPatterns.MVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Person _ModelPerson;

        public Person ModelPerson
        {
            get { return _ModelPerson; }
            set
            {
                _ModelPerson = value;
                OnPropertyChanged("ModelPerson");
            }
        }

        private ICommand _SavePersonCommand;
        public ICommand SavePersonCommand
        {
            get { return _SavePersonCommand; }
            set
            {
                _SavePersonCommand = value;
                OnPropertyChanged("SavePersonCommand");
            }
        }


        public MainViewModel()
        {
            InitializeCommand();
            ModelPerson = LoadPerson();
        }

        private void InitializeCommand()
        {
            _SavePersonCommand = new SavePersonCommand(UpdatePerson);
        }

        private void UpdatePerson()
        {
            ModelPerson.UpdatedDate = DateTime.Now;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private Person LoadPerson()
        {
            return new Person()
            {
                FirstName = "Andrew",
                LastName = "Ray"
            };
        }
    }

    public class SavePersonCommand : ICommand
    {
        Action _executeMethod;
        public event EventHandler CanExecuteChanged;

        public SavePersonCommand(Action executeMethod)
        {
            _executeMethod = executeMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeMethod.Invoke();
        }
    }
}
