using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace RepositoryInterface
{
    public interface IRepository<TEntity> where TEntity : IDomainObject
    {
        void Save(TEntity entity);
    }
}
