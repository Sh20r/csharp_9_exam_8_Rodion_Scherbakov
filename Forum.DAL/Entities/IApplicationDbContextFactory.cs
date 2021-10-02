using System;


namespace Forum.DAL.Entities
{
    public interface IApplicationDbContextFactory
    {
        ApplicationDbContext Create();
    }
}
