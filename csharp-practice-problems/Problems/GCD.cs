using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_practice_problems.Problems
{
    public class GCD
    {
        public int res(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if(a == b)
                return a;

            if (a > b)
                return res(a - b, b);

            return res(a, b - a);
        }

    }
}
