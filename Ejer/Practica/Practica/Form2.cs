using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();
        Dep f3 = new Dep();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pesoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            f.IsMdiContainer = true;
            f.Show();
        }

        private void depreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.IsMdiContainer=true;
            f3.Show();
        }
    }
}
