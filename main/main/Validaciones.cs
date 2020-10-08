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
            try
            {
                int.Parse(telefono);
                if (telefono.Length > 7)
                {
                    return true;
                }

                return false;

            }
            catch
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

        public Boolean esTarjeta(string tarjeta)
        {
            //validacion de tarjeta mastercard, american express, visa
            string expresion = "(^3[47][0 - 9]{ 13}$)|(5[1-5][0-9]{14}$)|(^4[0-9]{12}(?:[0-9]{3})?$)";

            if (Regex.IsMatch(tarjeta, expresion))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean esFechaTarjeta(string codigo)
        {
            //validacion de fecha ##/##
            string[] cod = codigo.Split('/');

            try
            {
                int dia = int.Parse(cod[0]);
                int mes = int.Parse(cod[1]);

                if (dia <= 31 && mes <= 12)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }

        }

    }
}
