using Forum.DAL.Entities;
using Forum.DAL.EntitiesConifurations.Contracts;


namespace Forum.DAL.EntitiesConifurations
{
    public class EntityConfigurationsContainer : IEntityConfigurationsContainer
    {
        public IEntityConfiguration<Reply> BlogConfiguration { get; }

        public IEntityConfiguration<Reply> ReplyConfiguration { get; }
        public EntityConfigurationsContainer()
        {
            BlogConfiguration = new BlogConfiguration();
            ReplyConfiguration = new ReplyConfiguration();
        }

        
    }

}
