using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonAbundantSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(AbundantNumbers()));
        }

        static bool IsAbundant(int n)
        {
            int sum = 0;
            for (int i = 1; i < (int)n / 2 + 1; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum > n ? true : false;
        }

        static int[] AbundantNumbers()
        {
            List<int> list = new List<int>();
            for (int i = 1; i < 28124; i++)
            {
                if (IsAbundant(i))
                    list.Add(i);
            }
            int[] array = list.ToArray();
            Array.Sort(array);
            return array;
        }
        static int Sum(int[] list)
        {
            int sum = 0;
            for (int i = 1; i < 28124; i++)
            {
                bool flag = false;
                int j = 0;
                int max = list.Max();
                while ((i - list[j]) < max && list[j] < i)
                {
                    if (list.Contains(i - list[j]))
                    { flag = true; break; }
                    j++;
                }
                if (!flag)
                    sum += i;
            }
            return sum;
        }
    }
}
