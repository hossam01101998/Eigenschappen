using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eigenschappen
{
    internal class Getal
    {

        public static string Getal1(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    output += c;
                }
            }
            if (output.Length > 0) { return "Jouw waarden zijn: " + output; }
            else { return "0 (Er waren geen waarden)"; }

        }
    }
}
