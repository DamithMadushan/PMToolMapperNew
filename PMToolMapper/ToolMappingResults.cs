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

            Point basiclblp = new Point(lblCommonBasic.Location.X, lblCommonBasic.Location.Y);
            Point basiclistboxp = new Point(listBox1.Location.X, listBox1.Location.Y);

            Point advancelblp = new Point(commonlbl.Location.X, commonlbl.Location.Y);
            Point listBox2blp = new Point(listBox2.Location.X, listBox2.Location.Y);



            if (MappingTempData.commonBasic == false)
            {

                listBox1.Visible = false;
                lblCommonBasic.Visible = false;

            }            
            
            if (MappingTempData.commonAdvanced == false)
            {

                listBox2.Visible = false;
                commonlbl.Visible = false;

     

            }            
            
            
            if (MappingTempData.extraFeatures == false)
            {

                listBox3.Visible = false;
                extralbl.Visible = false;

            }


            if(MappingTempData.commonBasic == false && MappingTempData.commonAdvanced == true && MappingTempData.extraFeatures == true)
            {
                commonlbl.Location = basiclblp;
                listBox2.Location = basiclistboxp;

                extralbl.Location = advancelblp;
                listBox3.Location = listBox2blp;

            }
            else if (MappingTempData.commonBasic == false && MappingTempData.commonAdvanced == false && MappingTempData.extraFeatures == true)
            {

                extralbl.Location = basiclblp;
                listBox3.Location = basiclistboxp;

            }
            else if (MappingTempData.commonBasic == false && MappingTempData.commonAdvanced == true && MappingTempData.extraFeatures == false)
            {
                commonlbl.Location = basiclblp;
                listBox2.Location = basiclistboxp;


            }
            else if (MappingTempData.commonBasic == true && MappingTempData.commonAdvanced == false && MappingTempData.extraFeatures == true)
            {
                extralbl.Location = advancelblp;
                listBox3.Location = listBox2blp;


            }


            //progressBarCustom1.ForeColor = Color.FromArgb(0, 255, 0);
            //progressBarCustom1.BackColor = Color.FromArgb(172, 0, 0);


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
                    
                    listBox1.Items.Add("");
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
                    
                    listBox2.Items.Add("");

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

                    listBox3.Items.Add("");

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


                ToolMappingService.updateMappingPercentage("100", mappingId);


                textProgressBar1.Value = 100;

                PercentagetextBox1.Text =  "100%";



            }
            else
            {
                double percentage = Math.Round((SharedDataModel.matchingRecords / SharedDataModel.totalRecords) * 100,3);



                ToolMappingService.updateMappingPercentage(percentage.ToString(), mappingId);


                PercentagetextBox1.Text = percentage.ToString() + "%";

                textProgressBar1.Value = (int)percentage;




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
