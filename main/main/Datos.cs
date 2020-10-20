using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Datos:Usuario
    {
        public string departamento;
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }


        public string municipio;
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }


        public string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
