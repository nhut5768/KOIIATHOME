using koi.respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace koi.services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
    }
}
