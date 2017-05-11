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
    public partial class AdminForm : Form
    {
        private UserLogic userLogic = new UserLogic();
        private UserModel selectedUser = null;


        public AdminForm()
        {
            InitializeComponent();
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
            userLevelComboBox.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));

        }

        private void RefreshUserList()
        {
            userGridView.DataSource = userLogic.GetListOfUsers();

        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)// -1 is the header row, dont caere about it
            { // a list of user model
                List<UserModel> users = (List < UserModel >) userGridView.DataSource;

                selectedUser = users.ElementAt<UserModel>(row); // get from this position 

            
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void UpdatePasswordbutton_Click(object sender, EventArgs e)
        {
            // assignment work
            if (selectedUser != null)
            {
                int rowsAffected = userLogic.UpdatePassword(newPasswordTextbox.Text, selectedUser.UserID, CurrentUser.UserLevel);
                if (rowsAffected > 0)
                {
                    MessageBox.Show(selectedUser.UserName + " password updated!");

                }
                else
                {
                    //didn't
                }

                RefreshUserList();
            }
        }

        private void deleteSelectedUser_Click(object sender, EventArgs e)
        {

            if (selectedUser != null)
            {
                int affectedRows = userLogic.DeleteUserByUserID(selectedUser.UserID, CurrentUser.UserLevel);


                selectedUser = null;


                RefreshUserList();

            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelComboBox.Text);
            int affectedRows = userLogic.AddNewUser(usernameTextBox.Text, passwordTextBox.Text, (int)userLevel, emailTextBox.Text);
            RefreshUserList();
        }

        private void userLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMaintainMedia));

            t.Start();
            
            
            
            //create thread which calls the new method

          // this.Close();
        }


        public static void OpenMaintainMedia()
        {
            Application.Run(new MaintainMedia());
        }
        //new method
        //Application.Run(new MaintainMedia());
        
       
    }
}
