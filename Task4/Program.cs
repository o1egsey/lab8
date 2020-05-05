using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        //обьявление делегата
        delegate int Operation(int a, int b);
        //основаня функция программы
        static void Main(string[] args)
        {
            //обьявление коллекции (ключ-значение, метод/делегат)
            Dictionary<String, Operation> op = new Dictionary<String, Operation>();
            //лямбда-выражения
            op["add"] = (a, b) => a + b;
            op["mult"] = (a, b) => a * b;
            //вывод информации на экран
            Console.WriteLine(op["add"](5, 3));
            Console.WriteLine(op["mult"](6, 7));
            Console.ReadKey();
        }
    }
}
