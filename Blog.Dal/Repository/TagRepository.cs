using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class TagRepository
    {
        public List<Tag> GetAllTag()
        {
            List<Tag> tags;
            using (var database = new ProjectContext())
            {
                tags = database.Tags.Include("Article").ToList();
            }
            return tags;
        }

    }
}
