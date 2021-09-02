using Newtonsoft.Json;
using PTM.BusinessLogic;
using PTM.BusinessLogic.Services;
using PTM.Model.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMToolMapper
{
    public partial class ToolMigration : Form
    {
        private Thread thread;
        private bool LoginOneClicked = false;
        private bool LoginTwoClicked = false;

        public ToolMigration()
        {
            InitializeComponent();

            jiraInfo1.Visible = false;
            tfsInfo1.Visible = false;
            lblMigrationProgress.Visible = false;

            loadDropDowns();

            jiraInfo1.OkButtonClickJira += new EventHandler(getProjectsJira);
            tfsInfo1.OkButtonClickTFS += new EventHandler(getProjectsTFS);
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

        private void btnCurrentLogin_Click(object sender, EventArgs e)
        {
            LoginOneClicked = true;
            LoginTwoClicked = false;

            //if jira selected
            if (drpCurrent.Text == "Jira")
            {
                jiraInfo1.Visible = true;

            }
            else if (drpCurrent.Text == "TFS")
            {
                tfsInfo1.Visible = true;
            }

        }


        private void getProjectsJira(object sender, EventArgs e)
        {

            try
            {


                    if (!string.IsNullOrEmpty(JiraInfoModel.Url) && !string.IsNullOrEmpty(JiraInfoModel.Url) && !string.IsNullOrEmpty(JiraInfoModel.Url))
                    {

                        string url = "https://api.atlassian.com/ex/jira/" + JiraInfoModel.Url + "/rest/api/3/project";
                        var response = GetResponseProjectsJira(url);

                        dynamic res = JsonConvert.DeserializeObject<List<JiraRoot>>(response.Content);


                        List<ProjectDropdown> projects = new List<ProjectDropdown>();

                        foreach (JiraRoot projectData in res)
                        {

                            ProjectDropdown projectDropdown = new ProjectDropdown()
                            {

                                ProjectId = projectData.id,
                                ProjectName = projectData.name

                            };

                            projects.Add(projectDropdown);



                        }

                        if (LoginOneClicked)
                        {
                            comboBoxSelectProject.DataSource = projects;
                            comboBoxSelectProject.ValueMember = "ProjectId";
                            comboBoxSelectProject.DisplayMember = "ProjectName";
                        }


                        if (LoginTwoClicked)
                        {
                            comboBoxSelectProjectEnd.DataSource = projects;
                            comboBoxSelectProjectEnd.ValueMember = "ProjectId";
                            comboBoxSelectProjectEnd.DisplayMember = "ProjectName";
                        }


                        jiraInfo1.Visible = false;
                        LoginOneClicked = false;
                        LoginTwoClicked = false;

                    }
                    else
                    {

                        MessageBox.Show("Please fill project data!", "Message");

                    }


                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Message");
            }



        }


        public IRestResponse GetResponseProjectsJira(string url, Method method = Method.GET)
        {
            string email = JiraInfoModel.Email;
            string token = JiraInfoModel.Token;

            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{email}:{token}"));
            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("Authorization", $"Basic {encoded}");
            IRestResponse response = client.Execute(request);
            return response;
        }



        public IRestResponse GetResponseProjectsTFS(string url, string personalAccessToken, Method method = Method.GET)
        {

            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(string.Format("{0}:{1}", "", personalAccessToken)));
            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("Authorization", $"Basic {encoded}");
            IRestResponse response = client.Execute(request);
            return response;

        }



        private void getProjectsTFS(object sender, EventArgs e)
        {

            try
            {

                    if (!string.IsNullOrEmpty(TFSInfoModel.Organization) && !string.IsNullOrEmpty(TFSInfoModel.Token))
                    {

                        string token = TFSInfoModel.Token;
                        string org = TFSInfoModel.Organization;
                        string url = "https://dev.azure.com/" + org + "/_apis/projects?stateFilter=All&api-version=1.0";


                        var response = GetResponseProjectsTFS(url, token);

                        dynamic res = JsonConvert.DeserializeObject<TFSRoot>(response.Content);


                        List<ProjectDropdown> projects = new List<ProjectDropdown>();

                        foreach (TFSValue projectData in res.value)
                        {

                            ProjectDropdown projectDropdown = new ProjectDropdown()
                            {

                                ProjectId = projectData.id,
                                ProjectName = projectData.name

                            };

                            projects.Add(projectDropdown);



                        }

                        if (LoginOneClicked)
                        {
                            comboBoxSelectProject.DataSource = projects;
                            comboBoxSelectProject.ValueMember = "ProjectId";
                            comboBoxSelectProject.DisplayMember = "ProjectName";
                        }


                        if (LoginTwoClicked)
                        {
                            comboBoxSelectProjectEnd.DataSource = projects;
                            comboBoxSelectProjectEnd.ValueMember = "ProjectId";
                            comboBoxSelectProjectEnd.DisplayMember = "ProjectName";
                        }


                        tfsInfo1.Visible = false;
                        LoginOneClicked = false;
                        LoginTwoClicked = false;

                    }
                    else
                    {

                        MessageBox.Show("Please fill project data!", "Message");

                    }


                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Message");
            }



        }





        private void btnDestinationLogin_Click(object sender, EventArgs e)
        {
            LoginOneClicked = false;
            LoginTwoClicked = true;

            //if jira selected
            if (drpDestination.Text == "Jira")
            {
                jiraInfo1.Visible = true;

            }
            else if (drpDestination.Text == "TFS")
            {

                tfsInfo1.Visible = true;

            }
        }

        private void btnMigrate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to migrate selected tools?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                lblMigrationProgress.Visible = true;

                setDelay().Wait();


                MigrationTempData.fromToolName = drpCurrent.Text;
                MigrationTempData.toToolName = drpDestination.Text;

                long mappingId = ToolMigrationService.insertMappingID();


                /////////////////


                Thread.Sleep(3000);
                ///Migratiopn Logic///




                //////////////////////


                lblMigrationProgress.Visible = false;

                this.Hide();
                ToolMigrationHistoryReport toolMigrationHistoryReport = new ToolMigrationHistoryReport(1);
                toolMigrationHistoryReport.ShowDialog();

            }
        }

        private async Task setDelay()
        {
            await Task.Delay(2000).ConfigureAwait(false);
        }

    }


    public class JiraAvatarUrls
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class JiraProperties
    {
    }

    public class JiraRoot
    {
        public string expand { get; set; }
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public JiraAvatarUrls avatarUrls { get; set; }
        public string projectTypeKey { get; set; }
        public bool simplified { get; set; }
        public string style { get; set; }
        public bool isPrivate { get; set; }
        public JiraProperties properties { get; set; }
    }



    //TFS classes
    public class TFSValue
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string state { get; set; }
        public int revision { get; set; }
        public string visibility { get; set; }
        public DateTime lastUpdateTime { get; set; }
    }

    public class TFSRoot
    {
        public int count { get; set; }
        public List<TFSValue> value { get; set; }
    }
}
