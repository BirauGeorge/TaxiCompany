using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infrastructure;
using Interface.Action;
using DesignPattern;
using DesignPattern.Strategy;
using DesignPattern.TemplateMethod;


namespace StringTools
{

 
    public static class StringHelpers
    {
        public static string Concat(this List<Driver> a, string separator)
        {
            bool first = true;

            var builder = new StringBuilder();

            foreach (var cuv in a)
            {
                if (!first)
                    builder.Append(separator);
                else
                    first = false;
               // builder.Append(cuv.FirstName);

            }
            return builder.ToString();
        }
    }

    public class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public IList<string> Section { get; private set; }
        public string Sectie { get; set; }
        public List<Student> studenti; 

        public Student(string name, int age)
      
        {
            Name = name;
            Age = age;
        }
    }

    public class FacultateFactory
    {
        public FacultateFactory(IStudentNotify addDriver)
        {
            _addDriver = addDriver;
        }
        public Student CreateNewStudent(string name, int age)
        {
           Student student = new Student(name,age);
           OnStudentCreation(student);
           return student;
        }
        public void OnStudentCreation(Student student)
        {
            _addDriver.Notify(student);
        }

        private readonly IStudentNotify _addDriver;
    }
    

    public class Rectorat
    {
        public IList<Student> StudentsList(int number)
        {
            var studenti = new List<Student>();
            for (long i = 0; i < number; i++)
            {
                Console.Write("Numele:");
                string name=Console.ReadLine();
                Console.Write("Age:");


                int age=int.Parse(Console.ReadLine());
               // Console.Write("Sectia:");
               
              //  string sectie = Console.ReadLine();
                var aaa = factoryStudent.CreateNewStudent(name,age);
                studenti.Add(aaa);
            }
            return studenti;
        }

        private static FacultateFactory factoryStudent;

        public Rectorat()
        {
            ServiceLocator.All();
            factoryStudent = ServiceLocator.Get<FacultateFactory>();
        }
    }
  
    
    class Program
    {
        public static void Afisare(string Name, int age = 18, string licenses = "nu")
        {
          //  Console.WriteLine($"Ma numesc {Name} am {age} si {licenses} am permis");
        }
        private static void MyCar()
        {
            IDecComponents a = new NewCar();
            IDecComponents b = new AudioSistem(a);
            IDecComponents c = new SportKit(b);
            IDecComponents d = new PanoramicRoof(c);
            d.AddComponent();
        }
      

       public static void Test(Student student)
        {
            Console.WriteLine(student?.Sectie?? "Sectia nu exista");
        }
        static void Main(string[] args)
        {

            //Observer Patern
            var phone = new Phone();
            var Iphone6 = new PushNotification("Iphone 6", phone);
            var Samsung = new PushNotification("Samsung", phone);
            phone.Attach(Iphone6);
            phone.Attach(Samsung);
            phone.State = "Version NO: 22421231";

            //14 C4#Future
            Afisare("George", 21, "da");
            Afisare(age: 18, Name:"Mihai", licenses:"da");
            Afisare("Alex");
            Afisare("Andrei",22);
            Student student=new Student("George",23);
            Test(null);
            //Strategy Patern
            var SearchList = new SearchList();
            SearchList.Add("George");
            SearchList.Add("Mihai");
            SearchList.Add("Alin");  
            SearchList.SetSearchStrategy(new LinqSearch());
            SearchList.CautaCuvant();
            

            //Template 
            Vehicle ferrari=new Car();
            Vehicle F17=new Plane();
            ferrari.Can("George",21);
            F17.Can("George",21);

            //var func = GetAFunc();
            //Console.WriteLine(func(6));
            //Console.WriteLine(func(3));
            //Console.WriteLine(func(7));
            //Console.WriteLine(func(4));
            //Console.WriteLine(func(5));
            //Console.WriteLine(func(2));
            //Console.WriteLine("da", null == null);
            //Console.ReadLine();
            MyCar();
            Console.ReadKey();
            //string Cuvant = "sadsaasdas";
            //Encoding ascii = Encoding.ASCII;
            //Encoding unicode = Encoding.Unicode;
            //byte[] unicodebytes = unicode.GetBytes(Cuvant);
            //byte[] asciistring = Encoding.Convert(unicode,ascii, unicodebytes);
            //Console.WriteLine(asciistring);
            //Console.WriteLine(unicode);
            //var rectorat = new Rectorat();
            //var student = rectorat.StudentsList(2);
            //foreach (var student1 in student)
            //{
            //    Console.WriteLine("{0} {1} {2}",student1.Name,student1.Age,student1.Sectie);
            //}
            //Console.ReadLine();
        }
        
        //Closure Variabila myVar nu se reinitializeaza cu 0 la fiecare apelare
        public static Func<int, int> GetAFunc()
        {
            var myVar = 0;
            Func<int, int> MarireNota = delegate (int var1)
            {
                if (var1 < 5)
                {
                    myVar = myVar + 1;              
                    Console.WriteLine("Am marit nota de la {1} la {2}, la {0} elevi", myVar,var1,var1+1);
                   return var1 + 1;
                    
                }
                else
                {
                    return var1;
                }
                
            };
            
            return MarireNota;
            
        }
        
    }
}
