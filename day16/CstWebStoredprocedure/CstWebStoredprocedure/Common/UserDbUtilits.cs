using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CstWebStoredprocedure.Models;

namespace CstWebStoredprocedure.Common
{
    public class UserDbUtilits
    {
        #region GetALLusers

        public static List<UserInfo> GetAllUsers()
        {
          List<UserInfo> userInfoList=new List<UserInfo>();

          string sqlTxt = "select CompanyName, ContactName from customers order by customerID desc";

          DataTable dt = SqlHelper.ExecuteDataTable(sqlTxt);

          foreach (DataRow row in dt.Rows)
          {
              UserInfo userInfo=new UserInfo();
              userInfo.CompanyName = row["CompanyName"].ToString();
              userInfo.ContactName = row["ContactName"].ToString();
              userInfoList.Add(userInfo);


          }

          return userInfoList;
        }

        #endregion

    }
}