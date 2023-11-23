using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CstWebStoredprocedure.Common;
using CstWebStoredprocedure.Models;

namespace CstWebStoredprocedure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        #region Customerslist

        #region MyRegion show all customers with no sqlHelper
        public ActionResult ShowCustomer()
        {
           // return Content("OK!!");

           List<UserInfo> userList=new List<UserInfo>();

           int pageIndex = 2;

           string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

           string sqlTxt = "GetPageList";  //execute stored procedure





           using (SqlConnection conn=new SqlConnection(connStr))
           {
               using (SqlCommand cmd=new SqlCommand(sqlTxt,conn))
               {
                   conn.Open();

                   cmd.CommandType = CommandType.StoredProcedure;

                   SqlParameter pIndex= new SqlParameter("@pageIndex",pageIndex);
                   SqlParameter PSize=new SqlParameter("@pageSize",10);
                   SqlParameter pCount=new SqlParameter("@rowCount",SqlDbType.Int);
                   pCount.Direction = ParameterDirection.Output;

                   cmd.Parameters.Add(pIndex);
                   cmd.Parameters.Add(PSize);
                   cmd.Parameters.Add(pCount);

                   using (SqlDataReader reader=cmd.ExecuteReader())
                   {
                       while (reader.Read())
                       {
                            UserInfo userInfo=new UserInfo();

                            userInfo.CompanyName = reader["CompanyName"].ToString();
                            userInfo.ContactName = reader["ContactName"].ToString();
                            userList.Add(userInfo);


                       } // end of while

                       ViewBag.userList = userList;

                   } // end of reader

                   ViewBag.PCount = pCount.Value.ToString();

               } // end of cmd

               
           }// end of conn



           return View();
        }


        #endregion



        #endregion


        #region getAllcustomers with SqlHelper

        public ActionResult ShowCustomers2()
        {

            //return Content("this is customers 2!!");
            List<UserInfo> userList = UserDbUtilits.GetAllUsers();


            string sqlTxt = "select CompanyName, ContactName from customers order by customerID desc";

            DataTable dt = SqlHelper.ExecuteDataTable(sqlTxt);

            foreach (DataRow row in dt.Rows)
            {
                UserInfo userInfo = new UserInfo();
                userInfo.CompanyName = row["CompanyName"].ToString();
                userInfo.ContactName = row["ContactName"].ToString();
                userList.Add(userInfo);


            }

            ViewBag.userList = userList;
            return View();
        }

        #endregion



    }
}