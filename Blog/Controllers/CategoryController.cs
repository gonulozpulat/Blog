using Blog.Entities.DTO;
using Blog.Models;
using Blog.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private readonly CategoryServices _categoryServices;
        private readonly ArticleServices _articleServices;

        public CategoryController()
        {
            _categoryServices = new CategoryServices();
            _articleServices = new ArticleServices();

        }
        public ActionResult Index(int Id)
        {
            CategoryDTO getCategory = _categoryServices.GetCategoryDTO(Id);
            List<ArticleDTO> articleDTOs = _articleServices.GetAllArticlesDTO();
            var model = new CategoryViewModel
            {
                Category = getCategory,
                Article = articleDTOs
            };
            return View(model);
        }
    }
}