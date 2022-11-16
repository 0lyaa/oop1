using System;

namespace Laba3
{
    public class Program
    {
        public static void Main()
        {
            Book book = new Book(new Title("Harry Potter"), new Author("Joanne Rowling"), new Content("Fantasy, adventure"));
            book.Show();
        }
    }
}