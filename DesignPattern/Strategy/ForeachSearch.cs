using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DesignPattern.Strategy
{
    public class ForeachSearch : ISearchStrategy
    {
        public void Search(List<string> lista, string cuvant )
        {
            bool exista=false;
            foreach (var deCautat in lista)
            {   
                if (deCautat==cuvant)
                {
                    exista = true;
                }
            }
            if (exista)
            {
                Console.WriteLine("Cuvantul {0} exista in aceasta lista", cuvant);
                
            }
            else
            {
                Console.WriteLine("Acest cuvant nu exista");
               
            }
        }
    }
}
