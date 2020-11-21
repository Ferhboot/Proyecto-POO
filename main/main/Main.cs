using System;
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
        int invitado = 0;
        string iduser="";
        int tipo = 0;

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
            iduser = user.IDusuario;
            btnmensajes.Text=Convert.ToString(cat.numeroMensajes(d.IDusuario));
            btncarrito.Text = Convert.ToString(cat.numeroCarrito(d.IDusuario));
            tipo = 1;
        }

        public Main(Empresa empresa)
        {
            InitializeComponent();
            lbuser.Text = empresa.Nombre + ' ' + empresa.Apellido;
            toolStrip1.Items[3].Visible = false;
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat();
            dgcategorias.DataSource = ds.Tables["categorias"];
            emp = empresa;
            iduser = empresa.IDusuario;
            btnmensajes.Text = Convert.ToString(cat.numeroMensajes(emp.IDusuario));
            btncarrito.Text = Convert.ToString(cat.numeroCarrito(emp.IDusuario));
            tipo = 2;
        }


        public Main(int inv)
        {
            InitializeComponent();
            toolStrip1.Items[1].Visible = false;
            toolStrip1.Items[4].Visible = false;
            lbuser.Text = "Invitado";
            Conexion cat = new Conexion();
            DataSet ds = cat.leercat();
            dgcategorias.DataSource = ds.Tables["categorias"];
            invitado = inv;
            btnmensajes.Visible = false;
            btncarrito.Visible = false;
            btnmisproductos.Visible = false;
            btnmiperfil.Visible = false;
            btnreportar.Visible = false;

            tipo = 0;
        }


        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            Perfil perfil;
            if (d != null)
            {
                perfil = new Perfil(d);
            }
            else
            {
                perfil = new Perfil(emp);
            }


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
            Perfil perfil;
            if (d != null)
            {
                perfil = new Perfil(d);
            }
            else
            {
                perfil = new Perfil(emp);
            }

            
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

                paginador();


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

                label5.Text = "$" + b[(paginaActual * 4) - 4].Precio.ToString("n2");
                label6.Text = "$" + b[(paginaActual * 4) - 3].Precio.ToString("n2");
                label7.Text = "$" + b[(paginaActual * 4) - 2].Precio.ToString("n2");
                label8.Text = "$" + b[(paginaActual * 4) - 1].Precio.ToString("n2");

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

                label5.Text = "$" + b[(paginaActual * 4) - 4].Precio.ToString("n2");
                label6.Text = "$" + b[(paginaActual * 4) - 3].Precio.ToString("n2");
                label7.Text = "$" + b[(paginaActual * 4) - 2].Precio.ToString("n2");

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

                label5.Text = "$" + b[(paginaActual * 4) - 4].Precio.ToString("n2");
                label6.Text = "$" + b[(paginaActual * 4) - 3].Precio.ToString("n2");

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

                label5.Text = "$" + b[(paginaActual * 4) - 4].Precio.ToString("n2");

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
            else
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

        private void button8_Click(object sender, EventArgs e)
        {

            paginaActual += 1;

            if((b.Count) >= (paginaActual * 4)) {

                paginador();

                if ((paginaActual * 4) != b.Count)
                {                 
                    button6.BackColor = Color.IndianRed;
                    button6.ForeColor = Color.White;
                    button7.BackColor = Color.Wheat;
                    button7.ForeColor = Color.Black;
                    button6.Text = (paginaActual - 1).ToString();
                    button7.Text = (paginaActual).ToString();
                }


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

                button6.BackColor = Color.Wheat;
                button6.ForeColor = Color.Black;
                button7.BackColor = Color.IndianRed;
                button7.ForeColor = Color.White;

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

            if ((b.Count) >= (paginaActual * 4))
            {   

                paginador();

                if ((paginaActual * 4) != b.Count)
                {
                    button6.BackColor = Color.IndianRed;
                    button6.ForeColor = Color.White;
                    button7.BackColor = Color.Wheat;
                    button7.ForeColor = Color.Black;
                    button6.Text = (paginaActual - 1).ToString();
                    button7.Text = (paginaActual).ToString();
                }

            }
            else
            {
                paginaActual -= 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            paginaActual -= 1;

            if (paginaActual >= 1)
            {

                button6.BackColor = Color.Wheat;
                button6.ForeColor = Color.Black;
                button7.BackColor = Color.IndianRed;
                button7.ForeColor = Color.White;

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

                paginador();

            }
            else
            {
                b = new List<BienOServicio>();
            }

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text.Trim()!="")
            {
                Conexion p = new Conexion();
                if (p.buscarBienOServicio(txtbuscar.Text) != null)
                {
                    if (txtbuscar.Text.Length > 4)
                    {
                        
                        paginaActual = 1;

                        b = p.buscarBienOServicio(txtbuscar.Text);

                        paginador();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar al menos 5 caracteres", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    

                }
            }
            else
            {
                MessageBox.Show("Debe llenar el buscador", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Conexion p = new Conexion();
            b = p.buscarBienOServicio("");
            paginador();
            dgcategorias.ClearSelection();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbreportar_Click(object sender, EventArgs e)
        {
            Reporte rp;
            if (emp == null && invitado == 0)
            {
                rp = new Reporte(d.IDusuario);
                rp.ShowDialog();
            }
            else if (d == null && invitado == 0)
            {
                rp = new Reporte(emp.IDusuario);
                rp.ShowDialog();
            }
            else if (d == null && emp == null)
            {
                MessageBox.Show("Debe registrarse previamente", "E-Market",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error grave, por favor reinicie el programa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmensajes_Click(object sender, EventArgs e)
        {
            Mensajes msg;
            if (d == null)
            {
                msg = new Mensajes(emp.IDusuario);
                msg.ShowDialog();
            }
            else if (emp == null)
            {
                msg = new Mensajes(d.IDusuario);
                msg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hubo un error grave, por favor reinicie el programa.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProducto p = new VerProducto(iduser,b[(paginaActual * 4) - 4].IdBienOServicio,tipo);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerProducto p = new VerProducto(iduser,b[(paginaActual * 4) - 3].IdBienOServicio,tipo);
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerProducto p = new VerProducto(iduser,b[(paginaActual * 4) - 2].IdBienOServicio,tipo);
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerProducto p = new VerProducto(iduser,b[(paginaActual * 4) - 1].IdBienOServicio,tipo);
            p.Show();
        }

        private void btncarrito_Click(object sender, EventArgs e)
        {
            CarritoCompras c = new CarritoCompras(iduser);
            c.Show();
        }

        private void btnmisproductos_Click(object sender, EventArgs e)
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

        private void btnmiperfil_Click(object sender, EventArgs e)
        {
            Perfil perfil;
            if (d != null)
            {
                perfil = new Perfil(d);
            }
            else
            {
                perfil = new Perfil(emp);
            }


            perfil.ShowDialog();
        }

        private void btnreportar_Click(object sender, EventArgs e)
        {
            Reporte rp;
            if (emp == null && invitado == 0)
            {
                rp = new Reporte(d.IDusuario);
                rp.ShowDialog();
            }
            else if (d == null && invitado == 0)
            {
                rp = new Reporte(emp.IDusuario);
                rp.ShowDialog();
            }
            else if (d == null && emp == null)
            {
                MessageBox.Show("Debe registrarse previamente", "E-Market",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error grave, por favor reinicie el programa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
