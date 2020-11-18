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
    public partial class AgregarAdmin : Form
    {
        Validaciones val = new Validaciones();
        Conexion cn = new Conexion();
        public AgregarAdmin()
        {
            InitializeComponent();
            cargar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void cargar()
        {
            dgadmin.DataSource = null;
            dgadmin.DataSource = cn.mostrarAdmin().Tables["administradores"];
            dgadmin.ClearSelection();
        }

        void limpiar()
        {
            txtid.Clear();
            txtpass.Clear();
            txtemail.Clear();
            txtid.Focus();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtemail.Text.Trim() != "" && txtid.Text.Trim() != "" && txtpass.Text.Trim() != "")
            {
                if (val.esCorreo(txtemail.Text))
                {
                    if (val.esFuerte(txtpass.Text))
                    {
                        try
                        {
                            cn.agregarAdmin(txtid.Text, txtemail.Text, txtpass.Text);
                            string mensaje = "El usuario administrador ha sido agregado al programa";
                            MessageBox.Show(mensaje, "Administrador agregado",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargar();
                            limpiar();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("No se pudo completar la acción",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string aviso = "Debe ingresar una contraseña válida con al menos " +
                            Environment.NewLine + Environment.NewLine +
                            "1 Mayúscula" + Environment.NewLine + "1 Número" +
                            Environment.NewLine + "8 caracteres en total";
                        MessageBox.Show(aviso, "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una dirección de correo electrónico válida",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            
        }
    }
}
