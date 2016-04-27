using System;
using System.Collections.Generic;

namespace Domain
{
    public class Driver
    {
        public virtual int Id { get; protected set;}
       // public virtual int EmployeeId { get; protected set; }
        public virtual bool OnDuty { get; set;}
        
        public virtual Employee Employee { get; set; }
        public virtual TaxiCar TaxiCar { get; protected set; }
        public Driver(Employee employee,int taxiCarId,bool onDuty)
        {
            OnDuty = onDuty;
            
            Employee = employee;
        }
        
        public Driver()
        {
        }
    }
}
