using Blog.Entities.DTO;
using Blog.Entities.Entities;
using Blog.Helpers.Extensions;
using Blog.Services.Services;
using System.Web.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryServices _categoryServices;

        public CategoryController()
        {
            _categoryServices = new CategoryServices();
        }
        // GET: Admin/CategoryList
        [HttpGet]
        public ActionResult Index()
        {
            var categories = _categoryServices.GetAllCategories();
            return View(categories);
        }

        //CategoryEditDetail Get
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = _categoryServices.GetCategory(id);

            if (category == null)
                return HttpNotFound();

            return View(category.GetCategoryDto());
        }

        //CategoryEdit Detail Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategoryDTO categoryDto)
        {
            if (id != categoryDto.Id)
                return new HttpNotFoundResult();

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Gerekli alanları doldurun!");
                return View();
            }

            var category = categoryDto.GetCategory();
            _categoryServices.EditCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Geçersiz Bilgi Girişi");
                return View(category);
            }
            _categoryServices.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        

    }
}