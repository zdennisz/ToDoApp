using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{

    public class ItemHandler
    {
        public List<ToDoItem> ToDoItems { get; private set; }

        public ItemHandler()
        {
            ToDoItems = new List<ToDoItem>();
        }

        public void Add(ToDoItem item)
        {
            ToDoItems.Add(item);
        }
    }

    public class ToDoViewModel
    {
        private readonly ItemHandler itemHandler;

        public ToDoViewModel()
        {
            itemHandler = new ItemHandler();
            itemHandler.Add(new ToDoItem("Buy Milk"));
            itemHandler.Add(new ToDoItem("Buy Cheese"));
            itemHandler.Add(new ToDoItem("Take over the world"));
        }

        public List<ToDoItem> ToDoItems
        {
            get { return itemHandler.ToDoItems; }
        }

    }
}
