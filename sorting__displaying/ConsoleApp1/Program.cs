using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;

namespace sorting_displaying
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "D:\\practiceprojects\\sorting_displaying\\ConsoleApp1\\Studentdata.txt";
            string[] lines = File.ReadAllLines(filename);
            int a = lines.Count();
            string[] slines = lines.OrderBy(x => x).ToArray();
            Console.WriteLine("sorted student list from the textfile:");
            foreach (var item in slines)
            {
                Console.WriteLine(item);
            }
            while (true)
            {
                Console.WriteLine("-----------Menu------------");
                Console.WriteLine("1.Search student by name \n2.Exit");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.WriteLine("enter the student name you want to find");
                    string s = Console.ReadLine();
                    foreach (var item in slines)
                    {
                        string[] strings = item.Split(',');
                        if (strings[0] == s)
                        {
                            Console.WriteLine("the student {0} is found and he is in standard {1}", strings[0], strings[1]);
                        }
                    }
                }
                else break;
            }
            Console.ReadLine();
        }
    }
}
