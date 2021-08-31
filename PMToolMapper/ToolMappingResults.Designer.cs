namespace PMToolMapper
{
    partial class ToolMappingResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolMappingResults));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblpm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewTool = new System.Windows.Forms.Label();
            this.lblCommonBasic = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mappingPercentage = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMappingInfo = new System.Windows.Forms.Label();
            this.generateReportbtn = new PMToolMapper.Resources.Custom_Designs.RoundCornersButton();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlTop.Location = new System.Drawing.Point(1, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1307, 48);
            this.pnlTop.TabIndex = 1;
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
            this.lblpm.Size = new System.Drawing.Size(204, 22);
            this.lblpm.TabIndex = 0;
            this.lblpm.Text = "Tool Mapping Results";
            this.lblpm.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblMappingInfo);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNewTool);
            this.panel1.Controls.Add(this.lblCommonBasic);
            this.panel1.Location = new System.Drawing.Point(1, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 580);
            this.panel1.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Items.AddRange(new object[] {
            " "});
            this.listBox3.Location = new System.Drawing.Point(902, 53);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(381, 500);
            this.listBox3.TabIndex = 13;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            " "});
            this.listBox2.Location = new System.Drawing.Point(460, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(381, 500);
            this.listBox2.TabIndex = 12;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(15, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(381, 500);
            this.listBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(954, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Extra features of destination tool ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNewTool
            // 
            this.lblNewTool.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewTool.AutoSize = true;
            this.lblNewTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTool.Location = new System.Drawing.Point(532, 10);
            this.lblNewTool.Name = "lblNewTool";
            this.lblNewTool.Size = new System.Drawing.Size(239, 22);
            this.lblNewTool.TabIndex = 9;
            this.lblNewTool.Text = "Common advanced features ";
            // 
            // lblCommonBasic
            // 
            this.lblCommonBasic.AutoSize = true;
            this.lblCommonBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonBasic.Location = new System.Drawing.Point(92, 10);
            this.lblCommonBasic.Name = "lblCommonBasic";
            this.lblCommonBasic.Size = new System.Drawing.Size(203, 22);
            this.lblCommonBasic.TabIndex = 6;
            this.lblCommonBasic.Text = "Common basic features ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Percentage of matching possibility of both tools";
            // 
            // mappingPercentage
            // 
            this.mappingPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mappingPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.mappingPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mappingPercentage.Location = new System.Drawing.Point(585, 643);
            this.mappingPercentage.Name = "mappingPercentage";
            this.mappingPercentage.ReadOnly = true;
            this.mappingPercentage.Size = new System.Drawing.Size(100, 23);
            this.mappingPercentage.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(403, 643);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(167, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // lblMappingInfo
            // 
            this.lblMappingInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMappingInfo.AutoSize = true;
            this.lblMappingInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lblMappingInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMappingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMappingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMappingInfo.Location = new System.Drawing.Point(524, 297);
            this.lblMappingInfo.Name = "lblMappingInfo";
            this.lblMappingInfo.Size = new System.Drawing.Size(270, 26);
            this.lblMappingInfo.TabIndex = 14;
            this.lblMappingInfo.Text = "Tool mapping in progress...";
            // 
            // generateReportbtn
            // 
            this.generateReportbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateReportbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.generateReportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateReportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.generateReportbtn.Location = new System.Drawing.Point(1147, 643);
            this.generateReportbtn.Name = "generateReportbtn";
            this.generateReportbtn.Size = new System.Drawing.Size(114, 32);
            this.generateReportbtn.TabIndex = 16;
            this.generateReportbtn.Text = "Generate Report";
            this.generateReportbtn.UseVisualStyleBackColor = false;
            this.generateReportbtn.Click += new System.EventHandler(this.generateReportbtn_Click);
            // 
            // ToolMappingResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 687);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.generateReportbtn);
            this.Controls.Add(this.mappingPercentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ToolMappingResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolMappingResults - Tool Mapping Results";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ToolMappingResults_Load);
            this.Shown += new System.EventHandler(this.ToolMappingResults_Shown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblpm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewTool;
        private System.Windows.Forms.Label lblCommonBasic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mappingPercentage;
        private Resources.Custom_Designs.RoundCornersButton generateReportbtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblMappingInfo;
    }
}