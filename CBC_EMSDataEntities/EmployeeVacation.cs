using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CBC_APIDataEntitiesV1
{
    public class EmployeeVacation
    {
        [Key]
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public DateTime VacationStartDate { get; set; }
        public int WorkingDaysOff { get; set; }
    }
}
