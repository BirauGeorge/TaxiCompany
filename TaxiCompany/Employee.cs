using System;
using System.Collections.Generic;
using System.Linq;


namespace Domain
{
   public class Employee: Entity
   {
       public virtual string FirstName { get;  set; }
       public virtual string LastName { get;  set; }
       public virtual string Adress { get;  set; }
       public virtual string Phone { get;  set; }
       public virtual double Salary { get;   set; }
       public virtual DateTime DataAngajarii { get;  set;}
       
       public virtual IList<Driver> Drivers { get; set; }
       
           // get { return _drivers; }
       
       public virtual string Name()
       {
           return FirstName + " " + LastName;
       }
       
       private void AddDriver() { }
       private void AddMechanic() { }
       private void DeleteDriver() { }
       private void DeleteMechanic() { }
       private void SetSalary() { }

    
       public Employee(string firstname, string lastname, string adress, string phone, double salary)
       {
           FirstName = firstname;
           LastName = lastname;
           Adress = adress;
           Phone = phone;
           Salary = salary;
           DataAngajarii = DateTime.Now;
           
       }
        private readonly  IList<Driver> _drivers=new List<Driver>();
        
        public Employee()
        {

        }

    }
}
