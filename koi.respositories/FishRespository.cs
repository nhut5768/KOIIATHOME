using koi.respositories.Entities;
using koi.respositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koi.respositories
{
    public class FishRespository : IFishRespository
    {
        private readonly KoiFishManagementDbContext _dbContext;
        public FishRespository(KoiFishManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Fish>> GetAllFish()
        {
            return await _dbContext.Fish.ToListAsync();
        }
    }
}
