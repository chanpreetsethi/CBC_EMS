using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_EMSBaseClasses;
using CBC_EMSApiIntegrator;
using CBC_EMSEntities;

namespace CBC_EMSManagers
{
    public class EmployeeManager : BaseManager
    {
        EmployeeIntegrator integrator = new EmployeeIntegrator();

        public override BaseEntity Search(BaseSearchCriteria searchCriteria)
        {
            //Get the employee based on the employee id of the currently logged on user. 
                return integrator.Search(searchCriteria);
        }
        public override bool IsValid(BaseEntity entity)
        {
            return true;
        }

        public bool ValidateCredentials(string username, string password)
        {
            var result = integrator.Search(new EmployeeSearchCriteria() { userName = username, password = password });
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
