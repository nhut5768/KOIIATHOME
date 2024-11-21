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
    public class SaltCalculationService : ISaltCalculationService
    {
        private readonly ISaltCalculationRespository _responsitory;
        public SaltCalculationService(ISaltCalculationRespository respository)
        {
            _responsitory = respository;

        }

        Task<List<SaltCalculation>> ISaltCalculationService.GetAllSaltCalculations()
        {
            return _responsitory.GetAllSaltCalculations();  
        }
    }
    
}
