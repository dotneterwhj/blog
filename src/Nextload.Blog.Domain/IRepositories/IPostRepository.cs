using Volo.Abp.Domain.Repositories;

namespace Nextload.Blog.IRepositories
{
    public interface IPostRepository : IRepository<Post, int>
    {
    }
}