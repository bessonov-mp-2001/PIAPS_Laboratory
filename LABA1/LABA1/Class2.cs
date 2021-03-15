using System;

namespace LABA1
{
    class Class2
    {
        public void Visocosn()
        {
            for (int n=1900; n < 2001; n++)
            {
                Console.Write(n);
                Console.WriteLine(" {0} високосный", n % 400 == 0 || n % 100 != 0 && n % 4 == 0 ? "Год" : "Год не");
            }
        }
    }
}
