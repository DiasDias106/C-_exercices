using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf1.Controller
{
    internal class ControllerI : UIElement
    {
        public Cmd cmdSair { get; set; }
        public Cmd cmdNavegar { get; set; }
        public ControllerI()
        {
            cmdSair = new Cmd(Sair, canSair);
            cmdNavegar=new Cmd(Navegar, canNavegar);
        }

        MainWindow main = (MainWindow)App.Current.MainWindow;

        public bool canNavegar(Object parameter)
        {
            return true;
        }
        public void Navegar(Object parameter)
        {
            string destino = parameter.ToString();
            switch (destino)
            {
                case "Dados":
                    main.frame.Source = new Uri("/View/Dados.xaml", UriKind.Relative);
                    break;
                case "Inicio":
                    main.frame.Source = new Uri("/View/Inicio.xaml",UriKind.Relative);
                    break;
                case "Selos":
                    main.frame.Source = new Uri("/View/Selos.xaml",UriKind.Relative);
                    break;

                default:
                    main.frame.Source = new Uri("/View/Inicio.xaml", UriKind.Relative);
                    break;
            }

        }


        public bool canSair(Object paramter)
        {
            return true;
        }
        public void Sair(Object parameter)
        {
            App.Current.Shutdown();
        }

    }
}
