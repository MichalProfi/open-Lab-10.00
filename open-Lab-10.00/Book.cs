using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_Lab_10._00
{
    class Book
    {
        private int Pages;

        private int ReleaseDate;


        public string author { get; set; }

        public string category { get; set; }
        public int pages
        {
          
            get => this.Pages;
            set
            {
                if (value < 1)
                {
                    Pages = 1;
                }
                else
                {
                    Pages = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Title:{this.title}, Pages:{this.pages}, Category:{this.category}, Author:{this.author}, RealeaseDate:{this.releaseDate}";

        }

        public int releaseDate
        {
            get => this.ReleaseDate;
            set
            {
                if (value < 1450 || value > 2020)
                {
                    ReleaseDate = -1;
                }
                else
                {
                    ReleaseDate = value;
                }
            }
        }

        public string title
        { get; set; }
    }


}

