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
        int globalCantidad = 1;
        public VerProducto(string user, int idProducto, int tipoUsuario)
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
                globalCantidad = b.Cantidad;
                ncant.Enabled = true;
            }

            if (tipoUsuario == 0)
            {
                btncontactar.Visible = false;
                btncarrito.Text = "Comprar ahora";
            }

            lbcategoria.Text = b.Cat.Nombre;

            iduser = user;

            System.IO.MemoryStream ms = new System.IO.MemoryStream(b.Imagen);
            pbimagen.Image = Image.FromStream(ms);

            this.ActiveControl = btncarrito;


        }

        private void btncarrito_Click(object sender, EventArgs e)
        {
            if (iduser!="" && globalCantidad>=ncant.Value)
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
                        MessageBox.Show("Existencias no disponibles o servicio ya en carrito", "E-Market",
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

        private void btncontactar_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            Respuesta resp = new Respuesta(iduser, b.User.IDusuario, cn.nombre(b.User.IDusuario));
            MessageBox.Show("Recuerde especificar el producto de su interés en el mensaje",
                "E-Market", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            resp.ShowDialog();
        }
    }
}
