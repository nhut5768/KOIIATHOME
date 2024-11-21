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
    public class FeedCalculationService : IFeedCalculationService
    {
        private readonly IFeedCalculationRespository _respository;
        public  FeedCalculationService(IFeedCalculationRespository respository)
        {
            _respository = respository;

        }

        public Task<List<FeedCalculation>> FeedCalculations()
        {
            return _respository.GetAllFeedCalculations();
        }
    }
}
