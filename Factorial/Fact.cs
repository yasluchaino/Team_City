using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Fact
    {
        public Fact() { }

        public int Factorial(int n)
        {
            int f = 1;
            for (int i = 2; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
