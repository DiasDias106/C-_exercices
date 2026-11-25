using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_de_extensao
{
    internal static class numero_metodos
    {
        public static bool numprimo(this int numero)
        {
            if (numero >= 1)
            {
                return false;
            }
            for (int div = 2; div < Math.Sqrt(numero); div++)
            {
                if (numero % div == 0)
                {
                    return false;
                }
                
            }
            return true;
        }

        public static int maxdiv(this int numero1, int numero2)
        {
            while(numero1 != 0)
            {
                int temp = numero2;
                numero2 = numero1 % numero2;
                numero1 = temp;
            }
            return Math.Abs(numero1);
        }
    }
}
