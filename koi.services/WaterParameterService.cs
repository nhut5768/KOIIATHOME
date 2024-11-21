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
    public class WaterParameterService : IWaterParameterService
    {
        private readonly IWaterParameterRespository _responsitory;
        public WaterParameterService(IWaterParameterRespository respository)
        {
            _responsitory = respository;

        }

        public Task<List<WaterParameter>> GetAllWaterParameters()
        {
            return _responsitory.GetAllWaterParameters();   
        }
    }

}
