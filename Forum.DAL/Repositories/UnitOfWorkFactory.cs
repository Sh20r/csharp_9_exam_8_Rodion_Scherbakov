using Forum.DAL.Entities;
using Forum.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.Repositories
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly IApplicationDbContextFactory _applicationDbContextFactory;

        public UnitOfWorkFactory(IApplicationDbContextFactory applicationDbContextFactory)
        {
            _applicationDbContextFactory = applicationDbContextFactory;
        }

        public UnitOfWork Create()
        {
            return new UnitOfWork(_applicationDbContextFactory.Create());
        }
    }
}
