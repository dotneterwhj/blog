using Nextload.Blog.EntityFrameworkCore;
using Nextload.Blog.IRepositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Nextload.Blog.Repositories
{
    public class PostRepository : EfCoreRepository<NextloadBlogDbContext, Post, int>, IPostRepository
    {
        public PostRepository(IDbContextProvider<NextloadBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}