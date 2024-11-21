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
    public class FishService: IFishService
    {
        private readonly IFishRespository _responsitory;
        public FishService(IFishRespository respository)
        {
            _responsitory = respository;

        }

        public Task<List<Fish>> Fish()
        {
            return _responsitory.GetAllFish();
        }

        
    }
}
