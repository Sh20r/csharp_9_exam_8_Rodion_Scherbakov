using AutoMapper;
using Forum.DAL.Entities;
using Forum.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateBlogToBlogModelMap();
            CreateBlogCreateModelToBlog();
        }

        public void CreateBlogToBlogModelMap()
        {
            CreateMap<Blog, BlogModel>()
                .ForMember(target => target.DatePublished,
                src => src.MapFrom(p => p.DatePublished.ToString("D")))
                .ForMember(target => target.Author, src => src.MapFrom(p => p.Author.UserName))
                .ForMember(target => target.Title, src => src.MapFrom(p => p.BlogTheme));
        }

        public void CreateBlogCreateModelToBlog()
        {
            CreateMap<BlogCreateModel, Blog>()
                .ForMember(target => target.DatePublished, src => src.MapFrom(p => DateTime.Now));

        }
    }
}
