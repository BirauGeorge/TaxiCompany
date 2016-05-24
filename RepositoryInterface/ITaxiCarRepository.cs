using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace RepositoryInterface
{
    public interface ITaxiCarRepository
    {
        void Save(TaxiCar entity);
        TaxiCar Get(int id);
        IList<TaxiCar> AllTaxi();
        void Delete(TaxiCar entity);
        IList<TaxiCar> UnusedCars();
    }
}
