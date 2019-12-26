using System.Collections.Generic;

namespace Blog.Entities.Entities
{
    public class Tag
    {
        public Tag()
        {
            Articles = new HashSet<Article>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
