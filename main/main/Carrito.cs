using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Carrito
    {

        int idCarrito;

        public int IdCarrito
        {
            get { return idCarrito; }
            set { idCarrito = value; }
        }

        BienOServicio bienOServicio;

        public BienOServicio BienServicio
        {
            get { return bienOServicio; }
            set { bienOServicio = value; }
        }

        Compra compra;

        public Compra Compra
        {
            get { return compra; }
            set { compra = value; }
        }


    }
}
