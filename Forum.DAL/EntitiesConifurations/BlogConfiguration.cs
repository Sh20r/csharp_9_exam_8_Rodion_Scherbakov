using Forum.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Forum.DAL.EntitiesConifurations
{
    public class BlogConfiguration : BaseEntityConfiguration<Reply>
    {
        protected override void ConfigureForeignKeys(EntityTypeBuilder<Reply> builder)
        {
            
            
        }

        protected override void ConfigureProperties(EntityTypeBuilder<Reply> builder)
        {
            builder
                .Property(b => b.BlogTheme)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(b => b.Content)
                .HasMaxLength(int.MaxValue)
                .IsRequired();
            builder
                .Property(b => b.DatePublished)
                .IsRequired();
        }
    }
}
