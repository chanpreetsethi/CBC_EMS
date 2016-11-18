using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_EMSBaseClasses;
using CBC_APIDataAccess;
using CBC_EMSApiTranslators;
using CBC_EMSEntities;

namespace CBC_EMSApiIntegrator
{
    public class EmployeeIntegrator: BaseAPIIntegrator
    {
        APIContext db = new APIContext();

        public override void CommitAsync()
        {
            db.SaveChangesAsync();
        }
        public override BaseEntity Search(int ID)
        {
            return EmployeeTranslator.TranslateFromDB(db.Employees.FirstOrDefault(e=>e.ID == ID));
        }

        public override BaseEntity Search(BaseSearchCriteria searchCriteria)
        {
            var EmpCriteria = (EmployeeSearchCriteria)searchCriteria;
            BaseEntity result;
            if (string.IsNullOrEmpty( EmpCriteria.password ))
            {
                result = EmployeeTranslator.TranslateFromDB(db.Employees.FirstOrDefault(e => e.Name == EmpCriteria.userName)) ?? null;
            }
            else
            {
                result = EmployeeTranslator.TranslateFromDB(db.Employees.FirstOrDefault(e => e.Name == EmpCriteria.userName && e.password == EmpCriteria.password)) ?? null;
            }
            return result;
        }

    }
}
