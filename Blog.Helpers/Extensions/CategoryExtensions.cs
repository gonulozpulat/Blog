using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Helpers.Extensions
{
    public static class CategoryExtensions
    {
        public static List<CategoryDTO> GetAllCategoryDto(this IEnumerable<Category> categories)
        {
            var categoryDto = categories.Select(category => new CategoryDTO
            {
                Id = category.Id,
                CategoryName = category.Name,
                CategoryDescription = category.Description,
                CategoryImagePathUrl = category.ImagePathUrl
            }).ToList();

            return categoryDto;
        }

        public static CategoryDTO GetCategoryDto(this Category category)
        {
            var categoryDto = new CategoryDTO
            {
                Id = category.Id,
                CategoryName = category.Name,
                CategoryDescription = category.Description,
                CategoryImagePathUrl = category.ImagePathUrl
            };
            return categoryDto;
        }

    }
}
