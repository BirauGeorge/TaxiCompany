using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
    public class Plane : Vehicle
    {
        protected override void Start()
        {
            Console.WriteLine("Start engine");
        }

        protected override void Stop()
        {
            Console.WriteLine("Stop Engine. Do no stop when fly :)");
        }
    }
}
