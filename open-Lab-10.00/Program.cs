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

            Console.WriteLine(LOTR.ToString());
            Console.ReadLine();
        }
    }
}
