namespace CSharp_Lessons
{
    using System;

    class Randomizer
    {
        static Random rand = new Random();

        public static int GetNumber(int from = -50, int to = 50)
        {
            return rand.Next(from, to);
        }
    }
}
