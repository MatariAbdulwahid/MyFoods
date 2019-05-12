using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFood
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }
        DataTable tblAll = new DataTable();
        private void ShowData()
        {
            tblAll.Rows.Clear();
            DataTable tblData = DB.GetDate("select *from food_data");
            DataTable tblCateg = DB.GetDate("select *from food_cat");
            DataTable tblComp = DB.GetDate("select *from foodcomponents");
            if (tblAll.Columns.Count < 1)
            {
                tblAll.Columns.Add("FoodName");
                tblAll.Columns.Add("FoodImage", typeof(byte[]));
                tblAll.Columns.Add("Category");
                tblAll.Columns.Add("Components");
                tblAll.Columns.Add("Description");
                tblAll.Columns.Add("FoodCode");

                for (int x = 0; x < tblData.Rows.Count; x++)
                {
                    DataRow row = tblAll.NewRow();
                    row[0] = tblData.Rows[x][1];
                    row[1] = tblData.Rows[x][2];

                    DataRow[] Cat = tblCateg.Select("FoodCode=" + tblData.Rows[x][0].ToString());
                    string strCat = "";
                    foreach (var i in Cat)
                    {
                        strCat += i[1] + Environment.NewLine;
                    }
                    row[2] = strCat;

                    DataRow[] Com = tblComp.Select("FoodCode=" + tblData.Rows[x][0].ToString());
                    string strComp = "";
                    foreach (var i in Com)
                    {
                        strComp += i[1] + Environment.NewLine;
                    }
                    row[3] = strComp;
                    row[4] = tblData.Rows[x][3];
                    row[5] = tblData.Rows[x][0];

                    tblAll.Rows.Add(row);
                }
            }
            dgvFood.DataSource = tblAll;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("MyFood.exe");
            DB.Open();
            ShowData();
            AutoNumber();
            
        }
        
        private void AutoNumber()
        {
            Val.category.Clear();
            int intRow = 0;
            txtFoodCode.Text = DB.GetDate("select max(Foodcode)+1 from food").Rows[intRow][0].ToString();
            if (txtFoodCode.Text.Trim() == "") txtFoodCode.Text = "1";
            txtFoodName.Text = "";
            txtPhotoPath.Text = "";
            pictureBox1.Image = new PictureBox().Image;
            txtComp.Text = "";
            lbxComp.Items.Clear();
            txtDesc.Text = "";
            txtCateg.Text = "";
            txtFoodName.Select();
            //intRow++;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            //txtFoodCode.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnAddimage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Filter = "Image Files|*.jpg;*.png";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    txtPhotoPath.Text = ofd.FileName;
                    Bitmap btm = new Bitmap(Image.FromFile(txtPhotoPath.Text), new Size(150, 150)); //Size des Bildes aendern
                    pbFood.Image = btm;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "<< Error " + ex.Message;
            }
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.ShowDialog();
            txtCateg.Text = "";
            foreach(var i in Val.category)
            {
                txtCateg.Text =i.Item2+ " , ";
            }
        }

        private void frmFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangBackc_Click(object sender, EventArgs e)
        {
            if(ColorDia1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = ColorDia1.Color;
            }
        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            if (txtComp.Text.Trim() != "")
            {
                lbxComp.Items.Add(txtComp.Text);
            }

                string[] str1 = new string[lbxComp.Items.Count];
                lbxComp.Items.CopyTo(str1, 0);
                string[] str2;
                str2 = str1.Distinct().ToArray();
                lbxComp.Items.Clear();
                lbxComp.Items.AddRange(str2);
                txtComp.Clear();
            
        }

        private void btnRmSelected_Click(object sender, EventArgs e)
        {
           if(lbxComp.Items.Count != 0)
            {
                lbxComp.Items.Remove(lbxComp.SelectedItem);
            }
        }

        private void txtComp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAddComp_Click(null, null);
            }
        }

        private void btnRmAll_Click(object sender, EventArgs e)
        {
            lbxComp.Items.Clear();
        }

        private void btnLastRemov_Click(object sender, EventArgs e)
        {
            if (lbxComp.Items.Count > 0)
                lbxComp.Items.RemoveAt(lbxComp.Items.Count - 1);
            else return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            if (txtFoodCode.Text.Trim() == "")
            {
                lblMessage.Text = "Error";
            }
            else if (txtFoodName.Text.Trim() == "")
            {
                lblMessage.Text = "no name";
                txtFoodName.Select();
            }
            else if (txtPhotoPath.Text.Trim() == "")
            {
                lblMessage.Text = "no image please add image";
            }
            else if (txtCateg.Text.Trim() == "")
            {
                lblMessage.Text = "please select one category";
                txtCateg.Select();
            }
            else if (lbxComp.Items.Count == 0)
            {
                lblMessage.Text = "no componenten pleas add";
            }
            else if (txtDesc.Text.Trim() == "")
            {
                lblMessage.Text = "no descripton";
                txtDesc.Select();
            }
            else
            {
                lblMessage.Text = ">>";
                try
                {
                    DB.Run("insert into food values ("+txtFoodCode.Text+",'"+txtFoodName.Text+"','"+txtDesc.Text+"')");
                    
                    //lblMessage.Text = "data is added";
                    MemoryStream ms = new MemoryStream();
                    pbFood.Image.Save(ms, ImageFormat.Jpeg);
                    DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());
                    DB.Run("insert into foodimage values (" + txtFoodCode.Text + ",@img)");
                    lblMessage.Text = "Food and Foto is added";

                    foreach(var i in Val.category)
                    {
                        DB.Run("insert into foodcategory values(" + txtFoodCode.Text + ","+i.Item1+")");
                    }
                    foreach(var i in lbxComp.Items)
                    {
                        DB.Run("insert into foodcomponents values (" + txtFoodCode.Text + ",'" + i.ToString() + "')");
                    }
                    lblMessage.Text = " , " + "is added";
                    ShowData();
                    AutoNumber();
                    
                }
                catch (Exception ex)
                {
                    // lblMessage.Text = "Error" + ex.Message;
                    MessageBox.Show("" + ex.Message);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
            btnAdd.Enabled = true;
             
            
        }

        private void btnCreateView_Click(object sender, EventArgs e)
        {
            // DB.Run("create view food_cat as select Foodcode , CategoryName , category.categoryno from category , foodcategory where category.categoryno = foodcategory.categoryno");
           // DB.Run("create view food_data as select Food.foodcode , foodname , foodimage ,fooddesc from food , foodimage where food.foodcode = foodimage.foodcode ");
            MessageBox.Show("ok");
        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvFood.CurrentRow != null)
            {
                txtFoodCode.Text = dgvFood.CurrentRow.Cells[5].Value.ToString();
                txtFoodName.Text = dgvFood.CurrentRow.Cells[0].Value.ToString();
                txtPhotoPath.Text = "";
                
                MemoryStream ms = new MemoryStream((byte[])dgvFood.CurrentRow.Cells[1].Value);
                pbFood.Image = Image.FromStream(ms);

                DataTable tblCat = DB.GetDate("select *from food_cat where foodcode=" + txtFoodCode.Text +"");
                Val.category.Clear();
                foreach (DataRow dr in tblCat.Rows)
                {
                    Val.category.Add(new Tuple<int, string>(Convert.ToInt16( dr[2]), dr[1].ToString()));
                }
                txtCateg.Text = "";
                foreach (var i in Val.category)
                {
                    txtCateg.Text += i.Item2 + "";
                }

                DataTable tblComp = DB.GetDate("select *from foodcomponents where foodcode=" + txtFoodCode.Text + "");
                lbxComp.Items.Clear();
                foreach (DataRow i in tblComp.Rows)
                {
                    lbxComp.Items.Add(i[1]);
                }
                txtDesc.Text = dgvFood.CurrentRow.Cells[4].Value.ToString();
            }
            btnAdd.Enabled = false;
            btnRemove.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DB.cmd.Parameters.Clear();
            if (txtFoodCode.Text.Trim() == "")
            {
                lblMessage.Text = "Error";
            }
            else if (txtFoodName.Text.Trim() == "")
            {
                lblMessage.Text = "no name";
                txtFoodName.Select();
            }
            else if (txtCateg.Text.Trim() == "")
            {
                lblMessage.Text = "please select one category";
                txtCateg.Select();
            }
            else if (lbxComp.Items.Count == 0)
            {
                lblMessage.Text = "no componenten pleas add";
            }
            else if (txtDesc.Text.Trim() == "")
            {
                lblMessage.Text = "no descripton";
                txtDesc.Select();
            }
            else
            {
                lblMessage.Text = ">>";
                try
                {
                    DB.Run("update food set foodname='" + txtFoodName.Text + "',foodDesc='" + txtDesc.Text + "' where foodcode="+txtFoodCode.Text);
                    //lblMessage.Text = "data is updated";
                    if (txtPhotoPath.Text.Trim() != "")
                    {
                        DB.Run("delete from foodimage where foodcode =" + txtFoodCode.Text);
                        MemoryStream ms = new MemoryStream();
                        pbFood.Image.Save(ms, ImageFormat.Jpeg);
                        DB.cmd.Parameters.AddWithValue("@img", ms.ToArray());
                        DB.Run("insert into foodimage values (" + txtFoodCode.Text + ",@img)");
                        lblMessage.Text = "Food and Foto is updated";
                    }
                    DB.Run("delete from foodcategory where foodcode=" + txtFoodCode.Text);
                    foreach (var i in Val.category)
                    {
                        DB.Run("insert into foodcategory values(" + txtFoodCode.Text + "," + i.Item1 + ")");
                    }
                    DB.Run("delete from foodcomponents where foodcode=" + txtFoodCode.Text);
                    foreach (var i in lbxComp.Items)
                    {
                        DB.Run("insert into foodcomponents values (" + txtFoodCode.Text + ",'" + i.ToString() + "')");
                    }
                    lblMessage.Text =  "is updated";
                    
                    ShowData();
                    AutoNumber();
                }
                catch (Exception ex)
                {
                    //lblMessage.Text = "Error" + ex.Message;
                    MessageBox.Show("" + ex.Message);
                }
            }
        }

        private void txtFoodName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                btnAddimage_Click(null, null);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            pnlDelete.Visible = true;
            ShowData();
            

        }

        private void btnDelYes_Click(object sender, EventArgs e)
        {
            try
            {
                DB.Run("delete from foodimage where foodcode=" + txtFoodCode.Text);
                DB.Run("delete from foodcategory where foodcode=" + txtFoodCode.Text);
                DB.Run("delete from foodcomponents where foodcode=" + txtFoodCode.Text);
                DB.Run("delete from food where foodcode=" + txtFoodCode.Text);

                lblMessage.Text = "data is deleted";
                ShowData();
                AutoNumber();
                pnlDelete.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorr " + ex.Message);
            }
        }

        private void btnDelNo_Click(object sender, EventArgs e)
        {
            pnlDelete.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmRpt frm = new frmRpt();
            

            ReportDataSource rds = new ReportDataSource("DataSet1", tblAll);
            //frm.reportViewer1.LocalReport.DataSources.Clear();
            //frm.reportViewer1.LocalReport.DataSources.Add(rds);
            //frm.reportViewer1.LocalReport.Refresh();

            frm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string strPatt = "";
            if (rbtnName.Checked) strPatt = "FoodName";
            else if (rbtnComp.Checked) strPatt = "Components";
            else if (rbtnCateg.Checked) strPatt = "Category";
            else strPatt = "Desc";

            strPatt += " like'%" + txtSearch.Text + "%'";
            DataView dv = new DataView(tblAll);
            dv.RowFilter = strPatt;
            dgvFood.DataSource = dv;
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            if (txtCatSug.Text.Trim() != "")
            {
                String strFilter = "";
                for (int i= 0; i< Val.category.Count; i++)
                {
                    strFilter += " Category like '%" + Val.category[i].Item2 + "%'";
                    if (i < Val.category.Count - 1) strFilter += " or  ";
                }
                DataRow[] rows = tblAll.Select(strFilter);
                if(rows.Count() > 0)
                {
                    tblAll = rows.CopyToDataTable();
                } else
                {
                    lblMessage.Text = "no foods at the same of this category";
                    return;
                }
            }

            if (tblAll.Rows.Count > 0)
            {
                frmDetials frm = new frmDetials();
                Random rn = new Random();
                int IndexRandom = rn.Next(0 , tblAll.Rows.Count);
                frm.txtFoodname.Text = tblAll.Rows[IndexRandom][0].ToString();
                frm.txtCateg.Text = tblAll.Rows[IndexRandom][2].ToString();
                frm.txtCompo.Text = tblAll.Rows[IndexRandom][3].ToString();
                frm.txtDesc.Text = tblAll.Rows[IndexRandom][4].ToString();
                MemoryStream ms = new MemoryStream((byte[])tblAll.Rows[IndexRandom][1]);
                frm.pbFood.Image = Image.FromStream(ms);

                frm.ShowDialog();
            }
        }

        private void btnAddSug_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;
            frmCategory frm = new frmCategory();
            txtCatSug.Clear();
            frm.ShowDialog();
            foreach (var i in Val.category)
            {
                txtCatSug.Text += i.Item2+ " , ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAll frm = new ShowAll();
            Val.tblAll = tblAll;
            frm.ShowDialog();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
        }
    }
}
