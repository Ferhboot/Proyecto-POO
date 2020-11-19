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
    public partial class CarritoCompras : Form
    {

        string user;
        int idproducto;
        int tipo;
        int cantidadActual;
        public CarritoCompras(string iduser)
        {
            InitializeComponent();

            Conexion cn = new Conexion();
            dgvcarrito.DataSource = cn.verCarrito(iduser).Tables["carrito"];
            dgvcarrito.ClearSelection();

            lbtotal.Text = "$"+cn.precioTotal(iduser).ToString();

            DateTime fechaActual = DateTime.Today;

            lbfecha.Text = fechaActual.ToString("dd/mm/yyyy");

            dgvcarrito.Columns[0].Visible = false;
            dgvcarrito.Columns[1].Visible = false;
            user = iduser;

        }

        private void dgvcarrito_DoubleClick(object sender, EventArgs e)
        {
            //int id = int.Parse(dgvcarrito.CurrentRow.Cells[0].FormattedValue.ToString());    

            idproducto = int.Parse(dgvcarrito.CurrentRow.Cells[0].FormattedValue.ToString());
            tipo = int.Parse(dgvcarrito.CurrentRow.Cells[1].FormattedValue.ToString());

            string nombre = dgvcarrito.CurrentRow.Cells[2].FormattedValue.ToString();
            decimal cantidad = Convert.ToDecimal(dgvcarrito.CurrentRow.Cells[4].FormattedValue.ToString());

            cantidadActual = int.Parse(dgvcarrito.CurrentRow.Cells[4].FormattedValue.ToString());

            lbproducto.Text = nombre;

            cant.Value = cantidad;

            cant.Enabled = true;
            btnactualizar.Enabled = true;
            btneliminar.Enabled = true;

            
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (tipo !=-1 && tipo >0) { 
                Conexion cn = new Conexion();
                cn.actualizarCarrito(user,idproducto,Convert.ToInt32(cant.Value),cantidadActual);
                cant.Value = 1;
                cant.Enabled = false;
                btnactualizar.Enabled = false;
                btneliminar.Enabled = false;
                MessageBox.Show("Existencias actualizadas", "E-Market",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("existencias no disponibles o es un servicio", "E-Market",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
