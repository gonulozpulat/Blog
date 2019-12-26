using Blog.Entities.DTO;
using Blog.Entities.Entities;

namespace Blog.Helpers.Extensions
{
    public static class AboutExtensions
    {
        public static AboutDTO GetAboutDTO(this About about)
        {
            var aboutDTO = new AboutDTO
            {
                AboutContent = about.Content,
                AboutTitle = about.Title,
                AboutImagePathUrl = about.ImagePathUrl
            };
            return aboutDTO;
        }
    }
}
