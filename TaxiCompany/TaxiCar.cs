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
using System.ComponentModel.DataAnnotations;

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
        public virtual int Id { get;  set; }

        //Ro Plate number Ex.Mh-34-CCC
        [Required]
        [RegularExpression(@"^[A-Z]{1,2}-[1-9]{2,3}-[A-Z]{3,3}$", ErrorMessage = "Plate Number Invalid, ex: BV-01-ABC")]
        public virtual string Plate { get;  set; }
        public virtual string UniquieId { get;  set; }
        //   p virtualublic DateTime? AcquisitingYear ;
        public virtual string Brand { get;  set; }
        public virtual double Price { get;  set; }
        public virtual double? GeoLong { get; set; }
        public virtual double? GeoLat { get; set; }
        public virtual IList<Driver> Drivers { get; set; }
  
        public enum Brandcar
        {
            Skoda,
            Dacia,
            Opel,
            BMW,
            Alfa

        }
        public TaxiCar(string uniqueId,string plate,double price, string brand)
        {
            UniquieId = uniqueId;
            Plate = plate;
            Price = price;
            Brand = brand;
            GeoLat = null;
            GeoLong = null;
        }
        public TaxiCar(string uniqueId, string plate, double price, string brand, double geoLat, double geoLong)
        {
            UniquieId = uniqueId;
            Plate = plate;
            Price = price;
            Brand = brand;
            GeoLong = geoLong;
            GeoLat = geoLat;
        }
       
        public TaxiCar()
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

    }
}
