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
    public partial class Comprobante : Form
    {
        string iduser;
        public Comprobante(string user)
        {
            InitializeComponent();
            iduser = user;
        }

        private void Comprobante_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();

            List<ComprobanteTotal> comt = new List<ComprobanteTotal>();

            ComprobanteTotal ct = new ComprobanteTotal();

            ct.Total = cn.precioTotal(iduser);

            DateTime fechaActual = DateTime.Today;

            ct.Fecha = fechaActual.ToString("dd/MM/yyyy");

            comt.Add(ct);

            ReportDataSource rds = new ReportDataSource("ComprobanteVenta", cn.verComprobante(iduser));

            ReportDataSource rds1 = new ReportDataSource("ComprobanteTotal", comt);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "main.Report1.rdlc";

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.LocalReport.DataSources.Add(rds1);

            this.reportViewer1.Refresh();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
