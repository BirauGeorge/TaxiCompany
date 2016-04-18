using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logical
{
    public class IncarcareDate
    {
        public void IncarcaDateDrivers(List<Driver> a)
        {
            a.Clear();
           
            
            System.IO.StreamReader file =
                new System.IO.StreamReader(
                    "D:/AmdarisInterShip/amdarisinternsh/trunk/TaxiCompany/Leasson1/Drivers.txt");
            while (!file.EndOfStream)
            {
               
                var id = int.Parse(file.ReadLine());
                var FirstName = file.ReadLine();
                var LastName = file.ReadLine();
                var Adress = file.ReadLine();
                var Phone = file.ReadLine();
                var Salary = double.Parse(file.ReadLine());
                var DataAngajarii = DateTime.Parse(file.ReadLine());
                var TaxiCarId = int.Parse(file.ReadLine());
                file.ReadLine();
              
            }
            file.Close();
        }


        public void IncarcaDateTaxiuri(List<TaxiCar> a)
        {
            System.IO.StreamReader file =
                new System.IO.StreamReader(
                    "D:/AmdarisInterShip/amdarisinternsh/trunk/TaxiCompany/Leasson1/Taxiuri.txt");
            while (!file.EndOfStream)
            {
                
                int Id = int.Parse(file.ReadLine());
                string UniquieId = file.ReadLine();
                string Plate = file.ReadLine();
                double Price = double.Parse(file.ReadLine());
                string Brand = file.ReadLine();
                file.ReadLine();
                
            }
            file.Close();
        }


    }
}

