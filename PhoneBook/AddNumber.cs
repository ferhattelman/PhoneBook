using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class AddNumber:Contact
    {
        public void add()
        {

            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string number = Console.ReadLine();
            contact.Add(number, name + " " + surname);
            Console.WriteLine(name + " " + surname + "added successfully.");

        }
    }
}
