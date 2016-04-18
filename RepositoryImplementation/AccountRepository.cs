using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using RepositoryInterface;
using Domain;
using Domain.Dto;

namespace Repository_Implementation
{

    public class AccountRepository: IAccountRepository
    {
        protected readonly ISession _session = SessionGenerator.Instance.GetSession();
        public void Register(Account account)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(account);
                transaction.Commit();
                
            }
        }

        public Account Login(Account account)
        {
            Account accountAlias = null;
            Account accountGet = _session.QueryOver(() => accountAlias).Where(x => x.Email == account.Email).SingleOrDefault();
            return accountGet;
        }

        public void ChangePassword(Account account, string password)
        {
            
        }
    }
}
