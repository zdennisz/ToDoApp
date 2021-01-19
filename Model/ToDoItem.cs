using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class ToDoItem
    {
        public string ToDoItemName { get; set; }
        
        public ToDoItem(string name)
        {
            ToDoItemName = name;
        }
    }
}
