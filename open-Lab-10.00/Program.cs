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
            LOTR.Pages(666);
            LOTR.Author("MichalProfi");
            LOTR.Category("Životopis");
            LOTR.RealeaseDate("31.12.2022");
            LOTR.Title("Môj život");
            Console.WriteLine(LOTR.ToString());
            Console.ReadLine();
        }
    }
}
