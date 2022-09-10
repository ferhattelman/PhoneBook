using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tPlease select the action you want to do ; ");
            Console.WriteLine("\t\t*******************************************");
            Console.WriteLine("\t\t(1) Registering New Number");
            Console.WriteLine("\t\t(2) Deleting Number");
            Console.WriteLine("\t\t(3) Updating Number");
            Console.WriteLine("\t\t(4) Listing the Directory");
            Console.WriteLine("\t\t(5) Searching the Directory");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddNumber newNum = new AddNumber();
                    newNum.add();
                    newNum.ListContact();
                    break;

                case "2":
                    Delete delNum = new Delete();
                    delNum.delete();
                    break;

                case "3":
                    Update updNum = new Update();
                    updNum.updateNum();
                    break;

                case "4":
                    Contact baseObj = new Contact();
                    baseObj.ListContact();
                    break;

                case "5":
                    SearchContact search = new SearchContact();
                    search.Search();
                    break;

            }
            Console.ReadLine();
        }
    }
}