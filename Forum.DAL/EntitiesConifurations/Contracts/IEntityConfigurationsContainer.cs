using Forum.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.EntitiesConifurations.Contracts
{
    public interface IEntityConfigurationsContainer
    {
        IEntityConfiguration<Reply> BlogConfiguration { get; }
        IEntityConfiguration<Reply> ReplyConfiguration { get; }
    }
}
