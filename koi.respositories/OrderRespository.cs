using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using koi.respositories.Entities;
using koi.respositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace koi.respositories
{
    public class OrderRespository : IOrderRespository
    {
        private readonly KoiFishManagementDbContext _dbContext;
        public OrderRespository(KoiFishManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _dbContext.Orders.ToListAsync();     
        }
    }
}
