using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Mensajes : Form
    {
        Conexion cn = new Conexion();
        string user = "";
        public Mensajes(string id)
        {
            InitializeComponent();
            user = id;
            cargar();
        }

        private void Mensajes_Load(object sender, EventArgs e)
        {
            
        }

        void cargar()
        {
            MessageBox.Show(user);
            dgmensajes.DataSource = null;
            dgmensajes.DataSource = cn.verMensajes(user).Tables["mensajes"];
        }
    }
}
