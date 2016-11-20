using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace HW23_XML
{
    public partial class MainWindow : Window
    {
        private readonly XmlEdit _library = new XmlEdit();
        public MainWindow()
        {
            InitializeComponent();

            var options = new List<string> {"Show All book", "Price", "Year", "Author"};
            searchAtribute.ItemsSource = options;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
           
            var books = _library.GetBooks((XmlEdit.Chose)searchAtribute.SelectedIndex, searchText.Text);
            var output = books.Aggregate(string.Empty, (current, book) =>
                                                                        current + ("Name: " + book.Name + "\nAuthor: " + book.Author +
                                                                        "\nYear: " + book.Year + "\nPrice: " + book.Price + 
                                                                        "\nDescription: " + book.Description + "\n\n"));

            if (output == string.Empty)
                MessageBox.Show("We found nothing");

            ShowPlace.Text = output;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (title.Text == string.Empty)
                MessageBox.Show("Name required");
            else
            {
                if (year.Text == string.Empty)
                    MessageBox.Show("Year required");
                else
                {
                    if (price.Text == string.Empty)
                        MessageBox.Show("Price required");
                    else
                    {
                        if (author.Text == string.Empty)
                            MessageBox.Show("Author required");
                        else
                        {
                            if (description.Text == string.Empty)
                                MessageBox.Show("Description required");
                            else
                            {
                                var b = new Book
                                {
                                    Name = title.Text,
                                    Year = year.Text,
                                    Price = price.Text,
                                    Author = author.Text,
                                    Description = description.Text
                                };
                                _library.AddBook(b);
                                MessageBox.Show("Successful");
                            }
                        }
                    }
                }
            }
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
