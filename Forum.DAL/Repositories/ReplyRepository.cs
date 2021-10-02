using Forum.DAL.Entities;
using Forum.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DAL.Repositories
{
    public class ReplyRepository : Repository<Reply>, IReplyRepository
    {
        public ReplyRepository(ApplicationDbContext context) : base(context)
        {
            entities = context.Replies;
        }

        public IEnumerable<Reply> GetAllWithAuthors()
        {
            return entities
                .Include(e => e.Author).ToList();
        }
    }
}
