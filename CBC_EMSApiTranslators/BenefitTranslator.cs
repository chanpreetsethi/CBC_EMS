using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API=CBC_APIDataEntitiesV1;
using CBC_EMSBaseClasses;
using App = CBC_EMSEntities;

namespace CBC_EMSApiTranslators
{
    public class BenefitTranslator
    {
        public static BaseEntity TranslateFromDB(API.Benefit source)
        {
            var target = new App.Benefit();
            //Perform basic validation checks here. 
            target.Name = source.Name;
            return target;
        }
        public static API.Benefit TranslateFromApp(BaseEntity source)
        {
            var target = new API.Benefit();
            //Perform basic validation checks here. 
            target.Name = ((App.Benefit)source).Name;
            return target;
        }
        public static List<App.Benefit> TranslateAllFromDB(ICollection<API.Benefit> Benefits)
        {
            var targetList = Benefits
              .Select(x =>new App.Benefit() { Name = x.Name})
              .ToList();
            return targetList;
        }
    }
}
