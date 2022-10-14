using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using employee_asp.Models;

namespace employee_asp.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult Index()
        {
            List<employee> list = new List<employee>();
            BAL bal = new BAL();
            List<empbal> l = bal.emplist();
            
            foreach(empbal emp in l)
            {
                employee empb = new employee();
                empb.empcode = emp.empcode;
                empb.empname = emp.empname;
                empb.deptcode = emp.deptcode;
                empb.email = emp.email;
                empb.DOB = emp.DOB.Date;
                
                list.Add(empb);
            }
            return View(list);
        }

        // GET: employee/Details/5
        public ActionResult Details(int id)
        {
            employee empb = new employee();
            BAL bal = new BAL();
            empbal emp = bal.search(id);
            empb.empcode = emp.empcode;
            empb.empname = emp.empname;
            empb.deptcode = emp.deptcode;
            empb.email = emp.email;
            empb.DOB = (Convert.ToDateTime(emp.DOB));
            return View(empb);
        }

        // GET: employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: employee/Create
        [HttpPost]
        public ActionResult Create(employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                empbal empb = new empbal();
                empb.empcode = emp.empcode;
                empb.empname = emp.empname;
                empb.deptcode = emp.deptcode;
                empb.email = emp.email;
                empb.DOB = (Convert.ToDateTime(emp.DOB));
                BAL bal = new BAL();
                bal.add(empb);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, employee emp)
        {
            try
            {
                // TODO: Add update logic here
                empbal empb = new empbal();
                empb.empcode = emp.empcode;
                empb.empname = emp.empname;
                empb.deptcode = emp.deptcode;
                empb.email = emp.email;
                empb.DOB = (Convert.ToDateTime(emp.DOB));
                BAL bal = new BAL();
                bal.edit(id, empb);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: employee/Delete/5
        public ActionResult Delete(int id)
        {
            employee empb = new employee();
            BAL bal = new BAL();
            empbal emp = bal.search(id);
            empb.empcode = emp.empcode;
            empb.empname = emp.empname;
            empb.deptcode = emp.deptcode;
            empb.email = emp.email;
            empb.DOB = (Convert.ToDateTime(emp.DOB));
            return View(empb);
        }

        // POST: employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,employee empb)
        {
            try
            {
                // TODO: Add delete logic here
                BAL bal = new BAL();
                bal.delete(id);     
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
