using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav2.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderRepository OrderRepository { get; set; }
        IProductRepository ProductRepository { get; set; }
        IUserRepository UserRepository { get; set; }
        IAddressRepository AddressRepository { get; set; }

        int Complete();
    }
}
