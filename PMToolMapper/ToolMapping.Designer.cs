namespace PMToolMapper
{
    partial class ToolMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolMapping));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewTool = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblExistingTool = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblpm = new System.Windows.Forms.Label();
            this.mapBtn = new PMToolMapper.Resources.Custom_Designs.RoundCornersButton();
            this.groupingFeatures = new PMToolMapper.GroupingFeatures();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupingFeatures);
            this.panel1.Controls.Add(this.lblNewTool);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.lblExistingTool);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 588);
            this.panel1.TabIndex = 8;
            // 
            // lblNewTool
            // 
            this.lblNewTool.AutoSize = true;
            this.lblNewTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTool.Location = new System.Drawing.Point(657, 10);
            this.lblNewTool.Name = "lblNewTool";
            this.lblNewTool.Size = new System.Drawing.Size(87, 22);
            this.lblNewTool.TabIndex = 16;
            this.lblNewTool.Text = "New Tool";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            " "});
            this.listBox2.Location = new System.Drawing.Point(661, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(600, 516);
            this.listBox2.TabIndex = 15;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lblExistingTool
            // 
            this.lblExistingTool.AutoSize = true;
            this.lblExistingTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingTool.Location = new System.Drawing.Point(21, 10);
            this.lblExistingTool.Name = "lblExistingTool";
            this.lblExistingTool.Size = new System.Drawing.Size(114, 22);
            this.lblExistingTool.TabIndex = 14;
            this.lblExistingTool.Text = "Existing Tool";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(25, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 516);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.homeBtn);
            this.pnlTop.Controls.Add(this.btnSettings);
            this.pnlTop.Controls.Add(this.lblpm);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1307, 48);
            this.pnlTop.TabIndex = 10;
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
            this.homeBtn.Location = new System.Drawing.Point(10, 5);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(40, 40);
            this.homeBtn.TabIndex = 3;
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
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // lblpm
            // 
            this.lblpm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpm.AutoSize = true;
            this.lblpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblpm.Location = new System.Drawing.Point(594, 10);
            this.lblpm.Name = "lblpm";
            this.lblpm.Size = new System.Drawing.Size(131, 22);
            this.lblpm.TabIndex = 0;
            this.lblpm.Text = "Tool Mapping";
            this.lblpm.UseMnemonic = false;
            // 
            // mapBtn
            // 
            this.mapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mapBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.mapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.mapBtn.Location = new System.Drawing.Point(1114, 648);
            this.mapBtn.Name = "mapBtn";
            this.mapBtn.Size = new System.Drawing.Size(114, 32);
            this.mapBtn.TabIndex = 17;
            this.mapBtn.Text = "Map";
            this.mapBtn.UseVisualStyleBackColor = false;
            this.mapBtn.Click += new System.EventHandler(this.mapBtn_Click);
            // 
            // groupingFeatures
            // 
            this.groupingFeatures.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupingFeatures.Location = new System.Drawing.Point(347, 149);
            this.groupingFeatures.Name = "groupingFeatures";
            this.groupingFeatures.Size = new System.Drawing.Size(565, 298);
            this.groupingFeatures.TabIndex = 17;
            this.groupingFeatures.Visible = false;
            this.groupingFeatures.Load += new System.EventHandler(this.groupingFeatures_Load);
            // 
            // ToolMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 687);
            this.Controls.Add(this.mapBtn);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ToolMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PM Tool Mapper  - ToolMapping";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ToolMapping_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblpm;
        private Resources.Custom_Designs.RoundCornersButton mapBtn;
        private System.Windows.Forms.Button homeBtn;
        private GroupingFeatures groupingFeatures;
        private System.Windows.Forms.Label lblNewTool;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblExistingTool;
        private System.Windows.Forms.ListBox listBox1;
    }
}