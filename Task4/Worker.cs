using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public struct Worker
    {
        public string fullname;

        public string streetName;

        public string houseNumber;

        public string flatNumber;

        public string mobileNumber;

        public string houseTelephoneNumber;

        public Worker (string fullname, string streetName, string houseNumber, string flatNumber, string mobileNumber, string houseTelephoneNumber)
        {
            Console.Write("Введите Ф.И.О. - ");
            this.fullname = Console.ReadLine();

            Console.Write("Введите название улицы - ");
            this.streetName = Console.ReadLine();

            Console.Write("Введите номер дома - ");
            this.houseNumber = Console.ReadLine();

            Console.Write("Введите номер квартиры - ");
            this.flatNumber = Console.ReadLine();

            Console.Write("Введите номер мобильного телефона - ");
            this.mobileNumber = Console.ReadLine();

            Console.Write("Введите номер домашнего телефона - ");
            this.houseTelephoneNumber = Console.ReadLine();
        }

    }
}
