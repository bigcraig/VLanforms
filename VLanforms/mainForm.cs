using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLanforms;

namespace VLanforms
{
    public partial class mainForm : Form
    {
        Form form1, nf5 = null;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form nf5 = null;
            if (nf5 == null || nf5.IsDisposed)
                nf5 = new NF5();
            nf5.Show();

        }

        private void NF5_Click(object sender, EventArgs e)
        {
            //Form nf5 = null; 
            if (nf5 == null || nf5.IsDisposed)
                nf5 = new NF5();
            nf5.Show();
        }

        private void TWBroadcom_Click(object sender, EventArgs e)
        {
            //Form form1 = null;
            if (form1 == null || form1.IsDisposed)
                form1 = new Form1();
            form1.Show();
        }

        private void NF5_Click_1(object sender, EventArgs e)
        {
            if (nf5 == null || nf5.IsDisposed)
                nf5 = new NF5();
            nf5.Show();
        }
    }
}
