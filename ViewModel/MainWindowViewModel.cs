using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public class MainWindowViewModel
    {
        private readonly ItemHandler itemHandler;

        public MainWindowViewModel()
        {
            itemHandler = new ItemHandler();
            itemHandler.Add(new ToDoItem("Buy Milk","1",true));
            itemHandler.Add(new ToDoItem("Buy Cheese","2", false));
            itemHandler.Add(new ToDoItem("Take over the world","3", false));
        }

        public List<ToDoItem> ToDoItems
        {
            get { return itemHandler.ToDoItems; }
        }

    }
}
