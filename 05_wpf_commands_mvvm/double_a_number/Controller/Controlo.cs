using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Dobro.Controller
{
    internal class Controlo:UIElement
    {
        public Exec execsair { get; set; }
        public Controlo()
        {
            this.execsair = new Exec(Sair, Cansair);
        }
        public bool Cansair(object parameter)
        {
            return true;
        }
        public void Sair(object parameter)
        {
            App.Current.Shutdown();   
        }
    }
}
