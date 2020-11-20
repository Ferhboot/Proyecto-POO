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
        public Confirmacion()
        {
            InitializeComponent();
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
    }
}
