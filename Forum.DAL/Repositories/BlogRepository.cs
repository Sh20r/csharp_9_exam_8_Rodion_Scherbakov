using Forum.DAL.Entities;
using Forum.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Forum.DAL.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(ApplicationDbContext context) : base(context)
        {
            entities = context.Blogs;
        }

        public IEnumerable<Blog> GetAllWithAuthors()
        {
            return entities
                .Include(e => e.Author).ToList();
        }

       
    }
}
