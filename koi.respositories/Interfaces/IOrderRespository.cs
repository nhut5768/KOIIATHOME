using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using koi.respositories.Entities;

namespace koi.respositories.Interfaces
{
    public interface IOrderRespository
    {
        Task<List<Order>> GetAllOrders();
    }
}
