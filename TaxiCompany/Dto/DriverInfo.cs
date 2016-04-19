using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class DriverInfo
    {
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string UniqueId { get; set; }
        public string Plate { get; set; }
        public string Brand { get; set; }
        public double GeoLong { get; set; }
        public double GeoLat { get; set; }      
        public bool Onduty { get; set; } 
    }
}
