using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using CstWebDay13.Models;

namespace CstWebDay13.Controllers
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

        public ActionResult Programs()
        {
            //string contents = "all programs are as bellows: NTS, SDP,Electorcial";


            return View();
        }

        public ActionResult Customers()
        {
            string connStr = "server=192.168.70.112;pwd=Cst001.com;uid=develop2;database=NORTHWND";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {

                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("select * from Customers", connStr))
                    {
                        // adapter read data to data set

                        DataTable dt = new DataTable();

                        adapter.Fill(dt);  // read all records form database to Datatable

                        List<UserInfo> userList=new List<UserInfo>(); // declare empty userList

                        foreach (DataRow dataRow in dt.Rows)
                        {
                            UserInfo userInfo=new UserInfo();

                            userInfo.CompanyName = dataRow["CompanyName"].ToString();
                            userInfo.ContactName = dataRow["ContactName"].ToString();

                            userList.Add(userInfo); // each time add userinfo object to userlist


                        }



                        //ViewBag.userList = userList;

                        ViewData["dt"] = dt;

                    } // end using adapter
                } // end using cmd


                
            } // end using conn


            

            return View();

        } // end of action

        #region Customers9()
        public  ActionResult Customers9()
        {
            UserInfo userInfo =new UserInfo();

            return View() ;
        }

        #endregion























    }//end of action
} // rnd of nameapace