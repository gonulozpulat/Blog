using Blog.Entities.DTO;
using System.Collections.Generic;

namespace Blog.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            Article = new List<ArticleDTO>();
            Category = new List<CategoryDTO>();
        }
        public List<ArticleDTO> Article { get; set; }
        public List<CategoryDTO> Category { get; set; }
    }
}