using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace здд1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
        {
            new Book { Title = "a", Price = 15 },
            new Book { Title = "Гарри Потер", Price = 12 },
            new Book { Title = "Мастер и Маргарита", Price = 10 },
            new Book { Title = "Вии", Price = 14 },
            new Book { Title = "Преступление и наказание", Price = 11 }
        };

            books.Sort();

            foreach (var book in books)
            {
                Console.WriteLine($"Название: {book.Title}, Цена:{book.Price}");
            }
            Console.ReadKey();
        }
        
    }
    
}
  