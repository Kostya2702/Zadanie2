using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.Write("Введите три числа:\n");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            int[] tmp = new int[2];
            int tmp2 = 32767;

            for(int i=0;i<3;i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        continue;
                    if(Math.Abs(numbers[i]- numbers[j]) < tmp2)
                    {
                        tmp[0] = numbers[i];
                        tmp[1] = numbers[j];
                        tmp2 = Math.Abs(numbers[i] - numbers[j]);
                    }
                }
            Console.Write("У чисел {0} {1} наименьший модуль разности, равный {2}\n", tmp[0], tmp[1], tmp2);

            tmp2 = -1;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        continue;
                    if (Math.Abs(numbers[i] - numbers[j]) > tmp2)
                    {
                        tmp[0] = numbers[i];
                        tmp[1] = numbers[j];
                        tmp2 = Math.Abs(numbers[i] - numbers[j]);
                    }
                }
            Console.Write("У чисел {0} {1} наибольший модуль разности, равный {2}\n", tmp[0], tmp[1], tmp2);

            Console.ReadKey();
        }
    }
}
