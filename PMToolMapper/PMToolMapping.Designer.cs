namespace PMToolMapper
{
    partial class PMToolMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMToolMapping));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblpm = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.desTextBox = new PMToolMapper.Resources.Custom_Designs.RoundTextBox();
            this.btnToolMigrationHistory = new PMToolMapper.Resources.Custom_Designs.RoundButton();
            this.btnMigratePMTools = new PMToolMapper.Resources.Custom_Designs.RoundButton();
            this.btnMappingsReports = new PMToolMapper.Resources.Custom_Designs.RoundButton();
            this.btnMapTools = new PMToolMapper.Resources.Custom_Designs.RoundButton();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.btnSettings);
            this.pnlTop.Controls.Add(this.lblpm);
            this.pnlTop.Location = new System.Drawing.Point(1, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1307, 48);
            this.pnlTop.TabIndex = 0;
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
            this.lblpm.Location = new System.Drawing.Point(528, 14);
            this.lblpm.Name = "lblpm";
            this.lblpm.Size = new System.Drawing.Size(272, 22);
            this.lblpm.TabIndex = 0;
            this.lblpm.Text = "PM Tool Mapping & Migration";
            this.lblpm.UseMnemonic = false;
            this.lblpm.Click += new System.EventHandler(this.lblpm_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeft.Controls.Add(this.btnToolMigrationHistory);
            this.pnlLeft.Controls.Add(this.btnMigratePMTools);
            this.pnlLeft.Controls.Add(this.btnMappingsReports);
            this.pnlLeft.Controls.Add(this.btnMapTools);
            this.pnlLeft.Location = new System.Drawing.Point(1, 54);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(916, 632);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.Controls.Add(this.desTextBox);
            this.pnlRight.Controls.Add(this.lblDescription);
            this.pnlRight.Location = new System.Drawing.Point(415, 54);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(893, 632);
            this.pnlRight.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(28, 25);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 22);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // desTextBox
            // 
            this.desTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.desTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.desTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.desTextBox.Location = new System.Drawing.Point(32, 60);
            this.desTextBox.Multiline = true;
            this.desTextBox.Name = "desTextBox";
            this.desTextBox.ReadOnly = true;
            this.desTextBox.Size = new System.Drawing.Size(829, 554);
            this.desTextBox.TabIndex = 1;
            this.desTextBox.Text = resources.GetString("desTextBox.Text");
            // 
            // btnToolMigrationHistory
            // 
            this.btnToolMigrationHistory.BackColor = System.Drawing.Color.SlateBlue;
            this.btnToolMigrationHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToolMigrationHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToolMigrationHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToolMigrationHistory.Location = new System.Drawing.Point(25, 298);
            this.btnToolMigrationHistory.Name = "btnToolMigrationHistory";
            this.btnToolMigrationHistory.Size = new System.Drawing.Size(333, 36);
            this.btnToolMigrationHistory.TabIndex = 3;
            this.btnToolMigrationHistory.Text = "Tool Migration History";
            this.btnToolMigrationHistory.UseVisualStyleBackColor = false;
            this.btnToolMigrationHistory.Click += new System.EventHandler(this.btnToolMigrationHistory_Click);
            this.btnToolMigrationHistory.MouseHover += new System.EventHandler(this.btnToolMigrationHistory_MouseHover);
            // 
            // btnMigratePMTools
            // 
            this.btnMigratePMTools.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMigratePMTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMigratePMTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigratePMTools.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMigratePMTools.Location = new System.Drawing.Point(25, 221);
            this.btnMigratePMTools.Name = "btnMigratePMTools";
            this.btnMigratePMTools.Size = new System.Drawing.Size(333, 36);
            this.btnMigratePMTools.TabIndex = 2;
            this.btnMigratePMTools.Text = "Migrate PM Tools";
            this.btnMigratePMTools.UseVisualStyleBackColor = false;
            this.btnMigratePMTools.Click += new System.EventHandler(this.btnMigratePMTools_Click);
            this.btnMigratePMTools.MouseHover += new System.EventHandler(this.btnMigratePMTools_MouseHover);
            // 
            // btnMappingsReports
            // 
            this.btnMappingsReports.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMappingsReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMappingsReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMappingsReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMappingsReports.Location = new System.Drawing.Point(25, 140);
            this.btnMappingsReports.Name = "btnMappingsReports";
            this.btnMappingsReports.Size = new System.Drawing.Size(333, 36);
            this.btnMappingsReports.TabIndex = 1;
            this.btnMappingsReports.Text = "Generate Mapping Reports";
            this.btnMappingsReports.UseVisualStyleBackColor = false;
            this.btnMappingsReports.Click += new System.EventHandler(this.btnMappingsReports_Click);
            this.btnMappingsReports.MouseHover += new System.EventHandler(this.btnMappingsReports_MouseHover);
            // 
            // btnMapTools
            // 
            this.btnMapTools.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMapTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapTools.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMapTools.Location = new System.Drawing.Point(25, 60);
            this.btnMapTools.Name = "btnMapTools";
            this.btnMapTools.Size = new System.Drawing.Size(333, 36);
            this.btnMapTools.TabIndex = 0;
            this.btnMapTools.Text = "Map Tools";
            this.btnMapTools.UseVisualStyleBackColor = false;
            this.btnMapTools.Click += new System.EventHandler(this.btnMapTools_Click);
            this.btnMapTools.MouseHover += new System.EventHandler(this.btnMapTools_MouseHover);
            // 
            // PMToolMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 687);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "PMToolMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PM Tool Mapper - PM Tool Mapping & Migration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblpm;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private Resources.Custom_Designs.RoundButton btnMapTools;
        private Resources.Custom_Designs.RoundButton btnToolMigrationHistory;
        private Resources.Custom_Designs.RoundButton btnMigratePMTools;
        private Resources.Custom_Designs.RoundButton btnMappingsReports;
        private System.Windows.Forms.Label lblDescription;
        private Resources.Custom_Designs.RoundTextBox desTextBox;
        private System.Windows.Forms.Button btnSettings;
    }
}