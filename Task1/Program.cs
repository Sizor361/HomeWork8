using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        /// <summary>
        /// Автоматически заполняем коллекцию
        /// </summary>
        /// <param name="list">Куда заполняем</param>
        /// <returns></returns>
        static List<int> Fill(List<int> list)
        {
            Random randomNumber = new Random();

            for (int i = 0; i < 100; i++) 
            { 
                list.Add(randomNumber.Next(101));
            }

            return list;
        }

        /// <summary>
        /// Распечатываем коллекцию
        /// </summary>
        /// <param name="list"></param>
        static void Print(List<int> list)
        {
            int counter = 0;
            foreach (int i in list) Console.WriteLine($"{counter++}-ый элемент: {i}");
            Console.WriteLine();
        }

        /// <summary>
        /// Удаляем некоторые элементы из коллекции
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static List<int> Delete(List<int> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    list.RemoveAt(i);
                }
            }

            return list;
        }

        /// <summary>
        /// До удаления элементов из коллекции
        /// </summary>
        /// <param name="list">Коллекция с которой работаем</param>
        static void Before(List<int> list)
        {
            Print(Fill(list));
        }

        /// <summary>
        /// После удаления некоторых элементов из коллекции
        /// </summary>
        /// <param name="list">Коллекция с которой работаем</param>
        static void After(List<int> list)
        {
            Print(Delete(list));
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Before(list);

            After(list);

            Console.ReadKey();

        }
    }
}