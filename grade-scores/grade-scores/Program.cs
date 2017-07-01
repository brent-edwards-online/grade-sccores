using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeScores
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("debug");
#else
            Console.WriteLine("release");
#endif
            Console.ReadKey();
        }
    }
}
