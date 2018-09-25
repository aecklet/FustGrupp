using System;
using System.Collections.Generic;
using System.Text;

namespace rednit.Domain
{
    class Menu
    {
        bool meny = true;

        public void Getmenu()
        {
            List<string[]> users = new List<string[]>();// Sparar Användaren som en Array innuti en lista.
            string[] userPref = new string[4];
            User user = new User();
            while (meny)//En while loop för menyn
            {
                Console.WriteLine("[1] Create Account");
                Console.WriteLine("[2] Login");
                Console.WriteLine("[3] Match");
                Console.WriteLine("[4] Quit");

                Console.Write("\nSelect: ");
                int menySelect = Utils.ReadInputMinMax(1, 4); // Hanterar siffer inmatning så att man inte får ett Error om man skriver tecken.

                switch (menySelect)
                {
                    case 1:
                        {
                            // Skriver in en användare och sparar det i classen User som sen sparas i en Array.
                            Console.Clear();
                            Console.WriteLine("Create account");  
                            Console.Write("Name: ");
                            user.FirstName = Console.ReadLine();
                            Console.Write("Gender: ");
                            user.Gender = Console.ReadLine();
                            Console.Write("Age: ");
                            user.Age = Console.ReadLine();
                            Console.Write("Looking for: ");
                            user.PrefGender = Console.ReadLine();
                            users.Add(new string[] { user.FirstName, user.Gender, user.Age, user.PrefGender });

                            break;
                        }

                    case 2:
                        {
                            //Skriver ut alla användare.
                            Console.Clear();
                            foreach (string[] user1 in users)
                            {
                                Console.WriteLine(user1[0] + " " + user1[1] + " " + user1[2] + " " + user1[3]);
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Här kan du söka på Användare");
                            Console.Write("Sök på Kön: ");
                            string userGenderSearch = Console.ReadLine();//användaren ger ett sökord.

                            foreach (string[] item in users)
                                if (item[1].Contains(userGenderSearch))//söker på item 1 som är variabel Kön i våran array.
                                {
                                    //Skriver ut alla 4 index platser i arrayn för att få fram hela användaren.
                                    Console.WriteLine("\t" + item[0]);
                                    Console.WriteLine("\t" + item[1]);
                                    Console.WriteLine("\t" + item[2]);
                                    Console.WriteLine("\t" + item[3]);

                                }
                                else
                                    Console.WriteLine("\nHittade inget med angivna sökordet\n");
                            break;
                        }

                    case 4:
                        {
                            //avbryter meny loopen och sätter meny bool 
                            Console.Clear();
                            meny = false;
                            break;
                        }

                    default:
                        break;
                }
            }
        }
    }
}