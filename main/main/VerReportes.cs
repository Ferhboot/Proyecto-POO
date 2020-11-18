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
        
        public VerReportes()
        {
            InitializeComponent();
        }

        private void VerReportes_Load(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar()
        {
            DataSet ds = cn.cargarReportes();
            dgreportes.DataSource = null;
            dgreportes.DataSource = ds.Tables["reportes"];
            dgreportes.ClearSelection();
        }
    }
}
