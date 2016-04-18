using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
  public class SearchList
  {
      private readonly List<string> _list;
      private string _decautat="George";
      private ISearchStrategy _searchStrategy;

      public SearchList()
      {
          _list=new List<string>();
      }
      public void SetSearchStrategy(ISearchStrategy searchStrategy)
      {
          _searchStrategy = searchStrategy;
      }
 
      public void Add(string item)
      {
          _list.Add(item);
      }
      public void CautaCuvant()
      {
          _searchStrategy.Search(_list,_decautat);
      }
    }
}
