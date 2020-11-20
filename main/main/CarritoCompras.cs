using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        string globalIDuser = "";
        public CarritoCompras(string iduser)
        {
            InitializeComponent();

            globalIDuser = iduser;

            Conexion cn = new Conexion();
            dgvcarrito.DataSource = cn.verCarrito(iduser).Tables["carrito"];
            dgvcarrito.ClearSelection();

            lbtotal.Text = "$"+cn.precioTotal(iduser).ToString();

            DateTime fechaActual = DateTime.Today;

            lbfecha.Text = fechaActual.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture);

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
                MessageBox.Show("Cantidad Actualizada", "E-Market",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvcarrito.DataSource = cn.verCarrito(globalIDuser).Tables["carrito"];
                dgvcarrito.ClearSelection();
            }
            else
            {
                MessageBox.Show("Existencias no disponibles o es un servicio", "E-Market",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CarritoCompras_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();

            if (MessageBox.Show("¿Desea eliminar este producto?", 
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idproducto = int.Parse(dgvcarrito.CurrentRow.Cells[0].FormattedValue.ToString());
                int cantidad = int.Parse(dgvcarrito.CurrentRow.Cells[4].FormattedValue.ToString());
                cn.eliminarDelCarrito(idproducto, globalIDuser, cantidad);
                dgvcarrito.DataSource = cn.verCarrito(globalIDuser).Tables["carrito"];
                dgvcarrito.ClearSelection();

                btneliminar.Enabled = false;
                btnactualizar.Enabled = false;
            }

            
        }
    }
}
