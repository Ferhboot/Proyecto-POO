using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class BienOServicio
    {

        private int idBienOServicio;
        public int IdBienOServicio
        {
            get { return idBienOServicio; }
            set { idBienOServicio = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private float precio;
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private byte[] imagen;

        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        private int mayoreo;
        public int Mayoreo
        {
            get { return mayoreo; }
            set { mayoreo = value; }
        }

        private Categoria cat;
        public Categoria Cat
        {
            get { return cat; }
            set { cat = value; }
        }

        private Usuario user;
        public Usuario User
        {
            get { return user; }
            set { user = value; }
        }


        public bool registrarBienOServicio(BienOServicio bienOServicio)
        {
            Conexion con = new Conexion();
            con.agregarBienOServicio("BienOServicio", bienOServicio);
            return true;
        }

    }
}
