using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CalculadoraWPF.Controller
{
    internal class Controller : UIElement
    {
        public Exe exenum { get; set; }
        public Exe exeopera { get; set; }

        public bool muda;

        public Byte operacoes;

        float numero, ans;

        public Controller()
        {
            this.exenum = new Exe(Exenum, canExenum);
            this.exeopera = new Exe(Exeopera, canExeopera);
        }

        MainWindow main = (MainWindow)App.Current.MainWindow;


        public void Exeopera(Object parameter)
        {
            string destino = parameter.ToString();
            switch(destino) {
                case "+":
                    if(muda == true)
                    {
                        operacoes = 1;
                    }
                    else
                    {
                        if (main.txtconta.Text != "")
                        {
                            operacao(operacoes);
                        }
                        numero = float.Parse(main.txtconta.Text);
                        main.txtmostra.Text = main.txtconta.Text + "+";
                        main.txtconta.Clear();
                        main.txtconta.Focus();
                        muda = true;
                        operacoes = 1;
                    }
                    break;
                case "-":
                    if (muda == true)
                    {
                        operacoes = 2;
                        Sinais(operacoes);
                    }
                    else
                    {
                        if (main.txtconta.Text != "")
                        {
                            operacao(operacoes);
                        }

                        main.txtmostra.Text = main.txtconta.Text + "-";
                        if (main.txtconta.Text != "")
                        {
                            numero = float.Parse(main.txtconta.Text);
                            main.txtconta.Clear();
                            main.txtconta.Focus();
                            operacoes = 2;
                            muda = true;
                        }
                    }
                    break;
                case "x":
                    if (muda == true)
                    {
                        operacoes = 3;
                        Sinais(operacoes);
                    }
                    else
                    {
                        if (main.txtconta.Text != "")
                        {
                            operacao(operacoes);
                        }
                        main.txtmostra.Text = main.txtconta.Text + "*";
                        numero = float.Parse(main.txtconta.Text);
                        main.txtconta.Clear();
                        main.txtconta.Focus();
                        muda = true;
                        operacoes = 3;

                    }
                    break;
                case "/":
                    if (muda == true)
                    {
                        operacoes = 4;
                        Sinais(operacoes);
                    }
                    else
                    {
                        if (main.txtconta.Text != "")
                        {
                            operacao(operacoes);
                        }
                        main.txtmostra.Text = main.txtconta.Text + "/";
                        numero = float.Parse(main.txtconta.Text);
                        main.txtconta.Clear();
                        main.txtconta.Focus();
                        muda = true;
                        operacoes = 4;

                    }
                    break;
                case "=":
                    operacao(operacoes);
                    break;
            }
        }

        private void Sinais(byte operaçoes)
        {


            int espacos = main.txtmostra.SelectionLength - 1;
            string texto = main.txtmostra.Text;
            main.txtmostra.Clear();
            for (int pos = 0; pos < espacos; pos++)
            {
                main.txtmostra.Text = main.txtmostra.Text + texto[pos];
            }
            switch (operaçoes)
            {
                case 1:
                    main.txtmostra.Text = main.txtmostra.Text + "+";
                    break;
                case 2:
                    main.txtmostra.Text = main.txtmostra.Text + "-";
                    break;
                case 3:
                    main.txtmostra.Text = main.txtmostra.Text + "*";
                    break;
                case 4:
                    main.txtmostra.Text = main.txtmostra.Text + "/";
                    break;

            }

        }


        public void operacao(byte operaçoes)
        {
            switch (operaçoes)
            {

                case 1:
                    ans = numero + float.Parse(main.txtconta.Text);
                    main.txtmostra.Clear();
                    main.txtmostra.Text = numero.ToString() + "+" + float.Parse(main.txtconta.Text);
                    main.txtconta.Text = ans.ToString();
                    break;
                case 2:
                    ans = numero - float.Parse(main.txtconta.Text);
                    main.txtmostra.Clear();
                    main.txtmostra.Text = numero.ToString() + "-" + float.Parse(main.txtconta.Text);
                    main.txtconta.Text = ans.ToString();
                    break;
                case 3:
                    ans = numero * float.Parse(main.txtconta.Text);
                    main.txtmostra.Clear();
                    main.txtmostra.Text = numero.ToString() + "*" + float.Parse(main.txtconta.Text);
                    main.txtconta.Text = ans.ToString();
                    break;
                case 4:
                    ans = numero / float.Parse(main.txtconta.Text);
                    main.txtmostra.Clear();
                    main.txtmostra.Text = numero.ToString() + "/" + float.Parse(main.txtconta.Text);
                    main.txtconta.Text = ans.ToString();
                    break;

            }
        }

        public bool canExeopera(object obj)
        {
            return true;
        }


        public void Exenum(Object parameter)
        {
            string destino = parameter.ToString();
            muda = false;
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
                case "0":
                    main.txtconta.Text = main.txtconta.Text.ToString() + "0";
                    break;

                default:
                    break;
            }
        }



        public bool canExenum(object obj)
        {
            return true;
        }


    }
}
