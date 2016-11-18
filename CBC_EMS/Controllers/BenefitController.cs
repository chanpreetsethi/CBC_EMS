using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CBC_EMS.Controllers
{
    public class BenefitController : ApiController
    {
        // GET: api/Benefit
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Benefit/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Benefit
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Benefit/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Benefit/5
        public void Delete(int id)
        {
        }
    }
}
