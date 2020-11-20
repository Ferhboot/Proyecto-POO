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
    public partial class Confirmacion : Form
    {
        string usuario = "";
        public Confirmacion(string idUser, List<Factura> lista, double total)
        {
            InitializeComponent();

            usuario = idUser;

            dgconfirmacion.DataSource = null;
            dgconfirmacion.DataSource = lista;

            dgconfirmacion.Columns[0].Visible = false;
            dgconfirmacion.Columns[2].Visible = false;

            lbtotal.Text = total.ToString();
        }

        private void Confirmacion_Load(object sender, EventArgs e)
        {
            rbmidireccion.Checked = true;
            txtindicaciones.Focus();
            cbdepartamento.SelectedIndex = -1;
        }

        private void rbotradireccion_CheckedChanged(object sender, EventArgs e)
        {
            txtdireccion.Enabled = true;
            txtmunicipio.Enabled = true;
            cbdepartamento.Enabled = true;
            txtdireccion.Focus();
        }

        private void rbmidireccion_CheckedChanged(object sender, EventArgs e)
        {
            txtdireccion.Enabled = false;
            txtmunicipio.Enabled = false;
            cbdepartamento.Enabled = false;
            txtdireccion.Clear();
            txtmunicipio.Clear();
            cbdepartamento.SelectedIndex = -1;
            txtindicaciones.Focus();
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
            if (rbmidireccion.Checked == true)
            {

            }

            else if (rbotradireccion.Checked == true)
            {

            }

            else
            {
                MessageBox.Show("Hay un error con sus datos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
