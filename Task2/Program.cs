using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //действия над содержимым файла
            Console.WriteLine("Содержимое файла <Task2.txt>:");
            ReadFiles("D:\\program\\vs_projects\\lb8\\Task2\\Task2.txt", Show);
            Console.WriteLine("\nЧисла файла <Task2.txt>:");
            ReadFiles("D:\\program\\vs_projects\\lb8\\Task2\\Task2.txt", Numbers);
            Console.WriteLine("\n\nВидоизмененный вид файла <Task2.txt>:");
            ReadFiles("D:\\program\\vs_projects\\lb8\\Task2\\Task2.txt", Change);
            ReadFiles("D:\\program\\vs_projects\\lb8\\Task2\\Task2.txt", Show);
            Console.WriteLine();
            Console.ReadKey();
        }
        //функция с использованием делегата
        public static void ReadFiles(String path, Action<String> act)
        {
            act(path);
        }
        //функция для демонстрации содержимого файла
        public static void Show(String path)
        {
            StringBuilder info = new StringBuilder();
            string line;
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                    info.Append(line);
            }
            Console.WriteLine(info);
        }
        //функция для вывода чисел на экран
        public static void Numbers(String path)
        {
            string line;
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    foreach (char x in line)
                    {
                        if (Char.IsDigit(x)) Console.Write("{0} ", x);
                    }
                }
            }
        }
        //замена ",/./*/()" на пробелы
        public static void Change(String path)
        {
            StringBuilder file = new StringBuilder();
            string line;
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                    file.Append(line);
            }
            file.Replace('(', ' ');
            file.Replace(')', ' ');
            file.Replace('.', ' ');
            file.Replace(',', ' ');
            file.Replace('*', ' ');
            using (StreamWriter MyFile = new StreamWriter(path))
            {
                MyFile.WriteLine(file);
            }
        }
    }
}
