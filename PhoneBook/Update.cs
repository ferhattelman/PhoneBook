using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Update:Contact
    {
        public void updateNum()
        {
        update:
            Console.WriteLine("Please, entern name or surname:");
            string name = Console.ReadLine();
            int count = 0;
            foreach (var item in contact)
            {
                if (item.Value.Contains(name))
                {
                    Console.WriteLine("Please, entern new phone number:");
                    string number = Console.ReadLine();
                    string nameNew = item.Value;
                    contact.Remove(item.Key);
                    contact.Add(number, nameNew);
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (count == contact.Count)
            {
                Console.WriteLine("No suitable person found. Please make a selection.");
                Console.WriteLine("* Process cancellation : (1)");
                Console.WriteLine("* Try again      : (2)");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Logged out.");
                }
                else if (choice == "2")
                    goto update;

            }

            //foreach (var item in contact)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
