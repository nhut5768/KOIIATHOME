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
    public class ProductService : IProductService
    {
        private readonly IProductRespository _responsitory;
        public ProductService(IProductRespository respository)
        {
            _responsitory = respository;

        }

        public Task<List<Product>> GetAllProducts()
        {
            return _responsitory.GetAllProducts();
        }
    }
}
