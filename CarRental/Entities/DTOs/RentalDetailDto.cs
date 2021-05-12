using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int RentalId { get; set; }
        public string BrandName { get; set; }
        public string customerFirstAndLastName { get; set; }
        public string rentDate { get; set; }
        public string returnDate { get; set; }
    }
}
