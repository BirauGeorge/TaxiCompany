using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Factories;
using Infrastructure;
using Domain;

namespace Logical
{
    public interface ITaxi
    {
        void Drive();
    }
  
    public class TaxiLogic
    {
        private static Factory factory;
         
        private enum MarcaMasini
        {
            Skoda,
            Dacia,
            Audi,
            Saab,
            Mercedes,
            Bmw,
            Renaut,
            Peugeot
        };

        public void Drive(List<Driver> driver , List<Taxi> taxiuri)
        {
            
        }
        public void checkInput(string nrimatriculare)
        {
            //char[] delimitator = {"-"};
            if (nrimatriculare.Length != 9)
            {
                throw new Exception("Nu ai introdus corect nr de imatriculare,numarul a fost introdus default");
            }

            //if (!Enum.IsDefined(typeof(TaxiLogic.MarcaMasini), marca))
            //{
            //    throw new Exception("Marca masinii este inexistenta");
            //}

        }

        public void AddTaxi()
        {
            _AddTaxi();
        }

        private void _AddTaxi()
        {
            int choise1 = 1;
            factory = ServiceLocator.Get<Factory>();
            while (choise1 == 1)
            {
                string answear;
                    Console.WriteLine("Adauga o masina de taxi");
                    Console.Write("Adauga id de sasiu: ");                                       string uniquieId = Console.ReadLine();
                    Console.Write("Adauga Numarul de imatriculare de forma ex:(mh-01-aaa):");    string plate = Console.ReadLine();
                    Console.Write("Adauga Pretul Masinii: ");                                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Adauga marca masinii: ");                                     string brand = Console.ReadLine();
                    var taxi = factory.CreateNewTaxi(uniquieId, plate, price, brand);
                    Console.WriteLine("Taxiul cu uniqueId {0} a fost adaugat cu succes!", taxi.UniquieId);
                    Console.WriteLine("----------------------------------------");
                    //StreamWriter sw =
                    //    File.AppendText("D:/AmdarisInterShip/amdarisinternsh/branches/TaxiCompany/Leasson1/Taxiuri.txt");
                    //{
                   
                    //    sw.WriteLine(taxi.UniquieId);
                    //    sw.WriteLine(taxi.Plate);
                    //    sw.WriteLine(taxi.Price);
                    //    sw.WriteLine(taxi.Brand);
                    //    sw.WriteLine(" ");
                    //}
                    //sw.Close();
                    Console.Clear();
                    Console.WriteLine("Mai vrei sa adaugi Taxiuri? Da/Nu?");
                    answear = Console.ReadLine().ToLower();
                    if (answear == "da")
                    {
                        choise1 = 1;
                    }
                    else
                    {
                        choise1 = 2;
                        Console.Clear();
                       
                    }
                }

            }
        

       

        public void OperatorUse(List<TaxiCar> taxi)
        {
            var countTaxi = taxi.Where(p => p.Plate == "AA-00-AAA").Count();
            int i = 1;
            var filterTaxi = taxi.Where(p => p.Plate == "AA-00-AAA").Select(p => new {Id = p.Id, Price = p.Price});
            Console.WriteLine("Avem {0} taxiuri fara numar de imatriculare:", countTaxi);
            foreach (var filter in filterTaxi)
            {
                Console.WriteLine("{2})Taxiul cu id{0} are pretul:{1}", filter.Id, filter.Price, i);
                i++;
            }
            return;
        }

        //private void _Cauta(string cauta, List<Driver> drivers, List<TaxiCar> taxiuri)
        //{
        //    int idTaxi = 1;
        //    foreach (var sofer in drivers)
        //    {
        //        var a = drivers.SingleOrDefault(x => x.LastName == cauta || x.FirstName == cauta);
        //        Console.Write("Adaugati id masinii pe care doriti sa o asignati pentru soferul {0}", a.FirstName);
        //        Console.WriteLine();
        //        idTaxi = int.Parse(Console.ReadLine());
        //        a.TaxiCarId = idTaxi;
        //        var b = taxiuri.SingleOrDefault(y => y.Id == a.TaxiCarId);
        //        Console.WriteLine("Soferului {0} i-a fost asignata masina cu numarul:{1}", a.Name(), b.Plate);
        //        Console.WriteLine("__________________________________________________________");
        //        File.WriteAllText("D:/AmdarisInterShip/amdarisinternsh/branches/TaxiCompany/Leasson1/Drivers.txt",
        //            String.Empty);
        //        StreamWriter sw =
        //            File.AppendText("D:/AmdarisInterShip/amdarisinternsh/branches/TaxiCompany/Leasson1/Drivers.txt");
        //        {
        //            foreach (var deScris in drivers)
        //            {
        //                sw.WriteLine(deScris.id);
        //                sw.WriteLine(deScris.FirstName);
        //                sw.WriteLine(deScris.LastName);
        //                sw.WriteLine(deScris.Adress);
        //                sw.WriteLine(deScris.Phone);
        //                sw.WriteLine(deScris.TaxiCarId);
        //                sw.WriteLine(" ");
        //            }

        //        }
        //        sw.Close();
        //        break;
                
        //    }

        //}

        //public void Cauta(string cauta, List<Driver> drivers, List<TaxiCar> taxiuri)
        //{
        //    _Cauta(cauta, drivers, taxiuri);
        //}
    }
}
