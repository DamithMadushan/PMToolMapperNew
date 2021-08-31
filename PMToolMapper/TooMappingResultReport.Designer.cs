namespace PMToolMapper
{
    partial class TooMappingResultReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TooMappingResultReport));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblpm = new System.Windows.Forms.Label();
            this.lblReportName = new System.Windows.Forms.Label();
            this.comboBoxReportName = new System.Windows.Forms.ComboBox();
            this.btnReportGenerate = new PMToolMapper.Resources.Custom_Designs.RoundCornersButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportMappingResults1 = new PMToolMapper.CrystalReportMappingResults();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.homeBtn);
            this.pnlTop.Controls.Add(this.btnSettings);
            this.pnlTop.Controls.Add(this.lblpm);
            this.pnlTop.Location = new System.Drawing.Point(2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1307, 48);
            this.pnlTop.TabIndex = 2;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.ForeColor = System.Drawing.Color.SkyBlue;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(9, 5);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(40, 40);
            this.homeBtn.TabIndex = 17;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(1257, 1);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblpm
            // 
            this.lblpm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpm.AutoSize = true;
            this.lblpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblpm.Location = new System.Drawing.Point(557, 14);
            this.lblpm.Name = "lblpm";
            this.lblpm.Size = new System.Drawing.Size(270, 22);
            this.lblpm.TabIndex = 0;
            this.lblpm.Text = "Tool Mapping Results Report";
            this.lblpm.UseMnemonic = false;
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.Location = new System.Drawing.Point(8, 68);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(103, 17);
            this.lblReportName.TabIndex = 4;
            this.lblReportName.Text = "Report Name";
            // 
            // comboBoxReportName
            // 
            this.comboBoxReportName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReportName.FormattingEnabled = true;
            this.comboBoxReportName.Location = new System.Drawing.Point(156, 66);
            this.comboBoxReportName.Name = "comboBoxReportName";
            this.comboBoxReportName.Size = new System.Drawing.Size(454, 24);
            this.comboBoxReportName.TabIndex = 5;
            // 
            // btnReportGenerate
            // 
            this.btnReportGenerate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReportGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReportGenerate.Location = new System.Drawing.Point(656, 65);
            this.btnReportGenerate.Name = "btnReportGenerate";
            this.btnReportGenerate.Size = new System.Drawing.Size(96, 26);
            this.btnReportGenerate.TabIndex = 18;
            this.btnReportGenerate.Text = "Generate";
            this.btnReportGenerate.UseVisualStyleBackColor = false;
            this.btnReportGenerate.Click += new System.EventHandler(this.btnReportGenerate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 97);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReportMappingResults1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1307, 592);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // TooMappingResultReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 687);
            this.Controls.Add(this.btnReportGenerate);
            this.Controls.Add(this.comboBoxReportName);
            this.Controls.Add(this.lblReportName);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TooMappingResultReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TooMappingResultReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TooMappingResultReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblpm;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReportMappingResults CrystalReportMappingResults1;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.ComboBox comboBoxReportName;
        private Resources.Custom_Designs.RoundCornersButton btnReportGenerate;
    }
}