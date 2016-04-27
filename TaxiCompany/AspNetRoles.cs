using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AspNetRoles: Entity
    {

       // public virtual string Id { get; set; }
        public virtual string Name { get; set; }

        public AspNetRoles(string name)
        {
            Name = name;
           // Id = id;

        }

        public AspNetRoles()
        {
            
        }
    }
}
