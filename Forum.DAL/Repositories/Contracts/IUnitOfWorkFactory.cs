using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.Repositories.Contracts
{
    public interface IUnitOfWorkFactory
    {
        UnitOfWork Create();
    }
}
