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
    public class PondService : IPondService
    {
        private readonly IPondRespository _responsitory;
        public PondService(IPondRespository respository)
        {
            _responsitory = respository;

        }

        public Task<List<Order>> GetAllPonds()
        {
            return _responsitory.GetAllPonds();
        }
    }
}
