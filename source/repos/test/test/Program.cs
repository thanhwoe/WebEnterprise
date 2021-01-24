using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine());
            int S;
            for (int i = 1; i <= N; i++)
            {
                S = i % K;
                Console.WriteLine(S);
            }
            Console.ReadKey();
        }
    }
}
