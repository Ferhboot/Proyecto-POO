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

        public void agregarCategoria(int id)
        {
           
        }

        public void modificarCategoria()
        {

        }
    }
}
