using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CBC_APIDataEntitiesV1
{
    public class Employee 
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string password { get; set; }
        public string Benefits { get; set; }
        public decimal Salary { get; set; }
        public int VacationDaysRemaining { get; set; }
    }
}
