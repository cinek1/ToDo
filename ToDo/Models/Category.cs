using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Model
{
    public class Category
    {
        public int Id { set; get; } 
        public string UserId { get; set; }
        public string Name { set; get; }
        public List<Work> ToDo { set; get;} 
    }
}
