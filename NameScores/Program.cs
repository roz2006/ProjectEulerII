using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"D:\Visual Studio\Projects\ProjectEulerII\NameScores\p022_names.txt";
            string[] allnames = Names.GetNames(filename);
            Console.WriteLine(Names.ScoreNames(allnames).ToString());
        }

    }
}
