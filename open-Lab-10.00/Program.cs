using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Book LOTR = new Book();

            LOTR.Author = "MichalProfi";

            LOTR.Category = "Adventure";

            LOTR.Pages += 666;

            LOTR.ReleaseDate += 1400;
        
            LOTR.Title = "HUHUHUH";*/


            Book LOTR2 = new Book();
            Book LOTR3 = new Book("HRHRH", 112);
            Book HOBIT = new Book("HOHOHO", 911, "Comedy", "santaClaus", 2025);

            HOBIT.Category = Book.categoryList[4];
            
           
            Console.WriteLine("");
            Console.WriteLine("LOTR2: " + LOTR2.ToString());
            Console.WriteLine("");
            Console.WriteLine("LOTR3: " + LOTR3.ToString());
            Console.WriteLine("");
            Console.WriteLine("HOBIT: " + HOBIT.ToString());
            Console.ReadKey();
        }
    }
}
