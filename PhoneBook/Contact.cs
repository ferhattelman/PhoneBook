using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Contact
    {
        public Dictionary<string, string> contact = new Dictionary<string, string>();

        public Contact()
        {
            contact.Add("14725836900", "Ferhat Telman");
            contact.Add("14725836901", "Eren Igit");
            contact.Add("14725836902", "Abdullah Beyoglu");
            contact.Add("14725836903", "Ibrahim Telman");
            contact.Add("147258369004", "Isa Beyoglu");
        }

        public void ListContact()
        {
            foreach (var item in contact)
            {
                Console.WriteLine(item);
            }
        }

    }
}
