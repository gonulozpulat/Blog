using Blog.Entities.DTO;
using Blog.Entities.Entities;
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
        private readonly CommentServices _commentServices;

        public HomeController()
        {
            _articleServices = new ArticleServices();
            _categoryServices = new CategoryServices();
            _commentServices = new CommentServices();
        }
        // GET: Home
        public ActionResult Index()
        {
            List<ArticleDTO> articleDTOs = _articleServices.GetTopArticleDTO();
            List<CategoryDTO> categoryTopDTOs = _categoryServices.GetTopCategoryDTO();
            //List<CommentDTO> commentDTOs = _commentServices.GetAllCommentDTO();
            var articleCategory = new HomeIndexViewModel
            {
                Article = articleDTOs,
                Category = categoryTopDTOs,
                //Comment = commentDTOs

            };
            return View(articleCategory);
        }
        
    }
}