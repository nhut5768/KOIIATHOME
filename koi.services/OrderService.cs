using koi.respositories.Entities;
using koi.respositories.Interfaces;
using koi.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koi.services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRespository _responsitory;
        public OrderService(IOrderRespository respository)
        {
            _responsitory = respository;

        }

        public Task<List<Order>> GetAllOrders()
        {
            return _responsitory.GetAllOrders();
        }
    }
}
