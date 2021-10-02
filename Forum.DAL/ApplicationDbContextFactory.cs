using Forum.DAL.Entities;
using Forum.DAL.EntitiesConifurations.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL
{
    public class ApplicationDbContextFactory : IApplicationDbContextFactory
    {
        private readonly DbContextOptions _options;
        private readonly IEntityConfigurationsContainer _entityConfigurationsContainer;

        public ApplicationDbContextFactory(
            DbContextOptions options,
            IEntityConfigurationsContainer entityConfigurationsContainer)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));
            if (entityConfigurationsContainer == null)
                throw new ArgumentNullException(nameof(entityConfigurationsContainer));

            _options = options;
            _entityConfigurationsContainer = entityConfigurationsContainer;
        }

        public ApplicationDbContext Create()
        {
            return new ApplicationDbContext(_options, _entityConfigurationsContainer);
        }
    }
}
