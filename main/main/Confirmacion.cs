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
        Conexion cn = new Conexion();
        List<Factura> items;
        public Confirmacion(string idUser, List<Factura> lista, double total)
        {
            InitializeComponent();

            usuario = idUser;

            dgconfirmacion.DataSource = null;
            dgconfirmacion.DataSource = lista;

            dgconfirmacion.Columns[0].Visible = false;
            dgconfirmacion.Columns[2].Visible = false;

            lbtotal.Text = total.ToString();

            items = lista;
        }

        private void Confirmacion_Load(object sender, EventArgs e)
        {
            rbmidireccion.Checked = true;
            cbdepartamento.SelectedIndex = -1;
        }

        private void rbotradireccion_CheckedChanged(object sender, EventArgs e)
        {
            txtdireccion.Enabled = true;
            txtmunicipio.Enabled = true;
            cbdepartamento.Enabled = true;
            txttelefono.Enabled = true;
            txtdireccion.Focus();
        }

        private void rbmidireccion_CheckedChanged(object sender, EventArgs e)
        {
            txtdireccion.Enabled = false;
            txtmunicipio.Enabled = false;
            cbdepartamento.Enabled = false;
            txttelefono.Enabled = false;
            txtdireccion.Clear();
            txtmunicipio.Clear();
            txttelefono.Clear();
            cbdepartamento.SelectedIndex = -1;
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {
           
            if (rbmidireccion.Checked == true)
            {
                string info = cn.ObtenerDatosConf(usuario);

                int cuenta = items.Count;
                try
                {
                    for (int i = 0; i < cuenta; i++)
                    {
                        string prod = items[i].Producto;
                        int cant = items[i].Cantidad;
                        double pre = items[i].Precio;
                        double tot = cant * pre;
                        string msg = "Compra: " + info + ". " + cant.ToString()
                            + " " + prod + ". Total $" + tot.ToString();

                        string vendedor = items[i].idVendedor;

                        cn.AlertarCompra(usuario, vendedor, msg);
                    }
                    string n = "Su orden ha sido efectuada. El vendedor se contactará con usted en caso de necesitar mayor información";
                    MessageBox.Show(n, "Orden recibida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Comprobante c = new Comprobante(usuario);
                    c.ShowDialog();

                    cn.CambiarEstadoCompra(usuario);

                    

                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            else if (rbotradireccion.Checked == true)
            {
                if (txtdireccion.Text != "" && txtmunicipio.Text != "" 
                    && txttelefono.Text != "" && cbdepartamento.SelectedIndex > 0)
                {
                    string dir = txtdireccion.Text + ". " + txtmunicipio.Text + ", " 
                        + cbdepartamento.Text + "(" + txttelefono.Text + ")";
                    int cuenta = items.Count;
                    string nom = cn.ObtenerNombre(usuario);

                    for (int i = 0; i < cuenta; i++)
                    {
                        int quantity = items[i].Cantidad;
                        string prod = items[i].Producto;
                        double cost = items[i].Precio;
                        double tot = quantity * cost;
                        string destino = items[i].idVendedor;
                        string msg = "Compra: " + nom + ". " + dir + ". " + quantity.ToString() +
                            " " + prod + ", por $" + tot.ToString();

                        cn.AlertarCompra(usuario, destino, msg);
                        
                    }
                    string n = "Su orden ha sido efectuada. El vendedor se contactará con usted en caso de necesitar mayor información";
                    MessageBox.Show(n, "Orden recibida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.CambiarEstadoCompra(usuario);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Hay un error con sus datos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
        }
    }
}
