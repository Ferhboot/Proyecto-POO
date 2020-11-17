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
        Datos d = new Datos();
        Empresa emp = new Empresa();
        public Perfil(Datos user)
        {
            InitializeComponent();
            txtusuario.Text = user.IDusuario;
            txtcorreo.Text = user.Email;
            txtnombre.Text = user.Nombre;
            txtciudad.Text = user.Municipio;
            txttelefono.Text = user.Telefono;
            cmbdep.SelectedItem = user.Departamento;
            d = user;
        }

        public Perfil(Empresa empresa)
        {
            InitializeComponent();
            txtusuario.Text = empresa.IDusuario;
            txtcorreo.Text = empresa.Email;
            txtnombre.Text = empresa.Nombre;
            txtciudad.Text = empresa.Municipio;
            txttelefono.Text = empresa.Telefono;
            cmbdep.SelectedItem = empresa.Departamento;
            emp = empresa;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                this.Close();
            }

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
                            Conexion con = new Conexion();
                            con.actualizarpass(d.IDusuario, txtpass.Text);
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

        private void btnactualizarperso_Click(object sender, EventArgs e)
        {
            try
            {

                Validaciones validacion = new Validaciones();

                if ((validacion.enBlanco(txtnombre.Text) && validacion.enBlanco(txtciudad.Text) && 
                    validacion.enBlanco(txtdireccion.Text) && 
                    validacion.enBlanco(txttelefono.Text)) == false)
                {

                    
                    if (!validacion.esTelefono(txttelefono.Text))
                    {
                        errorProvider1.SetError(txttelefono, "Teléfono debe ser mayor a 7 dígitos");
                    }

                    else
                    {
                        Conexion cn = new Conexion();
                        cn.actualizardatos(txtnombre.Text, cmbdep.SelectedItem.ToString(),
                            txtciudad.Text, txtdireccion.Text, txttelefono.Text, d.IDusuario);
                        MessageBox.Show("Datos modificados exitosamente", "E-Market",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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
            txtciudad.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            errorProvider1.SetError(txttelefono, "");
        }


        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if(txttelefono.Text.Length == 4)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    txttelefono.Text += "-";
                    txttelefono.SelectionStart = 5;
                }
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }
    }
}
