using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMVC.Interfaces;

namespace ToDoMVC.Model
{
    public class CategoryRepo : ICategoryRepos
    {
        private List<Category> _categories; 
        private static int ilosc = 0;
        private static int countWorks = 0; 
        public CategoryRepo()
        {
            _categories = new List<Category>();
            Work work = new Work() { Id = countWorks++, Name = "calki" };
            _categories.Add(new Category() { Id = ilosc++, Name="Matematyka", ToDo = new List<Work>() });
            _categories[0].ToDo.Add(work); 
        }

        public bool DeleteCategory(string name, string currentUser)
        {
            if (!_categories.Exists(w => w.Name == name && w.UserId == currentUser)) return false;
            _categories.Remove(_categories.First(w => w.Name == name));
            return true; 
        }

        public IEnumerable<Category> GetAllCategories(string userId)
        {
             return _categories.FindAll(w => w.UserId == userId);
        }

        public Category GetCategotyWorks(Category category, string user)
        {
            return _categories.First(w => w.Name == category.Name && w.UserId == user);
        }
        public bool AddCategory(Category category, string user)
        {
            if (_categories.Any(w => w.Name == category.Name && user == w.UserId)) return false;
            category.Id = ilosc++;
            category.UserId = user; 
            category.ToDo = new List<Work>(); 
            _categories.Add(category);
            return true; 
        }

        public Category GetCategotyWorks(string name, string userId)
        {
            if (_categories.Exists(w => w.Name == name && w.UserId == userId)) return _categories.First(w => w.Name == name && w.UserId == userId);
            return null; 
        }
        public Category GetCategotyWorks(int id, string userId)
        {
            if (_categories.Exists(w => w.Id == id && w.UserId == userId)) return _categories.First(w => w.Id == id && w.UserId == userId);
            return null;
        }

        public bool AddWorkToCategory(Work work, int idCategory)
        {
            if (!_categories.Exists(w => w.Id == idCategory)) return false;
            var toAdd = _categories.First(w => w.Id == idCategory).ToDo; 
            if (toAdd == null) toAdd = new List<Work>();
            toAdd.Add(work);
            return true; 
        }

        public bool RemoveWorkFromCategory(Work work, int idCategory)
        {
            if (!_categories.Exists(w => w.Id == idCategory)) return false;
            var toAdd = _categories.First(w => w.Id == idCategory).ToDo;
            if (toAdd == null) return false; 
            return _categories.First(w => w.Id == idCategory).ToDo.Remove(work);
        }

        public void EditCategory(Category category, string currentUser)
        {
            var toEdit = _categories.First(w => w.Id == category.Id && w.UserId == currentUser);
            toEdit.Name = category.Name; 
            
        }

        public void EditWork(int IdCategory, Work work)
        {
            var toEdit = _categories.First(w => w.Id == IdCategory).ToDo.First(w => w.Id == work.Id);
            toEdit.Name = work.Name;
            toEdit.TimeToDo = work.TimeToDo;
        }
    }
}
