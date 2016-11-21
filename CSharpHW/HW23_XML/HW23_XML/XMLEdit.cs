using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace HW23_XML
{
    internal class XmlEdit
    {
        public void AddBook(Book book)
        {
                var bookAdd = XDocument.Load("Books.xml");
                var root = bookAdd.Element("catalog");
                root.Add( new XElement("book",
                          new XElement("author", book.Author),
                          new XElement("title", book.Name),
                          new XElement("year", book.Year),
                          new XElement("price", book.Price),
                          new XElement("description", book.Description)));
                bookAdd.Save("Books.xml");                              
        }

        public List<Book> GetBooks(int chose, string criteria)
        {
            Predicate<XElement> part;
            switch (chose)
            {
                case 0:
                    part = xElement => true;
                    break;
                case 1:
                    part = xElement => ((string)xElement.Element("price")) == criteria;
                    break;
                case 2:
                    part = xElement => ((string)xElement.Element("year")) == criteria;
                    break;
                case 3:
                    part = xElement => ((string)xElement.Element("author")) == criteria;
                    break;
                default:
                    part = xElement => false;                                
                    break;
            }
                        
             var bookDoc = XDocument.Load("Books.xml");
             var root = bookDoc.Element("catalog");

             var books = (root.Descendants("book")).Where(book => part(book)).Select(book => new Book
             {
                 Name = (string) book.Element("title"),
                 Year = (string) book.Element("year"),
                 Price = (string) book.Element("price"),
                 Author = (string) book.Element("author"),
                 Description = (string) book.Element("description")
             });
             return books.ToList();
                              
        }
    }
}
