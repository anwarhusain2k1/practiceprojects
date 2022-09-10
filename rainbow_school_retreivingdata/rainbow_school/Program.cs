using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace rainbow_school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string filename1 = "D:\\practiceprojects\\rainbow_school\\rainbow_school\\studentdata.txt";
            string[] lines = File.ReadAllLines(filename1);
            
            List<student> students = new List<student>();
            foreach (string s in lines)
            {
                string[] temp;
                temp = s.Split(',');
                student student = new student();
                student.Name = temp[0];
                student.dept = temp[1];
                student.specialization = temp[2];
                students.Add(student);
            }int i =1;
            foreach (var item in students)
            {
                Console.WriteLine(i+".");
                Console.WriteLine("studentName:"+item.Name);
                Console.WriteLine("department:"+item.dept);
                Console.WriteLine("specialization:"+item.specialization);

            }
            Console.WriteLine("=======================");
            
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "data.txt";
            using (StreamWriter wrt = File.CreateText(filename))
            {
                foreach (string s in lines)
                {
                    wrt.WriteLine(s);

                }
            }
            Console.WriteLine("copy of student data created in this path");
            Console.WriteLine(filename);
            Console.Read();

        }
    }
}
