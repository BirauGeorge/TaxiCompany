using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class AspNetUserRoles
    {
        public virtual string UserId { get; set; }
        public virtual string RoleId { get; set; }
    }
}
