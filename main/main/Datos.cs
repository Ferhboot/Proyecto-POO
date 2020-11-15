using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Datos:Usuario
    {

        private int idDatos;

        public int IdDatos
        {
            get { return idDatos; }
            set { idDatos = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string departamento;
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }


        private string municipio;
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }


        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public bool registrar(Datos datos)
        {
            Conexion con = new Conexion();
            con.agregarusuario("Datos", datos);
            return true;
        }

    }
}
