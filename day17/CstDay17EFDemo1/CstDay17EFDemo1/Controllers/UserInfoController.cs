using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CstDay17EFDemo1.Models;

namespace CstDay17EFDemo1.Controllers
{   
     
      

    public class UserInfoController : Controller
    {
        DbContext dbContext=new myDbcontext();
        // GET: UserInfo
        public ActionResult Index()
        {  // list all users

            var list = dbContext.Set<userInfo>();
            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add( userInfo userinfo)
        {
            userinfo.CreatDatetime=DateTime.Now;
            dbContext.Set<userInfo>().Add(userinfo);
            int result=dbContext.SaveChanges();

            if (result > 0)
            {
                return Redirect(@Url.Action("Index", "UserInfo"));
            }
            else
            {
                return Redirect(@Url.Action("Add", "UserInfo"));
            }

        }


    }
}