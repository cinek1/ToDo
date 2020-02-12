using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Model
{
    public class Work
    {
        public int Id { set; get; } 
        public string Name { set; get; }
        public DateTime TimeToDo { set; get; }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Work p = (Work)obj;
                return (Name == p.Name);
            }
        }
    }
}
