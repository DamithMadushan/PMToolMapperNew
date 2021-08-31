namespace PMToolMapper
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            this.lblUserNameFull = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.drpRole = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.lblpm = new System.Windows.Forms.Label();
            this.errormsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserNameFull
            // 
            this.lblUserNameFull.AutoSize = true;
            this.lblUserNameFull.Location = new System.Drawing.Point(13, 19);
            this.lblUserNameFull.Name = "lblUserNameFull";
            this.lblUserNameFull.Size = new System.Drawing.Size(54, 13);
            this.lblUserNameFull.TabIndex = 0;
            this.lblUserNameFull.Text = "Full Name";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(113, 16);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(277, 20);
            this.textBoxFullName.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(113, 58);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(277, 20);
            this.textBoxUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(113, 145);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(277, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(113, 188);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(277, 20);
            this.textBoxConfirmPassword.TabIndex = 7;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(13, 191);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(244, 249);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 6, 12, 3);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(70, 36);
            this.ClearBtn.TabIndex = 39;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(113, 249);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 6, 12, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(68, 36);
            this.SaveButton.TabIndex = 38;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Location = new System.Drawing.Point(0, 3);
            this.UserdataGridView.MultiSelect = false;
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.ReadOnly = true;
            this.UserdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserdataGridView.Size = new System.Drawing.Size(860, 615);
            this.UserdataGridView.TabIndex = 40;
            this.UserdataGridView.SelectionChanged += new System.EventHandler(this.UserdataGridView_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errormsg);
            this.panel1.Controls.Add(this.labelRole);
            this.panel1.Controls.Add(this.drpRole);
            this.panel1.Controls.Add(this.textBoxFullName);
            this.panel1.Controls.Add(this.lblUserNameFull);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.textBoxConfirmPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblConfirmPassword);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Location = new System.Drawing.Point(2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 621);
            this.panel1.TabIndex = 41;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(14, 104);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 41;
            this.labelRole.Text = "Role";
            // 
            // drpRole
            // 
            this.drpRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpRole.FormattingEnabled = true;
            this.drpRole.Items.AddRange(new object[] {
            "--Select--",
            "Admin",
            "Project Manager",
            "Scrum Master"});
            this.drpRole.Location = new System.Drawing.Point(113, 101);
            this.drpRole.Name = "drpRole";
            this.drpRole.Size = new System.Drawing.Size(277, 21);
            this.drpRole.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.UserdataGridView);
            this.panel2.Location = new System.Drawing.Point(446, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 621);
            this.panel2.TabIndex = 42;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.homeBtn);
            this.pnlTop.Controls.Add(this.lblpm);
            this.pnlTop.Location = new System.Drawing.Point(2, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1307, 48);
            this.pnlTop.TabIndex = 43;
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
            this.homeBtn.TabIndex = 19;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // lblpm
            // 
            this.lblpm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpm.AutoSize = true;
            this.lblpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblpm.Location = new System.Drawing.Point(594, 10);
            this.lblpm.Name = "lblpm";
            this.lblpm.Size = new System.Drawing.Size(135, 22);
            this.lblpm.TabIndex = 0;
            this.lblpm.Text = "User Manager";
            this.lblpm.UseMnemonic = false;
            // 
            // errormsg
            // 
            this.errormsg.AutoSize = true;
            this.errormsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormsg.ForeColor = System.Drawing.Color.Red;
            this.errormsg.Location = new System.Drawing.Point(110, 221);
            this.errormsg.Name = "errormsg";
            this.errormsg.Size = new System.Drawing.Size(0, 13);
            this.errormsg.TabIndex = 42;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 687);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PM Tool Mapper  - UserManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserNameFull;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label lblpm;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox drpRole;
        private System.Windows.Forms.Label errormsg;
    }
}