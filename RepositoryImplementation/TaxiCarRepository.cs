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
    public class TaxiCarRepository:ITaxiCarRepository
    {
        protected readonly ISession _session = SessionGenerator.Instance.GetSession();
        public void Save(TaxiCar entity)
        {
            using (ITransaction transaction= _session.BeginTransaction())
            {
                _session.SaveOrUpdate(entity);

                transaction.Commit();
            }
        }
        public TaxiCar Get(long id)
        {
            return _session.Get<TaxiCar>(id);
        }

        public IList<TaxiCar> AllTaxi()
        {
            TaxiCar taxialias = null;
            IList<TaxiCar> taxiList = _session.QueryOver(() => taxialias).List();
            return taxiList;
        }

        public void AddTaxiToDriver(int id)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                var query = _session.CreateQuery("Update Driver set TaxiCar_Id=:taxicarid where Employee_id=employeeid");
                query.SetParameter("taxicarid", id);

                int res = query.ExecuteUpdate();
                transaction.Commit();
            }
        }
    }
}
