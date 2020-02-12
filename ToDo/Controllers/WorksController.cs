using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoMVC.Interfaces;
using ToDoMVC.Model; 

namespace ToDoMVC.Controllers
{
    [Authorize]
    public class WorksController : Controller
    {
        private ICategoryRepos _categoryRepos;
        private string currentUser; 
        private static int idCategory; 
        public WorksController(ICategoryRepos categoryRepos, IHttpContextAccessor httpContextAccessor)
        {
            _categoryRepos = categoryRepos;
            currentUser = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value; ;
        }
        public IActionResult Index(int id)
        {
            idCategory = id; 
            return View(_categoryRepos.GetCategotyWorks(id, currentUser).ToDo);
        }
        public IActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Create(Work work)
        {
            _categoryRepos.AddWorkToCategory(work, _categoryRepos.GetCategotyWorks(idCategory, currentUser).Id);
            return RedirectToAction("Index", new { id = idCategory });
        }
        public IActionResult Edit(int id)
        {
            var toEdit = _categoryRepos.GetCategotyWorks(idCategory, currentUser);
            return View(toEdit.ToDo.First(w => w.Id == id)); 
        }
        [HttpPost]
        public IActionResult Edit(Work work)
        {
            _categoryRepos.EditWork(idCategory, work);
            return RedirectToAction("Index", new { id = idCategory });
        }

        public IActionResult Delete(int id)
        {

            var toEdit = _categoryRepos.GetCategotyWorks(idCategory, currentUser).ToDo.First(w => w.Id == id);
            var categoryId = _categoryRepos.GetCategotyWorks(idCategory, currentUser).Id; 
            _categoryRepos.RemoveWorkFromCategory(toEdit, categoryId);
            return RedirectToAction("Index", new { id = idCategory }); 
        }
    }
}