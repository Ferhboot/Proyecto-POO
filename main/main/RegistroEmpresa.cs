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
    public partial class RegistroEmpresa : Form
    {
        public RegistroEmpresa()
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
        }

        private void Registro_Shown(object sender, EventArgs e)
        {
            
        }


        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            Validaciones validacion = new Validaciones();
            if (validacion.esFuerte(txtpass.Text)) { 
                lbfuerte.Text = "Su contraseña es fuerte";
                lbfuerte.ForeColor = Color.LimeGreen;
            }
            else
            {
                lbfuerte.Text = "Su contraseña es débil";
                lbfuerte.ForeColor = Color.Brown;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string c = "Su contraseña debe tener al menos: \n\n\t" +
                " 1 Mayúscula \n\t 1 Número \n\t 8 caracteres en total";
            MessageBox.Show(c, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registrar()
        {
            if (txtnom.Text != "" && txtuser.Text != "" && txtpass.Text != "" &&
                txtpass2.Text != "" && txtemail.Text != "")
            {
                if (txtpass.Text != txtpass2.Text)
                {
                    errorProvider1.SetError(txtpass2, "Las contraseñas no son iguales");
                }
                else
                {
                    try
                    {

                        Validaciones validacion = new Validaciones();
                        if (validacion.esFuerte(txtpass.Text))
                        {

                            Empresa user = new Empresa();

                            user.NombreEmpresa = txtempresa.Text;

                            user.Nombre = txtnom.Text;
                            user.Apellido = txtapellido.Text;
                            user.Departamento = cmbdep.Text;
                            user.Municipio = txtmunicipio.Text;
                            user.Direccion = txtdireccion.Text;
                            user.Telefono = txttelefono.Text;

                            user.IDusuario = txtuser.Text;
                            user.Contra = txtpass.Text;
                            user.Idtipousuario = 2;
                            user.Email = txtemail.Text;

                            user.registrar(user);

                            MessageBox.Show("Empresa registrada exitosamente", "E-Market",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una contraseña más fuerte\n\nDebe contener al menos:\n1 Letra mayúscula\n1 Número\n8 Carácteres");
                        }

                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void RegistroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
