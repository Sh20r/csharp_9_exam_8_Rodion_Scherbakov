using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DAL.Entities
{
    public class Role : IdentityRole<int>, IEntity
    {
        
    }
}
