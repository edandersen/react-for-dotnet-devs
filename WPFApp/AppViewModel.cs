using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFApp
{
    public class AppViewModel : INotifyPropertyChanged
    {
        public AppViewModel(int initialCounterValue)
        {
            _counter = initialCounterValue;
        }

        private int _counter;

        public int Counter
        {
            get
            {
                return _counter;
            }
            set
            {
                _counter = value;
                OnPropertyChanged("Counter");
            }
        }

        public ICommand Increment => new RelayCommand((p) => { Counter++; });

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
