using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMVC.Model; 

namespace ToDoMVC.Interfaces
{
    public interface ICategoryRepos
    {
        Category GetCategotyWorks(string name, string currentId);
        Category GetCategotyWorks(int id, string currentId);
        IEnumerable<Category> GetAllCategories(string currentId);
        bool AddCategory(Category category, string currentId); 
        bool DeleteCategory(string name, string currentId);
        bool AddWorkToCategory(Work work, int idCategory);
        bool RemoveWorkFromCategory(Work work, int idCategory);
        void EditCategory(Category category, string currentId);
        void EditWork(int IdCategory, Work work); 

    }
}
