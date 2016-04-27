using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  public  class AspNetUserLogin
    {
      public virtual string LoginProvider { get; set; } 
      public virtual string ProviderKey { get; set; }
      public virtual string UserId { get; set; }
    }
}
