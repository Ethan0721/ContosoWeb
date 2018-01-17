using Contoso.Data;
using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoWeb.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _ss;
        public StudentController( IStudentService ss)
        {
            _ss = ss;
        }
        public ActionResult Index()
        {
            //ContosoDbContext context = new ContosoDbContext();
            //StudentRepository sr = new StudentRepository(context);
            //StudentServices studentService = new StudentServices(sr);
            
            var students = _ss.GetStudents();
            return View(students);
        }

        // GET: Studnet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Studnet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Studnet/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Studnet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Studnet/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Studnet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Studnet/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
