namespace PMToolMapper
{
    partial class GroupingFeatures
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblpm = new System.Windows.Forms.Label();
            this.basicCheckbox = new System.Windows.Forms.CheckBox();
            this.advancedchkbox = new System.Windows.Forms.CheckBox();
            this.extrachkbox = new System.Windows.Forms.CheckBox();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(305, 239);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 6, 12, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 36);
            this.OKButton.TabIndex = 36;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(434, 239);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 6, 12, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 36);
            this.CancelBtn.TabIndex = 37;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.lblpm);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(565, 48);
            this.pnlTop.TabIndex = 38;
            // 
            // lblpm
            // 
            this.lblpm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpm.AutoSize = true;
            this.lblpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblpm.Location = new System.Drawing.Point(199, 14);
            this.lblpm.Name = "lblpm";
            this.lblpm.Size = new System.Drawing.Size(177, 22);
            this.lblpm.TabIndex = 0;
            this.lblpm.Text = "Grouping Features";
            this.lblpm.UseMnemonic = false;
            // 
            // basicCheckbox
            // 
            this.basicCheckbox.AutoSize = true;
            this.basicCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicCheckbox.Location = new System.Drawing.Point(39, 75);
            this.basicCheckbox.Name = "basicCheckbox";
            this.basicCheckbox.Size = new System.Drawing.Size(175, 21);
            this.basicCheckbox.TabIndex = 39;
            this.basicCheckbox.Text = "Common basic features";
            this.basicCheckbox.UseVisualStyleBackColor = true;
            // 
            // advancedchkbox
            // 
            this.advancedchkbox.AutoSize = true;
            this.advancedchkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedchkbox.Location = new System.Drawing.Point(39, 112);
            this.advancedchkbox.Name = "advancedchkbox";
            this.advancedchkbox.Size = new System.Drawing.Size(204, 21);
            this.advancedchkbox.TabIndex = 40;
            this.advancedchkbox.Text = "Common advanced features";
            this.advancedchkbox.UseVisualStyleBackColor = true;
            // 
            // extrachkbox
            // 
            this.extrachkbox.AutoSize = true;
            this.extrachkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extrachkbox.Location = new System.Drawing.Point(39, 149);
            this.extrachkbox.Name = "extrachkbox";
            this.extrachkbox.Size = new System.Drawing.Size(231, 21);
            this.extrachkbox.TabIndex = 41;
            this.extrachkbox.Text = "Extra features of destination tool";
            this.extrachkbox.UseVisualStyleBackColor = true;
            // 
            // GroupingFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.extrachkbox);
            this.Controls.Add(this.advancedchkbox);
            this.Controls.Add(this.basicCheckbox);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKButton);
            this.Name = "GroupingFeatures";
            this.Size = new System.Drawing.Size(565, 298);
            this.Load += new System.EventHandler(this.GroupingFeatures_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblpm;
        private System.Windows.Forms.CheckBox basicCheckbox;
        private System.Windows.Forms.CheckBox advancedchkbox;
        private System.Windows.Forms.CheckBox extrachkbox;
    }
}
