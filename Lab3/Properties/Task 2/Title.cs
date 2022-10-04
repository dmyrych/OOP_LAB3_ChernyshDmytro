using System;
namespace Lab3
{
    public class Title
    {
        public string title { get; set; }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Назва книги - {title}");
            Console.ResetColor();
        }
    }
}