using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserModel
    {
        #region attributes

        
        private int userId;
        private string userName;
        private int userLevel;

        #endregion

        //properties
        public int UserID
        {
            set { userId = value; }
            get { return userId; }
        }
        public string UserName
        {
            set { userName = value; /*extra code, whatever*/ }
            get { return userName; }
        }
        public int UserLevel
        {
            set { 
                if(value > -1) 
                    userLevel = value; 
            }
            get
            {
                return userLevel;
            }
        }

        //takes a row of data from our UserDataSet table and creates a UserModel object from it
        public static UserModel Parse(UserDS.TabUserRow userRow)
        {
            if (userRow == null)
                return null;

            UserModel userModel = new UserModel();
            userModel.UserID = userRow.UID;
            userModel.UserName = userRow.UserName;
            userModel.UserLevel = userRow.UserLevel;

            return userModel;
        }
    }
}
