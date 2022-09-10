using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Delete:Contact
    {
        public void delete()
        {
        delete:
            Console.WriteLine("Please entern name or surname:");
            string nameSurname = Console.ReadLine();
            int count = 0;
            foreach (var item in contact)
            {
                if (item.Value.Contains(nameSurname))
                {
                    contact.Remove(item.Key);
                    Console.WriteLine(item.Value + " Deletion successful!");
                    break;
                }
                else
                {
                    count++;
                    continue;
                }
            }

            if (count == contact.Count)
            {
                Console.WriteLine("No suitable person found. Please make a selection.");
                Console.WriteLine("* Process cancellation : (1)");
                Console.WriteLine("* Try again: (2)");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Logged out.");
                }
                else if (choice == "2")
                    goto delete;

            }

            foreach (var item in contact)
            {
                Console.WriteLine(item);
            }

        }
    }
}
