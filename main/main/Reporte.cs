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
    public partial class Reporte : Form
    {
        string userid = "";
        public Reporte(string id)
        {
            InitializeComponent();
            userid = id;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtreporte.Clear();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
 
            if (txtreporte.Text!="" && txtreporte.Text.Length < 300)
            {
                try
                {
                    Conexion cn = new Conexion();
                    cn.enviarReporte(userid, txtreporte.Text);
                    MessageBox.Show("Gracias por su reporte. De ser necesario, nos contactaremos con usted.",
                        "Reporte enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Hubo un error" + x.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un mensaje válido y con hasta 299 caracteres");
            }
        }
    }
}
