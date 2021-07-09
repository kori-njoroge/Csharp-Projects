using System;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("console phonebook app");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display Contact by Number");
            Console.WriteLine("3 View All Contacts");
            Console.WriteLine("4 Search Contact for a given name");


            var userinput = Console.ReadLine();

            var phonebook = new phonebook();

            while (true)
            {
                 switch (userinput)
            {
                case"1":
                 Console.WriteLine("Contact Name:");

                 var name = Console.ReadLine();

                  Console.WriteLine("Contact Number:");

                 var number= Console.ReadLine();

                 var newContact = new contact(name,number);
                 phonebook.Addcontact(newContact);
                 
                break;

                 case"2":
                break;

                 case"3":
                break;

                 case"4":
                break;

                default:
                Console.WriteLine("Select Valid  Operation");
                  break;
            }
            }

           
        }
    }
}
