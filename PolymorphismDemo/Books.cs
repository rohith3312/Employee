using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Books
    {
            public int book_ISBN;
            public string title;

            public Books(int isbn, string title)
            {
                this.book_ISBN = isbn;
                this.title = title;
            }
            public virtual void DislpayBookData()
            {
                Console.WriteLine("Book ISBN : " + book_ISBN + " Title : " + title);
            }
        }
 
}
