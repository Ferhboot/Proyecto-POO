using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Empresa:Datos
    {

        private int idEmpresa;
        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        private string nombreEmpresa;
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }

        public bool registrar(Empresa empresa)
        {
            Conexion con = new Conexion();
            con.agregarempresa("Empresa", empresa);
            return true;
        }
    }
}
