using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_UserControl
{
    public class ModelObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int _shoesize;

        public int Shoesize
        {
            get { return _shoesize; }
            set
            {
                _shoesize = value;
                OnPropertyChanged("Shoesize");
            }
        }

        public double Height
        {
            get;
            set;
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
