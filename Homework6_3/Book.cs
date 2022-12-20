using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6_3
{
    class Book
    {
        string content = "Використовуючи Visual Studio, створіть проект за шаблоном Console Application.Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes, який дозволить зберігати нотатки читача.";
        public string Content { get { return content; } }

        public class Notes
        {
            //string notes { get; set; }
            public List<string> notesContent = new List<string>();

        }
    }
}
