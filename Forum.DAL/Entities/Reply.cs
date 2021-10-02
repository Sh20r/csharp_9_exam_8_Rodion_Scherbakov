using System;

namespace Forum.DAL.Entities
{
    public class Reply : IEntity
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }
        public string BlogTheme { get; set; }
    }
}
