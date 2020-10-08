using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Usuario
    {
        string idusuario;
        public string IDusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        string contra;
        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }

        int idtipousuario;
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
