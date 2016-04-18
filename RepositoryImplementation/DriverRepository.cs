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
    public class DriverRepository : IDriverRepository
    {
        public void Save(Driver entity)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(entity);
                transaction.Commit(); 
            }
        }


        protected readonly ISession _session = SessionGenerator.Instance.GetSession();
    }
}
