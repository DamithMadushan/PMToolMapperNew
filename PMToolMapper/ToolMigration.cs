using PTM.BusinessLogic.Services;
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
    public partial class ToolMigration : Form
    {
        private Thread thread;

        public ToolMigration()
        {
            InitializeComponent();


            loadDropDowns();
        }

        private void lblLogin1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
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

        private void ToolMigration_Load(object sender, EventArgs e)
        {

        }

        private void loadDropDowns()
        {

            List<PMtoolModel> pMtoolModels = ToolMigrationService.getToolMappingDrp();
            List<PMtoolModel> pMtoolModels2 = ToolMigrationService.getToolMappingDrp();

            drpCurrent.DataSource = pMtoolModels;
            drpCurrent.DisplayMember = "ToolName";
            drpCurrent.ValueMember = "ToolId";            
            
            
            drpDestination.DataSource = pMtoolModels2;
            drpDestination.DisplayMember = "ToolName";
            drpDestination.ValueMember = "ToolId";
        }

        private void drpCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
