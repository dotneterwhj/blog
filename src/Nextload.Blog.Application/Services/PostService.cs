using Nextload.Blog.IRepositories;
using Nextload.Blog.IServices;
using Nextload.Blog.ToolKits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nextload.Blog.Services
{
    public class PostService : BlogAppService, IPostService
    {
        private readonly IPostRepository _repository;

        public PostService(IPostRepository repository)
        {
            this._repository = repository;
        }

        public async Task<ServiceResult> DeletePostAsync(int id)
        {
            var result = new ServiceResult();

            await _repository.DeleteAsync(id);

            return result;
        }

        public async Task<ServiceResult<PostDto>> GetPostByIdAsync(int id)
        {
            var result = new ServiceResult<PostDto>();

            var post = await _repository.GetAsync(id);

            if (post == null)
            {
                result.IsFail("cannot find this blog");

                return result;
            }

            var dto = new PostDto
            {
                Title = post.Title,
                Author = post.Author,
                CategoryId = post.CategoryId,
                CreationTime = post.CreationTime,
                Html = post.Html,
                Markdown = post.Markdown,
                Url = post.Url
            };

            result.IsSuccess(dto);

            return result;
        }

        public async Task<ServiceResult<string>> InsertPostAsync(PostDto postDto)
        {
            var result = new ServiceResult<string>();

            var post = new Post
            {
                Title = postDto.Title,
                Author = postDto.Author,
                CategoryId = postDto.CategoryId,
                CreationTime = postDto.CreationTime,
                Html = postDto.Html,
                Markdown = postDto.Markdown,
                Url = postDto.Url
            };

            var entity = await _repository.InsertAsync(post);

            if (entity == null)
            {
                result.IsFail("add a blog failed");

                return result;
            }

            result.IsSuccess("add a blog success");

            return result;
        }

        public async Task<ServiceResult<string>> UpdatePostAsync(int id, PostDto postDto)
        {
            var result = new ServiceResult<string>();

            var post = await _repository.GetAsync(id);

            if(post == null)
            {
                result.IsFail("cannot find this blog");
                return result;
            }

            post.Title = postDto.Title;
            post.Author = postDto.Author;
            post.CategoryId = postDto.CategoryId;
            post.CreationTime = postDto.CreationTime;
            post.Html = postDto.Html;
            post.Markdown = postDto.Markdown;
            post.Url = postDto.Url;

            var entity = await _repository.UpdateAsync(post);

            if (entity == null)
            {
                result.IsFail("update a blog failed");

                return result;
            }

            result.IsSuccess("update a blog success");

            return result;
        }
    }
}
