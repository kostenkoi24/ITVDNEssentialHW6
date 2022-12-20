using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6_2
{
    class FindAndReplaceManager
    {

        public void FindNext(string str,  Book book)
        {
            if (book.Content.ToLower().Contains(str.ToLower()) == true)
            {
                
                int position = book.Content.ToLower().IndexOf(str.ToLower());

                Console.WriteLine($" '{str}' знайдено");
                Console.WriteLine($"Позиція '{str}' = {position} ");

                                
                string[] contentArray = book.Content.Split(' ');

                for (int i = 0; i < contentArray.Length; i++)
                {
                    if (contentArray[i].ToLower().Contains( str.ToLower()) == true  )
                    {
                        Console.WriteLine($"Позиція {str} у масиві {i+1}");
                        break;
                    }
                }


            }
            else
            {
                Console.WriteLine($"{str} не знайдено");
            }
        }
    }
}
