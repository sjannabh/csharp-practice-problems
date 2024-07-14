using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice_problems.Problems
{
    public class BinaryRepresentation
    {
        public void bin(int n)
        {
            if (n > 1)
                bin(n / 2);

            Console.Write(n % 2);
        }
    }
}
