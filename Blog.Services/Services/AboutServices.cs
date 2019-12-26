using Blog.Dal.Repository;
using Blog.Entities.DTO;
using Blog.Helpers.Extensions;

namespace Blog.Services.Services
{
    public class AboutServices
    {
        private readonly AboutRepository _aboutRepository;

        public AboutServices()
        {
            _aboutRepository = new AboutRepository();
        }

        public AboutDTO GetAboutDTO()
        {
            var about = _aboutRepository.GetAbout();
            var aboutDTO = about.GetAboutDTO();
            return aboutDTO;
        }

    }
}
