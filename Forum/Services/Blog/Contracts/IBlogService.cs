using Forum.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Services.Contracts
{
    public interface IBlogService
    {
        List<BlogModel> GetAllBlogs(BlogIndexModel model);
        void CreateBlog(BlogCreateModel model, int currentUserId);
    }
}
