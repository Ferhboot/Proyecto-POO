using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace main
{
    public partial class Main : Form
    {
        //Lista temporal de categorías (Sólo para referencia)
        private
        List<Categoria> categorias = new List<Categoria>();

        //El programa recibirá un objeto del tipo usuario para poder identificarlo
        //en el transcurso de toda la sesión

        public Main(Usuario user)
        {
            //Si es Invitado, no puede ver su perfil ni vender
            InitializeComponent();
            if (user.Idtipousuario == 0)
            {
                toolStrip1.Items[1].Visible = false;
                toolStrip1.Items[4].Visible = false;
                lbuser.Text = "Invitado";
            }

            //Si no es invitado, tiene acceso a las funciones básicas
            else
            {
                lbuser.Text = user.Nombre;
                toolStrip1.Items[3].Visible = false;
            }         
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat();
            dgcategorias.DataSource = ds.Tables["categorias"];
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
            {
                //Esto cancelará la operación de FormClosing si se recibe la opción NO desde
                //messagebox
                e.Cancel = true;
            }
        }


        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            about acerca = new about();
            acerca.ShowDialog();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            inicio.Show();
            this.Hide();
        }

    }
}
