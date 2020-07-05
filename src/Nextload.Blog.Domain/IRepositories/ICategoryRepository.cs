using Volo.Abp.Domain.Repositories;

namespace Nextload.Blog.IRepositories
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
    }
}