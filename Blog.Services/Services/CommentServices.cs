using Blog.Dal.Repository;
using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using Blog.Helpers.Extensions;

namespace Blog.Services.Services
{   
    
    public class CommentServices
    {
        private readonly CommentRepository _commentRepository;

        public CommentServices()
        {
            _commentRepository = new CommentRepository();
        }
        //Home Index Method
        public List<CommentDTO> GetAllCommentDTO()
        {
            List<Comment> article = _commentRepository.GetAllComment();
            List<CommentDTO> articleDTO = article.GetAllCommentDTOs();
            return articleDTO;
        }
        //Article Index Method
        public List<CommentDTO> GetAllCommentDTO(int Id)
        {
            List<Comment> article = _commentRepository.GetAllComment(Id);
            List<CommentDTO> articleDTO = article.GetAllCommentDTOs();
            return articleDTO;
        }
    }
}
