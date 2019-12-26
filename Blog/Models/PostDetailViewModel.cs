using Blog.Entities.DTO;
using System.Collections.Generic;

namespace Blog.Models
{
    public class PostDetailViewModel
    {
        public PostDetailViewModel()
        {
            Article = new ArticleDTO();
            Comments = new List<CommentDTO>();
        }
        public List<CommentDTO> Comments { get; set; }
        public ArticleDTO Article { get; set; }
    }
}