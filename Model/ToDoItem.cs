using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class ToDoItem
    {
        public string ToDoItemIndex { get; set; }
        public string ToDoItemName { get; set; }

        public bool ToDoItemChecked { get; set; }



        public ToDoItem(string name,string index,bool val)
        {
            ToDoItemName = name;
            ToDoItemIndex = index;
            ToDoItemChecked = val;
        }
    }
}
