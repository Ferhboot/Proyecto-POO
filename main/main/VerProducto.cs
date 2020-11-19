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
    public partial class VerProducto : Form
    {

        BienOServicio b = null;
        string iduser = "";
        public VerProducto(string user, int idProducto)
        {

            InitializeComponent();

            b = new BienOServicio();
            Conexion cn = new Conexion();
            b = cn.verProducto(idProducto);

            lbnombre.Text = b.Nombre;
            txbdescripcion.Text = b.Descripcion;
            lbvendendor.Text = cn.nombre(b.User.IDusuario);

            if (b.Cantidad == -1)
            {
                label2.Text = "En Servicio";
                lbstock.Text = "";
                ncant.Enabled = false;
            }
            else
            {
                label2.Text = "Stock: ";
                lbstock.Text = b.Cantidad.ToString();
                ncant.Enabled = true;
            }

            lbcategoria.Text = b.Cat.Nombre;

            iduser = user;

            System.IO.MemoryStream ms = new System.IO.MemoryStream(b.Imagen);
            pbimagen.Image = Image.FromStream(ms);

            this.ActiveControl = btncarrito;


        }

        private void btncarrito_Click(object sender, EventArgs e)
        {
            if (iduser!="")
            {

                if(int.Parse(ncant.Text)>0) { 
                    Conexion cn = new Conexion();


                    if (cn.agregarPedido(iduser, b.IdBienOServicio, Decimal.ToInt32(ncant.Value)))
                    {
                        MessageBox.Show("Se ha agregado al carrito de compras exitosamente", "E-Market",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("existencias no disponibles o servicio ya en carrito", "E-Market",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad inválida", "E-Market",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Debe registrarse previamente", "E-Market",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
