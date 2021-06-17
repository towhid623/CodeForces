using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class PetyaAndStrings
    {
        public void Solve()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(string.Compare(a.ToLower(), b.ToLower()));
        }
    }
}
