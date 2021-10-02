using Forum.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.EntitiesConifurations.Contracts
{
   public interface IEntityConfiguration<T> where T : class, IEntity
    {
        Action<EntityTypeBuilder<T>> ProvideConfigurationAction();
    }
}
