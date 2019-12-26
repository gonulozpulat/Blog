using Blog.Entities.DTO;
using Blog.Services.Services;

using System.Web.Mvc;

namespace Blog.Controllers
{
    public class AboutController : Controller
    {
        private readonly AboutServices _aboutServices;
        public AboutController()
        {
            _aboutServices = new AboutServices();
        }
        [HttpGet]
        [OutputCache(Duration = 100)]
        public ActionResult Index()
        {
            AboutDTO aboutDTO = _aboutServices.GetAboutDTO();
            return View(aboutDTO);
        }
    }
}