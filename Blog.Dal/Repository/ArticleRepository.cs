using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class ArticleRepository
    {
        public List<Article> GetAllArticles()
        {
            List<Article> articles;
            using(var database = new ProjectContext())
            {
                articles = database.Articles.Include("Category").ToList();
            }
            return articles;
        }


        public Article GetArticle(int Id)
        {
            Article article;
            using(var database = new ProjectContext())
            {
                article = database.Articles.Include("Category").ToList().FirstOrDefault(i => i.Id.Equals(Id));
            }
            return article;
        }

        public bool EditArticle(Article article)
        {
            using (var database = new ProjectContext())
            {
                database.Entry(article).State = EntityState.Modified;
                return database.SaveChanges() > 0;
            }
        }
    }
}
