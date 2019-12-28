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

        //Admin Panel
        public static Category GetCategory(this CategoryDTO categoryDto)
        {
            var category = new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.CategoryName,
                Description = categoryDto.CategoryDescription,
                ImagePathUrl = categoryDto.CategoryImagePathUrl
            };
            return category;
        }

    }
}
