using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        /// <summary>
        /// Запись в коллекцию типа Dictonary записи о телефоне и ФИО владельца, ключ - телефон
        /// </summary>
        /// <param name="telephoneNote">Куда записываем</param>
        static Dictionary<string,string> Record(Dictionary<string, string> telephoneNote)
        {
            do
            {
                Console.Write("Введите номер телефона: ");

                string telephoneNumber = Console.ReadLine();

                if (telephoneNumber == string.Empty)
                {
                    break;
                }

                Console.Write("Введите Ф.И.О.: ");

                string fullname = Console.ReadLine();

                if (fullname == string.Empty)
                {
                    break;
                }

                telephoneNote.Add(telephoneNumber, fullname);

                Console.WriteLine("\nЗапись успешно введена!\n");

            } while (true);

            return telephoneNote;
        }

        /// <summary>
        /// Поиск в коллекции по ключу
        /// </summary>
        /// <param name="telephoneNote">В какой коллекции ищем</param>
        static void Search(Dictionary<string, string> telephoneNote)
        {
            Console.Clear();
            Console.Write("Введите номер телефона для поиска - ");

            string searchingNumber = Console.ReadLine();

            if (telephoneNote.ContainsKey(searchingNumber))
            {
                Console.WriteLine($"\nВладелец этого телефона - {telephoneNote[Convert.ToString(searchingNumber)]}");
            }
            else
            {
                Console.WriteLine("\nТакого номера не существует!");
            }

        }

        /// <summary>
        /// Объединенный метод или же попытки в инкапсуляцию
        /// </summary>
        /// <param name="telephoneNote"></param>
        static void RecordAndSearch(Dictionary<string, string> telephoneNote)
        {
            Search(Record(telephoneNote));
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> telephoneNote = new Dictionary<string, string>();

            RecordAndSearch(telephoneNote);

            Console.ReadKey();
        }
    }
}
