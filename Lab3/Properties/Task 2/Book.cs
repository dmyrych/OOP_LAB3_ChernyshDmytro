using System;
namespace Lab3
{
    public class Book
    {
        public Author Author { get; set; } = new Author() {author = "Роберт Гайнлайн" };
        public Title Title { get; set; } = new Title() { title = "Зоряний десант" };
        public Content Content { get; set; } = new Content()
        {
            content = "«Зоряний десант» — один з найбільш суперечливих " +
            "і неоднозначних творів Гайнлайна: попри захопливий сюжет, у романі обговорюється ряд серйозних політичних і соціальних питань. " +
            "Деякі критики звинувачували Гайнлайна у пропаганді фашизму та мілітаризму. " +
            "1960 року роман удостоєний премії «Г'юго», а 1997 року в полемічній манері екранізовано режисером Полом Верховеном. " +
            "Режисер радикально змістив акценти, залишивши незмінними лише імена героїв та деякі сюжетні ходи."
        };
        public Book()
        {

        }
        public Book(string authorName, string bookName, string words)
        {
            Author.author = authorName;
            Title.title = bookName;
            Content.content = words;
        }
        public void Show()
        {
            Author.Show();
            Title.Show();
            Content.Show();
        }
    }
}
