using Nextload.Blog.EntityFrameworkCore;
using Nextload.Blog.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Nextload.Blog.Repositories
{
    public class PostTagRepository : EfCoreRepository<NextloadBlogDbContext, PostTag, int>, IPostTagRepository
    {
        public PostTagRepository(IDbContextProvider<NextloadBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        public async Task BulkInsertAsync(IEnumerable<PostTag> postTags)
        {
            await base.DbContext.Set<PostTag>().AddRangeAsync(postTags);

            await base.DbContext.SaveChangesAsync();
        }
    }
}
