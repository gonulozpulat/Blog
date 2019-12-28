using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Helpers.Extensions
{
    public static class TagExtensions
    {
        public static List<TagDTO> GetTagDTO(this IEnumerable<Tag> tags)
        {
            var tagDTO = tags.Select(tag => new TagDTO
            {
                TagName = tag.Name,
                ArticleList = tag.Articles.ToList()
            }).ToList();
            return tagDTO;
        }
    }
}
