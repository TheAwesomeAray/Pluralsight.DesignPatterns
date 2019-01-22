using System.ComponentModel;

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
        public MainViewModel()
        {
            ModelPerson = LoadPerson();
        }

        public MainViewModel(Person person)
        {
            _ModelPerson = person;
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
}
