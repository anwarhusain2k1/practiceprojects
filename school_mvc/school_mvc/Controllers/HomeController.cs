using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using school_db;
using System.Configuration;
using school_mvc.Models;

namespace school_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DAL dal = new DAL();
            List<student> students = new List<student>();
            List<student_> s = new List<student_>();
            students = dal.getstudents();
            foreach(student item in students)
            {
                student_ s1 = new student_();
                s1.student_id = item.student_id;
                s1.student_name = item.student_name;
                s1.student_address = item.student_address;
                s1.student_email = item.student_email;
                s1.student_class = item.student_class;
                s.Add(s1);
            }
            return View(s);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(student_ s)
        {
            DAL dal = new DAL();
            student student = new student();
            student.student_email = s.student_email;
            student.student_address = s.student_address;
            student.student_name = s.student_name;
            student.student_id = s.student_id;
            student.student_class = s.student_class;
            dal.insert(student);
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
    }
}