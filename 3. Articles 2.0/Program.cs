using System.Security.Cryptography.X509Certificates;

namespace _2._Articles
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split(", ")
                    .ToList();
                Article article = new Article(input);

                Console.WriteLine(article.ToString());
            }
        }
    }
    class Article
    {
        public Article(List<string> articles)
        {
            Articles = articles;
        }
        public List<string> Articles { get; set; }
        public override string ToString()
        {
            return $"{Articles[0]} - {Articles[1]}: {Articles[2]}";
        }

    }
}