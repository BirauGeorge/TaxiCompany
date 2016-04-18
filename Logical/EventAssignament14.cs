using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class EventAssignament14
    {
     
       public delegate void MyEventHandler();

  
       public  class MyEvent
        {
            public event MyEventHandler SomeEvent;

          
            public void OnSomeEvent()
            {
                if (SomeEvent != null)
                    SomeEvent();
            }
        }
        public class Add
        {
            public void TaxiAdded()
            {
                Console.WriteLine("Taxiul a fost adugat");
            }
        }
    }
}
