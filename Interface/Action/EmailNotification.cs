using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Interface.Action
{
 
    public class EmailNotification : IStudentNotify
    {
       public void Notify(object student)
       {
           student.ToString();

           Console.WriteLine("Studentul a fost creeat {0}",student.GetHashCode());
           Console.ReadLine();
       }
    }
}
