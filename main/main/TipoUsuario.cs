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
    public partial class TipoUsuario : Form
    {
        public TipoUsuario()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            inicio.Show();
            this.Close();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            RegistroEmpresa empresa = new RegistroEmpresa();
            empresa.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Registro personal = new Registro();
            personal.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Registro personal = new Registro();
            personal.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RegistroEmpresa empresa = new RegistroEmpresa();
            empresa.ShowDialog();
            this.Close();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            RegistroEmpresa empresa = new RegistroEmpresa();
            empresa.ShowDialog();
            this.Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Registro personal = new Registro();
            personal.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
