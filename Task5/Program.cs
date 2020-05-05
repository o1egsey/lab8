using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        //делегат для определения периода дня
        public delegate void GetGreeting();
        //делегат для выбора нужной операции
        public delegate double UseOperation(double x, double y);
        //основная функция программы
        static void Main(string[] args)
        {
            //первая часть задания (определение времени)
            int time = DateTime.Now.Hour;
            GetGreeting DayTime;
            if (time >= 5 && time <= 10) DayTime = GoodMorning;
            else if (time > 10 && time <= 17) DayTime = GoodDay;
            else if (time > 17 && time <= 22) DayTime = GoodEvening;
            else DayTime = GoodNight;
            DayTime();
            //вторая часть задания (математические операции)
            double X, Y;
            string operation;
            //коллекция (ключ-значение, метод/делегат)
            Dictionary<string, UseOperation> op = new Dictionary<string, UseOperation>();
            op["+"] = (x, y) => x + y;
            op["-"] = (x, y) => x - y;
            op["*"] = (x, y) => x * y;
            op["/"] = (x, y) => x / y;
            //цикл для ввода нужной операции
            do
            {
                Console.WriteLine("Введите нужную Вам операцию (+, -, *, /):");
                operation = Console.ReadLine();
                if (op.ContainsKey(operation))
                {
                    break;
                }
                Console.WriteLine("Операция недоступна!");
            } while (true);
            //ввод параметров X, Y
            Console.WriteLine("Введите параметры X и Y:");
            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            //вывод результата
            Console.WriteLine("Результат:");
            Console.WriteLine("X " + operation + " Y = " + op[operation](X, Y) + ";");
            Console.ReadKey();
        }
        //методы без параметров для вывода текста 
        public static void GoodMorning()
        { Console.WriteLine("Доброе утро!"); }
        public static void GoodDay()
        { Console.WriteLine("Добрый день!"); }
        public static void GoodEvening()
        { Console.WriteLine("Добрый вечер!"); }
        public static void GoodNight()
        { Console.WriteLine("Доброй ночи!"); }
    }
}
