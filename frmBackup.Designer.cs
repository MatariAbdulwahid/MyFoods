namespace MyFood
{
    partial class frmBackup
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
            this.btnResBackup = new System.Windows.Forms.Button();
            this.btnNewBackup = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCLOSE1 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResBackup
            // 
            this.btnResBackup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnResBackup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResBackup.Location = new System.Drawing.Point(121, 127);
            this.btnResBackup.Name = "btnResBackup";
            this.btnResBackup.Size = new System.Drawing.Size(315, 58);
            this.btnResBackup.TabIndex = 30;
            this.btnResBackup.Text = "Restor a backup";
            this.btnResBackup.UseVisualStyleBackColor = false;
            this.btnResBackup.Click += new System.EventHandler(this.btnResBackup_Click);
            // 
            // btnNewBackup
            // 
            this.btnNewBackup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNewBackup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewBackup.Location = new System.Drawing.Point(121, 63);
            this.btnNewBackup.Name = "btnNewBackup";
            this.btnNewBackup.Size = new System.Drawing.Size(315, 58);
            this.btnNewBackup.TabIndex = 29;
            this.btnNewBackup.Text = "take a new backup";
            this.btnNewBackup.UseVisualStyleBackColor = false;
            this.btnNewBackup.Click += new System.EventHandler(this.btnNewBackup_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Red;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(548, 38);
            this.pnlHeader.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(508, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCLOSE1
            // 
            this.btnCLOSE1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCLOSE1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLOSE1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCLOSE1.Location = new System.Drawing.Point(121, 191);
            this.btnCLOSE1.Name = "btnCLOSE1";
            this.btnCLOSE1.Size = new System.Drawing.Size(315, 58);
            this.btnCLOSE1.TabIndex = 32;
            this.btnCLOSE1.Text = "Close";
            this.btnCLOSE1.UseVisualStyleBackColor = false;
            this.btnCLOSE1.Click += new System.EventHandler(this.btnCLOSE1_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(548, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btnCLOSE1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnResBackup);
            this.Controls.Add(this.btnNewBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBackup";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResBackup;
        private System.Windows.Forms.Button btnNewBackup;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCLOSE1;
    }
}