using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoMVC.Interfaces;
using ToDoMVC.Model;


namespace ToDoMVC.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private ICategoryRepos _categoryRepos;
        private string currentIDUser;

        public CategoriesController(ICategoryRepos categoryRepos, IHttpContextAccessor httpContextAccessor)
        {
            _categoryRepos = categoryRepos;
            currentIDUser = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
        public IActionResult Index()
        {
            return View(_categoryRepos.GetAllCategories(currentIDUser));
        }

        public IActionResult Edit(int id)
        {
            return View(_categoryRepos.GetCategotyWorks(id, currentIDUser));
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _categoryRepos.EditCategory(category, currentIDUser);
            return RedirectToAction("Index"); 
        }


        public IActionResult Delete(int id)
        {
            var category = _categoryRepos.GetCategotyWorks(id, currentIDUser);
            _categoryRepos.DeleteCategory(category.Name, currentIDUser);
            return RedirectToAction("Index"); 
        }
        public IActionResult Add()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryRepos.AddCategory(category, currentIDUser);
            return RedirectToAction("Index"); 
        }

        public IActionResult Create()
        {
            return View(); 
        }
    }
}