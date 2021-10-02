using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models.Blog
{
    public class BlogModel
    {
        public int Id { get; set; }

        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Дата публикации")]
        public string DatePublished { get; set; }
        [Display(Name = "Автор")]
        public string Author { get; set; }
        public int Replies { get; set; }

    }
}
    