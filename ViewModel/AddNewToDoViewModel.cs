using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.ViewModel
{
    class AddNewToDoViewModel: INotifyPropertyChanged
    {
        private string newToDo;
        public string NewToDoName { get { return newToDo; } set { newToDo = value; } }


        public AddNewToDoViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
