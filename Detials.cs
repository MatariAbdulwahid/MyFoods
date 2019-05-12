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
    public partial class frmDetials : Form
    {
        public frmDetials()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool MouseDowen = false;
        private Point LastLocation;
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDowen = true;
            LastLocation = e.Location;
            pnlHeader.Cursor = Cursors.Hand;
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDowen = false;
            pnlHeader.Cursor = Cursors.Default;

        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDowen)
            {
                int NewX = (this.Location.X - LastLocation.X) + e.X;
                int NewY = (this.Location.Y - LastLocation.Y) + e.Y;
                this.Location = new Point(NewX, NewY);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
