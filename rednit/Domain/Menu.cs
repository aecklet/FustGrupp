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
            List<string[]> users = new List<string[]>();
            string[] userPref = new string[4];
            User user = new User();
            while (meny)
            {
                Console.WriteLine("[1] Create Account");
                Console.WriteLine("[2] Login");
                Console.WriteLine("[3] Match");
                Console.WriteLine("[4] Quit");

                Console.Write("\nSelect: ");
                int menySelect = Utils.ReadInputMinMax(1, 4);

                switch (menySelect)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Create account")   
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
                                if (item[1].Contains(userGenderSearch))//söker på item 1 som är variabel titel i våran array.
                                {
                                    //Skriver ut alla 3 index platser i arrayn för att få fram hela loggen.
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