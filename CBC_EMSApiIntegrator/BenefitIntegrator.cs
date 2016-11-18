using System;
using System.Collections.Generic;
using System.Linq;
using CBC_EMSBaseClasses;
using CBC_APIDataAccess;
using CBC_EMSApiTranslators;
using CBC_EMSEntities;

namespace CBC_EMSApiIntegrator
{
    public class BenefitIntegrator 
    {
        APIContext db = new APIContext();

        public  void CommitAsync()
        {
            db.SaveChangesAsync();
        }

        public  void Create(BaseEntity entity)
        {
            db.Benefits.Add(BenefitTranslator.TranslateFromApp(entity));
            CommitAsync();
        }

        public  void Delete(BaseEntity entity)
        {
            db.Benefits.Remove(BenefitTranslator.TranslateFromApp(entity));
            CommitAsync();
        }

        public  List<Benefit> GetAll()
        {
            return BenefitTranslator.TranslateAllFromDB(db.Benefits.ToList());
        }

        public  ICollection<BaseEntity> Search(BaseSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }

        public  void Update(BaseEntity entity)
        {
            var translatedData = BenefitTranslator.TranslateFromApp(entity);
            db.Benefits.Attach(translatedData);
            db.Entry(translatedData).State = System.Data.Entity.EntityState.Modified;
            CommitAsync();
        }
    }
}
