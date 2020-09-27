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
        }
    }
}
