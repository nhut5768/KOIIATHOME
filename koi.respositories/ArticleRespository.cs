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
    public class ArticleRespository : IArticleRespository
    {
        private readonly KoiFishManagementDbContext _dbContext;
        public ArticleRespository(KoiFishManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Article>> GetAllArticles()
        {
            return await _dbContext.Articles.ToListAsync();
        }
    }
}
