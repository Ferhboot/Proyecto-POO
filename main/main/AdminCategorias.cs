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
    public partial class AdminCategorias : Form
    {
        Categoria cat = new Categoria();
        Conexion con = new Conexion();
        
        public AdminCategorias()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void AdminCategorias_Load(object sender, EventArgs e)
        {
            DataSet ds = con.leercat1();
            dgvcategorias.DataSource = ds.Tables["categorias"];
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Validaciones validacion = new Validaciones();
            if (!validacion.enBlanco(txtcategoria.Text))
            {
                try
                {
                    if (cat.agregarCategoria(txtcategoria.Text) == true)
                    {
                        MessageBox.Show("Categoría agregada exitosamente", "E-Market",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        DataSet ds = con.leercat1();
                        dgvcategorias.DataSource = null;
                        dgvcategorias.DataSource = ds.Tables["categorias"];
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }                              
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la categoría", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiar()
        {
            txtcategoria.Text = "";
        }

        private void AdminCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try {
                if (cat.modificarCategoria(cat.Idcategoria, txtnom.Text) == true)
                    {
                    MessageBox.Show("Categoría modificada con éxito", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSet ds = con.leercat1();
                    dgvcategorias.DataSource = null;
                    dgvcategorias.DataSource = ds.Tables["categorias"];
                    txtnom.Clear();
                    cat = null;
                    btneliminar.Enabled = false;
                    btnmodificar.Enabled = false;
                    }
                else
                    {
                    MessageBox.Show("Hubo un error, intente nuevamente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch
                {
                MessageBox.Show("Hubo un error", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea eliminar esta categoría?", "E-Market",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cat.eliminarCategoria(cat.Idcategoria) == true)
                    {
                        MessageBox.Show("Categoría eliminada con éxito", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataSet ds = con.leercat1();
                        dgvcategorias.DataSource = null;
                        dgvcategorias.DataSource = ds.Tables["categorias"];
                        txtnom.Clear();
                        cat = null;
                        btneliminar.Enabled = false;
                        btnmodificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error, intente nuevamente", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error, intente nuevamente", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvcategorias_DoubleClick(object sender, EventArgs e)
        {
            int idcat = 0;
            Conexion con = new Conexion();    
            idcat = int.Parse(dgvcategorias.CurrentRow.Cells[0].FormattedValue.ToString());       
            cat = con.datoscat(idcat);
            txtnom.Text = cat.Nombre;
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnom.ReadOnly = false;
            button1.Enabled = false;
        }
    }
}
