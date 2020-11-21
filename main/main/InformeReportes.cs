using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace main
{
    public partial class InformeReportes : Form
    {
        public InformeReportes(string param)
        {
            InitializeComponent();

            Conexion cn = new Conexion();

            DataSet ds = cn.cargarReportes(param);

            List<Reportes> rep = new List<Reportes>();

            for (int i = 0; i < ds.Tables["reportes"].Rows.Count; i++)
            {
                Reportes r = new Reportes();
                r.IdReporte = Convert.ToInt32(ds.Tables["reportes"].Rows[i][0]);
                r.IdUsuario = ds.Tables["reportes"].Rows[i][2].ToString();
                r.Mensaje = ds.Tables["reportes"].Rows[i][3].ToString();
                r.Fecha = Convert.ToDateTime(ds.Tables["reportes"].Rows[i][4]).ToString("dd/MM/yyyy");

                rep.Add(r);
            }


            ReportDataSource rds = new ReportDataSource("Reportes", rep);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "main.Report2.rdlc";

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.Refresh();

            this.reportViewer1.RefreshReport();

        }

        private void InformeReportes_Load(object sender, EventArgs e)
        {

            
        }
    }
}
