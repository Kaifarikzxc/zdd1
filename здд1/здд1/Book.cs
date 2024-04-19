using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace здд1
{
    class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Price { get; set; }

        public int CompareTo(Book book1)
        {
            return string.Compare(this.Title, book1.Title);
        }
    }
}

