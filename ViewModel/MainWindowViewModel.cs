using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ToDoApp
{

    public class ItemHandler
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; private set; }

        public ItemHandler()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
        }

        public void Add(ToDoItem item)
        {
            ToDoItems.Add(item);
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {

        private readonly ItemHandler itemHandler;

        public MainWindowViewModel()
        {
            itemHandler = new ItemHandler();
            itemHandler.Add(new ToDoItem("Buy Milk","1",true));
            itemHandler.Add(new ToDoItem("Buy Cheese","2", false));
            itemHandler.Add(new ToDoItem("Take over the world","3", false));
        }

        public ObservableCollection<ToDoItem> ToDoItems
        {
            get { return itemHandler.ToDoItems; }
        }

        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
