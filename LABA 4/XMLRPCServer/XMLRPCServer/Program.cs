using System;
using System.Collections;
using Nwc.XmlRpc;

namespace XMLRPCServer
{
    class Server
    {
        const int port = 8301;

        static void Main(string[] args)
        {
            XmlRpcServer server = new XmlRpcServer(port);
            server.Add("sample", new Server());
            Console.WriteLine("Сервер начал работу");
            server.Start(); //Запуск сервера
        }

        [XmlRpcExposed]
        public ArrayList Matrix(ArrayList arr, int size)
        {
            int min = (int)arr[0];
            int i, j;
            int a = 0;
            int b = 0;
            for (j = 0; j < size; j++)
            {
                for (i = 0; i < size; i++)
                {
                    if ((int)arr[i + j * size] <= min)
                    {
                        a = i;
                        b = j;
                        min = (int)arr[i + j * size];
                    }
                }
            }
            if (a >= b)
            {
                a = a - b;
                b = 0;
                do
                {
                    arr[a + b * size] = 0;
                    a += 1;
                    b += 1;
                } while ((a + b * size) < size * size);
            }
            else
            {
                b = b - a;
                a = 0;
                do
                {
                    arr[a + b * size] = 0;
                    a += 1;
                    b += 1;
                } while ((a + b * size) < size*size);
            }
            bool flag = false;
            for (int k = size - 1; k > 0; k--) //Возведение в квадрат элементов ниже необходимой диагонали с левого нижнего угда
            {
                if (flag)
                    break;
                i = k;
                j = 0;
                while (i < size)
                {
                    if ((int)arr[j + i * size] == 0)
                    {
                        flag = true;
                        break;
                    }
                    arr[j + i * size] = (int)arr[j + i * size] * (int)arr[j + i * size];
                    i++;
                    j++;
                    if (j == size)
                        break;
                }
            }
            j = 0;
            for (i = 0; i < size; i++) //Заполнение нулями элементов необходимой диагонали
            {
                if (flag)
                    break;
                if ((int)arr[j + i * size] == 0)
                {
                    flag = true;
                    break;
                }
                arr[j + i * size] = (int)arr[j + i * size] * (int)arr[j + i * size];
                j++;
            }
            arr.Add(min); //Добавить в самом конце минимальный элемент
            return arr;
        }
    }
}
