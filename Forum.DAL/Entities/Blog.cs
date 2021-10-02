using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.Entities
{
    public class Blog : IEntity
    {
        public int Id { get; set; }

        public string BlogTheme { get; set; }
        public DateTime DatePublished { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public ICollection<Reply> Replies { get; set; }

    }
}
