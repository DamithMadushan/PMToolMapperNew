using PTM.BusinessLogic;
using PTM.BusinessLogic.Services;
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
    public partial class ToolMapping : Form
    {
        Thread thread;

        public ToolMapping()
        {
            InitializeComponent();


            groupingFeatures.OkButtonClick += new EventHandler(UserControl_OkButtonClick);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mapBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to map selected tools?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                groupingFeatures.Visible = true;
                MappingTempData.fromToolName = listBox1.GetItemText(listBox1.SelectedItem);
                MappingTempData.toToolName = listBox2.GetItemText(listBox2.SelectedItem);

            }
        }




        private void UserControl_OkButtonClick(object sender, EventArgs e)
        {
            this.Hide();

            ToolMappingResults toolMappingResults = new ToolMappingResults();
            toolMappingResults.ShowDialog();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PMToolMapping pMToolMapping = new PMToolMapping();
            pMToolMapping.ShowDialog();
        }

        private void groupingFeatures1_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserManager userManager = new UserManager();
            userManager.ShowDialog();
        }

        private void groupingFeatures_Load(object sender, EventArgs e)
        {

        }

        private void ToolMapping_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = CommonDataService.getPMToolList();
            listBox1.DisplayMember = "ToolName";
            listBox1.ValueMember = "ToolId";

            listBox2.DataSource = CommonDataService.getPMToolList();
            listBox2.DisplayMember = "ToolName";
            listBox2.ValueMember = "ToolId";
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.GetItemText(listBox1.SelectedItem) == listBox2.GetItemText(listBox2.SelectedItem)) {

                buttonMap.Enabled = false;

            }
            else
            {
                buttonMap.Enabled = true;
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.GetItemText(listBox1.SelectedItem) == listBox2.GetItemText(listBox2.SelectedItem))
            {

                buttonMap.Enabled = false;

            }
            else
            {
                buttonMap.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to map selected tools?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                groupingFeatures.Visible = true;
                MappingTempData.fromToolName = listBox1.GetItemText(listBox1.SelectedItem);
                MappingTempData.toToolName = listBox2.GetItemText(listBox2.SelectedItem);

            }
        }
    }
}
