using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CstWebDay14.Models;
using Microsoft.Ajax.Utilities;

namespace CstWebDay14.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        #region getData by dataAdapter
        /// <summary>
        /// get data with data adapter, then with viewBag to viewer.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //show all database records with dataAdapter

            // connection string
            string connStr = "database=NORTHWND;pwd=Cst001.com;uid=develop2;server=192.168.70.112";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();

                    string sqlTxt = "select * from Customers  order by customerID desc";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlTxt, connStr))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        ViewBag.dt = dt;

                    } // end of dataadpter



                } //end of cmd


            } // end of conn

            return View();
        } // end of index method

        #endregion


        #region get data with datareader
        /// <summary>
        ///get data with data reader
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index2()
        {
            List<UserInfo> userList = new List<UserInfo>();

            string connStr = "server=192.168.70.112;uid=develop2;pwd=Cst001.com;database=NORTHWND";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "select CustomerID, CompanyName,ContactName,Address from Customers";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserInfo userInfo = new UserInfo();

                            userInfo.CustomerID = reader["CustomerID"].ToString();
                            userInfo.CompanyName = reader["CompanyName"].ToString();
                            userInfo.ContactName = reader["ContactName"].ToString();
                            userInfo.Address = reader["Address"].ToString();
                            userList.Add(userInfo);


                        }// end of while

                        ViewBag.userList = userList;

                    } // end of datareader



                } //end of cmd


            }// end of conn



            return View();

        }

        #endregion


        #region user regisiter
        [HttpGet]
        public ActionResult Reg()
        {

            //return Content("please register account!!");

            return View();

            //return Content("register form");


        }

        /// <summary>
        /// process the data from fron end form
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Reg(FormCollection collection)
        {
            string username = Request["username"];
            string password = Request["password"];

            //string connStr= "server=192.168.70.112;uid=develop2;pwd=Cst001.com;database=NORTHWND";

            String sqlTxt = string.Format(@"insert into person(username,password,isDeleted,createDatetime,upDateDatetime) values ('{0}','{1}',0,'{2}','{3}')", username, password, DateTime.Now.ToString(), DateTime.Now.ToString());
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();

                    cmd.CommandText = sqlTxt;
                    int result = cmd.ExecuteNonQuery(); // insert update delete



                } //end of cmd



            }// end of conn










            return Content("user registered successfully");










        } // end of reg action

        #endregion


        #region user login

        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(FormCollection collection)

        {
            // get username and password form front form
            // 

            string username = Request["username"];
            string password = Request["password"];

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return Content("<script> alert('username or password is empty!');location.href='/Customer/Login' </script> ");
            }

            //string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    //string sqlTxt = @"select count(*) from person where username='" + username + "' and password='" + password + "' ";

                    string sqlTxt = "select count(*) from person where username=@username and password=@password";



                    cmd.CommandText = sqlTxt;
                    cmd.Parameters.Add("@username", username);
                    cmd.Parameters.Add("@password", password);
                    object result = cmd.ExecuteScalar();

                    int rows = int.Parse(result.ToString());

                    if (rows >= 1)
                    {
                        return Content("<script>alert('login successfully!');location.href='/Customer/Index'</script>");
                    }
                    else
                    {

                        return Content("<script>alert('login failure,');location.href='/Customer/Login'</script>");
                    }

                }//end of cmd


            }// end of conn



            return Content("login successfully!");
        } //end of action

        #endregion






    } //end of controller
} //end of namespace