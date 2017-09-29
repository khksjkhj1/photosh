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
    public partial class mydlg3 : Form
    {

        prototype prt1 = null;
        public mydlg3(prototype prt)
        {

            InitializeComponent();
            this.AcceptButton = button1;
            this.CancelButton = button2;
            this.prt1 = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            prt1.bright(hScrollBar2.Value);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
