//***********************************************************************************
//*Задание:массивы                                                                  *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                                             *
//* Задание: Есть массив целых чисел размером 10. Значения задаются двумя способами:*
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a;
                int b;
                int[] v = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.Write("первый индекс a =");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("второй индекс b =");
                b = Convert.ToInt32(Console.ReadLine());

                if (a <= v.Length || b <= v.Length)
                {
                    Console.WriteLine("Сумма элементов: {0}", v[a] + v[b]);
                }
                else Console.WriteLine("Недопустимые значения");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Ошибка ввода данных:" + e.Message);
            }

            Console.ReadLine();
        }
    }
}