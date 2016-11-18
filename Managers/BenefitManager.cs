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
    public class BenefitManager
    {
        BenefitIntegrator integrator = new BenefitIntegrator();

        public  List<Benefit> GetAll()
        {
            return integrator.GetAll();
        }
        public  void Create(BaseEntity entity)
        {
            //Perform Validations on source data
            integrator.Create(entity);
        }
        public  void Update(BaseEntity entity)
        {
            //Perform Validations on source data
            integrator.Update(entity);
        }
        public  void Delete(BaseEntity entity)
        {
            //Perform Validations on source data
            integrator.Delete(entity);
        }
        public  ICollection<BaseEntity> Search(BaseSearchCriteria searchCriteria)
        {
            return integrator.Search(searchCriteria);
        }

        public  bool IsValid(BaseEntity entity)
        {
            return true;
        }
    }
}
