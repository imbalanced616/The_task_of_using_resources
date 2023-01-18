using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                     Задача об использовании ресурсов.");
            Console.WriteLine("  Предприятие изготавливает два вида товаров с использованием 3-ёх видов ресурсов,");
            Console.WriteLine("кол-во которых ограничено. Необходимо составить план выпуска продукции приносящих");
            Console.WriteLine("макс. доход, если известна прибыль от реализации единицы продукции каждого вида.");
            Console.WriteLine("Также известен расход каждого ресурса на единицу продукции.");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("|                |      Запас     |   Расход ресурса на 1-цу продукции   |");
            Console.WriteLine("|     Ресурс     |     ресурса    |--------------------------------------|");
            Console.WriteLine("|                |                |        Р1         |       Р2         |");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("|       R1       |       36       |        6          |       6          |");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("|       R2       |       20       |        4          |       2          |");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("|       R3       |       40       |        4          |       8          |");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("|    Прибыль от 1-цы продукции    |       12р         |      15р         |");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("                                           x1                 x2");
            Console.WriteLine();
            Console.WriteLine("Неизвестные: x1 и x2 — кол-во продукции первого и второго вида соответственно.");
            Console.WriteLine("Цель: максимальныей доход.");
            Console.WriteLine("Целевая функция: f = 12x1 + 15x2 -> max");
            Console.WriteLine("Ограничения по ресурсам:");
            Console.WriteLine("   -");
            Console.WriteLine("  | 6x1 + 6x2 <= 36");
            Console.WriteLine(" <  4x1 + 2x2 <= 20");
            Console.WriteLine("  | 6x1 + 6x2 <= 40");
            Console.WriteLine("   -");
            Console.WriteLine("     x1>=0, x2>=0");
            Console.WriteLine();
            Console.WriteLine("     Решение:");
            FunctionSolution();
            Console.ReadLine();
        }

        static void FunctionSolution()
        {
            int max = -100;
            int x1 = 0;
            int x2 = 0;
            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    if (6 * i + 6 * j <= 36 && 4 * i + 2 * j <= 20 && 4 * i + 8 * j <= 40)
                    {
                        int y = 12 * i + 15 * j;
                        Console.WriteLine($"x1={i},  x2={j},  f={y}");

                        if(y > max)
                        {
                            max = y;
                            x1 = i;
                            x2 = j;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Максимальный доход: {max}р при количестве продукции");
            Console.WriteLine($"первого и второго вида: {x1} и {x2} соответственно.");
        }
    }
}
