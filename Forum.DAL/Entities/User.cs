using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace Forum.DAL.Entities
{
    public class User : IdentityUser<int>, IEntity
    {
        public ICollection<Blog> Blogs { get; set; }
    }
}
