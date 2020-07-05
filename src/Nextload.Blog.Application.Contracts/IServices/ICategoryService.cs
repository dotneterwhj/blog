using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nextload.Blog
{
    public interface ICategoryService
    {
        Task<bool> InstertCategoryAsync(CategoryDto categoryDto);

        Task<bool> UpdateCategoryAsync(int id, CategoryDto categoryDto);

        Task<bool> DeleteCategoryAsync(int id);

        Task<CategoryDto> GetCategoryDtoByIdAsync(int id);
    }
}
