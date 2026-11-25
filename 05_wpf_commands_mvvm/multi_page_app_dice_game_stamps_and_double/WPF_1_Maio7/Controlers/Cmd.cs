using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_1_Maio7.Controlers
{
    //comando é o que faz a ligação
    public class Cmd : ICommand
    {
        //delegate Apontador de metodos

        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public Cmd(Action<object> execute, Predicate<object> canExecute)
        {
            this._execute = execute;   //this referencia ao futuro objeto
            this._canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
