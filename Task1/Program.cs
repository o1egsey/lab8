using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 4, m = 4;
            int[,] A = new int[n, m];
            Random rnd = new Random();
            //заполнение матрицы рандомными числами
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    A[i, j] = rnd.Next(-10, 10);
            //демонстрация функций программы
            Console.WriteLine("Элементы матрицы A:");
            MethodAct(A, Show);
            Console.WriteLine("Позитивные элементы матрицы A:");
            MethodAct(A, ShowPositive);
            Console.WriteLine("Видоизмененная матрица A (позитивные элементы умноженны на 3):");
            MethodFunc(A, Mult3);
            MethodAct(A, Show);
        }
        //функции с использованием делегатов
        static void MethodAct(int[,] arr, Action<int> act)
        {
            if (arr == null)
                throw new NullReferenceException();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    act(arr[i, j]);
                Console.WriteLine();
            }
        }
        static void MethodFunc(int[,] arr, Func<int, int> act)
        {
            if (arr == null)
                throw new NullReferenceException();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = act(arr[i, j]);
        }
        //функции вывода и рассчетов
        public static void Show(int num)
        {
            Console.Write("{0}\t", num);
        }
        public static void ShowPositive(int num)
        {
            if (num >= 0) Console.Write("{0}\t", num);
            else Console.Write("-\t");
        }
        public static int Mult3(int num)
        {
            if (num > 0) return num * 3;
            else return num;
        }
    }
}
