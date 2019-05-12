namespace MyFood
{
    partial class frmConfirmDel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelNo = new System.Windows.Forms.Button();
            this.btnDelYes = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to delete this food ?";
            // 
            // btnDelNo
            // 
            this.btnDelNo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelNo.Location = new System.Drawing.Point(317, 116);
            this.btnDelNo.Name = "btnDelNo";
            this.btnDelNo.Size = new System.Drawing.Size(155, 58);
            this.btnDelNo.TabIndex = 25;
            this.btnDelNo.Text = "No";
            this.btnDelNo.UseVisualStyleBackColor = false;
            this.btnDelNo.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelYes
            // 
            this.btnDelYes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelYes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelYes.Location = new System.Drawing.Point(122, 116);
            this.btnDelYes.Name = "btnDelYes";
            this.btnDelYes.Size = new System.Drawing.Size(146, 58);
            this.btnDelYes.TabIndex = 24;
            this.btnDelYes.Text = "Yes";
            this.btnDelYes.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmConfirmDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(563, 201);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelNo);
            this.Controls.Add(this.btnDelYes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmDel";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelNo;
        private System.Windows.Forms.Button btnDelYes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}