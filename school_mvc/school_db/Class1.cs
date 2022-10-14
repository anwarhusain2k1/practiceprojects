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
            schoolEntities context = new schoolEntities();
        }
        public List<student> getstudents()
        {
            schoolEntities context = new schoolEntities();
            List<student> students =context.students.ToList();
            return students;
        }

        public void insert(student s1)
        {
            schoolEntities context = new schoolEntities();
            context.students.Add(s1);
        }
        
    }
}
