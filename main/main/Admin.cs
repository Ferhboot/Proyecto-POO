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
        int num = 0;
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
            Conexion cn = new Conexion();
            num = cn.numeroMensajes(u.IDusuario);
            btnmensajes.Text = num.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            VerReportes r = new VerReportes(u.IDusuario);
            r.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            AgregarAdmin ad = new AgregarAdmin();
            ad.ShowDialog();
        }

        private void btnmensajes_Click(object sender, EventArgs e)
        {
            Mensajes msg = new Mensajes(u.IDusuario);
            msg.Show();
        }
    }
}
