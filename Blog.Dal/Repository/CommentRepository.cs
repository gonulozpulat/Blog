using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class CommentRepository
    {
        public List<Comment> GetAllComment()
        {
            List<Comment> comments;
            using (var database = new ProjectContext())
            {
                comments = database.Comments.Include("Article").ToList();
            }
            return comments;
        }
        public List<Comment> GetAllComment(int Id)
        {
            List<Comment> comments;
            using (var database = new ProjectContext())
            {
                comments = database.Comments.Include("Article").Where(i => i.ArticleId == Id).ToList();
            }
            return comments;
        }

        public Comment AddComment(Comment comment)
        {
            using(var database = new ProjectContext())
            {
                comment = database.Comments.Add(comment);
                database.SaveChanges();
            }
            return comment;
        }
    }
}
