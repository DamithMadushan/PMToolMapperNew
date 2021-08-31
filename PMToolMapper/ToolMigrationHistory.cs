using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMToolMapper
{
    public partial class ToolMigrationHistory : Form
    {
        public ToolMigrationHistory()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PMToolMapping pMToolMapping = new PMToolMapping();
            pMToolMapping.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }
    }
}
