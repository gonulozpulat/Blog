using Blog.Entities.DTO;
using Blog.Models;
using Blog.Services.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryServices _categoryServices; 
        private readonly ArticleServices _articleServices;

        public HomeController()
        {
            _articleServices = new ArticleServices();
            _categoryServices = new CategoryServices();            
        }
        // GET: Home
        public ActionResult Index()
        {
            List<ArticleDTO> articleDTOs = _articleServices.GetTopArticleDTO();
            List<CategoryDTO> categoryTopDTOs = _categoryServices.GetTopCategoryDTO();
            var articleCategory = new HomeIndexViewModel
            {
                Article = articleDTOs,
                Category = categoryTopDTOs

            };
            return View(articleCategory);
        }
    }
}