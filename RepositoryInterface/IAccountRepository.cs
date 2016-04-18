using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace RepositoryInterface
{
    public interface IAccountRepository
    {
        void Register(Account account);
        Account Login(Account account);
        void ChangePassword(Account account,string password);
    }
        
}
