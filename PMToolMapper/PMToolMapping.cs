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
    public partial class PMToolMapping : Form
    {
        Thread thread;

        public PMToolMapping()
        {
            InitializeComponent();
        }

        private void lblpm_Click(object sender, EventArgs e)
        {

        }


        private void btnMapTools_Click(object sender, EventArgs e)
        {
            this.Hide();

            ToolMapping toolMapping = new ToolMapping();
            toolMapping.ShowDialog();


        }



        private void btnMappingsReports_Click(object sender, EventArgs e)
        {

            this.Hide();

            //GenerateReports generateReports = new GenerateReports();
            //generateReports.ShowDialog();

            TooMappingResultReport tooMappingResultReport = new TooMappingResultReport(2);
            tooMappingResultReport.ShowDialog();
        }



        private void btnMigratePMTools_Click(object sender, EventArgs e)
        {

            this.Hide();

            ToolMigration toolMigration = new ToolMigration();
            toolMigration.ShowDialog();
        }



        private void btnToolMigrationHistory_Click(object sender, EventArgs e)
        {
            this.Hide();

            ToolMigrationHistoryReport toolMigrationHistory = new ToolMigrationHistoryReport(2);
            toolMigrationHistory.ShowDialog();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            PMToolMapping toolMapping = new PMToolMapping();
            toolMapping.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ToolMapping toolMapping = new ToolMapping();
            toolMapping.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            TooMappingResultReport tooMappingResultReport = new TooMappingResultReport(2);
            tooMappingResultReport.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            ToolMigration toolMigration = new ToolMigration();
            toolMigration.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            ToolMigrationHistoryReport toolMigrationHistory = new ToolMigrationHistoryReport(2);
            toolMigrationHistory.ShowDialog();
        }

        private void buttonMapTL_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Map Pm Tools";
            //buttonMapTL.BackColor = Color.FromArgb(22, 144, 248);

            //buttonGenerateMPToolReport.BackColor = Color.FromArgb(48, 50, 74);
            //buttonMigratePMTools.BackColor = Color.FromArgb(48, 50, 74);
            //buttonToolMigrationHistoryReport.BackColor = Color.FromArgb(48, 50, 74);
        }

        private void buttonGenerateMPTool_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Generate Mapping Reports";
            //buttonGenerateMPToolReport.BackColor = Color.FromArgb(22, 144, 248);

            //buttonMapTL.BackColor = Color.FromArgb(48, 50, 74);
            //buttonMigratePMTools.BackColor = Color.FromArgb(48, 50, 74);
            //buttonToolMigrationHistoryReport.BackColor = Color.FromArgb(48, 50, 74);
        }

        private void buttonMigratePMTools_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Migrate PM Tools";
            //buttonMigratePMTools.BackColor = Color.FromArgb(22, 144, 248);

            //buttonGenerateMPToolReport.BackColor = Color.FromArgb(48, 50, 74);
            //buttonMapTL.BackColor = Color.FromArgb(48, 50, 74);
            //buttonToolMigrationHistoryReport.BackColor = Color.FromArgb(48, 50, 74);
        }

        private void buttonToolMigrationHistory_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Tool migration history";
            //buttonToolMigrationHistoryReport.BackColor = Color.FromArgb(22, 144, 248);

            //buttonMapTL.BackColor = Color.FromArgb(48, 50, 74);
            //buttonGenerateMPToolReport.BackColor = Color.FromArgb(48, 50, 74);
            //buttonMigratePMTools.BackColor = Color.FromArgb(48, 50, 74);
        }
    }
}
