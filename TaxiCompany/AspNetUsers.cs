using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  public  class AspNetUsers
  {
        public virtual string Id { get; set; }
        public virtual string Email { get; set; }
        public virtual bool EmailConfirmed { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool PhoneNumberConfirmed { get; set; }
        public virtual bool TwoFactorEnabled { get; set; }
        public virtual DateTime LockoutEndDateUtc { get; set; }
        public virtual bool LockoutEnable { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual string UserName { get; set; }  
    }
}
