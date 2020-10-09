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
    public partial class Main : Form
    {
        //Lista temporal de categorías (Sólo para referencia)
        private
        List<Categoria> categorias = new List<Categoria>();

        //El programa recibirá un objeto del tipo usuario para poder identificarlo
        //en el transcurso de toda la sesión

        public Main(Usuario user)
        {
            //Si es Invitado, no puede ver su perfil ni vender
            InitializeComponent();
            if (user.Idtipousuario == 0)
            {
                toolStrip1.Items[1].Visible = false;
                toolStrip1.Items[4].Visible = false;
                lbuser.Text = "Invitado";
            }

            //Si no es invitado, tiene acceso a las funciones básicas
            else
            {
                lbuser.Text = user.Nombre;
                toolStrip1.Items[3].Visible = false;
            }
            Categoria cat1 = new Categoria();
            cat1.Nombre = "Arte";
            categorias.Add(cat1);

            Categoria cat2 = new Categoria();
            cat2.Nombre = "Automotriz";
            categorias.Add(cat2);

            Categoria cat3 = new Categoria();
            cat3.Nombre = "Bebé";
            categorias.Add(cat3);

            Categoria cat4 = new Categoria();
            cat4.Nombre = "Belleza y cuidado personal";
            categorias.Add(cat4);

            Categoria cat5 = new Categoria();
            cat5.Nombre = "Computadoras";
            categorias.Add(cat5);

            Categoria cat6 = new Categoria();
            cat6.Nombre = "Deporte";
            categorias.Add(cat6);

            Categoria cat7 = new Categoria();
            cat7.Nombre = "Electrónicos";
            categorias.Add(cat7);

            Categoria cat8 = new Categoria();
            cat8.Nombre = "Hogar";
            categorias.Add(cat8);

            Categoria cat9 = new Categoria();
            cat9.Nombre = "Juguetes";
            categorias.Add(cat9);

            Categoria cat10 = new Categoria();
            cat10.Nombre = "Libros";
            categorias.Add(cat10);

            Categoria cat11 = new Categoria();
            cat11.Nombre = "Salud";
            categorias.Add(cat11);

            Categoria cat12 = new Categoria();
            cat12.Nombre = "Software";
            categorias.Add(cat12);


            dgcategorias.DataSource = null;
            dgcategorias.DataSource = categorias;
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
            Perfil perfil = new Perfil();
            perfil.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            inicio.Show();
            this.Hide();
        }

    }
}
