using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CBC_APIDataEntitiesV1
{
   public class EmployeeBenefit
    {
        [Key]
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public Benefit Benefit { get; set; }

    }
}
