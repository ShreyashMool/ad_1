using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            BillingUserControl buc = new BillingUserControl();
            panel1.Controls.Add(buc);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            //BillingUserControl buc = new BillingUserControl();
            //panel1.Controls.Add(buc);
            sales s = new sales();
            panel2.Controls.Add(s);
        }
    }
}
