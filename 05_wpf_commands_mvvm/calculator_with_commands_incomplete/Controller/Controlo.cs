using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace calculadora1.Controller
{
    internal class Controlo :UIElement
    {
        public Cmd cmdsair { get; set; }
        public Cmd cmdapagar { get; set; }

        public Cmd cmdoperandos { get; set; }
        public Cmd cmdoperadores { get; set; }

        MainWindow main = (MainWindow)App.Current.MainWindow;
        public Controlo()
        {
            cmdsair = new Cmd(Sair,Cansair) ;
            cmdoperandos = new Cmd(Operandos, Canoperandos);
            cmdoperadores = new Cmd(Operadores, Canoperadores);
        }
        public bool Cansair(object paracter)
        {
            return true;
        }
        public void Sair(object parameter)
        {
            App.Current.Shutdown();
        }
        
        public bool Canoperandos(object parameter)
        {
            return true;
        }
        public void Operandos(object parameter)
        {
            string destino = parameter.ToString();
            switch (destino)
            {
                case "1":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "1";
                    break;
                case "2":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "2";
                    break;
                case "3":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "3";
                    break;
                case "4":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "4";
                    break;
                case "5":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "5";
                    break;
                case "6":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "6";
                    break;
                case "7":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "7";
                    break;
                case "8":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "8";
                    break;
                case "9":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "9";
                    break;
                case "0":
                    main.txtcontas.Text = main.txtcontas.Text.ToString() + "0";
                    break;
                case "ca":
                    main.txtcontas.Text = "";
                    main.txtmostra.Text = "";
                    break;
                case ",":
                    main.txtcontas.Text = main.txtcontas.Text + ",";
                    break;
            }
        }
        public bool Canoperadores(object parameter)
        {
            return true;
        }
        public void Operadores(object parameter)
        {
            string destino = parameter.ToString();
            switch (destino)
            {
                case "+":


            }
        }
    }

}
