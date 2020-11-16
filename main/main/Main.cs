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
        Datos d = null;
        Empresa e = null;
        public Main(Datos user)
        {
            InitializeComponent();
            lbuser.Text = user.Nombre + ' ' + user.Apellido;
            toolStrip1.Items[3].Visible = false;      
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat ();
            dgcategorias.DataSource = ds.Tables["categorias"];
            d = user;
        }

        public Main(Empresa empresa)
        {
            InitializeComponent();
            lbuser.Text = empresa.Nombre;
            toolStrip1.Items[3].Visible = false;
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat();
            dgcategorias.DataSource = ds.Tables["categorias"];
            e = empresa;

        }


        public Main()
        {
            InitializeComponent();
            toolStrip1.Items[1].Visible = false;
            toolStrip1.Items[4].Visible = false;
            lbuser.Text = "Invitado";
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
            Perfil perfil = new Perfil(d);
            perfil.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            inicio.Show();
            this.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Publicacion pub = new Publicacion();
            pub.ShowDialog();
        }

        private void tsUser_ButtonClick(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(d);
            perfil.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgcategorias.ClearSelection();
        }
    }
}
