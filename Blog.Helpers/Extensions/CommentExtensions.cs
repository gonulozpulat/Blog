﻿using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Helpers.Extensions
{
    public static class CommentExtensions
    {
        public static List<CommentDTO> GetAllCommentDTOs(this IEnumerable<Comment> comments)
        {
            var commentDTO = comments.Select(comment => new CommentDTO
            {
                Name = comment.Name,
                Surname = comment.Surname,
                Email = comment.Email,
                Message = comment.Message,
                ArticleId = comment.Article.CategoryId,
            }).ToList();
            return commentDTO;
        }
    }
}
