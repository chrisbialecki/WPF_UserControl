using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace WPF_UserControl_1
{
    public class StudentModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        string _firstName;
        string _lastName;
        int? _age;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FullName");
                OnPropertyChanged("FirstName");
            }

            
                    
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("FullName");
                OnPropertyChanged("LastName");
            }
        }


        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public int? Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
            
        }

        static StudentModel _studentModel;

        public static StudentModel GetStudentModel()
        {
            if (_studentModel == null)
                _studentModel = new StudentModel();
            return _studentModel;

        }

        
            
        
    }
}
