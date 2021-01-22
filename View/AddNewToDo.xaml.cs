using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ToDoApp.ViewModel;

namespace ToDoApp.View
{
    /// <summary>
    /// Interaction logic for AddNewToDo.xaml
    /// </summary>
    public partial class AddNewToDo : Window
    {
        private readonly AddNewToDoViewModel addNewToDoViewModel;
        public AddNewToDo()
        {
            InitializeComponent();
            addNewToDoViewModel = new AddNewToDoViewModel();
            DataContext = addNewToDoViewModel;
          
        }

        private void AddNewItem(object sender, RoutedEventArgs e)
        {
            // add new item to the list 
            //and close the window
            this.Close();
        }

        private void btn_CloseNewWindow(object sender, RoutedEventArgs e)
        {
            //close the window
            this.Close();
        }
    }
}
