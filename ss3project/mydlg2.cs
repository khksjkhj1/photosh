using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ss3project
{
    public partial class mydlg2 : Form
    {

        prototype prt1 = null;
        public mydlg2(prototype prt)
        {

            InitializeComponent();
            this.AcceptButton = button1;
            this.CancelButton = button2;
            this.prt1 = prt;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            prt1.resize(Convert.ToDouble(textBox1.Text));
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
