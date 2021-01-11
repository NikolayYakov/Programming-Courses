using System;
using System.Net.NetworkInformation;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                                   .Split(", ");

            Article article = new Article(text[0],text[1],text[2]);
            int index = int.Parse(Console.ReadLine());
            for(int i = 0; i < index; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split(": ");
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public Article(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
