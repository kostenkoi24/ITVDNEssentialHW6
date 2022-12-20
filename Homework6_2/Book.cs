using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6_2
{
    class Book : FindAndReplaceManager
    {
        string content = "Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str) для пошуку за книгою з прикладу уроку 005_Book. При виклику цього методу проводиться послідовний пошук рядка в книзі.";

        public string Content { get { return content; } }
    }
}
