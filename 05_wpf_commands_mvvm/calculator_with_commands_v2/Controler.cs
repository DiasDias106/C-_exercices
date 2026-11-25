using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculadora
{
    internal class Controler:UIElement
    {
        MainWindow janela = (MainWindow)App.Current.MainWindow;
        public Exec incerir_numero { get; set; }

        public Controler()
        {
            this.incerir_numero = new Exec(incerir, canincerir);
        }
        public bool canincerir(Object sender)
        {
            return true;
        }
        public void incerir(Object sender)
        {
            janela.txconta.Text = "1";
        }
        
    }
}
