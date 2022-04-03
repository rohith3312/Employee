using System;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Books bookObj = new FictionBooks(11, "ABC", "Fiction");
            bookObj.DislpayBookData();

            bookObj = new NonFictionBooks(12, "XYZ", "Non Fiction");
            bookObj.DislpayBookData();
        }
    }
}
