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
    public class ProductRespository : IProductRespository
    {
        private readonly KoiFishManagementDbContext _dbContext;
        public ProductRespository(KoiFishManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
        
 