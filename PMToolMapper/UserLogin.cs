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
    public partial class UserLogin : Form
    {

        public UserLogin()
        {
            LoadingMessage.Loadingmsg = "Loading Data...";

            InitializeComponent();

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }


        private void LoginUser()
        {

            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            if (userName.Equals("") || password.Equals(""))
            {
                lblError.Text = "Username or password is empty!";
            }
            else
            {

                if (UserService.Login(userName, password))
                {


                    dataLoading.Visible = true;

                    Thread syncData = new Thread(SyncData);

                    syncData.Start();


                }
                else
                {
                    lblError.Text = "Invalid username or password!";
                }

            }
        }

        private void SyncData()
        {
            ApiData apiData = new ApiData();

            //Get PM Tools
            Task asynctaskGetTools;
            asynctaskGetTools = apiData.getPMToolData();
            asynctaskGetTools.Wait();


            //Get AllFeatures
            Task asynctaskGetAllFeatures;
            asynctaskGetAllFeatures = apiData.getAllFeaturesData();
            asynctaskGetAllFeatures.Wait();

            //Get Feature Categories
            Task asynctaskGetAllFeatureCategories;
            asynctaskGetAllFeatureCategories = apiData.getAllFeaturesCatData();
            asynctaskGetAllFeatureCategories.Wait();

            //Get Tool Features
            Task asynctaskGetToolFeatures;
            asynctaskGetToolFeatures = apiData.getToolFeaturesData();
            asynctaskGetToolFeatures.Wait();


            Invoke(new Action(hideForm));

        }

        private void hideForm() {

            //All done
            this.Hide();
            dataLoading.Visible = false;
            PMToolMapping pMToolMapping = new PMToolMapping();
            pMToolMapping.ShowDialog();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginUser();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginUser();
            }
        }
    }
}
