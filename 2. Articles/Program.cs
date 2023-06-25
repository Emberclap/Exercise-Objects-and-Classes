using System.Security.Cryptography.X509Certificates;

namespace _2._Articles
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ")
                .ToList();
            List<Article> articles = new List<Article>();
            Article article = new Article(input[0], input[1], input[2]);
            articles.Add(article);
            
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split(": ")
                    .ToList();
                switch (commands[0])
                {
                    case "Edit":
                        article.Edit(commands[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commands[1]);
                        break;
                    case "Rename":
                        article.Rename(commands[1]);
                        break;

                }

            }
            Console.WriteLine(article.ToString());

        }
    }
    class Article
    {
        public Article(string title, string content, string autor) 
        {
            Title = title;
            Content = content;
            Author = autor;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}