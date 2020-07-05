using Nextload.Blog.EntityFrameworkCore;
using Nextload.Blog.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Nextload.Blog.Repositories
{
    public class FriendLinkRepository : EfCoreRepository<NextloadBlogDbContext, FriendLink, int>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<NextloadBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
