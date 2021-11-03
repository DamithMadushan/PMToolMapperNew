using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using Nancy.Json;
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
using System.Text.RegularExpressions;
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
            gitLabInfo1.Visible = false;
            lblMigrationProgress.Visible = false;

            loadDropDowns();

            jiraInfo1.OkButtonClickJira += new EventHandler(getProjectsJira);
            tfsInfo1.OkButtonClickTFS += new EventHandler(getProjectsTFS);
            gitLabInfo1.OkButtonClickGitLab += new EventHandler(getProjectsGitLab);

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

            }else if(drpCurrent.Text == "GitLab")
            {

                gitLabInfo1.Visible = true;
            }

        }


        private void JiraIssuesCreateFromTFS()
        {

            try
            {

                if (!string.IsNullOrEmpty(comboBoxSelectProject.Text) && !string.IsNullOrEmpty(comboBoxSelectProjectEnd.Text))
                {

                    string token = TFSInfoModel.Token;
                    string org = TFSInfoModel.Organization;
                    Uri url = new Uri("https://dev.azure.com/" + org);
                    string project = comboBoxSelectProject.Text;


                    VssBasicCredential credentials = new VssBasicCredential("", token);

                    Wiql wiql = new Wiql()
                    {
                        Query = "Select [State], [Title],[Remaining Work] From WorkItems Where [Work Item Type] = 'Issue' OR [Work Item Type] = 'Task' And [System.TeamProject] = '" + project + "'"
                    };

                    //create instance of work item tracking http client
                    using (WorkItemTrackingHttpClient workItemTrackingHttpClient = new WorkItemTrackingHttpClient(url, credentials))
                    {
                        //execute the query to get the list of work items in the results
                        WorkItemQueryResult workItemQueryResult = workItemTrackingHttpClient.QueryByWiqlAsync(wiql).Result;

                        //some error handling                
                        if (workItemQueryResult.WorkItems.Count() != 0)
                        {
                            foreach (IEnumerable<WorkItemReference> batch in workItemQueryResult.WorkItems.Batch(100))
                            {
                                var workItemIds = batch.Select(p => p.Id).ToArray();
                                var workItems = workItemTrackingHttpClient.GetWorkItemsAsync(workItemIds, expand: WorkItemExpand.All).Result;

                                foreach (var workItem in workItems)
                                {
                                    string taskType = "";
                                    string taskName = "";

                                    foreach (var field in workItem.Fields)
                                    {
                                        if (field.Key == "System.WorkItemType")
                                        {
                                            taskType = field.Value.ToString();

                                        }
                                        else if (field.Key == "System.Title")
                                        {
                                            taskName = field.Value.ToString();
                                        }

                                    }


                                    CreateJiraIssue(taskName, taskType);

                                }

                            }
                        }


                    }


                }
                else
                {
                    MessageBox.Show("Please select a project!");
                }

            }
            catch(Exception ex)
            {

            }
        }


        private void TFSIssuesCreate()
        {

            try
            {

                if (!string.IsNullOrEmpty(comboBoxSelectProject.Text) && !string.IsNullOrEmpty(comboBoxSelectProjectEnd.Text))
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
                else
                {
                    MessageBox.Show("Please select a project!");
                }

            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message.ToString(), "Message");
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


        private void JiraIssuesCreateFromTFSToGitLab()
        {

            try
            {

                if (!string.IsNullOrEmpty(comboBoxSelectProject.Text) && !string.IsNullOrEmpty(comboBoxSelectProjectEnd.Text))
                {
                    string selectedProjectId = comboBoxSelectProjectEnd.SelectedValue.ToString();

                    string token = TFSInfoModel.Token;
                    string org = TFSInfoModel.Organization;
                    Uri url = new Uri("https://dev.azure.com/" + org);
                    string project = comboBoxSelectProject.Text;


                    VssBasicCredential credentials = new VssBasicCredential("", token);

                    Wiql wiql = new Wiql()
                    {
                        Query = "Select [State], [Title],[Remaining Work] From WorkItems Where [Work Item Type] = 'Issue' OR [Work Item Type] = 'Task' And [System.TeamProject] = '" + project + "'"
                    };

                    //create instance of work item tracking http client
                    using (WorkItemTrackingHttpClient workItemTrackingHttpClient = new WorkItemTrackingHttpClient(url, credentials))
                    {
                        //execute the query to get the list of work items in the results
                        WorkItemQueryResult workItemQueryResult = workItemTrackingHttpClient.QueryByWiqlAsync(wiql).Result;

                        //some error handling                
                        if (workItemQueryResult.WorkItems.Count() != 0)
                        {
                            foreach (IEnumerable<WorkItemReference> batch in workItemQueryResult.WorkItems.Batch(100))
                            {
                                var workItemIds = batch.Select(p => p.Id).ToArray();
                                var workItems = workItemTrackingHttpClient.GetWorkItemsAsync(workItemIds, expand: WorkItemExpand.All).Result;

                                foreach (var workItem in workItems)
                                {
                                    string taskType = "";
                                    string taskName = "";

                                    foreach (var field in workItem.Fields)
                                    {
                                        if (field.Key == "System.WorkItemType")
                                        {
                                            taskType = field.Value.ToString();

                                        }
                                        else if (field.Key == "System.Title")
                                        {
                                            taskName = field.Value.ToString();
                                        }

                                    }

                                    string tokenGitLab = GitLabInfoModel.token;
                                    string useridGitLab = GitLabInfoModel.userid;

                                    taskName = taskName.Replace(" ", "%20");

                                    if(taskType == "Issue" || taskType == "Task")
                                    {
                                        string urlgitlab = "https://gitlab.com/api/v4/projects/" + selectedProjectId + "/issues?title=" + taskName + "&labels=" + taskType;



                                        CreateIssuesGitLab(urlgitlab, tokenGitLab);
                                    }



                                }

                            }
                        }


                    }


                }
                else
                {
                    MessageBox.Show("Please select a project!");
                }

            }
            catch (Exception ex)
            {

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

                            ProjectId = projectData.key,
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

              //  MessageBox.Show(ex.Message.ToString(), "Message");
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


        public IRestResponse GetResponseProjectsGitLab(string url, string personalAccessToken, Method method = Method.GET)
        {

            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("PRIVATE-TOKEN", personalAccessToken);
            IRestResponse response = client.Execute(request);
            return response;

        }



        public IRestResponse CreateIssuesGitLab(string url, string personalAccessToken, Method method = Method.POST)
        {

            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("PRIVATE-TOKEN", personalAccessToken);
            IRestResponse response = client.Execute(request);
            return response;

        }


        public IRestResponse GetResponseIssuesGitLab(string url, string personalAccessToken, Method method = Method.GET)
        {

            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("PRIVATE-TOKEN", personalAccessToken);
            IRestResponse response = client.Execute(request);
            return response;

        }


        public IRestResponse GetResponseWorkItemsTFS(string url, string personalAccessToken, Method method = Method.POST)
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


        private void getProjectsGitLab(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(GitLabInfoModel.token) && !string.IsNullOrEmpty(GitLabInfoModel.userid))
                {

                    string token = GitLabInfoModel.token;
                    string userid = GitLabInfoModel.userid;
                    string url = "https://gitlab.com/api/v4/users/" + userid + "/projects";


                    var response = GetResponseProjectsGitLab(url, token);

                    dynamic res = JsonConvert.DeserializeObject<List<GitLabRootProjects>>(response.Content);


                    List<ProjectDropdown> projects = new List<ProjectDropdown>();

                    foreach (GitLabRootProjects projectData in res)
                    {

                        ProjectDropdown projectDropdown = new ProjectDropdown()
                        {

                            ProjectId = projectData.id.ToString(),
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


                    gitLabInfo1.Visible = false;
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

                //MessageBox.Show(ex.Message.ToString(), "Message");
            }


        }


        private void TFSIssuesCreateFromGitLab()
        {

            try
            {

                if (!string.IsNullOrEmpty(comboBoxSelectProject.Text) && !string.IsNullOrEmpty(comboBoxSelectProjectEnd.Text))
                {


                    if (!string.IsNullOrEmpty(GitLabInfoModel.token) && !string.IsNullOrEmpty(GitLabInfoModel.userid))
                    {

                        string selectedProjectId = comboBoxSelectProject.SelectedValue.ToString();

                        string tokenGitLab = GitLabInfoModel.token;
                        string useridGitLab = GitLabInfoModel.userid;
                        string url = "https://gitlab.com/api/v4/projects/"+ selectedProjectId +"/issues";


                        var response = GetResponseIssuesGitLab(url, tokenGitLab);

                        dynamic res = JsonConvert.DeserializeObject<List<RootGitLab>>(response.Content);



                        foreach (RootGitLab issueData in res)
                        {
                            string issueName = "";
                            string description = "";
                            string issuetype = "";

                            issueName = issueData.title;

                            issuetype = "Issue";

                            description = issueData.description;

                     
                                if (!string.IsNullOrEmpty(TFSInfoModel.Organization) && !string.IsNullOrEmpty(TFSInfoModel.Token))
                                {
                                    string project = comboBoxSelectProjectEnd.Text;
                                    string token = TFSInfoModel.Token;
                                    string org = TFSInfoModel.Organization;
                                    string _url = "https://dev.azure.com/" + org;

                                    CreateBugUsingClientLib(_url, token, project, issueName, issuetype, description);
                                }

                            





                        }



                    }


                }
                else
                {
                    MessageBox.Show("Please select a project!");
                }

            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.Message.ToString(), "Message");
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
            else if (drpDestination.Text == "GitLab")
            {

                gitLabInfo1.Visible = true;
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

                    long mappingId = ToolMigrationService.insertMappingID(comboBoxSelectProject.Text, comboBoxSelectProjectEnd.Text);


                    /////////////////


                    if (drpCurrent.Text == "Jira" && drpDestination.Text == "TFS")
                    {
                        TFSIssuesCreate();

                    }
                    else if (drpCurrent.Text == "TFS" && drpDestination.Text == "Jira")
                    {
                        JiraIssuesCreateFromTFS();
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



   



        public IRestResponse CreateJiraIssue(string taskname, string issueType, Method method = Method.POST)
        {
            string email = JiraInfoModel.Email;
            string token = JiraInfoModel.Token;

            string project = comboBoxSelectProjectEnd.Text;
            string projectid = comboBoxSelectProjectEnd.SelectedValue.ToString();


            string url = "https://api.atlassian.com/ex/jira/" + JiraInfoModel.CloudId + "/rest/api/3/issue";

            if (issueType == "Issue")
            {
                issueType = "Bug";
            }



            string data = @"{""fields"": {""project"":{""key"": """ + projectid + @"""},""summary"": """ + taskname + @""",""issuetype"": {""name"": """ + issueType + @"""}}}";

            //dynamic json = JsonConvert.DeserializeObject(data);

            string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{email}:{token}"));
            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("Authorization", $"Basic {encoded}");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(data);
            IRestResponse response = client.Execute(request);
            return response;
        }

        private void buttonMigrate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure You want to migrate selected tools?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(comboBoxSelectProjectEnd.Text) && !string.IsNullOrEmpty(comboBoxSelectProject.Text))
                {

                    lblMigrationProgress.Visible = true;

                    setDelay().Wait();


                    MigrationTempData.fromToolName = drpCurrent.Text;
                    MigrationTempData.toToolName = drpDestination.Text;

                    long mappingId = ToolMigrationService.insertMappingID(comboBoxSelectProject.Text, comboBoxSelectProjectEnd.Text);


                    /////////////////


                    if (drpCurrent.Text == "Jira" && drpDestination.Text == "TFS")
                    {
                        TFSIssuesCreate();
                        
                    }
                    else if (drpCurrent.Text == "TFS" && drpDestination.Text == "Jira")
                    {
                        JiraIssuesCreateFromTFS();
                    }else if(drpCurrent.Text == "GitLab" && drpDestination.Text == "TFS")
                    {
                        TFSIssuesCreateFromGitLab();
                    }
                    else if (drpCurrent.Text == "TFS" && drpDestination.Text == "GitLab")
                    {
                        JiraIssuesCreateFromTFSToGitLab();
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

        private void jiraInfo1_Load(object sender, EventArgs e)
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

        private void tfsInfo1_Load(object sender, EventArgs e)
        {

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



    ///Jira Issue Create
    ///
    public class JiraProject
    {
        public string key { get; set; }
    }

    public class JiraIssuetype
    {
        public string name { get; set; }
    }

    public class JiraIssueFields
    {
        public JiraProject project { get; set; }
        public string summary { get; set; }
        public JiraIssuetype issuetype { get; set; }
    }

    public class JiraIssueRoot
    {
        public JiraIssueFields fields { get; set; }
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



    ////////GitLab Projects///////////

    public class GitLabProjectsNamespace
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string kind { get; set; }
        public string full_path { get; set; }
        public object parent_id { get; set; }
        public string avatar_url { get; set; }
        public string web_url { get; set; }
    }

    public class GitLabProjectsLinks
    {
        public string self { get; set; }
        public string issues { get; set; }
        public string merge_requests { get; set; }
        public string repo_branches { get; set; }
        public string labels { get; set; }
        public string events { get; set; }
        public string members { get; set; }
    }

    public class GitLabProjectsOwner
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string state { get; set; }
        public string avatar_url { get; set; }
        public string web_url { get; set; }
    }

    public class GitLabProjectsContainerExpirationPolicy
    {
        public string cadence { get; set; }
        public bool enabled { get; set; }
        public int keep_n { get; set; }
        public string older_than { get; set; }
        public string name_regex { get; set; }
        public object name_regex_keep { get; set; }
        public DateTime next_run_at { get; set; }
    }

    public class GitLabProjectsProjectAccess
    {
        public int access_level { get; set; }
        public int notification_level { get; set; }
    }

    public class GitLabProjectsPermissions
    {
        public GitLabProjectsProjectAccess project_access { get; set; }
        public object group_access { get; set; }
    }

    public class GitLabRootProjects
    {
        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string name_with_namespace { get; set; }
        public string path { get; set; }
        public string path_with_namespace { get; set; }
        public DateTime created_at { get; set; }
        public string default_branch { get; set; }
        public List<object> tag_list { get; set; }
        public List<object> topics { get; set; }
        public string ssh_url_to_repo { get; set; }
        public string http_url_to_repo { get; set; }
        public string web_url { get; set; }
        public string readme_url { get; set; }
        public object avatar_url { get; set; }
        public int forks_count { get; set; }
        public int star_count { get; set; }
        public DateTime last_activity_at { get; set; }
        public GitLabProjectsNamespace @namespace { get; set; }
        public string container_registry_image_prefix { get; set; }
        public GitLabProjectsLinks _links { get; set; }
        public bool packages_enabled { get; set; }
        public bool empty_repo { get; set; }
        public bool archived { get; set; }
        public string visibility { get; set; }
        public GitLabProjectsOwner owner { get; set; }
        public bool resolve_outdated_diff_discussions { get; set; }
        public GitLabProjectsContainerExpirationPolicy container_expiration_policy { get; set; }
        public bool issues_enabled { get; set; }
        public bool merge_requests_enabled { get; set; }
        public bool wiki_enabled { get; set; }
        public bool jobs_enabled { get; set; }
        public bool snippets_enabled { get; set; }
        public bool container_registry_enabled { get; set; }
        public bool service_desk_enabled { get; set; }
        public string service_desk_address { get; set; }
        public bool can_create_merge_request_in { get; set; }
        public string issues_access_level { get; set; }
        public string repository_access_level { get; set; }
        public string merge_requests_access_level { get; set; }
        public string forking_access_level { get; set; }
        public string wiki_access_level { get; set; }
        public string builds_access_level { get; set; }
        public string snippets_access_level { get; set; }
        public string pages_access_level { get; set; }
        public string operations_access_level { get; set; }
        public string analytics_access_level { get; set; }
        public string container_registry_access_level { get; set; }
        public object emails_disabled { get; set; }
        public bool shared_runners_enabled { get; set; }
        public bool lfs_enabled { get; set; }
        public int creator_id { get; set; }
        public string import_status { get; set; }
        public int open_issues_count { get; set; }
        public int ci_default_git_depth { get; set; }
        public bool ci_forward_deployment_enabled { get; set; }
        public bool ci_job_token_scope_enabled { get; set; }
        public bool public_jobs { get; set; }
        public int build_timeout { get; set; }
        public string auto_cancel_pending_pipelines { get; set; }
        public object build_coverage_regex { get; set; }
        public string ci_config_path { get; set; }
        public List<object> shared_with_groups { get; set; }
        public bool only_allow_merge_if_pipeline_succeeds { get; set; }
        public object allow_merge_on_skipped_pipeline { get; set; }
        public bool restrict_user_defined_variables { get; set; }
        public bool request_access_enabled { get; set; }
        public bool only_allow_merge_if_all_discussions_are_resolved { get; set; }
        public bool remove_source_branch_after_merge { get; set; }
        public bool printing_merge_request_link_enabled { get; set; }
        public string merge_method { get; set; }
        public string squash_option { get; set; }
        public object suggestion_commit_message { get; set; }
        public bool auto_devops_enabled { get; set; }
        public string auto_devops_deploy_strategy { get; set; }
        public bool autoclose_referenced_issues { get; set; }
        public bool keep_latest_artifact { get; set; }
        public string external_authorization_classification_label { get; set; }
        public bool requirements_enabled { get; set; }
        public bool security_and_compliance_enabled { get; set; }
        public List<object> compliance_frameworks { get; set; }
        public GitLabProjectsPermissions permissions { get; set; }
    }


    ///GitLab Issues///
    public class AuthorGitLab
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string state { get; set; }
        public string avatar_url { get; set; }
        public string web_url { get; set; }
    }

    public class TimeStatsGitLab
    {
        public int time_estimate { get; set; }
        public int total_time_spent { get; set; }
        public object human_time_estimate { get; set; }
        public object human_total_time_spent { get; set; }
    }

    public class TaskCompletionStatusGitLab
    {
        public int count { get; set; }
        public int completed_count { get; set; }
    }

    public class LinksGitLab
    {
        public string self { get; set; }
        public string notes { get; set; }
        public string award_emoji { get; set; }
        public string project { get; set; }
    }

    public class ReferencesGitLab
    {
        public string @short { get; set; }
        public string relative { get; set; }
        public string full { get; set; }
    }

    public class RootGitLab
    {
        public int id { get; set; }
        public int iid { get; set; }
        public int project_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string state { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object closed_at { get; set; }
        public object closed_by { get; set; }
        public List<object> labels { get; set; }
        public object milestone { get; set; }
        public List<object> assignees { get; set; }
        public AuthorGitLab author { get; set; }
        public string type { get; set; }
        public object assignee { get; set; }
        public int user_notes_count { get; set; }
        public int merge_requests_count { get; set; }
        public int upvotes { get; set; }
        public int downvotes { get; set; }
        public object due_date { get; set; }
        public bool confidential { get; set; }
        public object discussion_locked { get; set; }
        public string issue_type { get; set; }
        public string web_url { get; set; }
        public TimeStatsGitLab time_stats { get; set; }
        public TaskCompletionStatusGitLab task_completion_status { get; set; }
        public int blocking_issues_count { get; set; }
        public bool has_tasks { get; set; }
        public LinksGitLab _links { get; set; }
        public ReferencesGitLab references { get; set; }
        public object moved_to_id { get; set; }
        public object service_desk_reply_to { get; set; }
    }

}
