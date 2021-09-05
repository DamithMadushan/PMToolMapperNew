namespace PMToolMapper
{
    partial class ToolMigration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolMigration));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblpm = new System.Windows.Forms.Label();
            this.lblCurrentPlatform = new System.Windows.Forms.Label();
            this.drpCurrent = new System.Windows.Forms.ComboBox();
            this.lblLogin1 = new System.Windows.Forms.Label();
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.drpDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.comboBoxSelectProject = new System.Windows.Forms.ComboBox();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.comboBoxSelectProjectEnd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMigrationProgress = new System.Windows.Forms.Label();
            this.tfsInfo1 = new PMToolMapper.TFSInfo();
            this.jiraInfo1 = new PMToolMapper.JiraInfo();
            this.btnMigrate = new PMToolMapper.Resources.Custom_Designs.RoundCornersButton();
            this.btnDestinationLogin = new PMToolMapper.Resources.Custom_Designs.RoundCornersButton();
            this.btnCurrentLogin = new PMToolMapper.Resources.Custom_Designs.RoundCornersButton();
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
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
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
            this.homeBtn.Location = new System.Drawing.Point(10, 5);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(40, 40);
            this.homeBtn.TabIndex = 34;
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
            this.lblpm.Location = new System.Drawing.Point(588, 14);
            this.lblpm.Name = "lblpm";
            this.lblpm.Size = new System.Drawing.Size(138, 22);
            this.lblpm.TabIndex = 0;
            this.lblpm.Text = "Tool Migration";
            this.lblpm.UseMnemonic = false;
            // 
            // lblCurrentPlatform
            // 
            this.lblCurrentPlatform.AutoSize = true;
            this.lblCurrentPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlatform.Location = new System.Drawing.Point(12, 65);
            this.lblCurrentPlatform.Name = "lblCurrentPlatform";
            this.lblCurrentPlatform.Size = new System.Drawing.Size(154, 17);
            this.lblCurrentPlatform.TabIndex = 2;
            this.lblCurrentPlatform.Text = "Select Current Platform";
            // 
            // drpCurrent
            // 
            this.drpCurrent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpCurrent.FormattingEnabled = true;
            this.drpCurrent.Location = new System.Drawing.Point(273, 65);
            this.drpCurrent.Name = "drpCurrent";
            this.drpCurrent.Size = new System.Drawing.Size(274, 24);
            this.drpCurrent.TabIndex = 3;
            this.drpCurrent.SelectedIndexChanged += new System.EventHandler(this.drpCurrent_SelectedIndexChanged);
            // 
            // lblLogin1
            // 
            this.lblLogin1.AutoSize = true;
            this.lblLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin1.Location = new System.Drawing.Point(12, 158);
            this.lblLogin1.Name = "lblLogin1";
            this.lblLogin1.Size = new System.Drawing.Size(43, 17);
            this.lblLogin1.TabIndex = 18;
            this.lblLogin1.Text = "Login";
            this.lblLogin1.Click += new System.EventHandler(this.lblLogin1_Click);
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.Location = new System.Drawing.Point(12, 420);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(43, 17);
            this.lblLogin2.TabIndex = 32;
            this.lblLogin2.Text = "Login";
            // 
            // drpDestination
            // 
            this.drpDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpDestination.FormattingEnabled = true;
            this.drpDestination.Location = new System.Drawing.Point(273, 326);
            this.drpDestination.Name = "drpDestination";
            this.drpDestination.Size = new System.Drawing.Size(274, 24);
            this.drpDestination.TabIndex = 30;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(12, 326);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(178, 17);
            this.lblDestination.TabIndex = 29;
            this.lblDestination.Text = "Select Destination Platform";
            // 
            // comboBoxSelectProject
            // 
            this.comboBoxSelectProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectProject.FormattingEnabled = true;
            this.comboBoxSelectProject.Location = new System.Drawing.Point(273, 239);
            this.comboBoxSelectProject.Name = "comboBoxSelectProject";
            this.comboBoxSelectProject.Size = new System.Drawing.Size(274, 24);
            this.comboBoxSelectProject.TabIndex = 35;
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.AutoSize = true;
            this.lblSelectProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProject.Location = new System.Drawing.Point(12, 239);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(95, 17);
            this.lblSelectProject.TabIndex = 34;
            this.lblSelectProject.Text = "Select Project";
            // 
            // comboBoxSelectProjectEnd
            // 
            this.comboBoxSelectProjectEnd.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSelectProjectEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectProjectEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectProjectEnd.FormattingEnabled = true;
            this.comboBoxSelectProjectEnd.Location = new System.Drawing.Point(273, 499);
            this.comboBoxSelectProjectEnd.Name = "comboBoxSelectProjectEnd";
            this.comboBoxSelectProjectEnd.Size = new System.Drawing.Size(274, 24);
            this.comboBoxSelectProjectEnd.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Project";
            // 
            // lblMigrationProgress
            // 
            this.lblMigrationProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMigrationProgress.AutoSize = true;
            this.lblMigrationProgress.BackColor = System.Drawing.SystemColors.Info;
            this.lblMigrationProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMigrationProgress.Location = new System.Drawing.Point(713, 303);
            this.lblMigrationProgress.Name = "lblMigrationProgress";
            this.lblMigrationProgress.Size = new System.Drawing.Size(216, 20);
            this.lblMigrationProgress.TabIndex = 40;
            this.lblMigrationProgress.Text = "Tool Migration in progress";
            // 
            // tfsInfo1
            // 
            this.tfsInfo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tfsInfo1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tfsInfo1.Location = new System.Drawing.Point(372, 141);
            this.tfsInfo1.Name = "tfsInfo1";
            this.tfsInfo1.Size = new System.Drawing.Size(573, 285);
            this.tfsInfo1.TabIndex = 39;
            // 
            // jiraInfo1
            // 
            this.jiraInfo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jiraInfo1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.jiraInfo1.Location = new System.Drawing.Point(372, 138);
            this.jiraInfo1.Name = "jiraInfo1";
            this.jiraInfo1.Size = new System.Drawing.Size(573, 288);
            this.jiraInfo1.TabIndex = 38;
            // 
            // btnMigrate
            // 
            this.btnMigrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMigrate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMigrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMigrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMigrate.Location = new System.Drawing.Point(1143, 643);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(114, 32);
            this.btnMigrate.TabIndex = 33;
            this.btnMigrate.Text = "Migrate";
            this.btnMigrate.UseVisualStyleBackColor = false;
            this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
            // 
            // btnDestinationLogin
            // 
            this.btnDestinationLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDestinationLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinationLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinationLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDestinationLogin.Location = new System.Drawing.Point(273, 412);
            this.btnDestinationLogin.Name = "btnDestinationLogin";
            this.btnDestinationLogin.Size = new System.Drawing.Size(274, 32);
            this.btnDestinationLogin.TabIndex = 31;
            this.btnDestinationLogin.Text = "Login";
            this.btnDestinationLogin.UseVisualStyleBackColor = false;
            this.btnDestinationLogin.Click += new System.EventHandler(this.btnDestinationLogin_Click);
            // 
            // btnCurrentLogin
            // 
            this.btnCurrentLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCurrentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCurrentLogin.Location = new System.Drawing.Point(273, 150);
            this.btnCurrentLogin.Name = "btnCurrentLogin";
            this.btnCurrentLogin.Size = new System.Drawing.Size(274, 32);
            this.btnCurrentLogin.TabIndex = 17;
            this.btnCurrentLogin.Text = "Login";
            this.btnCurrentLogin.UseVisualStyleBackColor = false;
            this.btnCurrentLogin.Click += new System.EventHandler(this.btnCurrentLogin_Click);
            // 
            // ToolMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 687);
            this.Controls.Add(this.lblMigrationProgress);
            this.Controls.Add(this.tfsInfo1);
            this.Controls.Add(this.jiraInfo1);
            this.Controls.Add(this.comboBoxSelectProjectEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectProject);
            this.Controls.Add(this.lblSelectProject);
            this.Controls.Add(this.btnMigrate);
            this.Controls.Add(this.lblLogin2);
            this.Controls.Add(this.btnDestinationLogin);
            this.Controls.Add(this.drpDestination);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblLogin1);
            this.Controls.Add(this.btnCurrentLogin);
            this.Controls.Add(this.drpCurrent);
            this.Controls.Add(this.lblCurrentPlatform);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ToolMigration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PM Tool Mapper - Tool Migration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ToolMigration_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblpm;
        private System.Windows.Forms.Label lblCurrentPlatform;
        private System.Windows.Forms.ComboBox drpCurrent;
        private Resources.Custom_Designs.RoundCornersButton btnCurrentLogin;
        private System.Windows.Forms.Label lblLogin1;
        private System.Windows.Forms.Label lblLogin2;
        private Resources.Custom_Designs.RoundCornersButton btnDestinationLogin;
        private System.Windows.Forms.ComboBox drpDestination;
        private System.Windows.Forms.Label lblDestination;
        private Resources.Custom_Designs.RoundCornersButton btnMigrate;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.ComboBox comboBoxSelectProject;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.ComboBox comboBoxSelectProjectEnd;
        private System.Windows.Forms.Label label1;
        private JiraInfo jiraInfo1;
        private TFSInfo tfsInfo1;
        private System.Windows.Forms.Label lblMigrationProgress;
    }
}