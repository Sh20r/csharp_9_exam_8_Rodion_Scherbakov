using Forum.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.Repositories.Contracts
{
    public interface IReplyRepository : IRepository<Reply>
    {
        IEnumerable<Reply> GetAllWithAuthors();
    }
}
