using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBC_EMSBaseClasses;

namespace CBC_EMSEntities
{
    public class User:BaseEntity
    {
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PasswordHint { get; set; }
        public DateTime LastLogin { get; set; }
        public bool Locked { get; set; }
        public bool Enabled { get; set; }
    }
}
