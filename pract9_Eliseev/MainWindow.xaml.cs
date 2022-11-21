using System;
using System.Collections.Generic;
using System.Data;
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

namespace pract9_Eliseev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Literature> books = new List<Literature>(); //?
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            books.Add(new Literature(titleText.Text, authorText.Text, publisherText.Text));
            literatureGrid.ItemsSource = null;
            literatureGrid.ItemsSource = books;
            
        }
        private void search_Click(object sender, RoutedEventArgs e)
        {
            var foundBooks = new StringBuilder();
            foreach (var item in books)
            {
                if (item.Publisher == searchQuery.Text)
                {
                    foundBooks.AppendLine(item.Title);
                }
            }
            MessageBox.Show(foundBooks.ToString());
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = literatureGrid.SelectedIndex;
            books.RemoveAt(selectedBook);
            literatureGrid.ItemsSource = null;
            literatureGrid.ItemsSource = books;
        }
    }
}
/// ЗАЩИТА, ОБНОВЛЕНИЕ datagrid
