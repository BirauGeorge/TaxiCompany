using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using System.Threading;
using Domain;
using StringTools;
using Factories;
using Infrastructure;
using Logical;
using RepositoryInterface;
using Repository_Implementation;


namespace Leasson1
{
    class Program
    {
        static Program()
        {
            NHibernateProfiler.Initialize();
            ServiceLocator.All();
        }
  /*      static void SearchDriver(string deCautat, List<Driver> lista )
        {
            
            foreach (var a in lista)
            {
                var sofer = lista.SingleOrDefault(x => x.FirstName == deCautat || x.LastName == deCautat);
                if (sofer != null)
                {
                    Console.WriteLine("Soferul {0} se afla in acesta companie.", sofer.Name());
                    Console.WriteLine("______________________________________________________");
                    break;
                }
                else
                {
                    Console.WriteLine("Soferul nu se afla aici!");
                    break;
                }
                
            }
            return;
        } */

        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        public  class SortGeneric
        {
       public void Sortare(string[] bla)
        {

            var aux = bla[1];
            bla[1] = bla[2];
            bla[2] = aux;
                foreach(var elem in bla)
             {
                    Console.WriteLine(elem);
                }
            }

         public void Sortare(int[] bla)
            {
            var aux = bla[1];
            bla[1] = bla[2];
            bla[2] = aux;
             foreach (var elem in bla)
             {
                 Console.WriteLine(elem);
             }
            }
            
        }

        static void Testx()
        {
           // var driver = new Driver();
        }
    

        private static Factory employeeFactory;

        private static IEmployeeRepository employeeRepository;
        private static IDriverRepository driverRepository;

        static void Main(string[] args)

