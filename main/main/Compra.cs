using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Compra
    {

        int idCompra;

        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        DateTime fechaCompra;

        public DateTime FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }

        int estadoCompra;

        public int EstadoCompra
        {
            get { return estadoCompra; }
            set { estadoCompra = value; }
        }

        Usuario usuario;


        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

    }
}
