using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Circle
    {
        //методы класса <Circle> (длинна, площадь, обьем)
        public double Length(double R)
        {
            return 2 * Math.PI * R;
        }
        public double Square(double R)
        {
            return Math.PI * R * R;
        }
        public double V(double R)
        {
            return 4 / 3 * Math.PI * Math.Pow(R, 3);
        }
    }

    class Program
    {
        //делегат 
        delegate double Operation(double R);
        //основная функция программы
        static void Main(string[] args)
        {
            double R, result;
            Circle function = new Circle();
            Operation op;

            Console.WriteLine("Введите значение радиуса R:");
            R = double.Parse(Console.ReadLine());
            if (R <= 0)
                throw new FormatException("Радиус должен быть >= 0!");

            op = function.Length;
            result = op(R);
            Console.WriteLine("Длинна круга равна {0}, а его радиус - {1}", result, R);

            op = function.Square;
            result = op(R);
            Console.WriteLine("Площадь круга равна {0}, а его радиус - {1}", result, R);

            op = function.V;
            result = op(R);
            Console.WriteLine("Обьем сферы равен {0}, а его радиус - {1}", result, R);
            Console.ReadKey();
        }
    }
}
