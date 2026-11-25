using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    internal class Controller :UIElement
    {
        public Cmd cmdadd { get; set; }
        public Cmd cmdremove { get; set; }
        public Cmd cmdinvert { get; set; }
        public Cmd cmdsair { get; set; }

        public Controller() {
            cmdadd = new Cmd(Add, Canadd);
            cmdremove = new Cmd(Remove, Canremove);
            cmdinvert = new Cmd(Invert, Caninvert);
            cmdsair = new Cmd(Sair, Cansair);
        }
        MainWindow main = (MainWindow)App.Current.MainWindow;
        public bool Canadd(object parameter)
        {
            return true;
        }
        public void Add(object parameter)
        {
            string parametro = parameter.ToString();
            main.txtresult.Text = main.txtnome.ToString() + "" + main.txtadicionar.ToString();
        }
        public bool Canremove(object parameter)
        {
            return true;
        }
        public void Remove(object parameter)
        {
            string parametro = parameter.ToString();
            main.txtresult.Text = "";
            main.txtnome.Text = "";
            main.txtadicionar.Text = "";
        }
        public bool Caninvert(object parameter)
        {
            return true;
        }
        public void Invert(object parameter)
        {
            string parametro = parameter.ToString();
            main.txtresult.Text = main.txtadicionar.ToString()  + "" + main.txtnome.ToString();
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
