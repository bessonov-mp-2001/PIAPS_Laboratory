using System;
using System.Runtime.InteropServices;

namespace COM_OBJECT
{
    [Guid("364C5E66-4412-48E3-8BD8-7B2BF09E8922")]
    [ComVisible(true)]
    public interface ICalculator
    {
        int Sum(int a, int b);
        int Divide(int a, int b);
        int Substract(int a, int b);
        int Multiply(int a, int b);
    }
}
