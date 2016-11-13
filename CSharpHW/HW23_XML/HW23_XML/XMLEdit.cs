using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace HW23_XML
{
    class XMLEdit
    {
        public enum Chose { All,Price, Year, Author }
        public void AddBook(Book b)
        {
                XDocument bookAdd = XDocument.Load("Books.xml");
                XElement root = bookAdd.Element("catalog");
                root.Add(new XElement("book",
                                           new XElement("author", b.Author),
                                           new XElement("title", b.Name),
                                           new XElement("year", b.Year),
                                           new XElement("price", b.Price),
                                           new XElement("description", b.Description)));

                bookAdd.Save("Books.xml");                              
        }

        public List<Book> GetBooks(Chose chose, string criteria = "")
        {
            Predicate<XElement> part;
            switch (chose)
            {
                case Chose.All:
                    part = new Predicate<XElement>(b => true);
                    break;
               case Chose.Price:
                    part = new Predicate<XElement>(b => { if (((string)b.Element("price")) == criteria) return true;
                                                         return false;
                                                         });
                    break;
                case Chose.Year:
                    part = new Predicate<XElement>(b => { if (((string)b.Element("year")) == criteria)  return true;
                                                         return false;
                                                         });
                    break;
                case Chose.Author:
                    part = new Predicate<XElement>(b => { if (((string)b.Element("author")) == criteria) return true;
                                                         return false;
                                                         });
                    break;

                default:
                    part = new Predicate<XElement>(b => false);                                
                    break;
            }
                        
             XDocument bookDoc = XDocument.Load("Books.xml");
             XElement root = bookDoc.Element("catalog");

                var books = from book in root.Descendants("book")
                            where part(book)
                            select new Book {
                                            Name = (string)book.Element("title"),
                                            Year = (string)book.Element("year"),
                                            Price = (string)book.Element("price"),
                                            Author = (string)book.Element("author"),
                                            Description = (string)book.Element("description")
                                            };

             return books.ToList();
                              
        }
    }
}
