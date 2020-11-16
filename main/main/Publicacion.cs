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
    }
}
