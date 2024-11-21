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
    public class WaterParameterRespository : IWaterParameterRespository
    {
        private readonly KoiFishManagementDbContext _dbContext;
        public WaterParameterRespository(KoiFishManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<WaterParameter>> GetAllWaterParameters()
        {
            return await _dbContext.WaterParameters.ToListAsync();
        }
    }
}

