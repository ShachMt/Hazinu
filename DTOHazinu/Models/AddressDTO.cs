using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class AddressDTO
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int? NumberHome { get; set; }
        public int? NumberApartment { get; set; }
    }
}
