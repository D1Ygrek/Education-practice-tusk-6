using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void recur(double a1,double a2,double a3,int n,double[] arr)
        {
            if (n < arr.Length)
            {
                arr[n]= 13 * a1 - 10 * a2 + a3;
                recur(arr[n], a1, a2, n + 1, arr);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый элемент последовательности");
            double a1 = DoubleCheck();
            Console.WriteLine("Введите второй элемент последовательности");
            double a2 = DoubleCheck();
            Console.WriteLine("Введите третий элемент последовательности");
            double a3 = DoubleCheck();
            bool ok = true;
            Console.WriteLine("Введите количество элементов последовательности");
            int n = 0;
            do
            {
                n = IntCheck();
                if (n < 3)
                {
                    Console.WriteLine("Элементов не может быть меньше 3!");
                    ok = false;
                }
                else ok = true;
            } while (!ok);
            
            
            double[] arr= new double[n];
            arr[0] = a1;
            arr[1] = a2;
            arr[2] = a3;
            Console.WriteLine("Последовательность:");
            Console.Write(a1 + " " + a2 + " " + a3 + " ");
            if (n > 3)
            {
                recur(arr[2], arr[1], arr[0], 3, arr);
            }
            for(int i = 3; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }ok = true;
            double zeroel = arr[1];
            if (n > 3)
            {
                for (int i = 3; i < n; i += 2)
                {
                    if (zeroel < arr[i])
                    {
                        zeroel = arr[i];
                    }
                    else ok = false;
                }
            }
            else ok = false;
            Console.WriteLine();
            Console.WriteLine("Является ли последовательность чётных элементов возрастающей?\n"+ok);
            Console.ReadLine();
        }
        static double DoubleCheck()
        {
            double n;
            bool ok = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string s = Console.ReadLine();
            do
            {
                ok = double.TryParse(s, out n);
                if (ok == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ввод неправильный. Повторите.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    s = Console.ReadLine();
                }
            } while (!ok);
            Console.ForegroundColor = ConsoleColor.White;
            return (n);
        }
        static int  IntCheck()
        {
            int n;
            bool ok = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string s = Console.ReadLine();
            do
            {
                ok = int.TryParse(s, out n);
                if (ok == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ввод неправильный. Повторите.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    s = Console.ReadLine();
                }
            } while (!ok);
            Console.ForegroundColor = ConsoleColor.White;
            return (n);
        }
    }
}

