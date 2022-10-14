using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using webapi.Models;

namespace webapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<employee> Get()
        {
            List<employee> list = new List<employee>();
            BAL bal = new BAL();
            List<empbal> l = bal.emplist();

            foreach (empbal emp in l)
            {
                employee empb = new employee();
                empb.empcode = emp.empcode;
                empb.empname = emp.empname;
                empb.deptcode = emp.deptcode;
                empb.email = emp.email;
                empb.DOB = emp.DOB.Date;

                list.Add(empb);
            }
            return (list);
        }

        // GET api/values/5
        public employee Get(int id)
        {
            employee empb = new employee();
            BAL bal = new BAL();
            empbal emp = bal.search(id);
            empb.empcode = emp.empcode;
            empb.empname = emp.empname;
            empb.deptcode = emp.deptcode;
            empb.email = emp.email;
            empb.DOB = (Convert.ToDateTime(emp.DOB));
            return empb;
            
        }

        // POST api/values
        public string Post([FromBody] employee emp)
        {
            empbal empb = new empbal();
            empb.empcode = emp.empcode;
            empb.empname = emp.empname;
            empb.deptcode = emp.deptcode;
            empb.email = emp.email;
            empb.DOB = (Convert.ToDateTime(emp.DOB));
            BAL bal = new BAL();
            bal.add(empb);
            return "added";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody] employee emp)
        {
            empbal empb = new empbal();
            empb.empcode = emp.empcode;
            empb.empname = emp.empname;
            empb.deptcode = emp.deptcode;
            empb.email = emp.email;
            empb.DOB = (Convert.ToDateTime(emp.DOB));
            BAL bal = new BAL();
            bal.edit(id, empb);
            return "edit done";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            BAL bal = new BAL();
            bal.delete(id);
            return "deleted";
        }
    }
}
