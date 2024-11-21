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
    public class ArticleService : IArticleService
    {
        private readonly IArticleRespository _respository;
        public ArticleService(IArticleRespository respository)
        {
            _respository = respository;
        }
        public Task<List<Article>> Articles()
        {
            return _respository.GetAllArticles();
        }
    }
}
