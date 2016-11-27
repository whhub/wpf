using System.ComponentModel;

namespace Binding
{
    internal class Student : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public int Id { get; set; }
        public int Age { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}