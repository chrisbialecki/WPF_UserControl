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

        public bool CanExecute(object parameter)
        {
            var _student = StudentModel.GetStudentModel();
            return _student.LastName != null && _student.FirstName != null && _student.Age != null;
           
           

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
            
        }

        public void Execute(object parameter)
        {
            var _window2 = new Window2();
            _window2.Show();
        }
    }
}
