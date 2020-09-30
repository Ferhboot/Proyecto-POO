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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        //Éste es el botón para limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            txtnom.Clear();
            txtpass.Clear();
            txtpass2.Clear();
            txtuser.Clear();
            cmbcuenta.SelectedIndex = 0;
        }

        private void Registro_Shown(object sender, EventArgs e)
        {
            cmbcuenta.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text != txtpass2.Text)
            {
                errorProvider1.SetError(txtpass2, "Las contraseñas no son iguales");
            }
            else if (cmbcuenta.SelectedIndex == -1) errorProvider1.SetError(cmbcuenta, "Elija un tipo de cuenta");
            else
            {
                try
                {
                    int tipo = 0;
                    
                    if (cmbcuenta.SelectedIndex == 0) tipo = 1;
                    if (cmbcuenta.SelectedIndex == 1) tipo = 2;

                    Usuario user = new Usuario();
                    user.IDusuario = txtuser.Text;
                    user.Nombre = txtnom.Text;
                    user.Contra = txtpass.Text;
                    user.Idtipousuario = tipo;
                    user.Email = txtemail.Text;
                    user.registrar();        
                    MessageBox.Show("Usuario registrado exitosamente", "E-Market", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception x)
                {
                    //MessageBox.Show("El nombre de usuario ya está registrado, sus datos son inválidos o sus datos son muy largos");
                    MessageBox.Show(x.Message);
                }
            }
        }
    }
}
