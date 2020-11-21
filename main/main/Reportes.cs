using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Reportes
    {

        private int idReporte;
        public int IdReporte
        {
            get { return idReporte; }
            set { idReporte = value; }
        }

        private string idUsuario;
        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private String fecha;
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


    }
}
