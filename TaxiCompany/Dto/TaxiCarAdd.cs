using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
   public class TaxiCarAdd
   {
        
       public string Plate { get; set; }
       public string Vin { get; set; }
       public string Brand { get; set; }
       public double Price { get; set; }
       public double GeoLong { get; set; }
       public double GeoLat { get; set; }
   }
}
