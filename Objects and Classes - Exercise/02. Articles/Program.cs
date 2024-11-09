namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
Fight club, love story, Martin Scorsese
2
Edit: underground fight club that evolves into much more
ChangeAuthor: Chuck Palahniuk
             */

            List<string> input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            List<Article> articles = new List<Article>(input.Count);
            int n = int.Parse(Console.ReadLine());

            string title = input[0];
            string content = input[1];
            string author = input[2];
            string[] command;
           
            Article article = new Article(title, content, author);
            articles.Add(article);
            
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine()
                    .Split(':')
                    .Select(c => c.Trim())
                    .ToArray();

                if (command[0] == "Edit")
                {
                    string newContent = command[1];
                    article.Content = newContent;
                }
                else if (command[0] == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    article.Author = newAuthor;
                }
                else
                {
                    string newTitle = command[1];
                    article.Title = newTitle;
                }
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

        public Article(string title,string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
    }
}