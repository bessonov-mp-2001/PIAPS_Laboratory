namespace LABA1
{
    class Class4
    {
        public ulong Factorial(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(n - 1) * n;
            }
        }
    }
}
