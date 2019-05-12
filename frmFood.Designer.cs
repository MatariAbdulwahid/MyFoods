namespace MyFood
{
    partial class frmFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimaiz = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFoodCode = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddimage = new System.Windows.Forms.Button();
            this.txtCateg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.btnAddComp = new System.Windows.Forms.Button();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxComp = new System.Windows.Forms.ListBox();
            this.btnRmSelected = new System.Windows.Forms.Button();
            this.btnLastRemov = new System.Windows.Forms.Button();
            this.btnRmAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSuggest = new System.Windows.Forms.Button();
            this.btnAddSug = new System.Windows.Forms.Button();
            this.txtCatSug = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnCateg = new System.Windows.Forms.RadioButton();
            this.rbtnPrep = new System.Windows.Forms.RadioButton();
            this.rbtnComp = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnChangBackc = new System.Windows.Forms.Button();
            this.ColorDia1 = new System.Windows.Forms.ColorDialog();
            this.btnCreateView = new System.Windows.Forms.Button();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.btnDelNo = new System.Windows.Forms.Button();
            this.btnDelYes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.pnlDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Controls.Add(this.btnBackUp);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.btnMinimaiz);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Location = new System.Drawing.Point(2, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(998, 38);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // btnMinimaiz
            // 
            this.btnMinimaiz.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMinimaiz.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimaiz.Location = new System.Drawing.Point(918, 0);
            this.btnMinimaiz.Name = "btnMinimaiz";
            this.btnMinimaiz.Size = new System.Drawing.Size(40, 35);
            this.btnMinimaiz.TabIndex = 2;
            this.btnMinimaiz.Text = "ـــ";
            this.btnMinimaiz.UseVisualStyleBackColor = false;
            this.btnMinimaiz.Click += new System.EventHandler(this.btnMinimaiz_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(955, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Food";
            // 
            // txtFoodCode
            // 
            this.txtFoodCode.BackColor = System.Drawing.Color.MistyRose;
            this.txtFoodCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodCode.Location = new System.Drawing.Point(149, 43);
            this.txtFoodCode.Name = "txtFoodCode";
            this.txtFoodCode.Size = new System.Drawing.Size(256, 29);
            this.txtFoodCode.TabIndex = 2;
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.Color.MistyRose;
            this.txtFoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodName.Location = new System.Drawing.Point(149, 80);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(256, 29);
            this.txtFoodName.TabIndex = 4;
            this.txtFoodName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFoodName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food Name";
            // 
            // txtPhotoPath
            // 
            this.txtPhotoPath.BackColor = System.Drawing.Color.MistyRose;
            this.txtPhotoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhotoPath.Location = new System.Drawing.Point(149, 116);
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.Size = new System.Drawing.Size(147, 29);
            this.txtPhotoPath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Food Picture";
            // 
            // btnAddimage
            // 
            this.btnAddimage.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddimage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddimage.Location = new System.Drawing.Point(149, 151);
            this.btnAddimage.Name = "btnAddimage";
            this.btnAddimage.Size = new System.Drawing.Size(147, 47);
            this.btnAddimage.TabIndex = 8;
            this.btnAddimage.Text = "Add Photo";
            this.btnAddimage.UseVisualStyleBackColor = false;
            this.btnAddimage.Click += new System.EventHandler(this.btnAddimage_Click);
            // 
            // txtCateg
            // 
            this.txtCateg.BackColor = System.Drawing.Color.MistyRose;
            this.txtCateg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCateg.Location = new System.Drawing.Point(149, 204);
            this.txtCateg.Multiline = true;
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCateg.Size = new System.Drawing.Size(222, 29);
            this.txtCateg.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Food Categore";
            // 
            // btnAddCate
            // 
            this.btnAddCate.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddCate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCate.Location = new System.Drawing.Point(375, 204);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(29, 29);
            this.btnAddCate.TabIndex = 11;
            this.btnAddCate.Text = "+";
            this.btnAddCate.UseVisualStyleBackColor = false;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // btnAddComp
            // 
            this.btnAddComp.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddComp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddComp.Location = new System.Drawing.Point(375, 236);
            this.btnAddComp.Name = "btnAddComp";
            this.btnAddComp.Size = new System.Drawing.Size(29, 29);
            this.btnAddComp.TabIndex = 14;
            this.btnAddComp.Text = "+";
            this.btnAddComp.UseVisualStyleBackColor = false;
            this.btnAddComp.Click += new System.EventHandler(this.btnAddComp_Click);
            // 
            // txtComp
            // 
            this.txtComp.BackColor = System.Drawing.Color.MistyRose;
            this.txtComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComp.Location = new System.Drawing.Point(148, 236);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(223, 29);
            this.txtComp.TabIndex = 13;
            this.txtComp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComp_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Component";
            // 
            // lbxComp
            // 
            this.lbxComp.BackColor = System.Drawing.Color.MistyRose;
            this.lbxComp.FormattingEnabled = true;
            this.lbxComp.ItemHeight = 24;
            this.lbxComp.Location = new System.Drawing.Point(148, 267);
            this.lbxComp.Name = "lbxComp";
            this.lbxComp.Size = new System.Drawing.Size(257, 76);
            this.lbxComp.TabIndex = 15;
            // 
            // btnRmSelected
            // 
            this.btnRmSelected.BackColor = System.Drawing.Color.MistyRose;
            this.btnRmSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmSelected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRmSelected.Location = new System.Drawing.Point(16, 267);
            this.btnRmSelected.Name = "btnRmSelected";
            this.btnRmSelected.Size = new System.Drawing.Size(126, 26);
            this.btnRmSelected.TabIndex = 16;
            this.btnRmSelected.Text = "Rm Selected";
            this.btnRmSelected.UseVisualStyleBackColor = false;
            this.btnRmSelected.Click += new System.EventHandler(this.btnRmSelected_Click);
            // 
            // btnLastRemov
            // 
            this.btnLastRemov.BackColor = System.Drawing.Color.MistyRose;
            this.btnLastRemov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastRemov.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLastRemov.Location = new System.Drawing.Point(16, 292);
            this.btnLastRemov.Name = "btnLastRemov";
            this.btnLastRemov.Size = new System.Drawing.Size(126, 26);
            this.btnLastRemov.TabIndex = 17;
            this.btnLastRemov.Text = "Rm the Last";
            this.btnLastRemov.UseVisualStyleBackColor = false;
            this.btnLastRemov.Click += new System.EventHandler(this.btnLastRemov_Click);
            // 
            // btnRmAll
            // 
            this.btnRmAll.BackColor = System.Drawing.Color.MistyRose;
            this.btnRmAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRmAll.Location = new System.Drawing.Point(16, 317);
            this.btnRmAll.Name = "btnRmAll";
            this.btnRmAll.Size = new System.Drawing.Size(126, 26);
            this.btnRmAll.TabIndex = 18;
            this.btnRmAll.Text = "Rm All";
            this.btnRmAll.UseVisualStyleBackColor = false;
            this.btnRmAll.Click += new System.EventHandler(this.btnRmAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(433, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "My Foods";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.MistyRose;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Location = new System.Drawing.Point(148, 344);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(256, 80);
            this.txtDesc.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(11, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Prepartion";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.MistyRose;
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNew.Location = new System.Drawing.Point(12, 463);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 58);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(124, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 58);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MistyRose;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(236, 463);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 58);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.MistyRose;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Location = new System.Drawing.Point(348, 463);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 58);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.MistyRose;
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReport.Location = new System.Drawing.Point(460, 463);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(106, 58);
            this.btnReport.TabIndex = 26;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MistyRose;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(572, 463);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 58);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSuggest
            // 
            this.btnSuggest.BackColor = System.Drawing.Color.MistyRose;
            this.btnSuggest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuggest.Location = new System.Drawing.Point(684, 492);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(292, 29);
            this.btnSuggest.TabIndex = 28;
            this.btnSuggest.Text = "Suggest a name to eat";
            this.btnSuggest.UseVisualStyleBackColor = false;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // btnAddSug
            // 
            this.btnAddSug.BackColor = System.Drawing.Color.MistyRose;
            this.btnAddSug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSug.Location = new System.Drawing.Point(947, 462);
            this.btnAddSug.Name = "btnAddSug";
            this.btnAddSug.Size = new System.Drawing.Size(29, 29);
            this.btnAddSug.TabIndex = 30;
            this.btnAddSug.Text = "+";
            this.btnAddSug.UseVisualStyleBackColor = false;
            this.btnAddSug.Click += new System.EventHandler(this.btnAddSug_Click);
            // 
            // txtCatSug
            // 
            this.txtCatSug.BackColor = System.Drawing.Color.MistyRose;
            this.txtCatSug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatSug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatSug.Location = new System.Drawing.Point(684, 462);
            this.txtCatSug.Multiline = true;
            this.txtCatSug.Name = "txtCatSug";
            this.txtCatSug.Size = new System.Drawing.Size(257, 29);
            this.txtCatSug.TabIndex = 29;
            this.txtCatSug.WordWrap = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(17, 427);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(32, 24);
            this.lblMessage.TabIndex = 31;
            this.lblMessage.Text = ">>";
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnName.Location = new System.Drawing.Point(413, 103);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(79, 28);
            this.rbtnName.TabIndex = 32;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnCateg
            // 
            this.rbtnCateg.AutoSize = true;
            this.rbtnCateg.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnCateg.Location = new System.Drawing.Point(490, 104);
            this.rbtnCateg.Name = "rbtnCateg";
            this.rbtnCateg.Size = new System.Drawing.Size(103, 28);
            this.rbtnCateg.TabIndex = 33;
            this.rbtnCateg.Text = "Category";
            this.rbtnCateg.UseVisualStyleBackColor = true;
            // 
            // rbtnPrep
            // 
            this.rbtnPrep.AutoSize = true;
            this.rbtnPrep.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnPrep.Location = new System.Drawing.Point(725, 106);
            this.rbtnPrep.Name = "rbtnPrep";
            this.rbtnPrep.Size = new System.Drawing.Size(114, 28);
            this.rbtnPrep.TabIndex = 35;
            this.rbtnPrep.Text = "Prepartion";
            this.rbtnPrep.UseVisualStyleBackColor = true;
            // 
            // rbtnComp
            // 
            this.rbtnComp.AutoSize = true;
            this.rbtnComp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtnComp.Location = new System.Drawing.Point(593, 105);
            this.rbtnComp.Name = "rbtnComp";
            this.rbtnComp.Size = new System.Drawing.Size(127, 28);
            this.rbtnComp.TabIndex = 34;
            this.rbtnComp.Text = "Component";
            this.rbtnComp.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.MistyRose;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(836, 104);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(105, 29);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFood.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFood.Location = new System.Drawing.Point(413, 179);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.Size = new System.Drawing.Size(563, 245);
            this.dgvFood.TabIndex = 37;
            this.dgvFood.SelectionChanged += new System.EventHandler(this.dgvFood_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FoodName";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 104;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FoodCode";
            this.Column6.HeaderText = "FoodCode";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Category";
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 104;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Components";
            this.Column4.HeaderText = "Components";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 104;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 104;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FoodImage";
            this.Column2.HeaderText = "Image";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnChangBackc
            // 
            this.btnChangBackc.Location = new System.Drawing.Point(947, 48);
            this.btnChangBackc.Name = "btnChangBackc";
            this.btnChangBackc.Size = new System.Drawing.Size(29, 23);
            this.btnChangBackc.TabIndex = 38;
            this.btnChangBackc.UseVisualStyleBackColor = true;
            this.btnChangBackc.Click += new System.EventHandler(this.btnChangBackc_Click);
            // 
            // btnCreateView
            // 
            this.btnCreateView.Location = new System.Drawing.Point(734, 51);
            this.btnCreateView.Name = "btnCreateView";
            this.btnCreateView.Size = new System.Drawing.Size(105, 37);
            this.btnCreateView.TabIndex = 39;
            this.btnCreateView.Text = "view";
            this.btnCreateView.UseVisualStyleBackColor = true;
            this.btnCreateView.Visible = false;
            this.btnCreateView.Click += new System.EventHandler(this.btnCreateView_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.Red;
            this.pnlDelete.Controls.Add(this.btnDelNo);
            this.pnlDelete.Controls.Add(this.btnDelYes);
            this.pnlDelete.Controls.Add(this.label8);
            this.pnlDelete.Location = new System.Drawing.Point(325, 239);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(478, 174);
            this.pnlDelete.TabIndex = 41;
            this.pnlDelete.Visible = false;
            // 
            // btnDelNo
            // 
            this.btnDelNo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelNo.Location = new System.Drawing.Point(244, 97);
            this.btnDelNo.Name = "btnDelNo";
            this.btnDelNo.Size = new System.Drawing.Size(155, 58);
            this.btnDelNo.TabIndex = 28;
            this.btnDelNo.Text = "No";
            this.btnDelNo.UseVisualStyleBackColor = false;
            this.btnDelNo.Click += new System.EventHandler(this.btnDelNo_Click);
            // 
            // btnDelYes
            // 
            this.btnDelYes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelYes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelYes.Location = new System.Drawing.Point(50, 97);
            this.btnDelYes.Name = "btnDelYes";
            this.btnDelYes.Size = new System.Drawing.Size(146, 58);
            this.btnDelYes.TabIndex = 27;
            this.btnDelYes.Text = "Yes";
            this.btnDelYes.UseVisualStyleBackColor = false;
            this.btnDelYes.Click += new System.EventHandler(this.btnDelYes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(482, 36);
            this.label8.TabIndex = 26;
            this.label8.Text = "Do you want to delete this food ?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Location = new System.Drawing.Point(413, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(563, 29);
            this.button1.TabIndex = 42;
            this.button1.Text = "View all foods ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.White;
            this.btnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.Color.Red;
            this.btnBackUp.Location = new System.Drawing.Point(732, 3);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(85, 34);
            this.btnBackUp.TabIndex = 40;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyFood.Properties.Resources._15028_200;
            this.pictureBox2.Location = new System.Drawing.Point(943, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pbFood
            // 
            this.pbFood.BackColor = System.Drawing.Color.MistyRose;
            this.pbFood.Location = new System.Drawing.Point(302, 116);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(103, 82);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFood.TabIndex = 7;
            this.pbFood.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Image = global::MyFood.Properties.Resources.iconFood;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1000, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCreateView);
            this.Controls.Add(this.btnChangBackc);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbtnPrep);
            this.Controls.Add(this.rbtnComp);
            this.Controls.Add(this.rbtnCateg);
            this.Controls.Add(this.rbtnName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAddSug);
            this.Controls.Add(this.txtCatSug);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRmAll);
            this.Controls.Add(this.btnLastRemov);
            this.Controls.Add(this.btnRmSelected);
            this.Controls.Add(this.lbxComp);
            this.Controls.Add(this.btnAddComp);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddCate);
            this.Controls.Add(this.txtCateg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddimage);
            this.Controls.Add(this.pbFood);
            this.Controls.Add(this.txtPhotoPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFoodCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFood_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnMinimaiz;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodCode;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhotoPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.Button btnAddimage;
        private System.Windows.Forms.TextBox txtCateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Button btnAddComp;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxComp;
        private System.Windows.Forms.Button btnRmSelected;
        private System.Windows.Forms.Button btnLastRemov;
        private System.Windows.Forms.Button btnRmAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSuggest;
        private System.Windows.Forms.Button btnAddSug;
        private System.Windows.Forms.TextBox txtCatSug;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.RadioButton rbtnCateg;
        private System.Windows.Forms.RadioButton rbtnPrep;
        private System.Windows.Forms.RadioButton rbtnComp;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangBackc;
        private System.Windows.Forms.ColorDialog ColorDia1;
        private System.Windows.Forms.Button btnCreateView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Button btnDelNo;
        private System.Windows.Forms.Button btnDelYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBackUp;
    }
}

