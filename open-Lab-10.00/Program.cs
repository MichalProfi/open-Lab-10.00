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
            LOTR.title = "HUHHUH";
            Console.WriteLine(LOTR.title);
            Console.ReadLine();
        }
    }
}
