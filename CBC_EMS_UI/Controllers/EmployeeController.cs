using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CBC_EMSManagers;
using CBC_EMSEntities;

namespace CBC_EMS_UI.Controllers
{
    public class EmployeeController : ApiController
    {

        EmployeeManager manager = new EmployeeManager();
        // GET: api/Employee
        //Get the current logged on employee
        public IEnumerable<string> Get()
        {
            return null;
        }

        // GET: api/Employee/5
        //Get a specific employee
        public string[] Get(string name)
        {
            //return the current user
            var employee = (Employee)manager.Search(new EmployeeSearchCriteria() { userName = name });
            if (employee != null)
            {
                return new string[] { employee.Name, employee.Salary.ToString(), employee.Benefits.Replace(',','&'), employee.VacationDaysRemaining.ToString() };
            }
            else
                return null;
        }

        // POST: api/Employee
        //Used to validate the user login
        public async Task<IHttpActionResult> Post([FromBody] string value)
        {
            string userName = string.Empty;
            string password = string.Empty;
            //Validate user using his password and username from DB
            userName = value.Split(',')[0];
            password = value.Split(',')[1];
            return this.Ok<bool>(manager.ValidateCredentials(userName, password));
        }
    }
}
