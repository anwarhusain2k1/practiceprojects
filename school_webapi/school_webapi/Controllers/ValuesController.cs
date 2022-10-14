using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using studentdal;

namespace school_webapi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        
        public List<student> Get()
        {
            DAL dal = new DAL();
            List<student> students = dal.getstudents();
            return students;
        }

            // GET api/values/5
            public student Get(int id)
        {
            DAL dAL = new DAL();
            
            return dAL.find(id);
        }

        // POST api/values
        public string Post([FromBody] student s)
        {
            DAL dal = new DAL();
             dal.add(s);
            return "added";
            
            
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            DAL dal =new DAL(); 
            dal.delete(id);
            return "deleted";
        }
    }
}
