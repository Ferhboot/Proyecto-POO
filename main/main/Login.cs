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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            if(txtpass.Text!="" && txtuser.Text != "")
            {
                try
                {
                    Conexion cn = new Conexion();        
                    Main principal = new Main(cn.login(txtuser.Text, txtpass.Text));
                    this.Hide();
                    principal.Show();
                }
                catch(Exception X)
                {
                    MessageBox.Show(X.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home h = new main.Home();
            h.Show();
        }
    }
}
