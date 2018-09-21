using rednit.Domain;
using System;

namespace rednit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool meny = true;
            while (meny)
            {
                Console.WriteLine("[1] Create Account");
                Console.WriteLine("[2] Login");
                Console.WriteLine("[3] Match");
                Console.WriteLine("[4] Quit");

                Console.Write("\nSelect: ");
                string menySelect = Console.ReadLine();

                int nr;
                if (int.TryParse(menySelect, out nr))//en TryParse för att fånga fel inmatningar i menyn
                {

                }
                else
                {
                    Console.WriteLine("You have to choose a number.");
                }


                switch (nr)
                {
                    case 1:
                        {
                            Console.Write("Create account: ");
                            User user = new User("Joakim", "Snabel", 32);
                            //Console.Write("First name: ");
                            //user.FirstName = Console.ReadLine();

                            Console.WriteLine(user.FirstName + " " + user.Gender + " " + user.Age);

                            break;
                        }

                    case 2:
                        {

                            Console.WriteLine("User Name: ");
                            Console.WriteLine("");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Search User: ");
                            break;
                        }

                    case 4:
                        {
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
