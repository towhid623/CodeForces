using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    public class Team
    {
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            var totalSureProblems = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var result = input.Split(' ').Select(byte.Parse).ToArray();
                var petya = result[0];
                var vasya = result[1];
                var tonya = result[2];
                var surePersons = 0;
                if (petya == 1)
                {
                    surePersons++;
                }
                if (vasya == 1)
                {
                    surePersons++;
                }
                if (tonya == 1)
                {
                    surePersons++;
                }
                totalSureProblems += (surePersons >= 2 ? 1 : 0);
            }
            Console.WriteLine(totalSureProblems);
        }
    }
}
