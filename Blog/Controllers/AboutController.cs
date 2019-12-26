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
        // GET: About
        public ActionResult Index()
        {
            AboutDTO aboutDTO = _aboutServices.GetAboutDTO();
            return View(aboutDTO);
        }
    }
}