using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CBC_EMSEntities;
using CBC_EMSManagers;
using CBC_EMSBaseClasses;

namespace CBC_EMSWebAPI.Controllers
{
    public class BenefitController : ApiController
    {
        BenefitManager manager = new BenefitManager();
        // GET: api/Benefit
        public IEnumerable<BaseEntity> Get()
        {
            return (IEnumerable<BaseEntity>)manager.GetAll();
        }

        //// GET: api/Benefit/5
        //public BaseEntity Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Benefit
        public void Post([FromBody]Benefit value)
        {
            if (manager.IsValid(value))
            {
                manager.Update(value);
            }
        }

        // PUT: api/Benefit/
        public void Put([FromBody]Benefit value)
        {
            if (manager.IsValid(value))
            {
                manager.Create(value);
            }
        }

        // DELETE: api/Benefit/5
        public void Delete(Benefit value)
        {
            if (manager.IsValid(value))
            {
                manager.Delete(value);
            }
        }
    }
}
