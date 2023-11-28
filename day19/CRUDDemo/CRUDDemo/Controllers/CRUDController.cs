using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDDemo.Models;
using Microsoft.Ajax.Utilities;

namespace CRUDDemo.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult Index()
        {
            using (var context=new DemoCRUDEntities())
            {
                var data = context.Students.ToList();
                return View(data);

            }


            
        }

        [HttpGet]
        public ActionResult Create()
        {
            //return Content("OKOK!");

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            using (var context=new DemoCRUDEntities())
            {
                context.Students.Add(model);
                int myResult = context.SaveChanges();
                if (myResult > 0)
                {
                    return Redirect(@Url.Action("Index", "CRUD"));
                }
                else
                {

                    return Redirect(@Url.Action("Create", "CRUD"));
                }

                
            }

        }

        public ActionResult Delete(int studentid)
        {
           // return Content("delete OK");
           using (var context=new DemoCRUDEntities())
           {
               var data = context.Students.FirstOrDefault(x => x.id == studentid);

               if (data != null)
               {
                   context.Students.Remove(data);
                   context.SaveChanges();
                   return RedirectToAction("Index");
               }



               return Content("delete OK");

            }

        }

        [HttpGet]
        public ActionResult Edit(int studentid)
        {
            using (var context=new DemoCRUDEntities())
            {
                var data=context.Students.Where(x => x.id == studentid).SingleOrDefault();
                return View(data);
            }
            
            //return Content("update OKOK");
        }

        [HttpPost]
        public ActionResult Edit(int studentid, Student model)
        {
            using (var context=new DemoCRUDEntities())
            {
                var data = context.Students.FirstOrDefault(x => x.id == studentid);

                if (data != null)
                {
                    data.Name = model.Name;
                    data.Branch = model.Branch;
                    data.Section = model.Section;
                    data.Email = model.Email;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

            }




            return Content("OKOK");
        }









    } // end of controller
}