        {
            App_Start.NHibernateProfilerBootstrapper.PreStart();
            Employee employee=new Employee("George","Mihai","sssa","2121",22);
         //   Driver driver=new Driver(employee,1,true,1.22);
            employeeFactory = ServiceLocator.Get<Factory>();
            employeeRepository = ServiceLocator.Get<IEmployeeRepository>();
            driverRepository = ServiceLocator.Get<IDriverRepository>();
             //var employee = employeeFactory.CreateNewDriver("George", "Birau", "Stra", "2121212", 22);
             var aaa = employeeRepository.SlectAllEmployees();
             //employeeRepository.ShowTop3EmployeesbySalary();
         // employeeRepository.ShowDriverSalary();
       //    employeeRepository.EmployeeDate();
        employeeRepository.SubSelectEmployees();
      //      // employeeRepository.Save(employee);

             Testx();
            SortGeneric sortGeneric=new SortGeneric();
            string[] cuvinte= { "da","ba","aa"};
            int[] numere = {1, 2, 3};
            sortGeneric.Sortare(cuvinte);
            sortGeneric.Sortare(numere);
                   

            DriverLogic driverLogic = new DriverLogic();
            TaxiLogic taxiLogic=new TaxiLogic();
            IncarcareDate loadDate =new IncarcareDate();
           

            int choice=0;
            var sourceobject = new object[]
            {
              new Product {Name="paine",Price = 2} ,

                new Product
                {
                   Name = "Caise", Price = 3
                }
            
             };
             var taxiuri = new List<TaxiCar> {};
             var drivers = new List<Driver> {};  
                 
             loadDate.IncarcaDateDrivers(drivers);
             loadDate.IncarcaDateTaxiuri(taxiuri);
         //    var compareString = new DriverLogic.SortingDelegate(DriverLogic.SortingDelegateDriver);
             EventAssignament14.MyEvent evt =new EventAssignament14.MyEvent();
             EventAssignament14.Add add=new EventAssignament14.Add();

            while (choice != 10)
            {
               Console.WriteLine("1)AddTaxi");
                Console.WriteLine("2)Afisare Taxiuri");
                Console.WriteLine("3)Adauga Sofer");
                Console.WriteLine("4)Afisare Soferi");
                Console.WriteLine("5)Cauta sofer");
                Console.WriteLine("6)Asigneaza Masina");
                Console.WriteLine("9)Tema");
                Console.WriteLine("12)ProxyPatern");
                Console.WriteLine("10)Exit");
                Console.Write("Introduceti Optiunea: " );
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
               
                {
                    //Adaugare Taxiuri
                    case 1:
                        int z=0;
                        bool isEmpty1 = taxiuri.Any();
                        if (isEmpty1)
                        {
                            z = taxiuri.Max(x => x.Id);
                            z++;
                        }
                        else
                        {
                            z = 1;
                        }

                        taxiLogic.AddTaxi();
                     
                        evt.SomeEvent+=new EventAssignament14.MyEventHandler(add.TaxiAdded);
                        evt.OnSomeEvent();
                        
                        Console.ReadLine();

                        //Afisare Taxiuri
                        break;
                    case 2:
                        taxiuri.Clear();
                        loadDate.IncarcaDateTaxiuri(taxiuri);
                        Console.WriteLine("Toate Taxiurile:");
                        foreach (var b in taxiuri)
                        {
               Console.WriteLine("ID:{0} Marca:{1} Plate:{2} Price:{3}", b.Id,b.Brand,b.Plate,b.Price);
                          
                        }
                        Console.WriteLine("____________________________________");
                        Console.ReadLine();
                        Console.Clear();
                     
                        break;
                        
                        //Adaugare Soferi
                    case 3:
                        //int p;
                        //bool isEmpty = drivers.Any();
                        //if (isEmpty)
                        //{
                        //    p = drivers.Max(x => x.id);
                        //    p++;
                        //}

                        //else
                        //{
                        //    p = 1;
                        //}

                        driverLogic.AddDriver();
                       // loadDate.IncarcaDateDrivers(drivers);
                        
                        break;
                    //Afisare Soferi    
                    case 4:
                      //  driverLogic.ShowDrivers(drivers);                       
                        Console.ReadLine();
                        Console.Clear();

                        break;
                   //Cautare
                    case 5:
                        string deCautat;
                        Console.Write("Numele soferului pe care il cautati:");
                        deCautat = Console.ReadLine();
                     //   SearchDriver(deCautat, drivers);
                        break;
                        //Adaugare Masina
                    case 6:
                          Console.WriteLine("Cui vrei sa asignezi o masina");
                          string deAssignat = Console.ReadLine();
                       //   taxiLogic.Cauta(deAssignat,drivers,taxiuri);
                        
                        break;
                    case 7:
                     // driverLogic.Sort(drivers, delegate(Driver x, Driver y)
                     // {
                     //    return x.FirstName[0] > y.FirstName[0];
                     //});
                        break;
                    case 8:
                        taxiLogic.OperatorUse(taxiuri);

                        Console.ReadLine();
                        break;
                    case 9:
                       // driverLogic.Sort(drivers, (x,y) =>(((Driver)x).FirstName[0])>((Driver)y).FirstName[0]);
                        break;
                    case 10:                     
                        Console.Write("Programul se v-a inchide singur in 2 secunde");
                        Thread.Sleep(2000);
                        break;
                    case 11:
                        
                        //Console.WriteLine(drivers.Concat("+"));
                        //Console.WriteLine(StringHelpers.Concat(drivers, "*"));
                        Console.ReadLine();
                        break;
                    case 12:
                   //     driverLogic.ProxyShowDriver(drivers,taxiuri);
                        break;
                    case 13:
                       //// Driver mihai =new Driver();
                       // Angajat alex = mihai as Angajat;
                       // Angajat george = (Angajat) alex;
                       // Console.WriteLine(mihai is Driver);
                       // Console.WriteLine(alex is Driver);
                       // break;
                    default:
                        Console.WriteLine("Optiunea introdusa nu exista");
                        break;
                }
            }

        } 
    }
}

