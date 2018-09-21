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
                Console.WriteLine("[3] Quit");

                int menySelect = Convert.ToInt32(Console.ReadLine());

                switch (menySelect)
                {
                    case 1:
                        {
                            Console.WriteLine("Create account");

                            break;
                        }

                    case 2:
                        {

                            Console.WriteLine("Login");
                            break;
                        }

                    case 3:
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
