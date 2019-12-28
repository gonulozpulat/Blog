using Blog.Entities.DTO;
using Blog.Entities.Entities;
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
            //CommentDTO commentDTO = _articleServices.Get(Id);
            List<CommentDTO> commentDTOs = _commentServices.GetAllCommentDTO(Id);
            var model = new PostDetailViewModel
            {
                Article = articleDTO,
                Comments = commentDTOs
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Geçersiz Bilgi Girişi");
                return View(comment);
            }

            _commentServices.AddComment(comment);
            return RedirectToAction(nameof(Index));
        }
        

    }
}