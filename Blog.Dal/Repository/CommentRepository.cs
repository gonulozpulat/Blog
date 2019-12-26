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
    }
}
