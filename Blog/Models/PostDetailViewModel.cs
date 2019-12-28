using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;

namespace Blog.Models
{
    public class PostDetailViewModel
    {
        public PostDetailViewModel()
        {
            Article = new ArticleDTO();
            Comments = new List<CommentDTO>();
            Comment = new Comment();
        }
        public List<CommentDTO> Comments { get; set; }
        public ArticleDTO Article { get; set; }

        public Comment Comment { get; set; }
    }
}