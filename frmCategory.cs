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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
       // Val myclass = new Val();
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

        private void GetAuto()
        {
            DataTable dtl = DB.GetDate("select max(categoryno)+1 from category");
            txtCateNr.Text = dtl.Rows[0][0].ToString();
            if (txtCateNr.Text.Trim() == "")
            {
                txtCateNr.Text = "1";
                btnCateAdd.Enabled = true;
                btnCateRemove.Enabled = false;
                txtCateName.Select();
            }
            txtCateName.Focus();
        }

        private void ClearData()
        {
            txtCateName.Clear();
            ShowCategory();
            GetAuto();
        }
        private void ShowCategory()
        {
            dgvCategory.DataSource = DB.GetDate("select *from Category");
        }

        DataTable tblSearch = new DataTable();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            tblSearch = DB.GetDate("select *from Category");
            ClearData();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCateClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCateNew_Click(object sender, EventArgs e)
        {
            txtCateName.Clear();
            btnCateAdd.Enabled = true;
            GetAuto();
        }

        private void btnCateAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCateName.Text.Trim()!= "")
                {
                    DB.Run("insert into category values("+txtCateNr.Text+",'"+txtCateName.Text+"') ");
                    MessageBox.Show("Data is added");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "<< Error " + ex.Message;
            }
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow != null)
            {
                txtCateNr.Text = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                txtCateName.Text = dgvCategory.CurrentRow.Cells[1].Value.ToString();
                btnCateAdd.Enabled = false;
                if (lbxCategory.Items.Count == 0)
                {
                    btnCateRemove.Enabled = true;
                }
                else btnCateRemove.Enabled = false;
            }
            
            //else btnCateAdd.Enabled = true;
        }

        private void btnCateAdd_EnabledChanged(object sender, EventArgs e)
        {
            //((Button)sender).BackColor = (((Button)sender).Enabled) ? Color.Pink : Color.LightBlue;
        }
        
        List<Tuple<int, string>> data = new List<Tuple<int, string>>();
       // Dictionary<int, string> dc = new Dictionary<int, string>();
        private void SetItem()
        {
            lbxCategory.ValueMember = "Item1";
            lbxCategory.DisplayMember = "Item2";
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Distinct();
            lbxCategory.DataSource = bs;
        }

        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            if(dgvCategory.CurrentCell != null)
            {
                   data.Add(new Tuple<int, string>(Convert.ToInt16( dgvCategory.CurrentRow.Cells[0].Value), dgvCategory.CurrentRow.Cells[1].Value.ToString()));  
            }
            SetItem();
            btnCateRemove.Enabled = false;
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            data.Clear();
            foreach(DataGridViewRow r in dgvCategory.Rows)
            {
                data.Add(new Tuple <int , string> (Convert.ToInt16(r.Cells[0].Value),r.Cells[1].Value.ToString()));
            }
            SetItem(); //to add all
            btnCateRemove.Enabled = false;
        }

        private void btnRmAll_Click(object sender, EventArgs e)
        {
            data.Clear();
            if (lbxCategory.DataSource != null)
            {
                SetItem();
                btnCateRemove.Enabled = true;
            }
            else return;
            
        }

        private void btnCateRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCateName.Text.Trim() != "")
                {
                    DB.Run("delete from category where categoryno="+txtCateNr.Text);
                    MessageBox.Show("Data is deleted");
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "<< Error " + ex.Message;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tblSearch);
            dv.RowFilter = "Categoryname like '%" + txtSearch.Text + "%'";
            dgvCategory.DataSource = dv;
        }

        private void btnCateAgree_Click(object sender, EventArgs e)
        {
            Val.category.Clear();    
            for (int i = 0; i< lbxCategory.Items.Count; i+=1)
            {
                lbxCategory.SelectedIndex = i;
                Val.category.Add(new Tuple<int, string>(Convert.ToInt16( lbxCategory.SelectedValue), lbxCategory.GetItemText(lbxCategory.Items[i])));
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCateName.Clear();
            GetAuto();
        }
    }
}
