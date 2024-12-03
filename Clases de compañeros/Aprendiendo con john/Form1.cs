using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendiendo_con_john
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void v1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formV1 form = new formV1();
            form.Show();
            form.BringToFront();
        }

        private void v2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormV2 form = new FormV2();
            form.Show();
            form.BringToFront();
        }
    }
}
