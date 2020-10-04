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

    }
}
