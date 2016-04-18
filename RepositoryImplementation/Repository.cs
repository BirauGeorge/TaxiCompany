using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate;
using RepositoryInterface;

namespace Repository_Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IDomainObject
    {
        public void Save(TEntity entity)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(entity);

                transaction.Commit();
            }
        }

        public void Delete(TEntity tentity, long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                var entity = _session.Load<TEntity>(id);
                _session.Delete(entity);
                transaction.Commit();
            }
        }
        protected readonly ISession _session = SessionGenerator.Instance.GetSession();
    }
}
