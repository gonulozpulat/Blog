using System.Collections.Generic;

namespace Blog.Entities.Entities
{
    public class Category
    {
        public Category()
        {
            Articles = new HashSet<Article>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePathUrl { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}