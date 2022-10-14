using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using employee_asp.Models;

namespace employee_asp.Controllers
{
    public class deptController : Controller
    {
        // GET: dept
        public ActionResult Index()
        {
            BAL bal = new BAL();
            List<deptbal> list = bal.deptlist();
            List<dept> l = new List<dept>();
            foreach(deptbal deptb in list)
            {
                dept dept = new dept();
                dept.deptcode = deptb.deptcode;
                dept.deptname= deptb.deptname;
                l.Add(dept);
            }
            return View(l);
        }

        // GET: dept/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: dept/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dept/Create
        [HttpPost]
        public ActionResult Create(dept dept1)
        {
            try
            {
                // TODO: Add insert logic here
                deptbal deptb = new deptbal();
                deptb.deptcode=dept1.deptcode;
                deptb.deptname=dept1.deptname;
                BAL bal = new BAL();
                bal.add(deptb);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: dept/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: dept/Edit/5
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

        // GET: dept/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: dept/Delete/5
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
