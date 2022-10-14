using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace school_db
{
    public class DAL
    {
        public DAL() 
        {
            schoolEntities1 context = new schoolEntities1();
        }
        public List<student> getstudents()
        {
            schoolEntities1 context = new schoolEntities1();
            List<student> students = context.students.ToList();
            return students;    
        }

        public void insert(student s1)
        {
            schoolEntities1 context = new schoolEntities1();
            context.students.Add(s1);
            context.SaveChanges();
        }

        public void edit(int id,student s1)
        {
            schoolEntities1 context = new schoolEntities1();
            List<student> students = context.students.ToList();
            student s2 = students.Find(s => s.student_id == id);
            s2.student_email = s1.student_email;
            s2.student_address=s1.student_address;
            s2.student_name=s1.student_name;
            s2.student_class=s1.student_class;
            context.SaveChanges();
        }
        public void remove(int id)
        {
            schoolEntities1 context = new schoolEntities1();
            List<student> students = context.students.ToList();
            student s2 = students.Find(s => s.student_id == id);
            context.students.Remove(s2);
            context.SaveChanges();
        }
    }
}
