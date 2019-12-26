using Blog.Dal.Repository;
using Blog.Entities.DTO;
using Blog.Entities.Entities;
using Blog.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Blog.Services.Services
{
    public class CategoryServices
    {
        private readonly CategoryRepository _categoryRepository;

        private static int _rowNumber;

        public CategoryServices()
        {
            _categoryRepository = new CategoryRepository();
            _rowNumber = Convert.ToInt32(ConfigurationManager.AppSettings["TopRowNumber"]);
        }

        public List<CategoryDTO> GetAllCategoriesDTO()
        {
            List<Category> categories = _categoryRepository.GetAllCategories();
            List<CategoryDTO> categoryDTO = categories.GetAllCategoryDto();
            return categoryDTO;
        }

        public List<CategoryDTO> GetTopCategoryDTO()
        {
            List<Category> categories = _categoryRepository.GetAllCategories();
            List<CategoryDTO> categoryDTO = categories.Take(_rowNumber).GetAllCategoryDto();
            return categoryDTO;
        }

        public CategoryDTO GetCategoryDTO(int Id)
        {
            Category category = _categoryRepository.GetCategory(Id);
            CategoryDTO categoryDTO = category.GetCategoryDto();

            return categoryDTO;
        }  
    }
}
