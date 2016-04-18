using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
     public abstract class Vehicle : ICan
    {
       public void Can(string name, int age)
      {
           if (age > 18)
           {
               Console.WriteLine("{0} poti folosii vehiculele",name);
                Start();
                Stop();
           }
           else
           {
               Console.WriteLine("{0} nu poti poti folosii vehiculele",name);
           }
      }
        protected abstract void Start();
        protected abstract void Stop();
    }
}
