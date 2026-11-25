using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf1.Controller
{
    internal class Cmd : ICommand
    {

        public Action<object> _execute { get; set; }
        public Predicate<object> _canexecute { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Cmd(Action<object> execute, Predicate<object> canexecute)
        {
            this._execute = execute;
            this._canexecute = canexecute;
        }

        public bool CanExecute(object parameter)
        {
            return this._canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            this._execute.Invoke(parameter);
        }
    }
}
