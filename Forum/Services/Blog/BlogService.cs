using AutoMapper;
using Forum.DAL.Entities;
using Forum.DAL.Repositories.Contracts;
using Forum.Models;
using Forum.Models.Blog;
using Forum.Services.Contracts;
using System.Collections.Generic;
using System.Linq;


namespace Forum.Services
{
    public class BlogService : IBlogService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public BlogService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public void CreateBlog(BlogCreateModel model, int currentUserId)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var blog = Mapper.Map<Blog>(model);
                blog.AuthorId = currentUserId;
                blog.BlogTheme = model.Title;

                unitOfWork.Blogs.Create(blog);
            }
        }

        public List<BlogModel> GetAllBlogs(BlogIndexModel model)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var blogs = uow.Blogs.GetAllWithAuthors();

                blogs = blogs
                    .BySearchKey(model.SearchKey)
                    .ByAuthorName(model.Author)
                    .ByDateFrom(model.DateFrom)
                    .ByDateTo(model.DateTo);

                int pageSize = 2;
                int count = blogs.Count();
                int page = model.Page.HasValue ? model.Page.Value : 1;
                blogs = blogs.Skip((page - 1) * pageSize).Take(pageSize);
                model.PagingModel = new PagingModel(count, page, pageSize);
                model.Page = page;


                var models = Mapper.Map<List<BlogModel>>(blogs.ToList());
                return models;
            }
        }
    }
}
