using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using TES_API_OPENDATA.Models;
using static TES_API_OPENDATA.Models.OpenData;

namespace TES_API_OPENDATA.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<Class1> Get()
        {
            List<Class1> Open_Date_Result = new List<Class1>();

            Open_Date_Result = TEST_.Sample();


            return Open_Date_Result;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "123";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
