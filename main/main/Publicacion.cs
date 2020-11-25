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
            idUsuario = personal.IDusuario;           
        }

        public Publicacion(Empresa empresa)
        {
            InitializeComponent();
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
                lblcantidad.Text = "CANTIDAD:";
            }
            else
            {
                lblnombre.Text = "NOMBRE DEL SERVICIO:";
                lblprecio.Text = "PRECIO POR SERVICIO:";
                txtcantidad.Visible = false;
                lblcantidad.Text = "";
            }
        }

        private void Publicacion_Load(object sender, EventArgs e)
        {
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat1();            
            cmbcategoria.DisplayMember = "nombre";
            cmbcategoria.ValueMember = "idcategoria";
            cmbcategoria.DataSource = ds.Tables["categorias"];

            cbcat.DisplayMember = "nombre";
            cbcat.ValueMember = "idcategoria";
            cbcat.DataSource = ds.Tables["categorias"];
            cbcat.SelectedIndex = -1;

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

                if(fo.FileName.ToLower().EndsWith("jpg") || fo.FileName.ToLower().EndsWith("jpeg") || fo.FileName.ToLower().EndsWith("png"))
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(fo.FileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El tamaño de la imagen es demasiado grande", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                }
                else
                {
                    MessageBox.Show("El archivo no cumple el formato: jpg, jpeg o png", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (rbtnBIEN.Checked == true)
            {
                if (txtnombre.Text != "" && cmbcategoria.SelectedIndex != -1 &&
                txtprecio.Text != "" && txtcantidad.Text!="" && txtdescripcion.Text != "")
                {
                    if (pictureBox1.Image != null)
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

                        b.Imagen = ms.GetBuffer();
                        b.User = new Usuario();
                        b.User.IDusuario = idUsuario;
                        b.Cat = new Categoria();
                        b.Cat.Idcategoria = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());

                        b.registrarBienOServicio(b);

                        MessageBox.Show("Producto registrado y publicado exitosamente", "E-Market", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Conexion cn = new Conexion();

                        dtvpublicaciones.DataSource = null;
                        dtvpublicaciones.DataSource = cn.VerMisProductos(idUsuario).Tables["productos"];
                        dtvpublicaciones.Columns[0].Visible = false;
                        dtvpublicaciones.Columns[5].Visible = false;

                        dtvpublicaciones.ClearSelection();

                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Debe asignar una imagen al producto", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else if (rbtnSERVICIO.Checked == true)
            {
                if (txtnombre.Text != "" && cmbcategoria.SelectedIndex != -1 &&
                txtprecio.Text != ""  && txtdescripcion.Text != "")
                {
                    if (pictureBox1.Image != null)
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

                        b.Imagen = ms.GetBuffer();
                        b.User = new Usuario();
                        b.User.IDusuario = idUsuario;
                        b.Cat = new Categoria();
                        b.Cat.Idcategoria = Convert.ToInt32(cmbcategoria.SelectedValue.ToString());

                        b.registrarBienOServicio(b);

                        MessageBox.Show("Producto registrado y publicado exitosamente", "E-Market", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Conexion cn = new Conexion();

                        dtvpublicaciones.DataSource = null;
                        dtvpublicaciones.DataSource = cn.VerMisProductos(idUsuario).Tables["productos"];
                        dtvpublicaciones.Columns[0].Visible = false;
                        dtvpublicaciones.Columns[5].Visible = false;

                        dtvpublicaciones.ClearSelection();

                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Debe asignar una imagen al producto", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Elija un tipo de publicación", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
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
                btnupdate.Enabled = true;
                btneliminar.Enabled = true;
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
                btnupdate.Enabled = false;
                btneliminar.Enabled = false;
            }
            

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtsto.Enabled == true)
            {
                if(txtnom.Text!="" && cbcat.SelectedIndex!=-1 && txtprec.Text!=""
                    && txtsto.Text!="" && txtdesc.Text != "")
                {
                    Conexion cn = new Conexion();
                    string nom = txtnom.Text;
                    string desc = txtdesc.Text;
                    string cat = dtvpublicaciones.CurrentRow.Cells[3].FormattedValue.ToString();
                    double prec = double.Parse(txtprec.Text);
                    int sto = int.Parse(txtsto.Text);
                    int idprod = int.Parse(dtvpublicaciones.CurrentRow.Cells[0].FormattedValue.ToString());

                    cn.UpdateProductoA(idprod, nom, desc, int.Parse(cbcat.SelectedValue.ToString()), prec, sto);

                    MessageBox.Show("Producto actualizado", "Éxito", MessageBoxButtons.OK,
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

                    txtnom.Clear();
                    txtprec.Clear();
                    cbcat.SelectedIndex = -1;
                    txtsto.Clear();
                    txtdesc.Clear();

                    btnupdate.Enabled = false;
                    btneliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

            else
            {
                if (txtnom.Text != "" && cbcat.SelectedIndex != -1 && txtprec.Text != ""
                     && txtdesc.Text != "")
                {
                    Conexion cn = new Conexion();
                    string nom = txtnom.Text;
                    string desc = txtdesc.Text;
                    string cat = dtvpublicaciones.CurrentRow.Cells[3].FormattedValue.ToString();
                    double prec = double.Parse(txtprec.Text);
                    int idprod = int.Parse(dtvpublicaciones.CurrentRow.Cells[0].FormattedValue.ToString());

                    cn.UpdateProductoB(idprod, nom, desc, int.Parse(cbcat.SelectedValue.ToString()), prec);

                    MessageBox.Show("Producto actualizado", "Éxito", MessageBoxButtons.OK,
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

                    txtnom.Clear();
                    txtprec.Clear();
                    cbcat.SelectedIndex = -1;
                    txtsto.Clear();
                    txtdesc.Clear();

                    btnupdate.Enabled = false;
                    btneliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            Conexion cn = new Conexion();
            dtvpublicaciones.DataSource = null;
            dtvpublicaciones.DataSource = cn.VerMisProductos(idUsuario).Tables["productos"];
            dtvpublicaciones.Columns[0].Visible = false;
            dtvpublicaciones.Columns[5].Visible = false;

            txtnom.Enabled = false;
            txtprec.Enabled = false;
            cbcat.Enabled = false;
            txtsto.Enabled = false;
            txtdesc.Enabled = false;

            txtnom.Clear();
            txtprec.Clear();
            cbcat.SelectedIndex = -1;
            txtsto.Clear();
            txtdesc.Clear();

            btnupdate.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void txtprec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if((e.KeyChar == '.') && (!txtprec.Text.Contains(".")))
            { 
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '.') && (!txtprecio.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
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
