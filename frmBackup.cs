using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFood
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCLOSE1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewBackup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "backup";
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    DateTime now = DateTime.Now;
                    string fileName = fbd.SelectedPath + "\\MyFood_" + now.Year + "_" + now.Month + "_" + now.Day + "___" + now.Hour + "_" + now.Minute + "_" + now.Second + ".accdb";
                    File.Copy("MyFood.accdb", fileName);
                    MessageBox.Show("Backup is saved");
                }
            }
            catch (Exception ex)
            
            {
                MessageBox.Show("Error " + ex.Message);
            }
            
        }

        private void btnResBackup_Click(object sender, EventArgs e)
        {
            DB.Close();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Access Files |*.accdb";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DB.Open();
                    string strAllTables = "SELECT Food.FoodCode, Food.FoodName, Food.FoodDesc, foodimage.FoodCode, foodimage.FoodImage, foodcomponents.FoodCode, foodcomponents.Component, Category.CategoryNo, Category.CategoryName, foodcategory.FoodCode, foodcategory.CategoryNoFROM((Food INNER JOIN(Category INNER JOIN foodcategory ON Category.CategoryNo = foodcategory.CategoryNo) ON Food.FoodCode = foodcategory.FoodCode) INNER JOIN foodcomponents ON Food.FoodCode = foodcomponents.FoodCode) INNER JOIN foodimage ON Food.FoodCode = foodimage.FoodCode";
                    DB.GetDate(strAllTables);
                    DB.Close();
                    File.Delete("MyFood.accdb");
                    File.Copy(ofd.FileName, "MyFood.accdb");
                    MessageBox.Show("Backup is restored");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally
                {
                    Application.Restart();
                }
            }
        }
    }
}
