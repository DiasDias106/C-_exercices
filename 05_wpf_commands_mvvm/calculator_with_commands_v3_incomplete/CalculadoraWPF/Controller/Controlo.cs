using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CalculadoraWPF.Controller
{
    internal class Controlo : UIElement
    {
        public Exec exenum { get; set; }

        public Controlo()
        {
            this.exenum = new Exec(Execnum, canExecnum);
        }

        MainWindow main = (MainWindow)App.Current.MainWindow;

        public void Execnum(Object parameter)
        {
            string destino = parameter.ToString();
            switch (destino)
            {
                case "1":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "1";
                    break;
                case "2":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "2";
                    break;
                case "3":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "3";
                    break;
                case "4":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "4";
                    break;
                case "5":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "5";
                    break;
                case "6":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "6";
                    break;
                case "7":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "7";
                    break;
                case "8":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "8";
                    break;
                case "9":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "9";
                    break;
                default:
                    break;
            }
        }

        public bool canExecnum(object obj)
        {
            return true;
        }


    }
}
