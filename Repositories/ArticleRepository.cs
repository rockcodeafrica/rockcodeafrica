using Rockcodeafrica.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rockcodeafrica.Repositories
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(rockWebEntities dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
