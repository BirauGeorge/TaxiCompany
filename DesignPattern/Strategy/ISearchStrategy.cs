using System.Collections.Generic;


namespace DesignPattern.Strategy
{
    public interface ISearchStrategy
    {
       void Search(List<string> list,string cuvant);
    }
}
