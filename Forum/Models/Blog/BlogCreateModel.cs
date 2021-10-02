using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models.Blog
{
    public class BlogCreateModel
    {
        [Required]
        [Display(Name ="Заголовок")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Содержание")]
        public string Content { get; set; }
    }
}
