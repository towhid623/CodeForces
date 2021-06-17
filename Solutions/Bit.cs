using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    public class Bit
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            var statements = new string[] { };
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "X++"|| input == "++X")
                {
                    x++;
                }
                else if (input == "X--"|| input == "--X")
                {
                    x--;
                }
            }
            Console.WriteLine(x);
        }
    }

}
