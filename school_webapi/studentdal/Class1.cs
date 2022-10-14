using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdal
{
    public class DAL
    {
        public List<student> getstudents()
        {
            schoolEntities context = new schoolEntities();
            List<student> students = context.students.ToList();
            return students;
        }
        public bool add(student s)
        {
            schoolEntities context = new schoolEntities();
            context.students.Add(s);
            context.SaveChanges();
            return true;
        }
        public student find(int id)
        {
            schoolEntities context = new schoolEntities();
            List<student> students = context.students.ToList();
            student s = students.Find(x=>x.student_id==id);
            return s;
        }
        public void delete(int id)
        {
            
            schoolEntities context = new schoolEntities();
            List<student> students = context.students.ToList();
            student s = students.Find(x => x.student_id == id);
            context.students.Remove(s);
            context.SaveChanges ();
        }

    }
}
