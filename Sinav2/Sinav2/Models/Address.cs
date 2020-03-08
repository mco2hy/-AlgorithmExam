using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav2.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string OpenAddress { get; set; }

        public List<User> Users { get; set; }
        public List<Order> Orders { get; set; }
    }
}
