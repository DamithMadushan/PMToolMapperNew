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

            ToolMigrationHistory toolMigrationHistory = new ToolMigrationHistory();
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

        private void btnMapTools_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Map Pm Tools";
            btnMapTools.BackColor = Color.BlueViolet;

            btnMappingsReports.BackColor = Color.SlateBlue;
            btnMigratePMTools.BackColor = Color.SlateBlue;
            btnToolMigrationHistory.BackColor = Color.SlateBlue;
        }

        private void btnMappingsReports_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Generate Mapping Reports";
            btnMappingsReports.BackColor = Color.BlueViolet;

            btnMapTools.BackColor = Color.SlateBlue;
            btnMigratePMTools.BackColor = Color.SlateBlue;
            btnToolMigrationHistory.BackColor = Color.SlateBlue;
        }

        private void btnMigratePMTools_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Migrate PM Tools";
            btnMigratePMTools.BackColor = Color.BlueViolet;

            btnMappingsReports.BackColor = Color.SlateBlue;
            btnMapTools.BackColor = Color.SlateBlue;
            btnToolMigrationHistory.BackColor = Color.SlateBlue;
        }

        private void btnToolMigrationHistory_MouseHover(object sender, EventArgs e)
        {
            desTextBox.Text = "Tool migration history";
            btnToolMigrationHistory.BackColor = Color.BlueViolet;

            btnMigratePMTools.BackColor = Color.SlateBlue;
            btnMappingsReports.BackColor = Color.SlateBlue;
            btnMapTools.BackColor = Color.SlateBlue;
        }
    }
}
