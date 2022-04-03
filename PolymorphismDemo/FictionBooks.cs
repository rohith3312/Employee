using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class FictionBooks:Books
    {
        public string genere;

        public FictionBooks(int isbn, string name, string genere)
            : base(isbn, name)
        {

            this.genere = genere;
        }
        public override void DislpayBookData()
        {
            Console.WriteLine("Book ISBN : " + book_ISBN + " Title : " + title);
            Console.WriteLine("Genere : " + genere);
        }
    }
}
