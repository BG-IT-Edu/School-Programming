namespace BookShop.Initializer.Generators
{
    using BookShop.Models;

    internal class AuthorGenerator
    {
        internal static Author[] CreateAuthors()
        {
            string[] authorNames = new string[]
            {
                "Nayden Vitanov",
                "Deyan Tanev",
                "Desislav Petkov",
                "Dyakon Hristov",
                "Milen Todorov",
                "Aleksander Kishishev",
                "Ilian Stoev",
                "Milen Balkanski",
                "Kostadin Nakov",
                "Petar Strashilov",
                "Bozhidara Valova",
                "Lyubina Kostova",
                "Radka Antonova",
                "Vladimira Blagoeva",
                "Bozhidara Rysinova",
                "Borislava Dimitrova",
                "Anelia Velichkova",
                "Violeta Kochanova",
                "Lyubov Ivanova",
                "Blagorodna Dineva",
                "Desislav Bachev",
                "Mihael Borisov",
                "Ventsislav Petrova",
                "Hristo Kirilov",
                "Penko Dachev",
                "Nikolai Zhelyaskov",
                "Petar Tsvetanov",
                "Spas Dimitrov",
                "Stanko Popov",
                "Miro Kochanov",
                "Pesho Stamatov",
                "Roger Porter",
                "Jeffrey Snyder",
                "Louis Coleman",
                "George Powell",
                "Jane Ortiz",
                "Randy Morales",
                "Lisa Davis",

            };

            int authorCount = authorNames.Length;

            Author[] authors = new Author[authorCount];

            for (int i = 0; i < authorCount; i++)
            {
                string[] authorNameTokens = authorNames[i].Split();

                Author author = new Author()
                {
                    FirstName = authorNameTokens[0],
                    LastName = authorNameTokens[1],
                };

                authors[i] = author;
            }

            return authors;
        }
    }
}