using System;
using System.Collections;

namespace XMLRPCClient
{
    class Program
    {
        static ServObj obj;

        static void Main(string[] args)
        {
            obj = new ServObj("http://127.0.0.1:8301");
            ArrayList temp_arr = null;
            ArrayList arr = new ArrayList();
            Console.Write("Введите размер квадратной матрицы: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите квадратную матрицу: ");
            string[] str_arr;
            for (int i = 0; i < size; ++i)
            {
                str_arr = (Console.ReadLine()).Split(' ');
                for (int j = 0; j < size; j++)
                    arr.Add(Convert.ToInt32(str_arr[j]));
            }
            Console.Clear();
            Console.WriteLine("Введенная матрица:\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(arr[j + i * size] + "\t");
                Console.WriteLine("\n");
            }
            temp_arr = obj.Matrix(arr, size); //отправить запрос
            Console.WriteLine("\nМинимальный элемент: " + temp_arr[size * size] + "\n");
            Console.WriteLine("Итоговая матрица:\n");
            temp_arr.RemoveAt(size * size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(temp_arr[j + i * size] + "\t");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
