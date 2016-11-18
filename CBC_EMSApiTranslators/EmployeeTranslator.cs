using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API = CBC_APIDataEntitiesV1;
using CBC_EMSBaseClasses;
using App = CBC_EMSEntities;

namespace CBC_EMSApiTranslators
{
    public class EmployeeTranslator
    {
        public static BaseEntity TranslateFromDB(API.Employee source)
        {
            var target = new App.Employee();
            //Perform basic validation checks here. 
            target.Name = source.Name;
            target.ID = source.ID;
            target.Salary = source.Salary;
            target.VacationDaysRemaining = source.VacationDaysRemaining;
            target.Benefits = source.Benefits;
            return target;
        }
        public static API.Employee TranslateFromApp(BaseEntity source)
        {
            var target = new API.Employee();
            //Perform basic validation checks here. 
            target.Name = ((App.Employee)source).Name;
            target.ID = ((App.Employee)source).ID;
            target.Salary = ((App.Employee)source).Salary;
            target.VacationDaysRemaining = ((App.Employee)source).VacationDaysRemaining;
            target.Benefits = ((App.Employee)source).Benefits;
            return target;
        }
    }
}
