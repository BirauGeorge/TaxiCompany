using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DesignPattern.Strategy
{
    public class LinqSearch : ISearchStrategy
    {
        public void Search(List<string> list,string cuvant)
        {
           bool exista = list.Contains(cuvant);
            if (exista)
            {
                Console.WriteLine("Cuvantul {0} exista in aceasta lista",cuvant);
            }
            else
            {
                Console.WriteLine("Acest cuvant nu exista");
            }
        }
    }
}
