using System;

namespace Homework6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Book book = new Book();

            Console.WriteLine($"Зміст книги: \n{book.Content}");

            Console.WriteLine("\nВведіть слово для пошуку:");
            book.FindNext(Console.ReadLine(), book);

            Console.ReadKey();
        }
    }
}
