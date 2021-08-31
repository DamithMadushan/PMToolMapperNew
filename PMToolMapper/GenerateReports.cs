using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMToolMapper
{
    public partial class GenerateReports : Form
    {
        private Thread thread;

        public GenerateReports()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            PMToolMapping toolMapping = new PMToolMapping();
            toolMapping.ShowDialog();
        }


        private void generateAllReportbtn_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }
    }
}
