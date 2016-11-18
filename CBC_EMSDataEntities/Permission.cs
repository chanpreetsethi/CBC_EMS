using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CBC_APIDataEntitiesV1
{
   public  class Permission
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
