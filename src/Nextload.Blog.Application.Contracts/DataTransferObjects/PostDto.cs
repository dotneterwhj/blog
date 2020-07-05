using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Nextload.Blog
{
    public class PostDto : EntityDto
    {

        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        public string Title { get; set; }


        /// <summary>
        /// 作者
        /// </summary>
        [Required]
        public string Author { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [Required]
        public string Url { get; set; }

        /// <summary>
        /// HTML
        /// </summary>
        [Required]
        public string Html { get; set; }

        /// <summary>
        /// Markdown
        /// </summary>
        public string Markdown { get; set; }

        /// <summary>
        /// 分类Id
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
