using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Interface.Action;
using Factories;
using Infrastructure;

namespace Logical
{
    public class DriverLogic
    {
        
       // private Driver sofer = new Driver();
        
       private static Factory factory;

        public static bool SortingDelegateString(object a, object b)
        {
            return ((string) a)[0] > ((string) b)[0];
        }
       // public static bool SortingDelegateDriver(object a, object b )
      //  {

           // return SortingDelegateString(((Driver)a).LastName,((Driver)b).LastName);

      //  }
        public void AddDriver()
        {
            
            _AddDriver();
            
        }
        public readonly IStudentNotify _notifyUsersAction;
        public delegate bool SortingDelegate(object a, object b);  
        private void _AddDriver()
        {
            factory = ServiceLocator.Get<Factory>();
        //  EmployeeFactory employeeFactory = new EmployeeFactory();
            int choise1 = 1;
          
            while (choise1 == 1)
            {  
                string answear;
                Console.Write("Numele de familie: ");
                string FirstName = Console.ReadLine();
                Console.Write("Prenumele: ");
                string LastName = Console.ReadLine();
                Console.Write("Adresa ta: ");
                string Adress = Console.ReadLine();
                Console.Write("Numarul de Telefon: ");
                string Phone = Console.ReadLine();
                Console.Write("Salariu:");
                double Salary = double.Parse(Console.ReadLine());
                Console.Clear();
                //Console.WriteLine("Soferul {0} a fost adaugat cu succes!");
                //Console.WriteLine("----------------------------------------");
                //StreamWriter sw =
                //    File.AppendText("D:/AmdarisInterShip/amdarisinternsh/trunk/TaxiCompany/Leasson1/Drivers.txt");
                //{
                //    sw.WriteLine(i);
                //    sw.WriteLine(driver.FirstName);
                //    sw.WriteLine(driver.LastName);
                //    sw.WriteLine(driver.Adress);
                //    sw.WriteLine(driver.Phone);
                //    sw.WriteLine(driver.Salary);
                //    sw.WriteLine(driver.DataAngajarii);
                //    sw.WriteLine(driver.TaxiCarId);
                //    sw.WriteLine(" ");
                //}
                //sw.Dispose();
               
             ///   OnDriverCreate(driver);
              //  var driver = factory.CreateNewDriver(FirstName, LastName, Adress, Phone, Salary);
                Console.WriteLine("Mai vrei sa adaugi soferi? Da/Nu?");
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
        //public void OnDriverCreate(Driver driver)
        //{
        //    _notifyUsersAction.Notify(driver);
        //}

        //public void ShowDrivers(List<Driver> drivers)
        //{
        //    foreach (var driver in drivers)
        //    {
               
        //        DateTime dt = DateTime.Now;
        //     //   TimeSpan ts = driver.DataAngajarii > dt ? driver.DataAngajarii - dt : dt - driver.DataAngajarii;
        //        CultureInfo ro = CultureInfo.GetCultureInfo("ro-Ro");
        //        Console.WriteLine("Id:{0,-3} Nume:{1, 3} Salariu:{2} Vechime:{3}",driver.id,driver.Name(),driver.Salary.ToString("C",ro),ts.Days);
        //    }
        //}
      
        public void ProxyShowDriver(List<Driver>driver,List<TaxiCar>taxiCars)
        {
          //  TaxiCar taxiCar=new TaxiCar();
           // taxiCar.Drive(driver,taxiCars);

        }
        //public void Sort(List<Driver> a, Func<Driver,Driver, bool> SortingLamda)
        //{
           
        //    bool swap;
        //    do
        //    {
        //        swap = true;


        //        for (int b = 0; b < a.Count()-1; b++)
        //        {
        //            if (SortingLamda(a[b], a[b + 1]))
        //            {
        //                string temp = a[b].FirstName;
        //                a[b].FirstName = a[b + 1].FirstName;
        //                a[b + 1].FirstName = temp;
        //                swap = false;
        //            }
                    
        //        }
        //    } while (swap);
        //    foreach (var sofer in a)
        //    {
        //        Console.WriteLine(sofer.FirstName);
        //    }
        //    Console.ReadLine();
        //}
    }
}


