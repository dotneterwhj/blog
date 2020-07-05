using Microsoft.VisualBasic;
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
    public class TagRepository : EfCoreRepository<NextloadBlogDbContext, Tag, int>, ITagRepository
    {
        public TagRepository(IDbContextProvider<NextloadBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public async Task BulkInsertAsync(IEnumerable<Tag> tags)
        {
            await base.DbContext.Set<Tag>().AddRangeAsync(tags);

            await base.DbContext.SaveChangesAsync();
        }
    }
}
