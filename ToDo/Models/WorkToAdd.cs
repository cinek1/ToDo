using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Model
{
    public class WorkToAdd
    {
        public string CategoryName { set; get; }
        public Work work { set; get; }
    }
}
