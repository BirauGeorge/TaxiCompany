using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICar
    {
        void Drive(List<Driver> driver, List<TaxiCar> taxiCar);
    }

    public class TaxiCar
   {
     //  private static string text;

        bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }

        //public void Drive(List<Driver> alist, List<TaxiCar> bList)
        //{
        //    foreach (var a in alist)
        //    {
        //        if (a.TaxiCarId != 0)
        //        {
        //            var masina = bList.SingleOrDefault(x => x.Id == a.TaxiCarId);
        //            Console.WriteLine("Angajatul: {0}, conduce masina cu numarul:{1}", a.Name(), masina.Plate);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Angajatul: {0}, nu are masina inca", a.Name());
        //        }
        //    }
        //    Console.ReadLine();
        //}
        // public int TaxiId;
        public virtual int Id { get; protected set; }
        public virtual string Plate { get; protected set; }
        public virtual string UniquieId { get; protected set; }
        //   p virtualublic DateTime? AcquisitingYear ;
        public virtual string Brand { get; protected set; }
        public virtual double Price { get; protected set; }
        public virtual double GeoLong { get; set; }
        public virtual double GeoLat { get; set; }
        public virtual IList<Driver> Drivers { get; set; }
        public TaxiCar(string uniqueId,string plate,double price, string brand)
        {
            UniquieId = uniqueId;
            Plate = plate;
            Price = price;
            Brand = brand;
        }
        [Obsolete]
        protected TaxiCar()
        {
        }
        #region EqualityComparisons
        class TaxiCarCompare : IEqualityComparer<TaxiCar>
        {
            public bool Equals(TaxiCar a, TaxiCar b)
            {
                return a.UniquieId == b.UniquieId && a.Plate == b.Plate;
            }

            public int GetHashCode(TaxiCar obj)
            {
                return (obj.Plate).GetHashCode();
            }
         
        }
        #endregion
        
        public  TaxiCar(int id,string plate ,string brand, double price )
       {
           this.Id = id;
           this.Plate = plate;
           //this.AcquisitingYear = AquisitingDate;
           this.Brand = brand;
           this.Price = price;
       }

    }
}
