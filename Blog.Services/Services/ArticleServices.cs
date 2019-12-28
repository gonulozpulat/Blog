using Blog.Dal.Repository;
using Blog.Entities.DTO;
using System.Collections.Generic;
using Blog.Helpers.Extensions;
using Blog.Entities.Entities;
using System;
using System.Configuration;
using System.Linq;

namespace Blog.Services.Services
{
    public class ArticleServices
    {
        private readonly ArticleRepository _articleRepository;

        private static int _rowNumber;

        public ArticleServices()
        {
            _articleRepository = new ArticleRepository();
            _rowNumber = Convert.ToInt32(ConfigurationManager.AppSettings["TopRowNumberNew"]);
        }

        public List<ArticleDTO> GetAllArticlesDTO()
        {
            List<Article> article = _articleRepository.GetAllArticles();
            List<ArticleDTO> articleDTO = article.GetAllArticleDTO();
            return articleDTO;
        }       

        public List<ArticleDTO> GetTopArticleDTO()
        {
            List<Article> articles = _articleRepository.GetAllArticles();
            List<ArticleDTO> articleDTO = articles.Take(_rowNumber).GetAllArticleDTO();
            return articleDTO;
        }

        public ArticleDTO GetArticleDTO(int Id)
        {
            if (Id < 0)
                return null;

            Article article = _articleRepository.GetArticle(Id);
            ArticleDTO articleDTO = article.GetArticleDTO();
            return articleDTO;
        }
    }

}
