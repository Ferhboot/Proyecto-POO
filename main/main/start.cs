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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void start_Shown(object sender, EventArgs e)
        {
            Task.Delay(5000).Wait();
            Home f1 = new Home();
            f1.Show();
            this.Hide();
        }
    }
}
