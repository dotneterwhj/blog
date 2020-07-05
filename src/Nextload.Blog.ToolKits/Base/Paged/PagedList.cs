using System;
using System.Collections.Generic;
using System.Text;

namespace Nextload.Blog.ToolKits.Base.Paged
{
    public class PagedList<T> : ListResult<T>, IPagedList<T>
    {
        public int Total { get; set; }

        public PagedList()
        {

        }

        public PagedList(int total, IReadOnlyList<T> result) : base(result)
        {
            Total = total;
        }
    }
}
