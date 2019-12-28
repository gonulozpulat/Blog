using Blog.Entities.Entities;
using Blog.Services.Services;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactServices _contactServices;
        public ContactController()
        {
            _contactServices = new ContactServices();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Contact contact)
        {
            //Model geçersiz ise
            if (!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Geçersiz Bilgi Girişi");
                return View(contact);
            }
            _contactServices.Add(contact);
            return RedirectToAction(nameof(Index));
        }
    }
}