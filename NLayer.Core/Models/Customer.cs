using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Nieighborhood { get; set; }
        public string Street { get; set; }
        public string SiteName { get; set; }
        public string DoorNumber { get; set; }
        public int Floor { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int PostCode { get; set; }
        public string Describe { get; set; }

    }
}
