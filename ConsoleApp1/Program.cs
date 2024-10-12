using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Задание 1

            //Console.WriteLine("It's easy to win forgiveness for being wrong;");
            //Console.WriteLine("being right is what gets you into real trouble.");
            //Console.WriteLine("Bjarne Stroustrup");

            #endregion

            #region Задание 2

            //int[] arr = new int[5];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());

            //}


            //int sum = 0;
            //int min = 0, max = 0;

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //    if (arr[i] < min) min = arr[i];
            //    if (arr[i] > max) max = arr[i];
            //}

            //Console.WriteLine($"SUM: {sum}");
            //Console.WriteLine($"MIN: {min}");
            //Console.WriteLine($"MAX: {max}");


            #endregion

            #region Задание 3

            //int userNum = int.Parse(Console.ReadLine());
            //string res = "";

            //while(userNum > 0)
            //{
            //    int a = userNum % 10;
            //    userNum = userNum / 10;
            //    res += a;
            //}

            //Console.WriteLine($"result: {res}");

            #endregion

            #region Задание 4 

            //Console.WriteLine("Range start: ");
            //int rangeStart = int.Parse(Console.ReadLine());
            //Console.WriteLine("Range end: ");
            //int rangeEnd = int.Parse(Console.ReadLine());

            //int a = 0; 
            //int b = 1;

            //while (a <= rangeEnd)
            //{
            //    if (a >= rangeStart)
            //    {
            //        Console.WriteLine(a);
            //    }

            //    int temp = a;
            //    a = b;
            //    b = temp + b;
            //}

            #endregion

            #region Задание 5 

            //Console.WriteLine("Range start: ");
            //int rangeStart = int.Parse(Console.ReadLine());
            //Console.WriteLine("Range end: ");
            //int rangeEnd = int.Parse(Console.ReadLine());

            //for (int i = rangeStart; i <= rangeEnd; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Задание 6

            //Пользователь с клавиатуры вводит длину линии, символ заполнитель, направление линии(горизонтальная,
            //вертикальная). Программа отображает линию по заданным
            //параметрам.Например: +++++.

            Console.WriteLine("Line length: ");
            int line_length = int.Parse(Console.ReadLine());
            Console.WriteLine("Symbol: ");
            string line_symbol = Console.ReadLine();
            Console.WriteLine("Direction (h/v): ");
            string direction = Console.ReadLine();

            if(direction == "h")
            {
                for(int i = 0; i < line_length; i++)
                {
                    Console.Write(line_symbol + "");
                }
                Console.WriteLine(" ");
            }
            else if(direction == "v")
            {
                for (int i = 0; i < line_length; i++)
                {
                    Console.WriteLine(line_symbol);
                }

            }

            #endregion
        }
    }
}
