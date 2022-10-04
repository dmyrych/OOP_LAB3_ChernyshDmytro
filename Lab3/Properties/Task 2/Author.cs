using System;
namespace Lab3
{
    public class Author
    {
        public string author { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автором є {author}");
            Console.ResetColor();
        }
    }
}
