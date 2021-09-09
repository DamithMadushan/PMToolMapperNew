using PTM.BusinessLogic;
using PTM.BusinessLogic.Services;
using PTM.DBAccess.DBModel;
using PTM.Model.Models;
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
    public partial class ToolMappingResults : Form
    {
        private Thread thread;

        public ToolMappingResults()
        {
            LoadingMessage.Loadingmsg = "Mapping selected tools...";

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void ToolMappingResults_Load(object sender, EventArgs e)
        {
            setDelay().Wait();

            lblMappingInfo.Visible = true;

            setDataAsync().Wait();

            lblMappingInfo.Visible = false;
        }


        private async Task setDelay()
        {
            await Task.Delay(2000).ConfigureAwait(false);
        }

        private async Task setDataAsync()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            SharedDataModel.matchingRecords = 0;
            SharedDataModel.totalRecords = 0;
            mappingPercentage.Text = "";


            long mappingId = ToolMappingService.insertMappingID();


            //reset
            SharedDataModel.matchingRecords = 0;
            SharedDataModel.totalRecords = 0;

            if (MappingTempData.commonBasic)
            {
                var _commonBasictoolFeatures = await ToolMappingService.getCommonBasicFeatures(mappingId);

                foreach (ToolMappingDataModel toolFeature in _commonBasictoolFeatures)
                {
                    listBox1.Items.Add(toolFeature.FeatureName + " - " + toolFeature.FromToolName + "(" + toolFeature.FromToolYesNo + ")" + " - " + toolFeature.ToToolName + "(" + toolFeature.ToToolYesNo + ")");

                    //matching records
                    if (toolFeature.FromToolYesNo == "Yes" && toolFeature.ToToolYesNo == "Yes")
                    {
                        SharedDataModel.matchingRecords += 1;
                    }

                    //total
                    SharedDataModel.totalRecords += 1;
                }

            }


            if (MappingTempData.commonAdvanced)
            {
                var _commonAdvancedtoolFeatures = await ToolMappingService.getCommonAdvancedFeatures(mappingId);

                foreach (ToolMappingDataModel toolFeature in _commonAdvancedtoolFeatures)
                {
                    listBox2.Items.Add(toolFeature.FeatureName + " - " + toolFeature.FromToolName + "(" + toolFeature.FromToolYesNo + ")" + " - " + toolFeature.ToToolName + "(" + toolFeature.ToToolYesNo + ")");


                    //matching records
                    if (toolFeature.FromToolYesNo == "Yes" && toolFeature.ToToolYesNo == "Yes")
                    {
                        SharedDataModel.matchingRecords += 1;
                    }

                    //total
                    SharedDataModel.totalRecords += 1;
                }



            }


         
            if (MappingTempData.extraFeatures)
            {
                var _ExtratoolFeatures = await ToolMappingService.getExtraFeatures(mappingId);

                foreach (ToolMappingDataModel toolFeature in _ExtratoolFeatures)
                {
                    listBox3.Items.Add(toolFeature.FeatureName + " - " + toolFeature.FromToolName + "(" + toolFeature.FromToolYesNo + ")" + " - " + toolFeature.ToToolName + "(" + toolFeature.ToToolYesNo + ")");


                    //matching records
                    if (toolFeature.FromToolYesNo == "Yes" && toolFeature.ToToolYesNo == "Yes")
                    {
                        SharedDataModel.matchingRecords += 1;
                    }

                    //total
                    SharedDataModel.totalRecords += 1;

                }

            }



            if(SharedDataModel.matchingRecords >= SharedDataModel.totalRecords)
            {
                mappingPercentage.Text = "100 %";

                ToolMappingService.updateMappingPercentage("100", mappingId);

                progressBar1.Value = 100;
            }
            else
            {
                double percentage = Math.Round((SharedDataModel.matchingRecords / SharedDataModel.totalRecords) * 100,3);

                mappingPercentage.Text = percentage.ToString() + "%";

                ToolMappingService.updateMappingPercentage(percentage.ToString(), mappingId);

                progressBar1.Value = (int)percentage;
            }

            //reset
            SharedDataModel.matchingRecords = 0;
            SharedDataModel.totalRecords = 0;

        }

        private void generateReportbtn_Click(object sender, EventArgs e)
        {
          
            TooMappingResultReport tooMappingResultReport = new TooMappingResultReport(1);
            this.Hide();
            tooMappingResultReport.ShowDialog();

        }

        private void ToolMappingResults_Shown(object sender, EventArgs e)
        {


        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }

        private void homeBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PMToolMapping pMToolMapping = new PMToolMapping();
            pMToolMapping.ShowDialog();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            TooMappingResultReport tooMappingResultReport = new TooMappingResultReport(1);
            this.Hide();
            tooMappingResultReport.ShowDialog();
        }

        private void lblMappingInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
