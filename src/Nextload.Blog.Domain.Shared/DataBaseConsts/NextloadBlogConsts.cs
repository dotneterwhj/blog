using System;
using System.Collections.Generic;
using System.Text;

namespace Nextload.Blog
{
    public class NextloadBlogConsts
    {
        public const string DbTablePrefix = "nextload_";
    }

    public class NextloadBlogDbConsts
    {
        public static class DbTableName
        {
            public const string Post = "post";
            public const string Category = "category";
            public const string Tag = "tag";
            public const string PostTag = "post_tag";
            public const string Friendlink = "friendlink";
        }
    }
}
