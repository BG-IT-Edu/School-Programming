using BookShop.Models.Enums;

namespace BookShop.Initializer.Generators
{
    using BookShop.Models;
    using System;
    using System.Globalization;

    class BookGenerator
    {
        #region Book Description
        private static string bookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
            "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris " +
            "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit " +
            "in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
            "Excepteur sint occaecat cupidatat non proident, " +
            "sunt in culpa qui officia deserunt mollit anim id est laborum.";
        #endregion

        internal static Book[] CreateBooks()
        {
            string[] booksInput = new string[]
            {
                //Edition ReleaseDate Copies Price AgeRestriction Title
                "1 20/01/1998 27274 15.31 2 Absalom",
                "0 14/09/1998 16159 35.56 0 After Many a Summer Dies the Swan",
                "0 13/03/1999 29025 23.71 0 Ah",
                "2 12/3/1993 9998 5.26 2 Wilderness!",
                "2 22/10/2014 18832 5.69 2 Alien CornÂ (play)",
                "0 18/02/2003 28741 34.56 2 The Alien CornÂ (short story)",
                "1 11/10/1991 20471 7.18 1 All Passion Spent",
                "2 29/03/1996 9457 45.6 0 All the King's Men",
                "2 30/11/2000 17327 14.99 0 Alone on a Wide",
                "0 23/04/1998 3226 24.37 1 Wide Sea",
                "1 8/3/1996 6171 34.64 2 An Acceptable Time",
                "2 7/9/2005 10049 38.51 1 Antic Hay",
                "1 10/10/1996 21765 3.3 0 An Evil Cradling",
                "0 24/01/2001 2408 24.4 0 Arms and the Man",
                "1 25/04/1992 2997 25.81 2 As I Lay Dying",
                "1 25/09/2006 29543 20.21 2 A Time to Kill",
                "2 28/10/2011 4893 18.01 0 Behold the Man",
                "1 23/08/2012 8159 23.83 2 Beneath the Bleeding",
                "2 17/05/2006 24103 45.45 2 Beyond the Mexique Bay",
                "0 25/03/2001 22304 16.68 1 Blithe Spirit",
                "0 4/5/2007 28137 28.97 2 Blood's a Rover",
                "2 3/3/1999 20946 9.76 0 Blue Remembered Earth",
                "0 27/07/2005 9177 37.17 2 Blue Remembered Hills",
                "1 29/10/2013 17688 19.51 0 Bonjour Tristesse",
                "0 6/5/2015 26819 5.63 1 Brandy of the Damned",
                "2 5/7/1987 4894 3.86 1 Bury My Heart at Wounded Knee",
                "1 5/5/2002 211 30.66 0 Butter In a Lordly Dish",
                "2 28/10/2010 28396 14.15 0 By Grand Central Station I Sat Down and Wept",
                "2 29/05/2002 15170 37.47 1 Cabbages and Kings",
                "1 28/01/2010 20513 3.32 0 Carrion Comfort",
                "0 3/12/1991 16585 15.78 2 A Catskill Eagle",
                "0 20/07/1990 14166 23.87 0 Clouds of Witness",
                "1 18/06/1993 29606 40.23 0 A Confederacy of Dunces",
                "0 6/11/1990 22390 46.43 2 Consider Phlebas",
                "1 21/07/1987 19292 30.89 0 Consider the Lilies",
                "1 28/10/2000 12346 40.23 1 Cover Her Face",
                "2 6/4/2013 2500 32.68 1 The Cricket on the Hearth",
                "0 10/10/1989 21714 23.41 1 The Curious Incident of the Dog in the Night-Time",
                "1 6/6/2000 16829 32.45 1 The Daffodil Sky",
                "0 8/9/2002 2036 46.52 0 Dance Dance Dance",
                "2 3/4/1995 25151 36.61 2 A Darkling Plain",
                "2 26/02/1989 3810 38.64 1 Death Be Not Proud",
                "0 20/12/2013 23115 2.26 1 The Doors of Perception",
                "2 4/4/2004 18437 24.86 2 Down to a Sunless Sea",
                "2 9/10/2007 2869 11.84 0 Dulce et Decorum Est",
                "1 15/08/1990 24100 18.58 2 Dying of the Light",
                "0 17/05/1988 9569 45.43 2 East of Eden",
                "1 18/09/2010 18857 22.55 2 Ego Dominus Tuus",
                "2 15/04/2009 24907 33.96 1 Endless Night",
                "0 27/01/1994 378 42.35 0 Everything is Illuminated",
                "0 8/9/1991 681 1.82 1 Eyeless in Gaza",
                "0 27/01/2013 29100 43.23 0 Fair Stood the Wind for France",
                "0 5/3/2002 20952 6.07 0 Fame Is the Spur",
                "0 6/12/1989 24985 9.41 2 A Fanatic Heart",
                "2 19/09/1998 19285 8.04 1 The Far-Distant Oxus",
                "1 10/1/1997 6733 6.05 0 A Farewell to Arms",
                "2 19/10/1990 205 19.52 0 Far From the Madding Crowd",
                "1 22/04/2013 2790 44.09 0 Fear and Trembling",
                "2 19/04/1993 5936 44.68 0 For a Breath I Tarry",
                "0 12/11/2010 5650 8.13 0 For Whom the Bell Tolls",
                "2 3/10/2000 22009 18.24 1 Frequent Hearses",
                "1 20/02/2004 13402 17.21 2 From Here to Eternity",
                "2 24/05/2004 20887 35.59 2 A Glass of Blessings",
                "2 14/08/2011 6127 43.19 1 The Glory and the Dream",
                "2 12/4/1993 3364 42.82 2 The Golden Apples of the Sun",
                "0 13/11/2004 661 38.52 0 The Golden Bowl",
                "0 9/5/1994 2653 26.76 0 Gone with the Wind",
                "2 1/6/1992 19998 22.43 2 The Grapes of Wrath",
                "2 5/10/2014 9344 1.06 1 Great Work of Time",
                "1 21/10/1998 17086 40.07 2 The Green Bay Tree",
                "0 24/10/1999 22125 48.63 0 A Handful of Dust",
                "1 15/05/2006 15875 30.37 0 Have His Carcase",
                "0 20/08/1992 13624 2.46 0 The Heart Is a Lonely Hunter",
                "0 16/10/2003 19549 44.8 0 The Heart Is Deceitful Above All Things",
                "0 18/03/1990 1049 33.85 2 His Dark Materials",
                "2 18/11/2010 288 46.63 1 The House of Mirth",
                "2 7/1/1997 17285 29.47 0 How Sleep the Brave",
                "0 16/08/2014 16010 34.94 1 How Sleep the Brave",
                "2 5/12/2001 13298 35.6 2 How Sleep the Brave",
                "0 14/09/1992 29432 23.39 1 I Know Why the Caged Bird Sings",
                "1 23/01/2014 20250 38.74 0 I Sing the Body Electric",
                "0 11/11/2004 9777 32.36 0 I Will Fear No Evil",
                "2 13/02/1992 10081 33.21 0 If I Forget Thee Jerusalem",
                "0 9/3/2004 25437 6.4 2 If Not Now",
                "0 25/02/1993 24935 9.14 1 When?",
                "0 21/09/1987 9015 11.69 1 Infinite Jest",
                "0 16/11/2006 25080 38.6 2 In a Dry Season",
                "0 12/5/2006 22035 4.61 0 In a Glass Darkly",
                "0 14/03/2000 29880 7.19 1 In Death Ground",
                "2 16/06/2008 5401 41.08 1 In Dubious Battle",
                "2 19/02/2005 13057 43.75 1 An Instant In The Wind",
                "0 16/07/1995 14714 8.59 1 It's a Battlefield",
                "2 25/09/2001 26989 19.23 0 Jacob Have I Loved",
                "2 28/11/2002 28166 42.48 1 O Jerusalem!",
                "1 28/12/2011 24465 16.25 2 Jesting Pilate",
                "2 18/01/1997 10901 1.45 1 The Last Enemy",
                "0 16/03/2012 27604 46.56 0 The Last Temptation",
                "2 13/04/2005 22077 28.71 0 The Lathe of Heaven",
                "0 7/8/2005 2995 10.66 2 Let Us Now Praise Famous Men",
                "2 13/12/1997 1049 30.75 2 Lilies of the Field",
                "0 20/04/2006 12205 12.63 2 This Lime Tree Bower",
                "1 22/01/2001 16255 10.83 2 The Line of Beauty",
                "1 27/06/1988 12696 24 0 The Little Foxes",
                "0 5/2/2003 27401 18.74 2 Little Hands Clapping",
                "2 22/06/2014 4721 14.95 1 Look Homeward",
                "2 11/10/2004 13319 48.35 2 Angel",
                "1 19/12/2011 21958 45.42 1 Look to Windward",
                "0 9/5/1995 2743 42.18 0 The Man Within",
                "2 12/10/2007 5930 17.49 2 Many Waters",
                "2 9/7/2012 16591 47.55 2 A Many-Splendoured Thing",
                "1 27/06/2004 3582 39.11 2 The Mermaids Singing",
                "2 22/06/1997 15896 2.08 0 The Millstone",
                "2 15/03/2006 2046 38.05 0 The Mirror Crack'd from Side to Side",
                "2 18/06/2008 28201 1.82 0 Moab Is My Washpot",
                "0 24/01/1992 26490 46.93 2 The Monkey's Raincoat",
                "0 4/9/2013 29602 13.33 0 A Monstrous Regiment of Women",
                "1 9/1/2013 21111 10.32 0 The Moon by Night",
                "1 11/6/2006 11453 32.31 0 Mother Night",
                "2 16/11/1992 9110 28.35 2 The Moving Finger",
                "0 6/6/2012 13052 12.49 0 The Moving Toyshop",
                "2 12/3/1991 8154 29.99 2 Mr Standfast",
                "0 26/12/1998 20816 19.5 0 Nectar in a Sieve",
                "1 9/10/2000 19045 14.49 1 The Needle's Eye",
                "2 29/03/1998 23212 34.58 2 Nine Coaches Waiting",
                "1 6/2/2010 11131 24.05 0 No Country for Old Men",
                "0 6/3/2013 20978 6.44 0 No Highway",
                "0 25/02/2007 22512 22.98 2 Noli Me Tangere",
                "0 16/02/2011 18641 6.23 0 No Longer at Ease",
                "0 17/11/2004 28498 41.4 2 Now Sleeps the Crimson Petal",
                "0 5/4/2009 324 23.06 1 Number the Stars",
                "2 22/06/2013 12188 14.83 0 Of Human Bondage",
                "1 26/09/1992 22489 2.19 2 Of Mice and Men",
                "0 9/2/1992 29592 46.67 1 Oh! To be in England",
                "2 6/10/1989 16373 46.26 2 The Other Side of Silence",
                "1 17/01/2003 3815 45.78 2 The Painted Veil",
                "2 4/11/2012 24336 31.99 0 Pale Kings and Princes",
                "0 30/08/2014 3934 12.04 1 The Parliament of Man",
                "1 30/05/1989 9687 45.67 1 Paths of Glory",
                "0 23/07/2003 20601 31.15 1 A Passage to India",
                "1 3/3/1995 3416 49.9 1 O Pioneers!",
                "0 20/08/1995 23030 48.23 2 Postern of Fate",
                "2 7/1/2010 29854 45.91 0 Precious Bane",
                "0 13/09/1992 27354 47.63 1 The Proper Study",
                "0 24/02/2003 13138 28.66 1 Quo Vadis",
                "0 24/07/1989 24402 18.41 2 Recalled to Life",
                "0 4/5/2010 19376 22.64 0 Recalled to Life",
                "1 23/06/2008 23899 14.34 1 Ring of Bright Water",
                "0 15/03/1989 5084 11.27 1 The Road Less Traveled",
                "2 17/05/2008 18967 20.45 1 A Scanner Darkly",
                "0 12/6/2012 16930 34.99 1 Shall not Perish",
                "0 22/10/1995 3476 45.17 0 The Skull Beneath the Skin",
                "0 18/12/1991 1556 22.54 2 The Soldier's Art",
                "2 18/01/1991 11042 4.62 2 Some Buried Caesar",
                "2 22/12/1993 23331 30.87 2 Specimen Days",
                "0 27/02/1997 13629 26.81 0 The Stars' Tennis Balls",
                "2 6/1/2006 5340 27.17 0 Stranger in a Strange Land",
                "2 13/11/1991 1832 9.98 0 Such",
                "1 3/12/2000 12429 19.27 1 Such Were the Joys",
                "0 6/6/2000 10179 22.81 0 A Summer Bird-Cage",
                "0 7/6/1991 16301 20.4 0 The Sun Also Rises",
                "1 2/12/2014 2138 1.27 0 Surprised by Joy",
                "1 9/2/2003 1727 15.55 1 A Swiftly Tilting Planet",
                "2 18/10/1992 13829 10.06 0 Taming a Sea Horse",
                "2 13/03/1994 11647 37.34 0 Tender Is the Night",
                "1 12/12/1992 27153 35.39 2 Terrible Swift Sword",
                "0 8/7/1991 15918 20.11 2 That Good Night",
                "2 11/9/1993 13597 48.63 1 That Hideous Strength",
                "2 26/01/2008 22855 40.02 2 Things Fall Apart",
                "2 3/4/2013 8009 48.32 1 This Side of Paradise",
                "2 19/05/1987 26931 33.81 0 Those Barren Leaves",
                "1 14/05/1991 10810 21.41 0 Thrones",
                "2 5/2/2009 5371 15.54 0 Dominations",
                "0 24/09/1988 2627 11.42 2 Tiger! Tiger!",
                "1 5/8/2003 15625 38.58 2 A Time of Gifts",
                "1 15/08/2005 11601 23.29 1 Time of our Darkness",
                "0 21/08/1999 12654 5.93 1 Time To Murder And Create",
                "2 26/08/1987 26739 2.21 2 Tirra Lirra by the River",
                "1 4/4/2004 13659 27.05 2 To a God Unknown",
                "2 13/08/1999 25080 34.06 2 To Sail Beyond the Sunset",
                "2 24/02/1988 25541 8.88 1 To Say Nothing of the Dog",
                "1 6/4/2004 21573 38.95 1 To Your Scattered Bodies Go",
                "0 5/2/2003 249 35.35 2 The Torment of Others",
                "1 12/3/2003 6660 38.39 0 Unweaving the Rainbow",
                "2 28/10/1996 18708 47.19 1 Vanity Fair",
                "2 30/09/1996 1092 44.27 0 Vile Bodies",
                "1 21/10/1993 12978 34.49 0 The Violent Bear It Away",
                "1 9/9/2011 28211 38.13 1 Waiting for the Barbarians",
                "2 28/07/2010 5146 10.46 2 The Waste Land",
                "1 17/01/2004 19962 33.99 1 The Way of All Flesh",
                "0 10/8/2000 23466 42.61 0 The Way Through the Woods",
            };

            int bookCount = booksInput.Length;

            Category[] categories = CategoryGenerator.CreateCategories();

            Author[] authors = AuthorGenerator.CreateAuthors();

            Book[] books = new Book[bookCount];

            for (int i = 0; i < bookCount; i++)
            {
                string[] bookTokens = booksInput[i].Split();

                int edition = int.Parse(bookTokens[0]);
                DateTime releaseDate = DateTime.ParseExact(bookTokens[1], "d/M/yyyy", CultureInfo.InvariantCulture);
                int copies = int.Parse(bookTokens[2]);
                decimal price = decimal.Parse(bookTokens[3]);
                int ageRestriction = int.Parse(bookTokens[4]);
                string title = String.Join(" ", bookTokens, 5, bookTokens.Length - 5);
                Category category = categories[i / 10];
                Author author = authors[i / 5];

                Book book = new Book()
                {
                    Title = title,
                    ReleaseDate = releaseDate,
                    Description = bookDescription,
                    EditionType = (EditionType)edition,
                    Price = price,
                    Copies = copies,
                    AgeRestriction = (AgeRestriction)ageRestriction,
                    Author = author,
                };

                BookCategory bookCategory = new BookCategory()
                {
                    Category = category,
                    Book = book
                };

                book.BookCategories.Add(bookCategory);

                books[i] = book;
            }

            return books;
        }
    }
}
