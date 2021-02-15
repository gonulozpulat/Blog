using Blog.Entities.Entities;
using System.Collections.Generic;

namespace Blog.Entities.DTO
{
    public class TagDTO
    {
        public string TagName { get; set; }
        public virtual List<Article> ArticleList { get; set; }

    }
}
