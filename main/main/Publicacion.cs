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
    public partial class Publicacion : Form
    {
        string idUsuario;
        public Publicacion(Datos personal)
        {
            InitializeComponent();
            txtpormayor.Enabled = false;
            idUsuario = personal.IDusuario;           
        }

        public Publicacion(Empresa empresa)
        {
            InitializeComponent();
            txtpormayor.Enabled = true;
            idUsuario = empresa.IDusuario;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnBIEN_CheckedChanged(object sender, EventArgs e)
        {
            limpiar();

            if (rbtnBIEN.Checked)
            {
                lblnombre.Text = "NOMBRE DEL PRODUCTO:";
                lblprecio.Text = "PRECIO UNITARIO:";
                txtcantidad.Visible = true;
                txtpormayor.Visible = true;
                lblcantidad.Text = "CANTIDAD:";
                lblpormayor.Text = "CANTIDAD AL POR MAYOR:";
                lble.Text = "*solo empresas";
            }
            else
            {
                lblnombre.Text = "NOMBRE DEL SERVICIO:";
                lblprecio.Text = "PRECIO POR SERVICIO:";
                txtcantidad.Visible = false;
                txtpormayor.Visible = false;
                lblcantidad.Text = "";
                lblpormayor.Text = "";
                lble.Text = "";
            }
        }

        private void Publicacion_Load(object sender, EventArgs e)
        {
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat1();            
            cmbcategoria.DisplayMember = "nombre";
            cmbcategoria.ValueMember = "idcategoria";
            cmbcategoria.DataSource = ds.Tables["categorias"];

            dtvpublicaciones.DataSource = null;
            dtvpublicaciones.DataSource = cat.VerMisProductos(idUsuario).Tables["productos"];
            dtvpublicaciones.Columns[0].Visible = false;
            dtvpublicaciones.Columns[5].Visible = false;

            txtnom.Enabled = false;
            txtprec.Enabled = false;
            cbcat.Enabled = false;
            txtsto.Enabled = false;
            txtdesc.Enabled = false;

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();

            if (rs == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


            BienOServicio b = new BienOServicio();

            b.Nombre = txtnombre.Text;
            b.Descripcion = txtdescripcion.Text;
            b.Precio = float.Parse(txtprecio.Text);

            if (txtcantidad.Text.Trim() != "")
            {
                b.Cantidad = int.Parse(txtcantidad.Text);
            }
            else
            {
                if (rbtnSERVICIO.Checked)
                {
                    b.Cantidad = -1;
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            

            if (txtpormayor.Text.Trim() != "")
            {
                b.Mayoreo = int.Parse(txtpormayor.Text);
            }
            else
            {
                b.Mayoreo = 0;
            }

            b.Imagen = ms.GetBuffer();
            b.User = new Usuario();
            b.User.IDusuario = idUsuario;
            b.Cat = new Categoria();
            b.Cat.Idcategoria = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());

            b.registrarBienOServicio(b);

            MessageBox.Show("Producto registrado y publicado exitosamente", "E-Market",MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiar();
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            txtpormayor.Text = "";
            pictureBox1.Image = null;
        }

        private void btnREGRESAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtvpublicaciones_DoubleClick(object sender, EventArgs e)
        {
            if (dtvpublicaciones.Rows.Count != 0)
            {
                string nom = dtvpublicaciones.CurrentRow.Cells[1].FormattedValue.ToString();
                txtnom.Text = nom;
                txtnom.Enabled = true;
                string desc = dtvpublicaciones.CurrentRow.Cells[2].FormattedValue.ToString();
                txtdesc.Text = desc;
                txtdesc.Enabled = true;
                string cat = dtvpublicaciones.CurrentRow.Cells[3].FormattedValue.ToString();
                cbcat.Text = cat;
                cbcat.Enabled = true;
                double prec = double.Parse(dtvpublicaciones.CurrentRow.Cells[4].FormattedValue.ToString());
                txtprec.Text = prec.ToString();
                txtprec.Enabled = true;
                int sto = int.Parse(dtvpublicaciones.CurrentRow.Cells[5].FormattedValue.ToString());
                if (sto > 0)
                {
                    txtsto.Text = sto.ToString();
                    txtsto.Enabled = true;
                }
                else
                {
                    txtsto.Enabled = false;
                }
            }
            else
            {

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int prod = int.Parse(dtvpublicaciones.CurrentRow.Cells[0].FormattedValue.ToString());
            Conexion cn = new Conexion();
            if (MessageBox.Show("¿Realmente desea eliminar este producto? Esta acción no se puede deshacer",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.eliminarProducto(prod);
                MessageBox.Show("Producto eliminado", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dtvpublicaciones.DataSource = null;
                dtvpublicaciones.DataSource = cn.VerMisProductos(idUsuario).Tables["productos"];
                dtvpublicaciones.Columns[0].Visible = false;
                dtvpublicaciones.Columns[5].Visible = false;

                txtnom.Enabled = false;
                txtprec.Enabled = false;
                cbcat.Enabled = false;
                txtsto.Enabled = false;
                txtdesc.Enabled = false;
            }
            

        }
    }
}
