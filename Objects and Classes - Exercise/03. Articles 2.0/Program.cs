namespace Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input;
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToList();

                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            foreach (Article articl in articles)
            {
                Console.WriteLine($"{articl.Title} - {articl.Content}: {articl.Author}");
            }
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
    }
}