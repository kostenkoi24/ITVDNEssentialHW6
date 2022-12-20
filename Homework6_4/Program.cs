using System;

namespace Homework6_4
{

    static class ExtensionClass
    {
        public static void SortArrayAsc(this int[] Array, int[] myArray)
        {
             for (int i = 0; i < myArray.Length; i++)
            {
                int t;

                for (int j = i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        //{ 6, 2, 3, 4, 7, 1, 5 }
                        t = myArray[j ];
                        myArray[j] = myArray[i];
                        myArray[i] = t;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Використовуючи Visual Studio, створіть проект" +
                " за шаблоном Console Application. Потрібно: створити розширюючий" +
                " метод для цілого масиву, який сортує елементи масиву за зростанням. ");


            int[] myArray = new int[] { 6, 2, 3, 4, 7, 1, 5 }; 

            
            Console.WriteLine("Array before sort {0}", string.Join(",", myArray)); 

            myArray.SortArrayAsc(myArray);

            Console.WriteLine("Array after sort {0}", string.Join(",", myArray));

            Console.ReadKey();
        }
    }
}
