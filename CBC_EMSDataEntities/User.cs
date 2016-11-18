using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CBC_APIDataEntitiesV1
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PasswordHint { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Locked { get; set; }
        public bool Enabled { get; set; }
    }
}
