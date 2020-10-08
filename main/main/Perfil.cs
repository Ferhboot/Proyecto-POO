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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 4)
            {
                Main principal = new Main(null);
                principal.Show();
                this.Close();
            }

            limpiar1();
            limpiar2();
            limpiar3();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            Validaciones validacion = new Validaciones();
            if (validacion.esFuerte(txtpass.Text))
            {
                lbfuerte.Text = "Su contraseña es fuerte";
                lbfuerte.ForeColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                lbfuerte.Text = "Su contraseña es débil";
                lbfuerte.ForeColor = System.Drawing.Color.Brown;
            }
        }

        private void btnactualizaruser_Click(object sender, EventArgs e)
        {
            
            try
            {

                Validaciones validacion = new Validaciones();

                if((validacion.enBlanco(txtusuario.Text) && validacion.enBlanco(txtcorreo.Text) && validacion.enBlanco(txtcorreo.Text) && validacion.enBlanco(txtconfirm.Text)) == false) { 
            
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
                            //user.registrar();
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
                //MessageBox.Show("El nombre de usuario ya está registrado, sus datos son inválidos o sus datos son muy largos");
                MessageBox.Show(x.Message);
            }
            
        }

        private void btnlimpiaruser_Click(object sender, EventArgs e)
        {
            limpiar1();
        }

        void limpiar1()
        {
            txtusuario.Text = "";
            txtcorreo.Text = "";
            txtpass.Text = "";
            txtconfirm.Text = "";
            errorProvider1.SetError(txtcorreo, "");
            errorProvider1.SetError(txtconfirm, "");
            lbfuerte.Text = "";
        }

        private void btnactualizarperso_Click(object sender, EventArgs e)
        {
            try
            {

                Validaciones validacion = new Validaciones();

                if ((validacion.enBlanco(txtnombre.Text) && validacion.enBlanco(txtapellidos.Text) && validacion.enBlanco(txtciudad.Text) && validacion.enBlanco(txtdireccion.Text) && validacion.enBlanco(txtpostal.Text) && validacion.enBlanco(txttelefono.Text)) == false)
                {

                    
                    if (!validacion.esTelefono(txttelefono.Text))
                    {
                        errorProvider1.SetError(txttelefono, "Teléfono debe ser mayor a 7 dígitos");
                    }
                    else if (!validacion.esNumero(txtpostal.Text))
                    {
                        errorProvider1.SetError(txtpostal, "Debe ingresar un código postal correcto");
                        errorProvider1.SetError(txttelefono, "");
                    }

                    else
                    {

                        MessageBox.Show("Datos modificados exitosamente", "E-Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar2();
                        
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

        private void btnlimpiarperso_Click(object sender, EventArgs e)
        {
            limpiar2();
        }

        void limpiar2()
        {
            txtnombre.Text = "";
            txtapellidos.Text = "";
            txtciudad.Text = "";
            txtdireccion.Text = "";
            txtpostal.Text = "";
            txttelefono.Text = "";
            errorProvider1.SetError(txttelefono, "");
            errorProvider1.SetError(txtpostal, "");
        }

        private void btnagregartarjeta_Click(object sender, EventArgs e)
        {
            try
            {

                Validaciones validacion = new Validaciones();

                if ((validacion.enBlanco(txttarjeta.Text) && validacion.enBlanco(txtexpiracion.Text) && validacion.enBlanco(txtcodigo.Text) && validacion.enBlanco(txtnombretarjeta.Text) && validacion.enBlanco(txtapellidostarjeta.Text)) == false)
                {


                    if (!validacion.esTarjeta(txttarjeta.Text))
                    {
                        errorProvider1.SetError(txttarjeta, "Tarjeta incorrecta");
                    }
                    else if (!validacion.esFechaTarjeta(txtexpiracion.Text))
                    {
                        errorProvider1.SetError(txtexpiracion, "Debe ingresar una fecha de expiración correcta");
                        errorProvider1.SetError(txttarjeta, "");
                    }
                    else if (!validacion.esNumero(txtcodigo.Text))
                    {
                        errorProvider1.SetError(txtcodigo, "Debe ingresar un código de tarjeta válido");
                        errorProvider1.SetError(txtexpiracion, "");
                        errorProvider1.SetError(txttarjeta, "");
                    }

                    else
                    {
               
                        MessageBox.Show("Datos modificados exitosamente", "E-Market", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiar3();

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

        private void btnlimpiartarjeta_Click(object sender, EventArgs e)
        {
            limpiar3();
        }

        void limpiar3()
        {
            txttarjeta.Text = "";
            txtexpiracion.Text = "";
            txtcodigo.Text = "";
            txtnombretarjeta.Text = "";
            txtapellidostarjeta.Text = "";

            errorProvider1.SetError(txttarjeta, "");
            errorProvider1.SetError(txtexpiracion, "");
            errorProvider1.SetError(txtcodigo, "");
        }
    }
}
