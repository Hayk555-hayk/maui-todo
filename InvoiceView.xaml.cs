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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoApp.Data;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for InvoiceView.xaml
    /// </summary>
    public partial class InvoiceView : UserControl
    {
        public InvoiceView(User user)
        {
            InitializeComponent();
            this.DataContext = user;
        }

        private void AddToDoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = ToDoInput.Text;

            if (string.IsNullOrEmpty(todoText))
            {
                return;
            }

            TextBlock todoItem = new TextBlock
            {
                Text = todoText,
                Margin = new Thickness(10)
            };

            ToDoList.Children.Add(todoItem);

            ToDoInput.Clear();
        }
    }
}
