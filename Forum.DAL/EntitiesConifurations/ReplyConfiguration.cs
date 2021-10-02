using Forum.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.EntitiesConifurations
{
    public class ReplyConfiguration : BaseEntityConfiguration<Reply>
    {
        protected override void ConfigureForeignKeys(EntityTypeBuilder<Reply> builder)
        {
            
        }

        protected override void ConfigureProperties(EntityTypeBuilder<Reply> builder)
        {
            builder
                .Property(p => p.Content)
                .HasMaxLength(int.MaxValue)
                .IsRequired();
            builder
                .Property(p => p.DatePublished)
                .IsRequired();
        }
    }
}
