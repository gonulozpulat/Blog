using Blog.Entities.Entities;
using System;
using System.Collections.Generic;

namespace Blog.Entities.DTO
{
    public class ArticleDTO
    {
         public int Id { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleImagePathUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }

        public virtual List<Tag> TagList { get; set; }
    }
}
