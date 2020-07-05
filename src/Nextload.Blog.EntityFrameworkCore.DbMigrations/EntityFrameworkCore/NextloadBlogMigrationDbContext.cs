using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;

namespace Nextload.Blog.EntityFrameworkCore
{
    class NextloadBlogMigrationDbContext : AbpDbContext<NextloadBlogMigrationDbContext>
    {
        public NextloadBlogMigrationDbContext(DbContextOptions<NextloadBlogMigrationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configure();
        }

    }
}
