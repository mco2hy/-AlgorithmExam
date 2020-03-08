using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sinav2.Interfaces;
using Sinav2.Models;

namespace Sinav2.Services
{
    public class AddressRepository : Repository<Models.Address>, Interfaces.IAddressRepository
    {
        public AddressRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
