using System;
using System.Linq;

namespace Solutions
{
    public class DominoPiling
    {
        public void Solve()
        {
            string input = Console.ReadLine();
            var result = input.Split(' ').Select(int.Parse).ToArray();
            var m = result[0];
            var n = result[1];
            var boardSize = m * n;
            var dominoSize = 2 * 1;
            var numberOfDominos = boardSize / dominoSize;
            Console.WriteLine(numberOfDominos);
        }
    }
}
