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
    public class ArticleController : Controller
    {
        private readonly CommentServices _commentServices;
        private readonly ArticleServices _articleServices;

        public ArticleController()
        {
            _commentServices = new CommentServices();
            _articleServices = new ArticleServices();

        }
        // GET: Article
        public ActionResult Index(int Id)
        {
            ArticleDTO articleDTO = _articleServices.GetArticleDTO(Id);
            List<CommentDTO> commentDTOs = _commentServices.GetAllCommentDTO();
            var model = new PostDetailViewModel
            {
                Article = articleDTO,
                Comments = commentDTOs
            };
            return View(model);
        }
    }
}