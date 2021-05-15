using System;

namespace Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            //string song = "WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB";
            string song = "WUBANDREWUBWUBVOLELWUB";
            Console.WriteLine($"Song Length {song.Length}");
            Console.WriteLine($"Decode Song is {SongDecoder(song)}");
        }

        private static string SongDecoder(string input)
        {
            return String.Join(" ", input.Split(new string[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
