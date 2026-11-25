using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selos
{
    internal class Biblio
    {
        int[] numero = new int[6] { 1, 2, 3, 4, 5, 6 };

        internal static int[]Selos(int euros)
        {
            int quoc, r;
            int[] resposta = new int[2] { 0, 0 };
            if (euros >= 8)
            {
                quoc = euros / 8;
                r = quoc / 8;
                switch (r)
                {
                    case 0: resposta[0] = quoc; resposta[1] = quoc;break;
                    case 1: resposta[0] = quoc + 2; resposta[1] = quoc - 1; break;
                    case 2: resposta[0] = quoc -1 ; resposta[1] = quoc +1; break;
                    case 3: resposta[0] = quoc +1; resposta[1] = quoc; break;
                    case 4: resposta[0] = quoc +3; resposta[1] = quoc-1; break;
                    case 5: resposta[0] = quoc; resposta[1] = quoc+1; break;
                    case 6: resposta[0] = quoc+2; resposta[1] = quoc-1; break;
                    case 7: resposta[0] = quoc-1; resposta[1] = quoc+2; break;
                }

            }
            else
            {
                if(euros == 3) { resposta[0] = 1; resposta[1] = 0; }
                else if(euros == 5) { resposta[0] = 0; resposta[1] = 1; }
                else if (euros == 6) { resposta[0] = 2; resposta[1] = 0; }
                else { Console.WriteLine("devolução da quantia"); }
            }
            return resposta;
        }
        }

    }
