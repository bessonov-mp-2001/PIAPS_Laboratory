using System;

namespace LABA1
{
    class Class3
    {
        public void FibonacciNumbers(uint n)
        {
            uint[] arr = new uint[n];
            n -= 1;
            if (n == 0)
            {
                arr[0] = 1;
            }
            else
            {
                arr[0] = 1;
                arr[1] = 1;
            }

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            for (int i = 0; i <= n; i++)
            {
                if (arr[i] <= n + 1) Console.WriteLine(arr[i]);
                if (arr[i] > n) break;
            }
        }
    }
}
