using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
     class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("hello");
                List<contact> contacts = new List<contact>(20);
                Console.WriteLine("please choose your option: ");
                Console.WriteLine("press 1 to add a new user");
                Console.WriteLine("press 2 serch by any value");
                Console.WriteLine("press 3 to adite a user");
                Console.WriteLine("press 4 to delete a user");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("press 1 to add a business user or 2 ta add a privet user");
                        var userInput2 = Console.ReadLine();
                        switch (userInput2)
                        {
                            case "1":
                                Console.WriteLine("contact name");
                                var name = Console.ReadLine();
                                Console.WriteLine("contact number");
                                var number = Console.ReadLine();
                                Console.WriteLine("contact hp");
                                var hp = Console.ReadLine();
                                Console.WriteLine("contact adrees ");
                                var adress = Console.ReadLine();
                                var newContact = new Business(name, number, hp, adress);
                                contacts.Add(newContact);
                                break;
                            case "2":
                                Console.WriteLine("contact name");
                                var name1 = Console.ReadLine();
                                Console.WriteLine("contact number");
                                var number2 = Console.ReadLine();
                                Console.WriteLine("contact last name");
                                var lastName = Console.ReadLine();
                                Console.WriteLine("contact adrees ");
                                var adress2 = Console.ReadLine();

                                var newContact1 = new Private(name1, number2, lastName, adress2);
                                contacts.Add(newContact1);
                                break;
                            default:
                                Console.WriteLine("err");
                                break;

                        }

                        break;
                    case "2":
                        Console.WriteLine("contact name");
                        var param = Console.ReadLine();
                        
                        foreach (var content in contacts)
                        {
                            if (content.isContentHasValue(param)) {
                                content.displaycontactdeatails();
                                Console.WriteLine("if you like to update/delete this user press y else press n ");
                                var ans = Console.ReadLine();
                                if(ans == "y")
                                {
                                    Console.WriteLine("to update press 1 to delete 2 ");
                                    ans = Console.ReadLine();
                                    switch (ans)
                                    {
                                        case "1":
                                            while (ans == "1")
                                            {
                                                Console.WriteLine("enter the fild you like to uppdate");
                                                var fild = Console.ReadLine();
                                                Console.WriteLine("enter the value you would like to uppdate");
                                                var paraming = Console.ReadLine();
                                                content.uptade(fild.ToLower(), paraming);
                                                Console.WriteLine("to update another field press 1 atherwaise press any key");
                                                ans = Console.ReadLine();
                                            }
                                            break;

                                            case"2":
                                            contacts.Remove(content);
                                            break;
                                            default :  Console.WriteLine("bad input");
                                            break ;
                                    }

                                }

                               
                            }
                            
                        }
                        break ;
                    default:
                        Console.WriteLine("bad");
                        break;
                }
                Console.ReadLine();

            
            ConsoleKeyInfo key;
                Console.WriteLine("press space to quit");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) Environment.Exit(0);
            }
        }
    }
}
