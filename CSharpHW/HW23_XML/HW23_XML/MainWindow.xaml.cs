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

namespace HW23_XML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private XMLEdit _library = new XMLEdit();
        public MainWindow()
        {
            InitializeComponent();

            List<string> options = new List<string>();
            options.Add("Show All book");
            options.Add("Price");
            options.Add("Year");
            options.Add("Author");
         
            searchAtribute.ItemsSource = options;
            

            
            
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
           
             List<Book> books = _library.GetBooks((XMLEdit.Chose)searchAtribute.SelectedIndex, searchText.Text);


            string output = string.Empty;
            foreach (var book in books)
            {
                output += "Name: " + book.Name  + "\nAuthor: " + book.Author + 
                    "\nYear: " + book.Year + "\nPrice: " + book.Price +
                    "\n" + "Description: " + book.Description + "\n\n";
            }

            if (output == string.Empty)
                MessageBox.Show("We found nothing");
                

            ShowPlace.Text = output;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Book b = new Book  {
                              Name = title.Text,
                              Year = year.Text,
                              Price = price.Text,
                              Author = author.Text,
                              Description = description.Text
                               };
             _library.AddBook(b);
            MessageBox.Show("Successful");
           
        }

        private void searchAtribute_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (searchAtribute.SelectedIndex == 0)
            {
                searchText.IsReadOnly = true;
                searchText.Text = string.Empty;
            }
            else
                searchText.IsReadOnly = false;
        }


    }
}
