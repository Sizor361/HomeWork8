using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Task4
{
    internal class Program
    {
        /// <summary>
        /// Создаем работника
        /// </summary>
        /// <param name="workers">Коллекция для хранения работников</param>
        static void Create(List<Worker> workers)
        {
            workers.Add(new Worker("", "", "", "", "", ""));
        }

        /// <summary>
        /// Делаем красивую xml
        /// </summary>
        /// <param name="path">Путь по которой сохраняем</param>
        /// <param name="workers">Откуда берем параметры</param>
        static void Serialize(string path, List<Worker> workers)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                //Для наглядного представления
                XElement myPerson = new XElement("Person");
                XElement myAddress = new XElement("Address");
                XElement myStreet = new XElement("Street");
                XElement myHouseNumber = new XElement("HouseNumber");
                XElement myFlatNumber = new XElement("FlatNumber");
                XElement myPhones = new XElement("Phones");
                XElement myMobilePhone = new XElement("MobilePhone");
                XElement myFlatPhone = new XElement("FlatPhone");

                XAttribute xAttributeName = new XAttribute("name", workers[i].fullname);

                myPerson.Add(myAddress, myPhones, xAttributeName);
                myAddress.Add(myStreet, myHouseNumber, myFlatNumber);
                myPhones.Add(myMobilePhone, myFlatPhone);

                myStreet.Add(workers[i].streetName);
                myHouseNumber.Add(workers[i].houseNumber);
                myFlatNumber.Add(workers[i].flatNumber);
                myMobilePhone.Add(workers[i].mobileNumber);
                myFlatPhone.Add(workers[i].houseTelephoneNumber);

                myPerson.Save(path);
            }

            Console.WriteLine("Файл успешно создан!");
        }

        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();

            string path = "CoolFile.xml";

            Create(workers);

            Serialize(path, workers);

            Console.ReadKey();
        }
    }
}
