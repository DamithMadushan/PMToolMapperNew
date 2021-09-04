using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
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
using System.Web.Services.Description;
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


        private void fromProjectsJiraIssues()
        {

            try
            {


                if (!string.IsNullOrEmpty(JiraInfoModel.CloudId) && !string.IsNullOrEmpty(JiraInfoModel.CloudId) && !string.IsNullOrEmpty(JiraInfoModel.CloudId))
                {

                    string selectedProject = comboBoxSelectProject.Text.ToString();

                    string url = "https://api.atlassian.com/ex/jira/" + JiraInfoModel.CloudId + "/rest/api/3/search?jql=project%20%3D%20" + selectedProject + "&fields=names,summary,description,issuetype";
                    var response = GetResponseProjectsJira(url);

                    dynamic res = JsonConvert.DeserializeObject<IssueRootJira>(response.Content);



                    foreach (IssueJira issueData in res.issues)
                    {
                        string issueName = "";
                        string description = "";
                        string issuetype = "";

                        issueName = issueData.fields.summary;

                        issuetype = issueData.fields.issuetype.name;

                        if (issueData.fields.description.content != null)
                        {

                            foreach (IssueContentJira issueContentJira in issueData.fields.description.content)
                            {

                                if (issueContentJira.contentinside != null)
                                {

                                    foreach (IssueContentinsideJira issueContentinsideJira in issueContentJira.contentinside)
                                    {

                                        description = issueContentinsideJira.text;


                                    }
                                }

                            }
                        }

                        if (issuetype == "Task" || issuetype == "Bug")
                        {
                            if (!string.IsNullOrEmpty(TFSInfoModel.Organization) && !string.IsNullOrEmpty(TFSInfoModel.Token))
                            {
                                string project = comboBoxSelectProjectEnd.Text;
                                string token = TFSInfoModel.Token;
                                string org = TFSInfoModel.Organization;
                                string _url = "https://dev.azure.com/" + org;

                                if (issuetype == "Bug")
                                {
                                    issuetype = "Issue";
                                }

                                CreateBugUsingClientLib(_url, token, project, issueName, issuetype, description);
                            }

                        }





                    }



                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Message");
            }



        }



        /// <summary>
        /// Create a bug using the .NET client library
        /// </summary>
        /// <returns>Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models.WorkItem</returns>    
        public WorkItem CreateBugUsingClientLib(string _uri, string _personalAccessToken, string _project, string issuename, string issuetype, string issuedescription)
        {
            Uri uri = new Uri(_uri);
            string personalAccessToken = _personalAccessToken;
            string project = _project;

            VssBasicCredential credentials = new VssBasicCredential("", personalAccessToken);
            JsonPatchDocument patchDocument = new JsonPatchDocument() { };

            //add fields and their values to your patch document
            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Path = "/fields/System.Title",
                    Value = issuename
                }
            );

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Path = "/fields/Microsoft.VSTS.TCM.ReproSteps",
                    Value = issuedescription
                }
            );

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Path = "/fields/Microsoft.VSTS.Common.Priority",
                    Value = "1"
                }
            );

            patchDocument.Add(
                new JsonPatchOperation()
                {
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Path = "/fields/Microsoft.VSTS.Common.Severity",
                    Value = "2 - High"
                }
            );
            VssConnection connection = new VssConnection(uri, credentials);
            WorkItemTrackingHttpClient workItemTrackingHttpClient = connection.GetClient<WorkItemTrackingHttpClient>();

            try
            {
                WorkItem result = workItemTrackingHttpClient.CreateWorkItemAsync(patchDocument, project, issuetype).Result;

                Console.WriteLine("Bug Successfully Created: Bug #id- {0} issueName - {1}", result.Id, issuename);

                return result;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Error creating bug: {0}", ex.InnerException.Message);
                return null;
            }
        }




        private void getProjectsJira(object sender, EventArgs e)
        {

            try
            {


                if (!string.IsNullOrEmpty(JiraInfoModel.CloudId) && !string.IsNullOrEmpty(JiraInfoModel.CloudId) && !string.IsNullOrEmpty(JiraInfoModel.CloudId))
                {

                    string url = "https://api.atlassian.com/ex/jira/" + JiraInfoModel.CloudId + "/rest/api/3/project";
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
                if (!string.IsNullOrEmpty(comboBoxSelectProjectEnd.Text) && !string.IsNullOrEmpty(comboBoxSelectProject.Text))
                {

                    lblMigrationProgress.Visible = true;

                    setDelay().Wait();


                    MigrationTempData.fromToolName = drpCurrent.Text;
                    MigrationTempData.toToolName = drpDestination.Text;

                    long mappingId = ToolMigrationService.insertMappingID(comboBoxSelectProject.Text,comboBoxSelectProjectEnd.Text);


                    /////////////////


                    if (drpCurrent.Text == "Jira" && drpDestination.Text == "TFS")
                    {
                        fromProjectsJiraIssues();
                    }






                    //////////////////////


                    lblMigrationProgress.Visible = false;

                    this.Hide();
                    ToolMigrationHistoryReport toolMigrationHistoryReport = new ToolMigrationHistoryReport(1);
                    toolMigrationHistoryReport.ShowDialog();


                }
                else
                {


                    MessageBox.Show("Please select projects to migrate!");

                }

            }
        }

        private async Task setDelay()
        {
            await Task.Delay(2000).ConfigureAwait(false);
        }

    }

    //Jira project classes
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



    /// <summary>
    /// Jira Issue classes
    /// </summary>
    public class IssuetypeJira
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public bool subtask { get; set; }
        public int avatarId { get; set; }
        public int hierarchyLevel { get; set; }
    }

    public class IssueContentinsideJira
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class IssueContentJira
    {
        public string type { get; set; }
        public List<IssueContentinsideJira> contentinside { get; set; }
    }

    public class IssueDescriptionJira
    {
        public int version { get; set; }
        public string type { get; set; }
        public List<IssueContentJira> content { get; set; }
    }

    public class IssueFieldsJira
    {
        public string summary { get; set; }
        public IssuetypeJira issuetype { get; set; }
        public IssueDescriptionJira description { get; set; }
    }

    public class IssueJira
    {
        public string expand { get; set; }
        public string id { get; set; }
        public string self { get; set; }
        public string key { get; set; }
        public IssueFieldsJira fields { get; set; }
    }

    public class IssueRootJira
    {
        public string expand { get; set; }
        public int startAt { get; set; }
        public int maxResults { get; set; }
        public int total { get; set; }
        public List<IssueJira> issues { get; set; }
    }








    /// <summary>
    /// TFS project classes
    /// </summary>
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
