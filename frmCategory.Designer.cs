namespace MyFood
{
    partial class frmCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCateNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCateNew = new System.Windows.Forms.Button();
            this.btnCateRemove = new System.Windows.Forms.Button();
            this.btnCateAdd = new System.Windows.Forms.Button();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnRmAll = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCateClose = new System.Windows.Forms.Button();
            this.btnCateAgree = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Location = new System.Drawing.Point(1, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(998, 38);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(407, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 37);
            this.label6.TabIndex = 20;
            this.label6.Text = "Category";
            // 
            // txtCateName
            // 
            this.txtCateName.BackColor = System.Drawing.Color.MistyRose;
            this.txtCateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCateName.Location = new System.Drawing.Point(149, 155);
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(303, 29);
            this.txtCateName.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Categ Name";
            // 
            // txtCateNr
            // 
            this.txtCateNr.BackColor = System.Drawing.Color.MistyRose;
            this.txtCateNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCateNr.Location = new System.Drawing.Point(149, 118);
            this.txtCateNr.Name = "txtCateNr";
            this.txtCateNr.ReadOnly = true;
            this.txtCateNr.Size = new System.Drawing.Size(303, 29);
            this.txtCateNr.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Categ Number";
            // 
            // btnCateNew
            // 
            this.btnCateNew.BackColor = System.Drawing.Color.MistyRose;
            this.btnCateNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCateNew.Location = new System.Drawing.Point(601, 118);
            this.btnCateNew.Name = "btnCateNew";
            this.btnCateNew.Size = new System.Drawing.Size(76, 67);
            this.btnCateNew.TabIndex = 25;
            this.btnCateNew.Text = "New";
            this.btnCateNew.UseVisualStyleBackColor = false;
            this.btnCateNew.Click += new System.EventHandler(this.btnCateNew_Click);
            // 
            // btnCateRemove
            // 
            this.btnCateRemove.BackColor = System.Drawing.Color.MistyRose;
            this.btnCateRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCateRemove.Location = new System.Drawing.Point(849, 118);
            this.btnCateRemove.Name = "btnCateRemove";
            this.btnCateRemove.Size = new System.Drawing.Size(91, 67);
            this.btnCateRemove.TabIndex = 27;
            this.btnCateRemove.Text = "Remove";
            this.btnCateRemove.UseVisualStyleBackColor = false;
            this.btnCateRemove.Click += new System.EventHandler(this.btnCateRemove_Click);
            // 
            // btnCateAdd
            // 
            this.btnCateAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnCateAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCateAdd.Location = new System.Drawing.Point(684, 118);
            this.btnCateAdd.Name = "btnCateAdd";
            this.btnCateAdd.Size = new System.Drawing.Size(72, 67);
            this.btnCateAdd.TabIndex = 26;
            this.btnCateAdd.Text = "Add";
            this.btnCateAdd.UseVisualStyleBackColor = false;
            this.btnCateAdd.EnabledChanged += new System.EventHandler(this.btnCateAdd_EnabledChanged);
            this.btnCateAdd.Click += new System.EventHandler(this.btnCateAdd_Click);
            // 
            // lbxCategory
            // 
            this.lbxCategory.BackColor = System.Drawing.Color.MistyRose;
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 24;
            this.lbxCategory.Location = new System.Drawing.Point(601, 277);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(354, 148);
            this.lbxCategory.TabIndex = 28;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToOrderColumns = true;
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(16, 275);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(436, 150);
            this.dgvCategory.TabIndex = 29;
            this.dgvCategory.SelectionChanged += new System.EventHandler(this.dgvCategory_SelectionChanged);
            this.dgvCategory.DoubleClick += new System.EventHandler(this.dgvCategory_DoubleClick);
            // 
            // btnRmAll
            // 
            this.btnRmAll.BackColor = System.Drawing.Color.MistyRose;
            this.btnRmAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRmAll.Location = new System.Drawing.Point(473, 356);
            this.btnRmAll.Name = "btnRmAll";
            this.btnRmAll.Size = new System.Drawing.Size(106, 58);
            this.btnRmAll.TabIndex = 31;
            this.btnRmAll.Text = "Remove All";
            this.btnRmAll.UseVisualStyleBackColor = false;
            this.btnRmAll.Click += new System.EventHandler(this.btnRmAll_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddAll.Location = new System.Drawing.Point(473, 275);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(106, 58);
            this.btnAddAll.TabIndex = 30;
            this.btnAddAll.Text = "Add All";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 255);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(436, 23);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cleck towice of category ";
            // 
            // btnCateClose
            // 
            this.btnCateClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnCateClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCateClose.Location = new System.Drawing.Point(561, 467);
            this.btnCateClose.Name = "btnCateClose";
            this.btnCateClose.Size = new System.Drawing.Size(129, 53);
            this.btnCateClose.TabIndex = 34;
            this.btnCateClose.Text = "Close";
            this.btnCateClose.UseVisualStyleBackColor = false;
            this.btnCateClose.Click += new System.EventHandler(this.btnCateClose_Click);
            // 
            // btnCateAgree
            // 
            this.btnCateAgree.BackColor = System.Drawing.Color.MistyRose;
            this.btnCateAgree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCateAgree.Location = new System.Drawing.Point(414, 467);
            this.btnCateAgree.Name = "btnCateAgree";
            this.btnCateAgree.Size = new System.Drawing.Size(129, 53);
            this.btnCateAgree.TabIndex = 35;
            this.btnCateAgree.Text = "Agree";
            this.btnCateAgree.UseVisualStyleBackColor = false;
            this.btnCateAgree.Click += new System.EventHandler(this.btnCateAgree_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(145, 438);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(32, 24);
            this.lblMessage.TabIndex = 36;
            this.lblMessage.Text = ">>";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(765, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 67);
            this.button1.TabIndex = 37;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1000, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCateAgree);
            this.Controls.Add(this.btnCateClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRmAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.lbxCategory);
            this.Controls.Add(this.btnCateRemove);
            this.Controls.Add(this.btnCateAdd);
            this.Controls.Add(this.btnCateNew);
            this.Controls.Add(this.txtCateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCateNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCateNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCateNew;
        private System.Windows.Forms.Button btnCateRemove;
        private System.Windows.Forms.Button btnCateAdd;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btnRmAll;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCateClose;
        private System.Windows.Forms.Button btnCateAgree;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;
    }
}