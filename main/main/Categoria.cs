using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Categoria
    {
        private int idcategoria;
        public int Idcategoria
        {
          get { return idcategoria; }
          set { idcategoria = value; }  
        }
        
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public bool agregarCategoria(string nom)
        {
            Conexion cn = new Conexion();
            return cn.agregarCat(nom);
        }

        public bool modificarCategoria(int id, string nom)
        {
            Conexion cn = new Conexion();
            return cn.modificarCat(id, nom);
        }

        public bool eliminarCategoria(int id)
        {
            Conexion cn = new Conexion();
            return cn.eliminarCat(id);
        }
    }
}
