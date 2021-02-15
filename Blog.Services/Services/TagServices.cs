using Blog.Dal.Repository;
using Blog.Entities.DTO;
using Blog.Entities.Entities;
using Blog.Helpers.Extensions;
using System.Collections.Generic;

namespace Blog.Services.Services
{
    public class TagServices
    {
        private readonly TagRepository _tagRepository;

        public TagServices()
        {
            _tagRepository = new TagRepository();
        }

        public List<TagDTO> GetAllTagDTO()
        {
            List<Tag> tags = _tagRepository.GetAllTag();
            List<TagDTO> tagDTOs = tags.GetTagDTO();
            return tagDTOs;
        }
    }
}
