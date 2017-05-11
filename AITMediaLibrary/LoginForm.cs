using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITMediaLibrary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();

            //get users based on textbox entries
            List<UserModel> users = userLogic.GetListOfUsersByLogin(txtUsername.Text, txtPassword.Text);

            //if got some users
            if (users.Count > 0)
            {
                //keep track of current user details
                CurrentUser.UserName = users[0].UserName;
                CurrentUser.UserLevel = users[0].UserLevel;

                //if admin user (userLevel 3) goto admin form
                if (users[0].UserLevel == 3)
                {
                    //go to admin form

                    //create new thread that will call this function openAdminForm
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminForm));
       
                    t.Start();
                }
                else
                {
                    //go to student form
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaForm));

                    t.Start();
                }
                //either way, close this form off
                this.Close();
            }
            else
            {
                lblError.Text = "Login Error!";
            }
        }

        public static void OpenMediaForm()
        {
            Application.Run(new MediaBrowser());
        }

        public static void OpenAdminForm()
        {
            Application.Run(new AdminForm());
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserLogic userLogic = new UserLogic();

            userComboBox.DataSource = userLogic.GetListOfUsers(); //make combobox reference list of all user models

            //what to show in the list: Uses the string provided to look for an attribute of this name for each list item
            userComboBox.DisplayMember = "UserName"; 
            //what the value of this choice would be if we chose it 
            userComboBox.ValueMember = "UserID";
           
            
        }

        
    }
}
