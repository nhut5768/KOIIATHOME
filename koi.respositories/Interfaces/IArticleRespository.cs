using koi.respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koi.respositories.Interfaces
{
    public interface IArticleRespository
    {
        Task<List<Article>> GetAllArticles();
    }
}
