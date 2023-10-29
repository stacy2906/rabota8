using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.

            //1.Вызов пустого метода Func без возвращения значений для вычисления функции y = x2.

            //    Func();
            //}
            //static void Func()
            //{
            //    Console.WriteLine("Введите значение x: ");
            //    int x = int.Parse(Console.ReadLine());
            //    int y = x * x;
            //}

            //2.Преобразуйте программу так, чтобы метод Func вызывался n раз.

            //    Console.WriteLine("Введите значение n: ");
            //    int n = int.Parse(Console.ReadLine());
            //    for (int i=0; i<=n; i++)
            //    { Func(); }
            //}

            //static void Func()
            //{
            //    Console.WriteLine("Введите значение x: ");
            //    int x = int.Parse(Console.ReadLine());
            //    int y = x * x;
            //}

            //3.Преобразуйте программу так, чтобы метод Func вычислял значение выражения:

            //      int x = 9, y = 10;
            //      Console.WriteLine($"x={x}\ y={y}");
            //      int z= Add (x, y);
            //      Console.WriteLine($"z={z}");
            //      Console.WriteLine($"x={x}\ y={y}");
            //  }
            //static int Add (int x, int y)
            //  {
            //      int sum = x + y;
            //      x = 100;
            //      y = 500;
            //      return sum;

            //  }


            //Задача 2.Нахождение суммы двух чисел с использованием метода сложения двух чисел.


            //    Console.WriteLine("Введите значение x: ");
            //    int x = Convert.ToInt32(Console.ReadLine());

            //    double y = Func(x);
            //    Console.WriteLine("Значение выражения y = (3 * x * x + 8 * x - 10) / 15 : " + y);

            //    Console.ReadLine();
            //    }

            //static double Func(double x)
            //{
            //    double y = (3 * x * x + 8 * x - 10) / 15;
            //    return y;
            //}


            //Задача 3.Вызов метода Func для вычисления функции y = x2, в который будет передаваться значение х от a до b с шагом h, а сам метод возвращал значение y.


            //    Console.WriteLine("Введите начальное значение a: ");
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Введите конечное значение b: ");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Введите шаг h: ");
            //    double h = Convert.ToDouble(Console.ReadLine());

            //    for (double x = a; x <= b; x += h)
            //    {
            //        double y = Func(x);
            //        Console.WriteLine("Значение функции y = x^2 при x = " + x + " : " + y);
            //    }

            //    Console.ReadLine();
            //    }

            //static double Func(double x)
            //{
            //    double y = x * x;
            //    return y;
            //}

            //Задача 4.Составьте таблицу значений функции y = 5x² -2x + 1 на отрезке[-5; 5] с шагом h = 2 с использованием дополнительного метода.

            //    double a = -5;
            //    double b = 5;
            //    double h = 2;

            //    Console.WriteLine("x\t  y");
            //    Console.WriteLine("-----------------");

            //    for (double x = a; x <= b; x += h)
            //    {
            //        double y = Func(x);
            //        Console.WriteLine(x + "\t" + y);
            //    }

            //    Console.ReadLine();
            //}

            //static double Func(double x)
            //{
            //    double y = 5 * x * x - 2 * x + 1;
            //    return y;
            //}

            //Задача 5.Напишите дополнительный метод для вычисления функции:

            //    Console.WriteLine("Введите значение x: ");
            //    double x = Convert.ToDouble(Console.ReadLine());

            //    double y = Func(x);
            //    Console.WriteLine("Значение функции y = " + y);

            //    Console.ReadLine();
            //}

            //static double Func(double x)
            //{
            //    double y;

            //    if (x < 5)
            //    {
            //        y = 4 * x * x + 1 / x - 5;
            //    }
            //    else
            //    {
            //        y = 3 * x * x - 2;
            //    }

            //    return y;
            //}



            //Задача 6.Создайте приложение, которое выводит сумму, вычитание, умножение и деление двух параметров входных данных.

            //        Console.WriteLine("Введите первое число:");
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Введите второе число:");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    double sum = a + b;
            //    double difference = a - b;
            //    double product = a * b;
            //    double division = a / b;

            //    Console.WriteLine($"Сумма: {sum}");
            //    Console.WriteLine($"Разность: {difference}");
            //    Console.WriteLine($"Произведение: {product}");
            //    Console.WriteLine($"Деление: {division}");
            //}

            //Домашнее задание.

            //1.Нахождение максимальной величины из двух целых переменных a, b.

            //Console.WriteLine("Введите значение переменной a:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите значение переменной b:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int max = a > b ? a : b;

            //Console.WriteLine($"Максимальное значение: {max}");


            //2.Вычислить среднее арифметическое трех действительных чисел.

            //    Console.WriteLine("Введите первое число:");
            //    double a = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Введите второе число:");
            //    double b = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Введите третье число:");
            //    double c = Convert.ToDouble(Console.ReadLine());

            //    double average = CalculateAverage(a, b, c);

            //    Console.WriteLine($"Среднее арифметическое: {average}");
            //}

            //static double CalculateAverage(double num1, double num2, double num3)
            //{
            //    double sum = num1 + num2 + num3;
            //    double average = sum / 3;
            //    return average;
            //}

            //Console.WriteLine($"Среднее арифметическое: {average}");

            //3.Составьте таблицу значений функции y = 4x² +5x - 10 на отрезке[-9; 9] с шагом h = 3.

            //    double a = -9;
            //    double b = 9;
            //    double h = 3;

            //    Console.WriteLine("Значение x\tЗначение y");

            //    for (double x = a; x <= b; x += h)
            //    {
            //        double y = CalculateFunctionValue(x);
            //        Console.WriteLine($"{x}\t\t{y}");
            //        Console.ReadKey();
            //    }
            //}


            //static double CalculateFunctionValue(double x)
            //{
            //    double y = 4 * x * x + 5 * x - 10;
            //    return y;

            //}

        }
    }
}
