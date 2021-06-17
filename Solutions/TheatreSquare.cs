using System;
using System.Linq;

namespace Solutions
{
    public class TheatreSquare
    {
        public void Solve()
        {
            string input = Console.ReadLine();
            var result = input.Split(' ').Select(int.Parse).ToArray();
            var n = result[0];
            var m = result[1];
            var a = result[2];
            var nSideStone = n % a > 0 ? n / a + 1 : n / a;
            var mSideStone = m % a > 0 ? m / a + 1 : m / a;
            ulong numberOfRequiredStone = ((ulong)nSideStone * (ulong)mSideStone);
            Console.WriteLine(numberOfRequiredStone);
        }
    }
}
