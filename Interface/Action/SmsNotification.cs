using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Action
{
  public  class SmsNotification : IStudentNotify
    {
        public void Notify(object student)
        {
            Console.WriteLine("(SMS)Studentul a fost creeat");
            Console.ReadLine();
        }
    }
}
