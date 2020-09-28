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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }




        private void Home_Shown(object sender, EventArgs e)
        {
            start iniciar = new start();
            this.Hide();
            iniciar.Show();
            Task.Delay(5000).Wait();
            iniciar.Hide();
            this.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
                      
        }

        private void btncerrar_MouseEnter(object sender, EventArgs e)
        {
            this.btncerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar2));
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            this.btncerrar.Image = ((System.Drawing.Image)(Properties.Resources.cerrar1));
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.ShowDialog();
        }

        private void btncuenta_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }

        private void btninvitado_Click(object sender, EventArgs e)
        {
            Main principal = new Main(0);
            principal.Show();
            this.Hide();
        }
    }
}
