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
    public partial class TooMappingResultReport : Form
    {
        //to load default or custom report
        int loadpoint = 2;

        public TooMappingResultReport(int loadpoint)
        {
            InitializeComponent();

            this.loadpoint = loadpoint;

            if(loadpoint == 1)
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

        private void TooMappingResultReport_Load(object sender, EventArgs e)
        {

        }


        private void loadDrp() {

            List<PMtoolModel> mtoolModels =  ToolMappingReportService.getToolMappingDrp();

            comboBoxReportName.DataSource = mtoolModels;
            comboBoxReportName.ValueMember = "ToolId";
            comboBoxReportName.DisplayMember = "ToolName";
        }


        private void loadReport()
        {

            try
            {
                //Rpt file
                CrystalReportMappingResults crystalReportMappingResults = new CrystalReportMappingResults();


                //dataset
                MappingResultDataSet mappingResultDataSet = new MappingResultDataSet();

                //data table
                DataTable headingTable = mappingResultDataSet.Headings.Clone();

                DataTable mappingDataTable = mappingResultDataSet.MappingData.Clone();

                //data row
                DataRow headertRow = headingTable.NewRow();
                


                //header data
                var headerData = ToolMappingReportService.gettoolMappingResultHeader();

                headertRow["MappingFrom"] = headerData.MappingFrom;
                headertRow["MappingTo"] = headerData.MappingTo;
                headertRow["MappedBy"] = headerData.MappedBy;
                headertRow["MappedDate"] = headerData.MappedDate;
                headertRow["MappingPercentage"] = headerData.MappingPercentage;

                headingTable.Rows.Add(headertRow);

                mappingResultDataSet.Tables.Add(headingTable);


                //mapping data

                var mappingData = ToolMappingReportService.gettoolMappingResultDetails();

                foreach (var data in mappingData)
                {
                    DataRow mappingtRow = mappingDataTable.NewRow();

                    mappingtRow["FeatureName"] = data.featureName;
                    mappingtRow["MappingFromYesNo"] = data.fromToolYesNo;
                    mappingtRow["MappingToYesNo"] = data.toToolYesNo;

                    mappingDataTable.Rows.Add(mappingtRow);

                }


                mappingResultDataSet.Tables.Add(mappingDataTable);


                //crystalReportMappingResults.SetDataSource(mappingResultDataSet);
                crystalReportMappingResults.Database.Tables[0].SetDataSource(headingTable);
                crystalReportMappingResults.Database.Tables[1].SetDataSource(mappingDataTable);

                crystalReportViewer1.ReportSource = crystalReportMappingResults;
                crystalReportViewer1.Refresh();

            }
            catch(Exception ex)
            {

                throw ex;

            }
           


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

        /// <summary>
        /// generate custom report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            catch(Exception ex)
            {

            }





        }


        private void loadReportCustom(long selecttedReport)
        {

            try
            {
                //Rpt file
                CrystalReportMappingResults crystalReportMappingResults = new CrystalReportMappingResults();


                //dataset
                MappingResultDataSet mappingResultDataSet = new MappingResultDataSet();

                //data table
                DataTable headingTable = mappingResultDataSet.Headings.Clone();

                DataTable mappingDataTable = mappingResultDataSet.MappingData.Clone();

                //data row
                DataRow headertRow = headingTable.NewRow();



                //header data
                var headerData = ToolMappingReportService.gettoolMappingResultHeaderCustom(selecttedReport);

                headertRow["MappingFrom"] = headerData.MappingFrom;
                headertRow["MappingTo"] = headerData.MappingTo;
                headertRow["MappedBy"] = headerData.MappedBy;
                headertRow["MappedDate"] = headerData.MappedDate;
                headertRow["MappingPercentage"] = headerData.MappingPercentage;

                headingTable.Rows.Add(headertRow);

                mappingResultDataSet.Tables.Add(headingTable);


                //mapping data

                var mappingData = ToolMappingReportService.gettoolMappingResultDetailsCustom(selecttedReport);

                foreach (var data in mappingData)
                {
                    DataRow mappingtRow = mappingDataTable.NewRow();

                    mappingtRow["FeatureName"] = data.featureName;
                    mappingtRow["MappingFromYesNo"] = data.fromToolYesNo;
                    mappingtRow["MappingToYesNo"] = data.toToolYesNo;

                    mappingDataTable.Rows.Add(mappingtRow);

                }


                mappingResultDataSet.Tables.Add(mappingDataTable);


                //crystalReportMappingResults.SetDataSource(mappingResultDataSet);
                crystalReportMappingResults.Database.Tables[0].SetDataSource(headingTable);
                crystalReportMappingResults.Database.Tables[1].SetDataSource(mappingDataTable);

                crystalReportViewer1.ReportSource = crystalReportMappingResults;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {

                throw ex;

            }



        }

    }
}
