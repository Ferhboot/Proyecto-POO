using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Usuario
    {
        private string idusuario;
        public string IDusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }    

        private string contra;
        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }

        private int idtipousuario;
        public int Idtipousuario
        {
            get { return idtipousuario; }
            set { idtipousuario = value; }
        }
   
    }
}
