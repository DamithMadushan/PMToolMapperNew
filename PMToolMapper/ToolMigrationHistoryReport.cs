using PTM.BusinessLogic.Services;
using PTM.Model.Models;
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
    public partial class ToolMigrationHistoryReport : Form
    {
        //to load default or custom report
        int loadpoint = 2;

        public ToolMigrationHistoryReport(int loadpoint)
        {
            InitializeComponent();

            this.loadpoint = loadpoint;

            if (loadpoint == 1)
            {
                loadReport();
            }
            else
            {
                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.Refresh();
            }

            //load dropdown
            loadDrp();

            comboBoxReportName.SelectedIndex = -1;

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

        private void lblpm_Click(object sender, EventArgs e)
        {

        }

        private void ToolMigrationHistoryReport_Load(object sender, EventArgs e)
        {

        }

        private void loadDrp()
        {

            List<PMtoolModel> mtoolModels = ToolMigrationReportService.getToolMappingDrp();

            comboBoxReportName.DataSource = mtoolModels;
            comboBoxReportName.ValueMember = "ToolId";
            comboBoxReportName.DisplayMember = "ToolName";
        }

        private void btnReportGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                long selecttedReport = Convert.ToInt64(comboBoxReportName.SelectedValue);

                if (selecttedReport != null || selecttedReport != -1)
                {
                    loadReportCustom(selecttedReport);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void loadReport()
        {

            try
            {
                //Rpt file
                ToolMigtationCrystalReport toolMigtationCrystalReport = new ToolMigtationCrystalReport();


                //dataset
                MigrationReportDataSet migrationReportDataSet = new MigrationReportDataSet();

                //data table
                DataTable migrationDataTable = migrationReportDataSet.MigrationData.Clone();


                //migration data

                var migrationData = ToolMigrationReportService.gettoolMappingResultDetails();


                DataRow migrationRow = migrationDataTable.NewRow();

                migrationRow["FromTool"] = migrationData.FromTool;
                migrationRow["ToTool"] = migrationData.ToTool;
                migrationRow["MigrationDate"] = migrationData.Date;
                migrationRow["MigratedBy"] = migrationData.User;
                migrationRow["FromProject"] = migrationData.MigratedFrom;
                migrationRow["ToProject"] = migrationData.MigratedTo;

                migrationDataTable.Rows.Add(migrationRow);




                migrationReportDataSet.Tables.Add(migrationDataTable);


                toolMigtationCrystalReport.Database.Tables[0].SetDataSource(migrationDataTable);

                crystalReportViewer1.ReportSource = toolMigtationCrystalReport;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {

                throw ex;

            }



        }



        private void loadReportCustom(long selecttedReport)
        {

            try
            {
                //Rpt file
                ToolMigtationCrystalReport toolMigtationCrystalReport = new ToolMigtationCrystalReport();


                //dataset
                MigrationReportDataSet migrationReportDataSet = new MigrationReportDataSet();

                //data table
                DataTable migrationDataTable = migrationReportDataSet.MigrationData.Clone();


                //migration data

                var migrationData = ToolMigrationReportService.gettoolMigrationResultDetailsCustom(selecttedReport);


                DataRow migrationRow = migrationDataTable.NewRow();

                migrationRow["FromTool"] = migrationData.FromTool;
                migrationRow["ToTool"] = migrationData.ToTool;
                migrationRow["MigrationDate"] = migrationData.Date;
                migrationRow["MigratedBy"] = migrationData.User;
                migrationRow["FromProject"] = migrationData.MigratedFrom;
                migrationRow["ToProject"] = migrationData.MigratedTo;

                migrationDataTable.Rows.Add(migrationRow);




                migrationReportDataSet.Tables.Add(migrationDataTable);


                toolMigtationCrystalReport.Database.Tables[0].SetDataSource(migrationDataTable);

                crystalReportViewer1.ReportSource = toolMigtationCrystalReport;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {

                throw ex;

            }



        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                long selecttedReport = Convert.ToInt64(comboBoxReportName.SelectedValue);

                if (selecttedReport != null || selecttedReport != -1)
                {
                    loadReportCustom(selecttedReport);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PMToolMapping pMToolMapping = new PMToolMapping();
            pMToolMapping.ShowDialog();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }
    }
}
