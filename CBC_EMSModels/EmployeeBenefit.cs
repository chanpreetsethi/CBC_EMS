using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_EMSBaseClasses;

namespace CBC_EMSEntities
{
    public class EmployeeBenefit
    {
        public Employee Employee { get; set; }
        public Benefit Benefit { get; set; }
    }
}
