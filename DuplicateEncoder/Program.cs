using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string wrd = "Champions";
            Console.WriteLine($"{DuplicateEncode(wrd)}");
        }

        public static string DuplicateEncode(string word)
        {
            string output = string.Empty;
            string lowercaseWord = word.ToLower();
            Dictionary<string, string> dict = LoadDictionary(lowercaseWord);
            foreach (char c in lowercaseWord.ToCharArray())
            {
                var results = dict.Where(a => a.Value == c.ToString()).ToList();
                if (results.Count == 1)
                    output += "(";
                else if (results.Count > 1)
                    output += ")";
            }
            return output;
        }

        private static Dictionary<string, string> LoadDictionary(string word)
        {
            Dictionary<string, string> wordDict = new Dictionary<string, string>();
            int key = 0;

            //Load Dictionary
            foreach (char c in word.ToCharArray())
            {
                wordDict.Add(key.ToString(), c.ToString());
                key++;
            }

            return wordDict;
        }
    }
}
