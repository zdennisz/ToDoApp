using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoApp.View;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AddNewToDo addNewToDO;
        private readonly MainWindowViewModel toDoViewModel;
        public MainWindow()
        {
            InitializeComponent();
            toDoViewModel=new MainWindowViewModel();
            DataContext = toDoViewModel;  
        }

        private void btnAddNewToDo(object sender, RoutedEventArgs e)
        {

            addNewToDO = new AddNewToDo();
            addNewToDO.Show();

        }
    }
}
