using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_EMSBaseClasses;

namespace CBC_EMSEntities
{
    public class EmployeeVacation: BaseEntity
    {
        public Employee Employee { get; set; }
        public DateTime VacationStartDate { get; set; }
        public int WorkingDaysOff { get; set; }

    }
}
