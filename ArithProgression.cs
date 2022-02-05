using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ15
{
    internal class ArithProgression : ISeries
    {
        int x;
        int x0;
        public int getNext()
        {
            int nextX = x * 2;
            x = nextX;
            Console.WriteLine("Следующее число ар. ряда \t{0}", nextX);
            return nextX;
        }

        public void reset()
        {
            x = x0;
            Console.WriteLine();
            Console.WriteLine("Сброс до начального значения {0}", x);
        }

        public void setStart()
        {
            Console.Write("Ведите начальное значение х для арифмического ряда: ");
            while (!int.TryParse(Console.ReadLine(), out x0))
            {
                Console.Write("Ошибка! Введите целое число: ");
            }
            Console.WriteLine();
            Console.WriteLine("Вы ввели число \t\t\t{0}", x0);
            x= x0;
        }
    }
}
