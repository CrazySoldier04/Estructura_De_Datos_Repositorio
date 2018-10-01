using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Estructura_De_Datos_Proyecto
{
    class RegularExpressions
    {
         static Regex reg;

        public static bool NumerosEnteros(String campo)
        {
            reg = new Regex("[0-9]$");
            return reg.IsMatch(campo);
        }
    }
}
