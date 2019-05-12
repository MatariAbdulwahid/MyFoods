using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFood
{
    public partial class frmConfirmDel : Form
    {
        public frmConfirmDel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity > 1) timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity < 0) this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;

        }
    }
}
