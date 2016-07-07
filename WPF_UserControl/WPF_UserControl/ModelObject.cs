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
            set { PropertyChanged(this, new PropertyChangedEventArgs("Shoesize")); }
        }

        public double Height
        {
            get;
            set;
        }
    }
}
