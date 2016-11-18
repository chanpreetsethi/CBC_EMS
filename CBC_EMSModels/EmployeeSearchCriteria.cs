using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_EMSBaseClasses;

namespace CBC_EMSEntities
{
    public class EmployeeSearchCriteria:BaseSearchCriteria
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}
