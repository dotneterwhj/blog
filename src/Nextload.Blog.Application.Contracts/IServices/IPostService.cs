using Nextload.Blog.ToolKits;
using System.Threading.Tasks;
//using Nextload.Blog.ToolKits;

namespace Nextload.Blog.IServices
{
    public interface IPostService
    {
        Task<ServiceResult<string>> InsertPostAsync(PostDto postDto);

        Task<ServiceResult<string>> UpdatePostAsync(int id, PostDto postDto);

        Task<ServiceResult> DeletePostAsync(int id);

        Task<ServiceResult<PostDto>> GetPostByIdAsync(int id);
    }
}