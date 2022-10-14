using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using school_db;
using school_mvc.Models;

namespace school_mvc.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            DAL dal = new DAL();
            List<student> students = new List<student>();
            List<student_> s = new List<student_>();
            students = dal.getstudents();
            foreach (student item in students)
            {
                student_ s1 = new student_();
                s1.student_id =  Convert.ToInt32(item.student_id);
                s1.student_name = item.student_name;
                s1.student_address = item.student_address;
                s1.student_email = item.student_email;
                s1.student_class = item.student_class;
                s.Add(s1);
            }
            return View(s);
        }

        // GET: student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: student/Create
        [HttpPost]
        public ActionResult Create(student_ s)
        {
            try
            {
                // TODO: Add insert logic here
                DAL dal = new DAL();
                student student = new student();
                student.student_email = s.student_email;
                student.student_address = s.student_address;
                student.student_name = s.student_name;
                student.student_id = s.student_id;
                student.student_class = s.student_class;
                dal.insert(student);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, student_ s)
        {
            try
            {
                // TODO: Add update logic here
                student student = new student();
                student.student_email = s.student_email;
                student.student_address = s.student_address;
                student.student_name = s.student_name;
                student.student_id = s.student_id;
                student.student_class = s.student_class;
                DAL dal = new DAL();
                dal.edit(id, student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: student/Delete/5
        public ActionResult Delete(int id)
        {
            DAL dal = new DAL();
            dal.remove(id);

            return View();
        }

        // POST: student/Delete/5
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
