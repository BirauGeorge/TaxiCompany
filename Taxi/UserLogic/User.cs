using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace Taxi.UserLogic
{
    public class User : IUser<int>
    {
        public User()
        {
            this.Roles = new List<string>();
     //    this.Claims = new List<UserClaim>();
        }

        public User(string userName)
            : this()
        {
            this.UserName = userName;
        }

        public User(int id, string userName) : this()
        {
            this.Id = Id;
            this.UserName = userName;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool TwoFactorEnabled { get; set; }

        public IList<string> Roles { get; private set; }
      //  public IList<UserClaim> Claims { get; private set; }
    }
}