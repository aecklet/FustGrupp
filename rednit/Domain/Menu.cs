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

                /*int nr;
                if (int.TryParse(menySelect, out nr))//en TryParse för att fånga fel inmatningar i menyn
                {

                }
                else
                {
                    Console.WriteLine("You have to choose a number.");
                }*/


                switch (menySelect)
                {
                    case 1:
                        {
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
                            Console.Clear();
                            foreach (string[] user1 in users)
                            {
                                Console.WriteLine(user1[0] + " " + user1[1] + " " + user1[2] + " " + user1[3]);
                            }
                            //Console.Write("Write your name: ");
                            //string userName = Console.ReadLine();
                            //if(userName == user.FirstName)
                            //{
                            //    Console.WriteLine("Welcome to our awesome site!!");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Enter valid username!");
                            //}
                            break;
                        }

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Search User: ");
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