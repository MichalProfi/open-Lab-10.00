using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_Lab_10._00
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;

        public void Title(string title)
        {
            this.title = title;
        }
        public void Pages(int pages)
        {
            this.pages = pages;
        }
        public void Category(string category)
        {
            this.category = category;
        }
        public void Author(string author)
        {
            this.author = author;
        }
        public void RealeaseDate(string releaseDate)
        {
            this.releaseDate = releaseDate;
        }
        public override string ToString()
        {
            return $"Title:{this.title}, \nPages:{this.pages}, \nCategory:{this.category}, \nAuthor:{this.author}, \nRealeaseDate:{this.releaseDate}";

        }


    }


}

