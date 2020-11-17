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
    public partial class Admin : Form
    {
        Usuario u = new Usuario();
        public Admin(Usuario user)
        {
            InitializeComponent();
            lbuser.Text = user.IDusuario;
            u = user;
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminCategorias categorias = new AdminCategorias();
            categorias.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AgregarAdmin admin = new AgregarAdmin();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfilAdmin admin = new PerfilAdmin(u);
            admin.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            AdminCategorias categorias = new AdminCategorias();
            categorias.ShowDialog();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            PerfilAdmin admin = new PerfilAdmin(u);
            admin.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            inicio.Show();
            this.Close();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home h = new Home();
            h.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Reporte r = new Reporte();
            r.ShowDialog();
        }
    }
}
