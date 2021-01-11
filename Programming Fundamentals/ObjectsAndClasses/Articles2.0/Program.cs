using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for(int i = 0; i < index; i++)
            {
                List<string> text = Console.ReadLine()
                                              .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();
                Article article = new Article(text[0], text[1], text[2]);
                articles.Add(article);
            }
            string command = Console.ReadLine();
             
            switch (command.ToLower())
            {
                case "title":
                    articles=articles.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                   articles= articles.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                   articles= articles.OrderBy(a => a.Author).ToList();
                    break;
            }
            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
