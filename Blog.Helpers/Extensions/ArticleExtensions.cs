using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Helpers.Extensions
{
    public static class ArticleExtensions
    {
        public static List<ArticleDTO> GetAllArticleDTO(this IEnumerable<Article> articles)
        {
            var articleDTO = articles.Select(article => new ArticleDTO
            {

                Id = article.Id,
                ArticleTitle = article.Title,
                ArticleDescription = article.Content,
                ArticleImagePathUrl = article.ImagePathUrl,
                CreatedDate = article.CreatedDate,
                CategoryName = article.Category.Name,
                CategoryId = article.CategoryId
                
            }).ToList();

            return articleDTO;
        }

        public static ArticleDTO GetArticleDTO(this Article article)
        {
            var articleDTO = new ArticleDTO
            {
                Id = article.Id,
                ArticleTitle = article.Title,
                ArticleDescription = article.Content,
                ArticleImagePathUrl = article.ImagePathUrl,
                CreatedDate = article.CreatedDate,
                CategoryName = article.Category.Name,
                CategoryId = article.Category.Id
            };
            return articleDTO;
        }


    }
}
