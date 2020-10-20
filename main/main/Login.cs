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
            entrar();         
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home h = new main.Home();
            h.Show();
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar();
            }
        }

        private void entrar()
        {
            if (txtpass.Text != "" && txtuser.Text != "")
            {
                try
                {
                    Conexion cn = new Conexion();
                    Datos user = new Datos();
                    user = cn.login(txtuser.Text, txtpass.Text);
                    if (user.idtipousuario == 3) {
                        Admin admin = new Admin(user);
                        admin.Show();
                    }
                    else { 
                        Main principal = new Main(user);
                        principal.Show();
                    }
                    this.Hide();
                    
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }
}
