using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculadoraWPF
{
    internal class Exec : ICommand
    {
        private Action<Object> _execute {  get; set; }
        private Predicate<Object> _canexecute {  get; set; }

        public Exec(Action<object> execute, Predicate<object> canexecute)
        {
            _execute = execute;
            _canexecute = canexecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object parameter)
        {
            return _canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
