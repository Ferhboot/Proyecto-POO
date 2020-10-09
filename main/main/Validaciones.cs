using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace main
{
    class Validaciones
    {

        public Boolean esFuerte(string password)
        {

            if (Regex.Matches(password, "[A-Z]").Count > 0 && Regex.Matches(password, "[0-9]").Count > 0 && password.Length >=8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean enBlanco(string dato)
        {
            if (dato.Trim() == "")
            {
                return true;
            }

            return false;
        }

        public Boolean esCorreo(string correo)
        {

            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(correo, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean esTelefono(string telefono)
        {
            string expresion = "^[2|6|7][0-9]{3}-[0-9]{4}";

            if (Regex.IsMatch(telefono, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean esNumero(string numero)
        {
            try
            {
                int.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }

        }     

    }
}
