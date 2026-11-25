using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace adivinhar_numero.imagens
{
    internal class Controller :UIElement
    {
        public Cmd cmdadivinha { get; set; }
        public Cmd cmdlimpar { get; set; }


        public Controller()
        {
            cmdadivinha = new Cmd(Adivinha, Canadivinha);
            cmdlimpar = new Cmd(Limpa, Canlimpa);
        }
        MainWindow main = (MainWindow)App.Current.MainWindow;

        public bool Canadivinha(object parameter)
        {
            return true;
        }
        public void Adivinha(object parameter)
        {
            Random random = new Random( );
            string parametro = parameter.ToString();
            int numa = random.Next(0, 1001);
            int numero = Convert.ToInt32(parametro);
            int temp = 10;
            while (temp != 0) {
                if (numero != numa)
                {
                    main.txtresult.Text = "Errado";
                    temp = temp - 1;
                } else
                {
                    main.txtresult.Text = "acertou" + "," + "parabens\t" + numa;
                }
            }
        }
        public bool Canlimpa(object parameter)
        {
            return true;
        }
        public void Limpa(object parameter)
        {
            main.txtmostra.Clear();
            main.txtresult.Clear();
        }


    }

}
