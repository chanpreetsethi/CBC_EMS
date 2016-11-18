using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_EMSBaseClasses;

namespace CBC_EMSEntities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string password { get; set; }
        public string Benefits { get; set; }
        public decimal Salary { get; set; }
        public int VacationDaysRemaining { get; set; }
    }
}
