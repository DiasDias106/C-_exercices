using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculadora
{
    internal class Exec:ICommand
    {
        private Action<Object> acao { get; set; }
        private Predicate<Object> predicado { get; set; }


        public Exec(Action<object> conta, Predicate<Object> pred) {
            this.acao = conta;
            this.predicado = pred;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return predicado(parameter);
        }

        public void Execute(object parameter)
        {
            acao.Invoke(parameter);
        }
    }
}
