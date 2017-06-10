using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace NameScores
{
    class Names
    {
        public static string[] GetNames(string filename)
        {
            string alltexts = File.ReadAllText(filename);
            string[] allnames = alltexts.Split(',');
            return allnames;
        }

        public static BigInteger ScoreNames(string[] names)
        {
            Array.Sort(names, StringComparer.InvariantCulture);
            BigInteger score = 0;
            for (int i = 0; i < names.Length; i++)
            {
                string s = names[i];
                int s1 = OneNameScore(s);

                score = score + s1 * (i + 1);
            }
            return score;
        }

        public static int OneNameScore(string name)
        {
            name = name.Replace('"', ' ').Trim();
            char[] cs = name.ToCharArray();
            int score = 0;
            foreach (char c in cs)
            {
                int index = GetLetterIndex(c);
                if (index == -1)
                {
                    Console.WriteLine("Letter not found in the alphbet");
                    return 0;
                }
                score += index + 1;
            }
            return score;
        }
        public static int GetLetterIndex(char c)
        {
            string alphbet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alphbet.IndexOf(c);
        }

    }
}
