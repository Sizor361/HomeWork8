using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        /// <summary>
        /// Добавляем в коллекцию HashSet число и проверяем нет ли его уже там
        /// </summary>
        /// <param name="number">С какой коллекцией работаем</param>
        static void AddAndCheck(HashSet<int> number)
        {
            do
            {
                Console.Write("Введите число: ");

                string inputNumber = Console.ReadLine();

                if (number.Contains(Convert.ToInt32(inputNumber)))
                {
                    Console.WriteLine("\nЭто число вводилось ранее\n");
                }
                else
                {
                    number.Add(Convert.ToInt32(inputNumber));
                    Console.WriteLine("\nНовое число успешно введено в коллекцию!\n");
                }

            } while (true);
        }

        static void Main(string[] args)
        {
            HashSet<int> number = new HashSet<int>();

            AddAndCheck(number);
        }
    }
}
