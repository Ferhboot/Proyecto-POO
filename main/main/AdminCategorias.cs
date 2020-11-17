﻿using System;
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
            Conexion con = new Conexion();
            DataSet ds = con.leercat1();
            dgvcategorias.DataSource = ds.Tables["categorias"];
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Validaciones validacion = new Validaciones();
            if (!validacion.enBlanco(txtcategoria.Text))
            {
                MessageBox.Show("Categoría agregada exitosamente", "E-Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre de la categoría");
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
            Categoria cat = new Categoria();
            if (cat.modificarCategoria(cat.Idcategoria, txtnom.Text) == true){
                MessageBox.Show("Categoría modificada con éxito", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);//
            }
            else
            {
                MessageBox.Show("Hubo un error, intente nuevamente", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvcategorias_DoubleClick(object sender, EventArgs e)
        {
            int idcat = 0;
            
            Conexion con = new Conexion();    
            idcat = int.Parse(dgvcategorias.CurrentRow.Cells[0].FormattedValue.ToString());
            cat = con.datoscat(idcat);
            txtnom.Text = cat.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnom.ReadOnly = false;
            button1.Enabled = false;
        }
    }
}
