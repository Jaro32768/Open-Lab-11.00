using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        /// <summary>
        /// List of available categories.
        /// </summary>
        public static List<string> categoryList = new List<string>();

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
            categoryList.Add("children's");
            categoryList.Add("romantic");
            categoryList.Add("educational");
            categoryList.Add("sci-fi");
            categoryList.Add("adventure");
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        /// <summary>
        /// Property, that set up a title of book.
        /// </summary>
        public string Title
        {
            get => this.title;
            set
            {
                this.title = value;
            }
        }
        /// <summary>
        /// Property, that set up a number of pages in book.
        /// </summary>
        public int Pages
        {
            get => this.pages;
            set
            {
                this.pages = value;
                if (this.pages < 0)
                {
                    this.pages = 1;
                }
            }
        }
        /// <summary>
        /// Property, that set up a category of book.
        /// </summary>
        public string Category
        {
            set
            {
                this.category = value;
            }
        }
        /// <summary>
        /// Property, that set up an author of book.
        /// </summary>
        public string Author
        {
            get => this.author;
            set
            {
                this.author = value;
            }
        }
        /// <summary>
        /// Property, that set up release date of book.
        /// </summary>
        public int ReleaseDate
        {
            get => this.releaseDate;
            set
            {
                this.releaseDate = value;
                if ((this.releaseDate > 2021) || (this.releaseDate < 1450))
                {
                    this.releaseDate = -1;
                }
            }
        }
        public string GetBook()
        {
            return String.Format($"{title} , {pages} , {category} , {author} , {releaseDate}");
        }
    }
}
