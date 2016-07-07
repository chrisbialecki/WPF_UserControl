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

        public int Shoesize
        {
            get;
            set;
        }

        public double Height
        {
            get;
            set;
        }
    }
}
