using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Domain.Dto
{
  public class DriverAdd
    {
        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Adress { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string Phone { get; set; }

        [Required]
        [Range(1,1000)]
        public double Salary { get; set; }

        public DateTime DataAngajarii { get; protected set; }

        [Required]
        public int TaxiCarId { get; set; }

        [Required]
        public bool Onduty { get; set; }
    }
   
}
