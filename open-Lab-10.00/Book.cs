using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_Lab_10._00
{
    class Book
    {
        
        public static List<string> categoryList = new List<string>() { "detské", "romantické", "náučné", "sci-fi", "dobrodružné" };

        private int pages;
        private string category;
        private int releaseDate;
        private string author;
        private string title;

        public string Author { 
            get{ return this.author; } 
            set { this.author = value; } 
        }

        public string Category
        {
            set => category = value;
        }
        public int Pages
        {
          
            get => this.Pages;
            set
            {
                if (value <= 1)
                {
                    this.pages = 1;
                }
                else
                {
                    this.pages = value;
                }
            }
        }
        

        public int ReleaseDate
        {
            get => this.releaseDate;
            set
            {
                if (value < 1450 || value > 2020)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }
        public string Title
        { get { return this.title; } set { this.title = value; } }
    

        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;

        }
        public override string ToString()
        {
            return $"Title:{this.title}, Pages:{this.pages}, Category:{this.category}, Author:{this.author}, RealeaseDate:{this.releaseDate}";

        }

    }
}


