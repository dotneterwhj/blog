using Nextload.Blog.EntityFrameworkCore;
using Nextload.Blog.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Nextload.Blog.Repositories
{
    public class CategoryRepository : EfCoreRepository<NextloadBlogDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<NextloadBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
