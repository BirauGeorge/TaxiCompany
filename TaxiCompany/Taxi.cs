using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   
    public sealed class Taxi
    {
      
        private static readonly Lazy<Taxi> lazy=new Lazy<Taxi>(()=> new Taxi(),true); 
        public static Taxi Instance { get { return lazy.Value ;} }
        private Taxi() { }  
        public int Id;
        public string Name ;
        public string Address ;
        public string PhoneNumber ;
        public double Fare ; 
        private void DeleteCar() { } 
       
        }
   
    }

   
