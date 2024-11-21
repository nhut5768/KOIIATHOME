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
    public class SaltCalculationRespository : ISaltCalculationRespository
    {
        private readonly KoiFishManagementDbContext _dbContext;
        public SaltCalculationRespository(KoiFishManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SaltCalculation>> GetAllSaltCalculations()
        {
            return await _dbContext.SaltCalculations.ToListAsync();
        }
    }
}

