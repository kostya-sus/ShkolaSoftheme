using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows;


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
            var books = _library.GetBooks(searchAtribute.SelectedIndex, searchText.Text);
            var output = books.Aggregate(string.Empty, (current, book) =>current + ("Name: " + book.Name + "\nAuthor: " + book.Author +
                                                                        "\nYear: " + book.Year + "\nPrice: " + book.Price + 
                                                                        "\nDescription: " + book.Description + "\n\n"));
            if (output == string.Empty)
                MessageBox.Show("We found nothing");
            ShowPlace.Text = output;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var book = new Book
            {
                Name = title.Text,
                Year = year.Text,
                Price = price.Text,
                Author = author.Text,
                Description = description.Text
            };
            var results = new List<ValidationResult>();
            var context = new ValidationContext(book);

            if (!Validator.TryValidateObject(book, context, results, true))
                foreach (var error in results)
                    MessageBox.Show(error.ErrorMessage);
            else
            {
                MessageBox.Show("Successful. Book add");
                _library.AddBook(book);
            }
        }
    }
}
