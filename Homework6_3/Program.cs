using System;

namespace Homework6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Використовуючи Visual Studio, створіть проект за шаблоном
             * Console Application. Розширте приклад уроку 005_Book, 
             * створивши в класі Book вкладений клас Notes, 
             * який дозволить зберігати нотатки читача.*/


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Book book = new Book();
            Book.Notes notes = new Book.Notes();

            Console.WriteLine($"Зміст книги: \n{book.Content}");
            string userInput = "e";

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Оберіть варінт: " +
                    "\nДодати нотатку - 'y'" +
                    "\nПереглянути нотатки - 'r' " +
                    "\nВихід - 'e'");


                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "y":
                        Console.WriteLine("Введіть зміст нотатки:");
                        notes.notesContent.Add(Console.ReadLine());
                        Console.ResetColor();
                        Console.WriteLine("Нотатку додано");
                        break;
                    case "r":
                        Console.ResetColor();
                        if (notes.notesContent.Count != 0)
                        {
                            Console.WriteLine("Існуючі нотатки:");
                            foreach (var note in notes.notesContent)
                            {
                                Console.WriteLine(note);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нотатки відсутні");
                        }
                        break;
                    default:
                        Console.WriteLine(userInput.ToLower()=="e"?"Вихід":"Варіант не знайдено, спробуйте ще раз");
                        break;
                }

            } while (userInput != "e");

            Console.ReadKey();

        }
    }
}
