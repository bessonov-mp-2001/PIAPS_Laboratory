using System;

namespace LABA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 fun1 = new Class1(); //Вывод аргументов командной строки
            Class2 fun2 = new Class2(); //Високосный год
            Class3 fun3 = new Class3(); //Числа Фиббоначчи
            Class4 fun4 = new Class4(); //Факториал числа
            Class5 fun5 = new Class5(); //Решето Эратосфена
            string selection;
            do
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Вывод аргументов из командной строки");
                Console.WriteLine("2. Високосный год");
                Console.WriteLine("3. Фибоначи");
                Console.WriteLine("4. Факториал");
                Console.WriteLine("5. Простые числа");
                Console.WriteLine("6. Выход");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        fun1.ArgComLine(args);
                        break;
                    case "2":
                        fun2.Visocosn();
                        break;
                    case "3":
                        Console.Write("n = ");
                        var input = Convert.ToUInt32(Console.ReadLine());
                        fun3.FibonacciNumbers(input);
                        break;
                    case "4":
                        Console.Write("n = ");
                        input = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine($"Факториал числа {input} равен {fun4.Factorial(input)}");
                        break;
                    case "5":
                        Console.Write("n = ");
                        input = Convert.ToUInt32(Console.ReadLine());
                        var primeNumbers = fun5.SieveEratosthenes(input);
                        Console.WriteLine($"Простые числа до заданного {input}:");
                        Console.WriteLine(string.Join(", ", primeNumbers));
                        break;
                }
            } while (selection != "6");
        }
    }
}