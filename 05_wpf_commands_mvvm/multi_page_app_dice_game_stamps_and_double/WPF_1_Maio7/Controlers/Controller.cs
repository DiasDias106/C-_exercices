using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using WPF_1_Maio7.Views;

namespace WPF_1_Maio7.Controlers
{
    public class Controller:UIElement
    {
        public ClsJogoDados myjogo { get; set; }

        public Cmd cmdRolar { get; set; }
        public Cmd cmdSair { get; set; }
        public Cmd cmdNavegar { get; set; }

        public Cmd cmdDobro { get; set; }

        public Cmd cmdSelos { get; set; }

        public Controller() {
            myjogo = new ClsJogoDados();
            myjogo.OnPremio += Myjogo_OnPremio;
            cmdRolar = new Cmd(Rolar, canRolar);
            cmdSair = new Cmd(Sair,canSair);
            cmdNavegar = new Cmd(Navegar,canNavegar);
            cmdDobro = new Cmd(CalculaDobro,canCalculaDobro);
            cmdSelos = new Cmd(CalculaSelos, canCalculaSelos);

            //Com class biblioteca
            //cmdSelos = new Cmd(TrocaSelos, canTrocaSelos);
        }

        private void Myjogo_OnPremio(object sender, RoutedEventArgs e)
        {
            JogoDados pag = (JogoDados)main.frame.Content;
            ClsJogoDados jogo = (ClsJogoDados)sender;
            int premio = jogo.Dado1 * 2 * ((ClsJogoDados.OnPremioRoutedEventArgs)e).Aposta;
            jogo.Montante += premio;
            StringBuilder sb = new StringBuilder();
            sb.Append("Parabens ganhou \r\n");
            sb.Append($"{premio} euros");
            //pag.lblvisor.Content = "Parabens ganhou "+ premio + "";
            pag.lblvisor.Content = sb.ToString();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            int idx = path.IndexOf("bin");
            path = path.Substring(0, idx) + "dados/gongo.wav";
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Load();
            soundPlayer.Play();

        }

        public bool canRolar(Object parameter)
        {
            if (parameter == null) return false;
            if(int.TryParse(parameter.ToString(), out int aposta))
            {
                if(aposta > 0) return true;
            }
            return false;
        }
        public void Rolar(Object parameter)
        {
            JogoDados pag = (JogoDados)main.frame.Content;
            pag.lblvisor.Content = "";
            
            if(int.TryParse(parameter.ToString(), out int aposta))
            {
                if(aposta == 0) pag.lblvisor.Content = "Não há aposta";
                myjogo.rolar(aposta);
                if (myjogo.Montante == 0){

                    pag.slider.Value = 0;
                    pag.lblvisor.Content = "Acabou o guito !!!";
                }
            }
            else
            {
                pag.lblvisor.Content = "Não há aposta";
            }
        }




        //é Object porque entra tudo 
        public Boolean canCalculaDobro(Object parameter)
        {
            if(string.IsNullOrEmpty(parameter.ToString())) return false;
            if(int.TryParse(parameter.ToString(), out int result) ) return true;
            return false;
        }

        public void CalculaDobro(Object parameter)
        {
            Dobro dobro = (Dobro)main.frame.Content;
            int i = int.Parse(parameter.ToString());

            dobro.resultado.Content = (2 * i).ToString();
        }

        public Boolean canNavegar(Object parameter)
        {
            if(string.IsNullOrEmpty(main.frame.Source.ToString())) return true;
            if(string.IsNullOrEmpty(parameter.ToString())) return false;

            String destino = parameter.ToString();
            String corrente = main.frame.Source.ToString();

            if(corrente.Contains(destino)) return false;

            return true;
        }

