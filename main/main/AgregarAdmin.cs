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
        Conexion cn = new Conexion();
        public AgregarAdmin()
        {
            InitializeComponent();
            cargar();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtpass.Clear();
            txtemail.Clear();
            txtid.Focus();
        }

        void cargar()
        {
            dgadmin.DataSource = null;
            dgadmin.DataSource = cn.mostrarAdmin().Tables["administradores"];
            dgadmin.ClearSelection();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.agregarAdmin(txtid.Text, txtemail.Text, txtpass.Text);
                string mensaje = "El usuario administrador ha sido agregado al programa";
                MessageBox.Show(mensaje, "Administrador agregado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo completar la acción" + x.ToString(), 
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
