using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbaseball
{
    class Program
    {
        static void mv() { Console.Write("     "); }
        static void printline(char symbol, int length)
        {
            int p;
            for (p = 0; p < length; p++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            mv();
            printline('@', 49);
            Console.WriteLine("                세상에서 가장 어려운 숫자야구              ");
            mv();
            printline('@', 49);
            Console.WriteLine("");
            Console.Write("             * Easy");
            Console.WriteLine("             * Medium\n");
            Console.WriteLine("");
            Console.Write("          1)    두자리");
            Console.WriteLine("          3)    네자리\n");
            Console.Write("          2)    세자리");
            Console.WriteLine("          4)   다섯자리\n");
            Console.WriteLine("");
            Console.Write("             * Hard");
            Console.WriteLine("             * Hell\n");
            Console.WriteLine("");
            Console.Write("          5)   여섯자리");
            Console.WriteLine("          7)   여덟자리\n");
            Console.Write("          6)   일곱자리");
            Console.WriteLine("          8)   아홉자리\n");
            Console.WriteLine("");
            Console.WriteLine("                      0)      종료");
            Console.WriteLine("");
            mv();
            printline('@', 49);
            Console.WriteLine("");
            Console.Write("           :");
            Console.ReadLine();
        }
    }
}
