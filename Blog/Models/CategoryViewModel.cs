using Blog.Entities.DTO;
using System.Collections.Generic;

namespace Blog.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Article = new List<ArticleDTO>();
        }
        public CategoryDTO Category { get; set; }
        public List<ArticleDTO> Article { get; set; }
    }
}