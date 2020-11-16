﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace main
{
    public partial class Main : Form
    {
        Datos d = null;
        Empresa emp = null;

        List<BienOServicio> b = new List<BienOServicio>();

        int paginaActual;
        public Main(Datos user)
        {
            InitializeComponent();
            lbuser.Text = user.Nombre + ' ' + user.Apellido;
            toolStrip1.Items[3].Visible = false;      
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat ();
            dgcategorias.DataSource = ds.Tables["categorias"];
            d = user;


        }

        public Main(Empresa empresa)
        {
            InitializeComponent();
            lbuser.Text = empresa.Nombre;
            toolStrip1.Items[3].Visible = false;
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat();
            dgcategorias.DataSource = ds.Tables["categorias"];
            emp = empresa;

        }


        public Main()
        {
            InitializeComponent();
            toolStrip1.Items[1].Visible = false;
            toolStrip1.Items[4].Visible = false;
            lbuser.Text = "Invitado";
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat();
            dgcategorias.DataSource = ds.Tables["categorias"];


        }


        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
            {
                //Esto cancelará la operación de FormClosing si se recibe la opción NO desde
                //messagebox
                e.Cancel = true;
            }
        }


        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            about acerca = new about();
            acerca.ShowDialog();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(d);
            perfil.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            inicio.Show();
            this.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Publicacion pub;
            if (d != null)
            {
                pub = new Publicacion(d);
            }
            else
            {
                pub = new Publicacion(emp);
            }
            
            pub.ShowDialog();
        }

        private void tsUser_ButtonClick(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil(d);
            perfil.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgcategorias.ClearSelection();

            Conexion p = new Conexion();

            if (p.listaBienOServicio() != null) {

                paginaActual = 1;
             
                b = p.listaBienOServicio();

               if (b.Count>=4)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[1].Imagen);
                    System.IO.MemoryStream ms3 = new System.IO.MemoryStream(b[2].Imagen);
                    System.IO.MemoryStream ms4 = new System.IO.MemoryStream(b[3].Imagen);

                    pb1.Image = Image.FromStream(ms);
                    pb2.Image = Image.FromStream(ms2);
                    pb3.Image = Image.FromStream(ms3);
                    pb4.Image = Image.FromStream(ms4);

                    label1.Text = b[0].Nombre;
                    label2.Text = b[1].Nombre;
                    label3.Text = b[2].Nombre;
                    label4.Text = b[3].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = true;
                    pb3.Visible = true;
                    pb4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = true;
                    tableLayoutPanel8.Visible = true;
                    tableLayoutPanel9.Visible = true;


                }
                else if(b.Count == 3)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);
                    System.IO.MemoryStream ms1 = new System.IO.MemoryStream(b[1].Imagen);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[2].Imagen);

                    pb1.Image = Image.FromStream(ms);
                    pb2.Image = Image.FromStream(ms1);
                    pb3.Image = Image.FromStream(ms2);

                    label1.Text = b[0].Nombre;
                    label2.Text = b[1].Nombre;
                    label3.Text = b[2].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = true;
                    pb3.Visible = true;
                    pb4.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = true;
                    tableLayoutPanel8.Visible = true;
                    tableLayoutPanel9.Visible = false;

                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;

                }
                else if (b.Count == 2)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[1].Imagen);

                    pb1.Image = Image.FromStream(ms);
                    pb2.Image = Image.FromStream(ms2);

                    label1.Text = b[0].Nombre;
                    label2.Text = b[1].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = true;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = true;
                    tableLayoutPanel8.Visible = false;
                    tableLayoutPanel9.Visible = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;

                }
                else if (b.Count == 1)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);

                    pb1.Image = Image.FromStream(ms);

                    label1.Text = b[0].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    label1.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = false;
                    tableLayoutPanel8.Visible = false;
                    tableLayoutPanel9.Visible = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;

                }
                else if (b.Count <= 1)
                {

                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = false;
                    tableLayoutPanel7.Visible = false;
                    tableLayoutPanel8.Visible = false;
                    tableLayoutPanel9.Visible = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }


            }



        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void paginador()
        {
            
            button6.Text = (paginaActual).ToString();
            button7.Text = (paginaActual + 1).ToString();        

            if (b.Count >= (paginaActual * 4))
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b[(paginaActual * 4) - 4].Imagen);
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[(paginaActual * 4) - 3].Imagen);
                System.IO.MemoryStream ms3 = new System.IO.MemoryStream(b[(paginaActual * 4) - 2].Imagen);
                System.IO.MemoryStream ms4 = new System.IO.MemoryStream(b[(paginaActual * 4) - 1].Imagen);

                pb1.Image = Image.FromStream(ms);
                pb2.Image = Image.FromStream(ms2);
                pb3.Image = Image.FromStream(ms3);
                pb4.Image = Image.FromStream(ms4);

                label1.Text = b[(paginaActual * 4) - 4].Nombre;
                label2.Text = b[(paginaActual * 4) - 3].Nombre;
                label3.Text = b[(paginaActual * 4) - 2].Nombre;
                label4.Text = b[(paginaActual * 4) - 1].Nombre;

                pb1.Visible = true;
                pb2.Visible = true;
                pb3.Visible = true;
                pb4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                tableLayoutPanel6.Visible = true;
                tableLayoutPanel7.Visible = true;
                tableLayoutPanel8.Visible = true;
                tableLayoutPanel9.Visible = true;


            }
            else if (b.Count == (paginaActual * 4) - 1)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b[(paginaActual * 4) - 4].Imagen);
                System.IO.MemoryStream ms1 = new System.IO.MemoryStream(b[(paginaActual * 4) - 3].Imagen);
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[(paginaActual * 4) - 2].Imagen);

                pb1.Image = Image.FromStream(ms);
                pb2.Image = Image.FromStream(ms1);
                pb3.Image = Image.FromStream(ms2);

                label1.Text = b[(paginaActual * 4) - 4].Nombre;
                label2.Text = b[(paginaActual * 4) - 3].Nombre;
                label3.Text = b[(paginaActual * 4) - 2].Nombre;

                pb1.Visible = true;
                pb2.Visible = true;
                pb3.Visible = true;
                pb4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
                tableLayoutPanel6.Visible = true;
                tableLayoutPanel7.Visible = true;
                tableLayoutPanel8.Visible = true;
                tableLayoutPanel9.Visible = false;

                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = false;

            }
            else if (b.Count == (paginaActual * 4) - 2)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b[(paginaActual * 4) - 4].Imagen);
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[(paginaActual * 4) - 3].Imagen);

                pb1.Image = Image.FromStream(ms);
                pb2.Image = Image.FromStream(ms2);

                label1.Text = b[(paginaActual * 4) - 4].Nombre;
                label2.Text = b[(paginaActual * 4) - 3].Nombre;

                pb1.Visible = true;
                pb2.Visible = true;
                pb3.Visible = false;
                pb4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                tableLayoutPanel6.Visible = true;
                tableLayoutPanel7.Visible = true;
                tableLayoutPanel8.Visible = false;
                tableLayoutPanel9.Visible = false;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = false;

            }
            else if (b.Count == (paginaActual * 4) - 3)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b[(paginaActual * 4) - 4].Imagen);

                pb1.Image = Image.FromStream(ms);

                label1.Text = b[(paginaActual * 4) - 4].Nombre;

                pb1.Visible = true;
                pb2.Visible = false;
                pb3.Visible = false;
                pb4.Visible = false;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                tableLayoutPanel6.Visible = true;
                tableLayoutPanel7.Visible = false;
                tableLayoutPanel8.Visible = false;
                tableLayoutPanel9.Visible = false;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = false;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            paginaActual += 1;

            if((paginaActual * 4) >= (b.Count)) {

                paginador();

            }
            else
            {
                paginaActual -= 1;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            paginaActual -= 1;

            if (paginaActual  >= 1)
            {

                paginador();

                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

            }
            else
            {
                paginaActual += 1;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            paginaActual += 1;

            if ((paginaActual * 4) >= (b.Count))
            {

                paginador();

            }
            else
            {
                paginaActual -= 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dgcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string categoria = "";

            categoria = dgcategorias.CurrentCell.Value.ToString();

            Conexion p = new Conexion();

            if (p.listaBienOServicio() != null)
            {

                paginaActual = 1;

                b = p.listaPorCategoria(categoria);

                if (b.Count >= 4)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[1].Imagen);
                    System.IO.MemoryStream ms3 = new System.IO.MemoryStream(b[2].Imagen);
                    System.IO.MemoryStream ms4 = new System.IO.MemoryStream(b[3].Imagen);

                    pb1.Image = Image.FromStream(ms);
                    pb2.Image = Image.FromStream(ms2);
                    pb3.Image = Image.FromStream(ms3);
                    pb4.Image = Image.FromStream(ms4);

                    label1.Text = b[0].Nombre;
                    label2.Text = b[1].Nombre;
                    label3.Text = b[2].Nombre;
                    label4.Text = b[3].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = true;
                    pb3.Visible = true;
                    pb4.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = true;
                    tableLayoutPanel8.Visible = true;
                    tableLayoutPanel9.Visible = true;


                }
                else if (b.Count == 3)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);
                    System.IO.MemoryStream ms1 = new System.IO.MemoryStream(b[1].Imagen);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[2].Imagen);

                    pb1.Image = Image.FromStream(ms);
                    pb2.Image = Image.FromStream(ms1);
                    pb3.Image = Image.FromStream(ms2);

                    label1.Text = b[0].Nombre;
                    label2.Text = b[1].Nombre;
                    label3.Text = b[2].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = true;
                    pb3.Visible = true;
                    pb4.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = true;
                    tableLayoutPanel8.Visible = true;
                    tableLayoutPanel9.Visible = false;

                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;

                }
                else if (b.Count == 2)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);
                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream(b[1].Imagen);

                    pb1.Image = Image.FromStream(ms);
                    pb2.Image = Image.FromStream(ms2);

                    label1.Text = b[0].Nombre;
                    label2.Text = b[1].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = true;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = true;
                    tableLayoutPanel8.Visible = false;
                    tableLayoutPanel9.Visible = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;

                }
                else if (b.Count == 1)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(b[0].Imagen);

                    pb1.Image = Image.FromStream(ms);

                    label1.Text = b[0].Nombre;

                    pb1.Visible = true;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    label1.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = true;
                    tableLayoutPanel7.Visible = false;
                    tableLayoutPanel8.Visible = false;
                    tableLayoutPanel9.Visible = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;

                }
                else if (b.Count <= 1)
                {

                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    tableLayoutPanel6.Visible = false;
                    tableLayoutPanel7.Visible = false;
                    tableLayoutPanel8.Visible = false;
                    tableLayoutPanel9.Visible = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                }


            }

        }
    }
}
