﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.UserDSTableAdapters;

namespace DataAccessLayer
{
    public class UserDAO
    {
        private UserDS userDataSet;
        private TabUserTableAdapter tabUserAdapter; //this class was autogenerated by our userDS query configure stage

        public UserDAO()
        {
            userDataSet = new UserDS();
            tabUserAdapter = new TabUserTableAdapter();
        }

        public UserDS.TabUserDataTable GetUserDataTable()
        {
            try
            {
                tabUserAdapter.FillAll(userDataSet.TabUser);//adapter helps fill our userDS for the TabUser table
                return userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                //dunno make it someone elses problem for now
                throw ex;
            }
        }

        public UserDS.TabUserDataTable GetUserByUserNamePassword(string userName, string password)
        {
            try
            {
                //use adapter to fill the TabUser table in the userDataSet using the FillByUserNamePassword method
                tabUserAdapter.FillByUserNamePassword(userDataSet.TabUser, userName, password);
                return userDataSet.TabUser;//return the table full of data
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertNewUser(string userName, string password, int userLevel, string email)
        {
            return tabUserAdapter.InsertNewUser(userName, password, userLevel, email);

        }

        public int UpdatePassword(string password, int userID)
        {
            return tabUserAdapter.UpdateUserPassword(password, userID);

        }

        public int DeleteUserByUserID(int userID)
        {
            return tabUserAdapter.DeleteUserByUserID(userID);
        }




    }
}