        MainWindow main = (MainWindow)App.Current.MainWindow;
        public void Navegar(object parameter)
        {
            string destino = parameter.ToString();
            switch(destino)
            {
                case "Inicio":
                    main.frame.Source = new Uri("/Views/Inicio.xaml", UriKind.Relative);
                    break;

                case "Dobro":
                    main.frame.Source = new Uri("/Views/Dobro.xaml", UriKind.Relative);
                    break;

                case "Selos":
                    main.frame.Source = new Uri("/Views/Selos.xaml", UriKind.Relative);
                    break;

                case "JogoDados":
                    main.frame.Source = new Uri("/Views/JogoDados.xaml", UriKind.Relative);
                    break;

                default:
                    main.frame.Source = new Uri("/Views/Inicio.xaml", UriKind.Relative);
                    break;



            }
        }



        //Selos pela class biblioteca
        //public bool canTrocaSelos(Object parameter)
        //{
        //    if (parameter == null || String.IsNullOrEmpty(parameter.ToString())) return false;
        //    int euros;
        //    if (int.TryParse(parameter.ToString(), out euros))
        //    {
        //        if (euros > 0) return true;
        //        return false;
        //    }
        //    else return false;

        //}
        //public void TrocaSelos(object parameter)
        //{
        //    int euros;
        //    WPF_1_Maio7.Views.Selos pgselos = (Selos)main.frame.Content;
        //    if(int.TryParse(parameter.ToString(),out euros))
        //    {
        //        pgselos.lblresultado.Content = Biblioteca.trocaSelos(euros);

        //    }
        //    else
        //    {
        //        pgselos.lblresultado.Content = "Quantia invalida";
        //    }
        //}

        public bool canCalculaSelos(object parameter)
        {
            if (string.IsNullOrEmpty(parameter.ToString())) return false; //se a caixa estiver vazia
            if (int.TryParse(parameter.ToString(), out int result)) return true; // se caixa estiver com algo que n seja numero
            else return false;
        }

        public void CalculaSelos(object parameter)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory;
            int idx = path.LastIndexOf("bin");
            path = path.Substring(0, idx) + @"\sons\rosca.wav";
            SoundPlayer player = new SoundPlayer(path);

            player.Load();
            player.Play();

            Selos selos = (Selos)main.frame.Content;
            int i = int.Parse(parameter.ToString());
            int quoc, r;
            int[] resposta = new int[2] { 0, 0 };
            if (i > 8)
            {
                quoc = i / 8;
                r = i % 8;
                switch (r)
                {
                    case 0:
                        resposta[0] = quoc; resposta[1] = quoc;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                    case 1:
                        resposta[0] = quoc + 2; resposta[1] = quoc - 1;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                    case 2:
                        resposta[0] = quoc - 1; resposta[1] = quoc + 1;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                    case 3:
                        resposta[0] = quoc + 1; resposta[1] = quoc;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                    case 4:
                        resposta[0] = quoc + 3; resposta[1] = quoc - 1;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                    case 5:
                        resposta[0] = quoc; resposta[1] = quoc + 1;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                    case 6:
                        resposta[0] = quoc + 2; resposta[1] = quoc;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                    case 7:
                        resposta[0] = quoc - 1; resposta[1] = quoc + 2;
                        selos.resultado.Content = "selos de 3:" + resposta[0].ToString() + "\t" + "selos de 5:" + resposta[1].ToString();
                        break;
                }
            }
            else
            {
                if (i == 3) { resposta[0] = 1; resposta[1] = 0; selos.resultado.Content = resposta[0].ToString() + "\t" + resposta[1].ToString(); }
                else if (i == 5) { resposta[0] = 0; resposta[1] = 1; selos.resultado.Content = resposta[0].ToString() + "\t" + resposta[1].ToString(); }
                else if (i == 6) { resposta[0] = 2; resposta[1] = 0; selos.resultado.Content = resposta[0].ToString() + "\t" + resposta[1].ToString(); }
                else { selos.resultado.Content = "devolução de quantia:" + i; }
            }
        }

        public Boolean canSair(Object parameter)
        {
            return true;
        }

        public void Sair(Object parameter)
        {
            App.Current.Shutdown();
        }
    }
}
