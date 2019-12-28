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

        //Admin List Category
        public List<Category> GetAllCategories()
        {
            var categories = _categoryRepository.GetAllCategories();
            return categories;
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
            if (Id < 0)
                return null;

            Category category = _categoryRepository.GetCategory(Id);
            CategoryDTO categoryDTO = category.GetCategoryDto();

            return categoryDTO;
        }
        
        //AdminPanel GetCategory
        public Category GetCategory(int id)
        {
            if (id < 0)
                return null;
            var result = _categoryRepository.GetCategory(id);
            return result;
        }

        //Admin Panel EditCategory
        public void EditCategory(Category category)
        {
            if (category == null)
                return;
            _categoryRepository.EditCategory(category);
        }

        //Admin Panel Add Category
        public Category AddCategory(Category category) => _categoryRepository.AddCategory(category);

    }
}
