using System;
using System.Collections.Generic;
using System.Text;

namespace Nextload.Blog.ToolKits.Base.Paged
{
    public class ListResult<T> : IListResult<T>
    {
        private IReadOnlyList<T> _item;
        public IReadOnlyList<T> Item
        {
            get => _item ?? (_item = new List<T>());
            set => _item = value;
        }

        public ListResult()
        {

        }

        public ListResult(IReadOnlyList<T> item)
        {
            _item = item;
        }
    }
}
