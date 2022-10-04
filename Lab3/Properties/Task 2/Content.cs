using System;
namespace Lab3
{
    public class Content
    {
        public string content { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}