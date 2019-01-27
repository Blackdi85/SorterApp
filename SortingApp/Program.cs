using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace SortingApp
{
    class MainClass
    {
        public static void Main(string[] args)


        {

            Console.WriteLine("Choose sorting method:\n1.By First name\n2.By first given name\n3.By second given name\n4.By third given name\n5.By last name");
            string inFile = AppDomain.CurrentDomain.BaseDirectory + "unsorted-names-list.txt";
            string outFile = AppDomain.CurrentDomain.BaseDirectory + "sorted - names-list.txt";
            File.WriteAllText(outFile, string.Empty);
            string chooseButton = Console.ReadLine();
            Console.WriteLine("==================================");
            var contents = File.ReadAllLines(inFile);

            List<Human> HumanList = new List<Human>();

            foreach (var item in contents)
            {
                Human user = new Human();
                user.FromString(item);
                HumanList.Add(user);

            }

            var orderedHumans = HumanList;

            switch (chooseButton)
            {
                case "1":
                    orderedHumans = HumanList.OrderBy(user => user.FirstName).ToList();
                    break;
                case "2":
                    orderedHumans = HumanList.OrderBy(user => user.FirstGivenName).ToList();
                    break;
                case "3":
                    orderedHumans = HumanList.OrderBy(user => user.SecondGivenName).ToList();
                    break;
                case "4":
                    orderedHumans = HumanList.OrderBy(user => user.ThirdGivenName).ToList();
                    break;

                case "5":
                    orderedHumans = HumanList.OrderBy(user => user.LastName).ToList();
                    break;
                default:
                    Console.WriteLine("Please use default numbers");
                    break;
            }

            foreach (var items in orderedHumans)
            {
                Console.WriteLine(items);
                using (StreamWriter file = new StreamWriter(outFile, true))
                {
                    file.WriteLine(items);
                }
            }

            Console.WriteLine("==================================\nSorted {0} people", orderedHumans.Count());
            Console.ReadKey();
        }
    }
}




