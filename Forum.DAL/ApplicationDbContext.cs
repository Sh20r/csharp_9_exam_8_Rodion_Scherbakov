using Forum.DAL.Entities;
using Forum.DAL.EntitiesConifurations.Contracts;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Forum.DAL
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {
        private readonly IEntityConfigurationsContainer _entityConfigurationsContainer;

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Reply> Replies { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IEntityConfigurationsContainer entityConfigurationsContainer) : base(options)
        {
            _entityConfigurationsContainer = entityConfigurationsContainer;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity(_entityConfigurationsContainer.BlogConfiguration.ProvideConfigurationAction());
            builder.Entity(_entityConfigurationsContainer.ReplyConfiguration.ProvideConfigurationAction());
        }
    }
}
