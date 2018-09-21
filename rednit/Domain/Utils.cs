using System;
using System.Threading;

namespace rednit.Domain
{
    class Utils
    {
        public HashCode GetID(string strInput)
        {
            Random rnd = new Random(strInput.GetHashCode());
            return rnd;
        }

        public static int ReadInputMinMax(int min, int max) //minsta och största värde av funktionen skickas hit
        {
            var value = min;
            var done = false;

            while (!done)
            {
                var input = Console.ReadLine();
                try  // Catching if something else than number is enterd
                {
                    value = Convert.ToInt32(input); // användaren värde görs om till Int och lagras i value
                    value = Math.Max(value, min); // value jämförs med min värdet och högsta värdet lagras i value
                    value = Math.Min(value, max); // value jämförs med max värdet och det minsta värdet  lagras i value
                    done = true; // avslutar funktionen
                }
                catch (Exception) //om nått blir fel 
                {
                    Console.Clear();
                    Console.WriteLine($"Please enter a number between {min} and {max}!");
                }
            }
            return value; //retunerar ett värde mellan min och max
        }
    }
}
