using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBC_EMSBaseClasses
{
    public class BaseAPIIntegrator
    {
        public virtual List<BaseEntity> GetAll()
        {
            throw new NotImplementedException();
        }
        public virtual void Create(BaseEntity entity) { }
        public virtual void Update(BaseEntity entity) { }
        public virtual void Delete(BaseEntity entity) { }
        public virtual BaseEntity Search(int ID)
        {
            throw new NotImplementedException();
        }
        public virtual BaseEntity Search (BaseSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }
        public virtual void CommitAsync() { }
    }
}
