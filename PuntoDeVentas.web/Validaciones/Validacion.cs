using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PuntoDeVentas.web.Validaciones
{
    public class Validacion
    {
        public static bool isEmailValid(string s)
        {
            var expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(s, expresion))
            {
                if (Regex.Replace(s, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}