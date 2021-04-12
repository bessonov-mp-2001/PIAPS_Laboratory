using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

[Guid("364C5E66-4412-48E3-8BD8-7B2BF09E8922")]
[ComVisible(true)]
public interface ICalculator
{
    int Sum(int a, int b);
    int Divide(int a, int b);
    int Substract(int a, int b);
    int Multiply(int a, int b);
}

[Guid("8C034F6A-1D3F-4DB8-BC99-B73873D8C297")]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public class Calculator : ICalculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
    public int Substract(int a, int b)
    {
        return a - b;
    }
    public int Divide(int a, int b)
    {
        return a / b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}
