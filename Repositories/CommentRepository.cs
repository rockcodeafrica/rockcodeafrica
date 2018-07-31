using Rockcodeafrica.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rockcodeafrica.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(rockWebEntities dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
