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
    public partial class VerReportes : Form
    {
        Conexion cn = new Conexion();
        string id = "";
        public VerReportes(string idusuario)
        {
            InitializeComponent();
            id = idusuario;
        }

        private void VerReportes_Load(object sender, EventArgs e)
        {
            rbnoleido.Checked = true;
            cargar("where Estado='No leido'");
        }

        void cargar(string param)
        {
            DataSet ds = cn.cargarReportes(param);
            dgreportes.DataSource = null;
            dgreportes.DataSource = ds.Tables["reportes"];
            dgreportes.ClearSelection();
        }

        private void rbnoleido_CheckedChanged(object sender, EventArgs e)
        {
            cargar("where Estado='No leido'");
        }

        private void rbleido_CheckedChanged(object sender, EventArgs e)
        {
            cargar("where Estado='Leido'");
        }

        private void rbtodo_CheckedChanged(object sender, EventArgs e)
        {
            cargar("");
        }

        private void VerReportes_Shown(object sender, EventArgs e)
        {
            dgreportes.ClearSelection();
        }

        private void dgreportes_DoubleClick(object sender, EventArgs e)
        {   
            if (dgreportes.CurrentRow != null)
            {
                int id = int.Parse(dgreportes.CurrentRow.Cells[0].FormattedValue.ToString());
                string mensaje = dgreportes.CurrentRow.Cells[3].FormattedValue.ToString();
                string ver = "Reporte: " + Environment.NewLine +
                    Environment.NewLine + "'" + mensaje + "'";

                if (MessageBox.Show(ver, "Reporte",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    cn.cambiarEstadoReporte(id);
                    rbnoleido.Checked = true;
                    cargar("where Estado='No leido'");
                }
            }

            else
            {

            }

        }

        private void dgreportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgreportes.CurrentRow != null)
            {
                int id = int.Parse(dgreportes.CurrentRow.Cells[0].FormattedValue.ToString());
                label3.Visible = true;
                label3.Text = "Reporte ID " + id.ToString() + " seleccionado";
            }
            else
            {

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgreportes.CurrentRow != null)
            {
                int id = int.Parse(dgreportes.CurrentRow.Cells[0].FormattedValue.ToString());
                string alerta = "¿Realmente desea eliminar este reporte? Esta acción no puede deshacerse";
                if (MessageBox.Show(alerta, "Advertencia", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.eliminarReporte(id);
                    rbtodo.Checked = true;
                    cargar("");
                }
            }
            else
            {

            }
        }

        private void btnresponder_Click(object sender, EventArgs e)
        {
            if (dgreportes.CurrentRow != null)
            {
                string dest = dgreportes.CurrentRow.Cells[1].FormattedValue.ToString();
                string name = dgreportes.CurrentRow.Cells[2].FormattedValue.ToString();
                Respuesta resp = new Respuesta(id, dest, name);
                resp.ShowDialog();
            }
            else
            {

            }
                
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (rbleido.Checked) { 

                InformeReportes ir = new InformeReportes("where Estado='Leido'");
                ir.ShowDialog();
            }
            else if (rbnoleido.Checked)
            {
                InformeReportes ir = new InformeReportes("where Estado = 'No leido'");
                ir.ShowDialog();
            }
            else
            {
                InformeReportes ir = new InformeReportes("");
                ir.ShowDialog();
            }
        }
    }
}
