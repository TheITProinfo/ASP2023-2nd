using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using CRUDDemo1.Models;
using Microsoft.Ajax.Utilities;

namespace CRUDDemo1.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult Index(int pageIndex=1,int pageSize=5,string name=" ")
        { 
            // list all  records in Tables
            using (var context=new demoCRUDEntities())
            {
                //var data = context.Students.ToList();  // return records to list
                var data = context.Students
                    //.Where(x => x.Name.Contains(name))
                    .OrderBy(x => x.id)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                
                // page counting
                var totalRows = data.Count();
                var totalPages = Math.Ceiling(totalRows * 1.00 / pageSize);

                ViewBag.totalPages = totalPages;
                ViewBag.pageIndex = pageIndex;
                ViewBag.name = name;
                ViewBag.pageSize = pageSize;



                return View(data);
            }


            


           
        } //end of action

        [HttpGet]
        public ActionResult Create()
        {

           // return Content("Add Ok!");

           return View();
        }

        [HttpPost]
        public ActionResult Create(Student model)
        {
            using (var context=new demoCRUDEntities()) // To open a connection to the database Student
            {
                context.Students.Add(model);
                int myResult=context.SaveChanges(); // save the changes to the database
                if (myResult > 0)
                {
                    return Redirect(@Url.Action("Index", "CRUD"));
                }
                else
                {
                    return Redirect(@Url.Action("Create", "CRUD"));
                }


            }

            
            //string message = "Add student successfully";
            //ViewBag.message = message;

           // return View();


            //return Content("Add OK!");
        }


        public ActionResult Delete(int studentid)
        {
          
            using (var context=new demoCRUDEntities())
            {
                var data = context.Students.FirstOrDefault(x => x.id ==studentid);
                if (data != null)
                {

                    context.Students.Remove(data);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }



            }


            return Content("delete OK");
        }

        [HttpGet]
        public ActionResult Edit(int studentid)
        {
            using (var context=new demoCRUDEntities())
            {
                var data = context.Students.Where(x => x.id == studentid).SingleOrDefault();
                return View(data);
            }


            //return Content("Edit OK");
        }

        [HttpPost]
        public ActionResult Edit(int studentid, Student model)
        {

            using (var context=new demoCRUDEntities())
            {
                var data = context.Students.FirstOrDefault(x => x.id == studentid);

                if(data !=null)
                {
                    data.Name = model.Name;
                    data.Section = model.Section;
                    data.Name = model.Name;
                    data.Email = model.Email;
                    context.SaveChanges();
                    return RedirectToAction("Index");

                }
                else
                {
                    return View();
                }
            }
            


            return Content("Update success!");
        }

    } // end of class
}