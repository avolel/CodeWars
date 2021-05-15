using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedisGood
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4,3,3,3,3 };
            Console.WriteLine($"Score is {Score(numbers)}");
        }

        private static int Score(int[] dice)
        {
            int sum = 0;

            int one = dice.Count(x => x == 1);
            int two = dice.Count(x => x == 2);
            int three = dice.Count(x => x == 3);
            int four = dice.Count(x => x == 4);
            int five = dice.Count(x => x == 5);
            int six = dice.Count(x => x == 6);

            if (one == 1) sum += 100;
            if (one == 2) sum += 200;
            if (one == 3) sum += 1000;
            if (one == 4) sum += 1100;
            if (one == 5) sum += 1200; 

            if (two == 3) sum += 200;

            if (three == 3) sum += 300;
            if (three > 3) sum = sum + 300;

            if (four == 3) sum += 400;

            if (five == 1) sum += 50;
            if (five == 2) sum += 100;
            if (five == 3) sum += 500;
            if (five == 4) sum += 550;
            if (five == 5) sum += 600;

            if (six == 3) sum += 600;

            return sum;
        }
    }
}
