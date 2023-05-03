using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Infrastructure.IRepository;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategory _services;

        public CategoryController(ICategory services)
        {



            _services = services;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            CategoryInfoModel model = new CategoryInfoModel();
            model.CategoriesList = _services.GetCategoryData();
            return View(model);
        }

        // GET: CategoryController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            CategoryInfo model = new CategoryInfo();
            model = _services.GetCategoryById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult AddEditcategory(int id)
        {
            CategoryInfo model = new CategoryInfo();
            model = _services.GetCategoryById(id);
            if (model == null)
            {

            return View();
            }
            else
            {
                return View(model);

            }
        }

        // POST: CategoryController/Create
        [HttpPost] 
        public ActionResult Create(CategoryInfo infomodel)
        {
            CategoryInfo model = new CategoryInfo();

            try
            {
           
                    model = _services.AddCategory(infomodel);
                if (model.TotalRowCount > 0)
                {

                return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View();
            }
        }

      

        [HttpGet]
        public ActionResult Delete(int id)
        {
            CategoryInfo model = new CategoryInfo();

            try
            {

                model = _services.DeleteCategory(id);
                if (model.TotalRowCount > 0)
                {

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
