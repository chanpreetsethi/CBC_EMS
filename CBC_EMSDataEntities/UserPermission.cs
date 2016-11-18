using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CBC_APIDataEntitiesV1
{
    public class UserPermission
    {
        [Key]
        public int ID { get; set; }

        public User User { get; set; }
        public Permission Permission { get; set; }
    }
}
