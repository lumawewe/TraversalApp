using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;
using Traversal.Repository.Abstract;
using Traversal.Repository.Concrete;
using Traversal.Repository.Repository;

namespace Traversal.Repository.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x => x.Destination).ToList();
            }
        }
    }
}
