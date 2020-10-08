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
    public partial class Main : Form
    {
        //El programa recibirá un valor int que le permitirá saber qué clase de usuario es
        public Main(Usuario user)
        {
            InitializeComponent();
            toolStrip1.Text = user.idusuario;
            
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
            perfil.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            inicio.Show();
            this.Close();
        }
    }
}
