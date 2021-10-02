using Forum.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.Repositories.Contracts
{
    public interface IBlogRepository : IRepository<Blog>
    {
        IEnumerable<Blog> GetAllWithAuthors();
    }
}
