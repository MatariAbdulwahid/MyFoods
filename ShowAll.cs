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
    public partial class ShowAll : Form
    {
        public ShowAll()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ShowAll_Load(object sender, EventArgs e)
        {
            dgvFood.DataSource = Val.tblAll;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string strPatt = "";
            if (rbtnName.Checked) strPatt = "FoodName";
            else if (rbtnComp.Checked) strPatt = "Components";
            else if (rbtnCateg.Checked) strPatt = "Category";
            else strPatt = "Description";

            strPatt += " like'%" + txtSearch.Text + "%'";
            DataView dv = new DataView(Val.tblAll);
            dv.RowFilter = strPatt;
            dgvFood.DataSource = dv;

            
        }
    }
}
