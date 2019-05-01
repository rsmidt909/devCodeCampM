using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecChar Single = new SpecChar();
            int Ind = Single.CodeChar();
            Console.WriteLine(Ind);
            Console.ReadLine();
        }
    }
}
