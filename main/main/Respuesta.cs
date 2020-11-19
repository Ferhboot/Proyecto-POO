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
    public partial class Respuesta : Form
    {
        Conexion cn = new Conexion();
        string orig = "";
        string dest = "";
        string name = "";
        public Respuesta(string origen, string destino, string nombre)
        {
            InitializeComponent();
            orig = origen;
            dest = destino;
            name = nombre;
            lbuser.Text = nombre;
        }

        private void lbuser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if(txtmensaje.Text.Trim()!="" && txtmensaje.Text.Length < 300)
            {
                cn.enviarMensaje(orig, dest, txtmensaje.Text);
                MessageBox.Show("Mensaje enviado", "Mensaje enviado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmensaje.Clear();
            }
            else
            {
                MessageBox.Show("El mensaje debe tener menos de 299 caracteres",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
