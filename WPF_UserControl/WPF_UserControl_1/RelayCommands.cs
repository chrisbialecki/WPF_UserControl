using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_UserControl_1
{
   public class RelayCommands
    {
        CommandOpenNewWindow _myCommand = new CommandOpenNewWindow();
        public CommandOpenNewWindow MyCommand
        {
            get { return _myCommand; }
        }
    }
}
