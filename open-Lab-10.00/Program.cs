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
            Book LOTR = new Book();

            LOTR.author = "MichalProfi";

            LOTR.category = "Adventure";

            LOTR.pages += 666;

            LOTR.releaseDate += 1400;
        
            LOTR.title = "HUHUHUH";


            Book LOTR2 = new Book();
            Book LOTR3 = new Book("HRHRH", 112);
            Book HOBIT = new Book("HOHOHO", 911, "Comedy", "santaClaus", 2025);

            Console.WriteLine(LOTR.ToString());
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
