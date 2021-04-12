using System;
using System.Runtime.InteropServices;

[Guid("8C034F6A-1D3F-4DB8-BC99-B73873D8C297")]
[ClassInterface(ClassInterfaceType.None)]
[ComVisible(true)]
public class Calculator : COM_OBJECT.ICalculator
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
