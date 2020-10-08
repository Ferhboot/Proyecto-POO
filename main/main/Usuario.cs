using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Usuario
    {
        public string idusuario;
        public string IDusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

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

        public int codpostal;
        public int Codpostal
        {
            get { return codpostal; }
            set { codpostal = value; }
        }

        public string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string contra;
        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }

        public int idtipousuario;
        public int Idtipousuario
        {
            get { return idtipousuario; }
            set { idtipousuario = value; }
        }

        public bool registrar()
        {
            Conexion con = new Conexion();  
            con.agregarusuario("Usuarios", idusuario, nombre,email, contra, idtipousuario);
            return true;
        }
    }
}
