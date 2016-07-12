using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_UserControl_1
{
    public class CommandOpenNewWindow : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }                    
        }


        public bool CanExecute(object parameter)
        {
            var _studentDetails = StudentModel.GetStudentModel();
            return _studentDetails.Age != null && _studentDetails.FirstName != null && _studentDetails.LastName != null;
        }

        public void Execute(object parameter)
        {
            var _window2 = new Window2();
            _window2.Show();
        }
    }
}
