using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models.Blog
{
    public class BlogIndexModel
    {
        
        [Display(Name = "Автор")]
        public string Author { get; set; }
        
        public string SearchKey { get; set; }
        
        [Display(Name = "С даты по")]
        public DateTime? DateFrom { get; set; }
        
        [Display(Name = "С даты до")]
        public DateTime? DateTo { get; set; }
        public List<BlogModel> Blogs { get; set; }
        public int? Page { get; set; }
        public PagingModel PagingModel { get; set; }
    }
}
