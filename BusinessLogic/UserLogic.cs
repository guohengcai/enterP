using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserLogic
    {
        //attributes
        private UserDAO userDAO;
        private UserDS.TabUserDataTable userTable;

        public UserLogic()
        {
            userDAO = new UserDAO();
            userTable = new UserDS.TabUserDataTable();
        }

        public List<UserModel> GetListOfUsers()
        {
            List<UserModel> users = new List<UserModel>(); //build empty list first

            userTable = userDAO.GetUserDataTable(); //fill userTable from our userDAO

            //for each row in our user table...
            foreach (UserDS.TabUserRow userRow in userTable.Rows)
            {
                //conver that row to a userModel and add it to the list
                UserModel user = UserModel.Parse(userRow);
                users.Add(user);
            }

            return users; //return list of users :D
        }

        public List<UserModel> GetListOfUsersByLogin(string userName, string password)
        {
            List<UserModel> users = new List<UserModel>(); //build empty list first

            userTable = userDAO.GetUserByUserNamePassword(userName, password);

            //for each row in our user table...
            foreach (UserDS.TabUserRow userRow in userTable.Rows)
            {
                //conver that row to a userModel and add it to the list
                UserModel user = UserModel.Parse(userRow);
                users.Add(user);
            }

            return users; //return list of users :D
        }


        public int AddNewUser(string username, string password, int userLevel, string email)
        {
            return userDAO.InsertNewUser(username, password, userLevel, email);

        }


        public int UpdatePassword(string newPassword, int userID, int userLevel)
        {
            if (userLevel < 3)//not an admin, can not change users passwords
                return -1;
            else

            return userDAO.UpdatePassword(newPassword, userID);

        }


        public int DeleteUserByUserID(int userID, int userLevel)
        {
            if (userLevel < 3)// 
                return -1;
            else

                return userDAO.DeleteUserByUserID(userID);

        }


    }
}
