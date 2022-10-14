using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_dal
{
    public class DAL
    {
        public List<Deptmaster> getdepart()
        {
            employeeEntities context = new employeeEntities();
            List<Deptmaster> depts = context.Deptmasters.ToList();
            return depts;
        }

        public void adddept(Deptmaster dept)
        {
            employeeEntities context = new employeeEntities();
            context.Deptmasters.Add(dept);
        }
        public List<empprofile> getemployees()
        {
            employeeEntities context = new employeeEntities();
            List<empprofile> employees = new List<empprofile>();
            employees = context.empprofiles.ToList();
            return employees;
        }

        public void insert(empprofile emp)
        {
            employeeEntities context = new employeeEntities();
            context.empprofiles.Add(emp);
            context.SaveChanges();
        }

        public void delete(int id)
        {
            employeeEntities context = new employeeEntities();
            List<empprofile> employees = new List<empprofile>();
            employees = context.empprofiles.ToList();
            empprofile emp = employees.Find(x=>x.empcode==id);
            context.empprofiles.Remove(emp);
            context.SaveChanges();
            
        }

        public void update(int id,empprofile employee)
        {
            employeeEntities context = new employeeEntities();
            List<empprofile> employees = new List<empprofile>();
            employees = context.empprofiles.ToList();
            empprofile emp = employees.Find(x => x.empcode == id);
            emp.empname=employee.empname;
            emp.email=employee.email;
            emp.deptcode=employee.deptcode;
            emp.DOB=employee.DOB;
            context.SaveChanges();
        }

        public empprofile find(int id)
        {
            employeeEntities context = new employeeEntities();
            List<empprofile> employees = new List<empprofile>();
            employees = context.empprofiles.ToList();
            empprofile emp = employees.Find(x => x.empcode == id);
            return emp;
        }

    }
}
