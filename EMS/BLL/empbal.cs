using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class empbal
    {
        public int empcode { get; set; }
        public DateTime DOB { get; set; }
        public string empname { get; set; }
        public string email { get; set; }
        public int deptcode { get; set; }
    }

    public class deptbal
    {
        public int deptcode { get; set; }
        public string deptname { get; set; }
    }
}
