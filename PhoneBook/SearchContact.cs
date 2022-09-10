using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class SearchContact:Contact
    {
        public void Search()
        {
            Console.WriteLine("Search type;");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            Console.WriteLine("Name or Surname: (1)");
            Console.WriteLine("Phone Number: (2)");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Please, entern name or surname:");
                string namSur = Console.ReadLine();
                foreach (var item in contact)
                {
                    if (item.Value.Contains(namSur))
                    {
                        Console.WriteLine("Name - Surname:" + item.Value);
                        Console.WriteLine("Phone Number:" + item.Key);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }


            }

            else if (choice == "2")
            {
                Console.WriteLine("Please, entern phone number:");
                string phoNum = Console.ReadLine();
                foreach (var item in contact)
                {
                    if (item.Key.Contains(phoNum))
                    {
                        Console.WriteLine("Name - Surname:" + item.Value);
                        Console.WriteLine("Phone Number:" + item.Key);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
