using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class employee
    {
        public int empcode { get; set; }

        public string empname { get; set; }
        public string email { get; set; }
        public int deptcode { get; set; }
        public DateTime DOB { get; set; }
    }
}