using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42_Implementing_Layers
{
    public class Menu
    {
        private void Show()
        {
            Console.WriteLine("Goddag");
            Console.WriteLine("1. Tilføj et kæledyr");
            Console.WriteLine("2. Vis alle kæledyr");
            Console.WriteLine("3. Tilføj en ejer");
            Console.WriteLine("4. Find ejer med efternavn");
            Console.WriteLine("5. Find ejer med email");
            Console.WriteLine("0. Luk ned");
        }

        public string petName, petType, petBreed, petDOB, petWeight, ownerID;
        private string ownerFirstName, ownerLastName, ownerPhone, ownerEmail;

        public void RunMenu()
        {
            Show();
            string input = GetUserInput();

            switch (input)
            {
                case "1":
                    do
                    {
                        Console.Clear();
                        InsertPet();
                        break;

                    } while (true);
                    RunMenu();
                    break;

                //case "2":
                //    do
                //    {
                //        Console.Clear();
                //        ShowPets();
                //        Console.WriteLine("\n");
                //        break;

                //    } while (true);
                //    RunMenu();
                //    break;

                case "3":
                    do
                    {
                        Console.Clear();
                        InsertOwner();
                        break;

                    } while (true);
                    RunMenu();
                    break;

                case "4":
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Insert last name");
                        FindOwnerByLastName(GetUserInput());
                        Console.WriteLine("\n");
                        break;

                    } while (true);
                    RunMenu();
                    break;

                case "5":
                    Console.WriteLine("Insert email");
                    Console.WriteLine("Insert name");
                    FindOwnerByEmail(GetUserInput(), GetUserInput());
                    break;
                case "0":
                    //run = false;
                    break;
                default:
                    do
                    {
                        Console.WriteLine("??");
                        Console.WriteLine("\n");
                        break;

                    } while (true);
                    RunMenu();
                    break;
            }

            //} while (run);
        }
    


            private string GetUserInput()
            {
                string input = Console.ReadLine();
                return input;
            }

            public void InsertPet()
            {
                Console.WriteLine("Hvad er kæledyrets navn?");
                petName = Console.ReadLine();
                Console.WriteLine("Hvilket slags kæledyr?");
                petType = Console.ReadLine();
                Console.WriteLine("Hvilken race?");
                petBreed = Console.ReadLine();
                Console.WriteLine("Hvornår blev kæledyret født?");
                petDOB = Console.ReadLine();
                Console.WriteLine("Hvor meget vejer kæledyret?");
                petWeight = Console.ReadLine();
                Console.WriteLine("Hvad er ejer ID?");
                ownerID = Console.ReadLine();

                List<string> pets = new List<string>();
                pets.Add(petName);
                pets.Add(petType);
                pets.Add(petBreed);
                pets.Add(petDOB);
                pets.Add(petWeight);
                pets.Add(ownerID);

            }

            private void InsertOwner()
            {
                Console.WriteLine("Hvad er ejers fornavn?");
                ownerFirstName = Console.ReadLine();
                Console.WriteLine("Hvad er ejers efternavn?");
                ownerLastName = Console.ReadLine();
                Console.WriteLine("Hvad er ejers telefonnummer?");
                ownerPhone = Console.ReadLine();
                Console.WriteLine("Hvad er ejers email?");
                ownerEmail = Console.ReadLine();

            }
    }
}

