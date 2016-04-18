
using System;
using Domain;

namespace Factories
{
   public class Factory
    {
        //public Driver CreateNewDriver(string firstName, string lastName, string adress, string phoneNumber, double salary,)
        //{
        //    return createDriverInternal(firstName, lastName, adress, phoneNumber, salary,
        //        (f, l, a, p, s) => new Driver(f, l, a, p, s));
        //}

        private Driver createDriverInternal(Employee employee ,string firstName, string lastName, string adress, string phoneNumber, double salary, Func<string, string, string, string, double, Driver> createDriver)
        {
            var driver = createDriver(firstName, lastName, adress, phoneNumber, salary);
            return driver;
        }

       public TaxiCar CreateNewTaxi(string uniqueId, string plate, double price, string brand)
       {
           return createInternalTaxiCar(uniqueId, plate, price, brand, (u, p, pr, b) => new TaxiCar(u, p, pr, b));
       }
       private TaxiCar createInternalTaxiCar(string uniqueId,string plate, double price, string brand, Func<string, string,double,string,TaxiCar> createTaxiCar)
        {
            var taxiCar = createTaxiCar(uniqueId, plate, price, brand);
            return taxiCar;
        }
    }

}
