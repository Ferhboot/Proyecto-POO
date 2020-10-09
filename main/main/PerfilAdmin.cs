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
    public partial class PerfilAdmin : Form
    {
        public PerfilAdmin()
        {
            InitializeComponent();
        }

        private void btnactualizaruser_Click(object sender, EventArgs e)
        {
            try
            {

                Validaciones validacion = new Validaciones();

                if ((validacion.enBlanco(txtusuario.Text) && validacion.enBlanco(txtcorreo.Text) && validacion.enBlanco(txtcorreo.Text) && validacion.enBlanco(txtconfirm.Text)) == false)
                {

                    Usuario user = new Usuario();

                    user.IDusuario = txtusuario.Text;
                    user.Contra = txtpass.Text;
                    user.Email = txtcorreo.Text;

                    if (!validacion.esCorreo(txtcorreo.Text))
                    {
                        errorProvider1.SetError(txtcorreo, "Correo inválido");
                    }
                    else if (txtpass.Text != txtconfirm.Text)
                    {
                        errorProvider1.SetError(txtconfirm, "Las contraseñas no son iguales");
                        errorProvider1.SetError(txtcorreo, "");
                    }

                    else
                    {

                        if (validacion.esFuerte(txtpass.Text))
                        {
                            Conexion con = new Conexion();
                            con.actualizarpass(u.IDusuario, txtpass.Text);
                            MessageBox.Show("Datos modificados exitosamente", "E-Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar1();
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una contraseña más fuerte\n\nDebe contener al menos:\n1 Letra mayúscula\n1 Número\n8 Carácteres");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }

            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void btnlimpiaruser_Click(object sender, EventArgs e)
        {
            limpiar1();
        }

        void limpiar1()
        {
            txtpass.Text = "";
            txtconfirm.Text = "";
            errorProvider1.SetError(txtcorreo, "");
            errorProvider1.SetError(txtconfirm, "");
            lbfuerte.Text = "";
        }
    }
}
