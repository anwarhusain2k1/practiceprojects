using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employee_dal;
namespace BLL
{
    public class BAL
    {
        DAL dal = null;
        public BAL()
        {
            dal = new DAL();
        }
        public List<empbal> emplist()
        {
            List<empprofile> l = dal.getemployees();
            List<empbal> list = new List<empbal>();
            foreach(empprofile emp in l)
            {
                empbal empb = new empbal();
                empb.empcode = emp.empcode;
                empb.empname = emp.empname;
                empb.deptcode = emp.deptcode;
                empb.email = emp.email;
                empb.DOB = (Convert.ToDateTime(emp.DOB));
                list.Add(empb);
            }
            return list;
        }
        public void add(empbal employee)
        {
            empprofile empb = new empprofile();
            empb.empcode = employee.empcode;
            empb.empname = employee.empname;
            empb.deptcode = employee.deptcode;
            empb.email = employee.email;
            empb.DOB = Convert.ToDateTime(employee.DOB);
            dal.insert(empb);
        }
        public void delete(int id)
        {
            dal.delete(id);
        }
        public void edit(int id, empbal employee)
        {
            empprofile empb = new empprofile();
            empb.empcode = employee.empcode;
            empb.empname = employee.empname;
            empb.deptcode = employee.deptcode;
            empb.email = employee.email;
            empb.DOB = Convert.ToDateTime(employee.DOB);
            dal.update(id, empb);
        }

        public empbal search(int id)
        {
            empprofile employee = dal.find(id);
            empbal empb = new empbal();
            empb.empcode = employee.empcode;
            empb.empname = employee.empname;
            empb.deptcode = employee.deptcode;
            empb.email = employee.email;
            empb.DOB = Convert.ToDateTime(employee.DOB);
            return empb;
        }

        public List<deptbal> deptlist()
        {
            List<Deptmaster> l = dal.getdepart();
            List<deptbal> list = new List<deptbal>();
            foreach(Deptmaster deptmaster in l)
            {
                deptbal deptb = new deptbal();
                deptb.deptcode= deptmaster.deptcode;
                deptb.deptname = deptmaster.deptname;
                list.Add(deptb);
            }
            return list;
        }

        public void add(deptbal deptb)
        {
            Deptmaster deptmaster = new Deptmaster();
            deptmaster.deptcode = deptb.deptcode;
            deptmaster.deptname = deptb.deptname;
            dal.adddept(deptmaster);
        }
    }
}
