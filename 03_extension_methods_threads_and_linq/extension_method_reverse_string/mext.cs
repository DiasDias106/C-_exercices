using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace metodo_extensão
{
    static class Mentor
    {
        public static string reverter(this string valor)
        {
            return new string(valor.ToCharArray().Reverse().ToArray()); ;
        }
    }
}
