using System;
using System.Collections.Generic;

namespace Blog.Entities.Entities
{
    public class Article
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePathUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}