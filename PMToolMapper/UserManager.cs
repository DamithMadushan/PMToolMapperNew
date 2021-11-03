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
    public partial class UserManager : Form
    {
        private bool UpdateUser = false;
        private string Userid;
        private string Password;

        public UserManager()
        {
            InitializeComponent();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            //users
            List<UserManegeModel> _userList = new List<UserManegeModel>();

            foreach (var user in UserService.getUserList())
            {

                UserManegeModel oneUser = new UserManegeModel()
                {

                    UserId = user.UserId,
                    UserFullName = user.UserFullName,
                    UserName = user.UserName,
                    Password = user.Password,
                    Role = user.Role,
                    Date = user.Date

                };

                _userList.Add(oneUser);
            }


            UserdataGridView.DataSource = _userList;
            UserdataGridView.ClearSelection();
            UserdataGridView.Columns["Password"].Visible = false;

            UpdateUser = false;
            Clear();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PMToolMapping toolMapping = new PMToolMapping();
            toolMapping.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string userFullName = textBoxFullName.Text;
            string userName = textBoxUserName.Text;
            string userRole = drpRole.Text;
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;


            if(password != confirmPassword)
            {
                errormsg.ForeColor = Color.Red;
                errormsg.Text = "Password is mot matching!";
            }
            else
            {


                if (password == confirmPassword && !userFullName.Equals("") && !userName.Equals("") && !userRole.Equals("--Select--"))
                {

                    UserModel userModel = new UserModel
                    {

                        userFullName = userFullName,
                        userName = userName,
                        Role = userRole,
                        password = password,
                        confirmPassword = confirmPassword,
                        Date = DateTime.Now.ToString()

                    };

                    //update user
                    if (UpdateUser)
                    {


                        userModel.userId = Convert.ToInt32(Userid);

                        if (password == "")
                        {
                            userModel.password = Password;
                        }

                        if (UserService.UpdateUser(userModel))
                        {
                            errormsg.ForeColor = Color.Green;
                            errormsg.Text = "Successfully updated!";


                            Userid = "";

                            //users
                            List<UserManegeModel> _userList = new List<UserManegeModel>();

                            foreach (var user in UserService.getUserList())
                            {

                                UserManegeModel oneUser = new UserManegeModel()
                                {

                                    UserId = user.UserId,
                                    UserFullName = user.UserFullName,
                                    UserName = user.UserName,
                                    Password = user.Password,
                                    Role = user.Role,
                                    Date = user.Date

                                };

                                _userList.Add(oneUser);
                            }


                            UserdataGridView.DataSource = _userList;
                            UserdataGridView.ClearSelection();
                            UserdataGridView.Columns["Password"].Visible = false;

                            UpdateUser = false;
                            Clear();
                        }
                        else
                        {
                            errormsg.ForeColor = Color.Red;
                            errormsg.Text = "Update error!";


                            Userid = "";

                            //users
                            List<UserManegeModel> _userList = new List<UserManegeModel>();

                            foreach (var user in UserService.getUserList())
                            {

                                UserManegeModel oneUser = new UserManegeModel()
                                {

                                    UserId = user.UserId,
                                    UserFullName = user.UserFullName,
                                    UserName = user.UserName,
                                    Password = user.Password,
                                    Role = user.Role,
                                    Date = user.Date

                                };

                                _userList.Add(oneUser);
                            }


                            UserdataGridView.DataSource = _userList;
                            UserdataGridView.ClearSelection();
                            UserdataGridView.Columns["Password"].Visible = false;

                            UpdateUser = false;
                            Clear();

                        }
                    }

                    else
                    {

                        //add password check
                        if(password.Equals("") || confirmPassword.Equals(""))
                        {
                            errormsg.ForeColor = Color.Green;
                            errormsg.Text = "Password is empty!";

                        }
                        else
                        {


                            if (UserService.AddUser(userModel))
                            {

                                errormsg.ForeColor = Color.Green;
                                errormsg.Text = "Successfully added!";

                                //users
                                List<UserManegeModel> _userList = new List<UserManegeModel>();

                                foreach (var user in UserService.getUserList())
                                {

                                    UserManegeModel oneUser = new UserManegeModel()
                                    {

                                        UserId = user.UserId,
                                        UserFullName = user.UserFullName,
                                        UserName = user.UserName,
                                        Password = user.Password,
                                        Role = user.Role,
                                        Date = user.Date

                                    };

                                    _userList.Add(oneUser);
                                }


                                UserdataGridView.DataSource = _userList;
                                UserdataGridView.ClearSelection();
                                UserdataGridView.Columns["Password"].Visible = false;

                                UpdateUser = false;
                                Clear();
                            }
                            else
                            {

                                errormsg.ForeColor = Color.Red;
                                errormsg.Text = "User add error!";

                                //users
                                List<UserManegeModel> _userList = new List<UserManegeModel>();

                                foreach (var user in UserService.getUserList())
                                {

                                    UserManegeModel oneUser = new UserManegeModel()
                                    {

                                        UserId = user.UserId,
                                        UserFullName = user.UserFullName,
                                        UserName = user.UserName,
                                        Password = user.Password,
                                        Role = user.Role,
                                        Date = user.Date

                                    };

                                    _userList.Add(oneUser);
                                }


                                UserdataGridView.DataSource = _userList;
                                UserdataGridView.ClearSelection();
                                UserdataGridView.Columns["Password"].Visible = false;

                                UpdateUser = false;
                                Clear();
                            }


                        }


                    }



                }
                else
                {
                    errormsg.ForeColor = Color.Red;
                    errormsg.Text = "Please fill all fields!";
                }
            }


            

        }

        private void Clear()
        {
            textBoxFullName.Text = "";
            textBoxUserName.Text = "";
            drpRole.SelectedIndex = 0;
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            errormsg.Text = "";

            Clear();
        }

        private void UserdataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (UserdataGridView.SelectedCells.Count > 0)
            {

                UpdateUser = true;

                int selectedrowindex = UserdataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = UserdataGridView.Rows[selectedrowindex];
                Userid = Convert.ToString(selectedRow.Cells["UserId"].Value);
                string UserFullName = Convert.ToString(selectedRow.Cells["UserFullName"].Value);
                string UserName = Convert.ToString(selectedRow.Cells["UserName"].Value);
                Password = Convert.ToString(selectedRow.Cells["Password"].Value);
                string Role = Convert.ToString(selectedRow.Cells["Role"].Value);

                textBoxFullName.Text = UserFullName;
                textBoxUserName.Text = UserName;

                if (Role == "Admin")
                {
                    drpRole.SelectedIndex = 1;
                }
                else if (Role == "Project Manager")
                {

                    drpRole.SelectedIndex = 2;
                }
                else if (Role == "Scrum Master")
                {

                    drpRole.SelectedIndex = 3;
                }

            }

        }

        private void homeBtn_Click_1(object sender, EventArgs e)
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
    }
}
