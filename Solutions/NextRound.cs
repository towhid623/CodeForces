using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    public class NextRound
    {
        public void Solve()
        {
            string inputNK = Console.ReadLine();
            var n = inputNK.Split(' ').Select(byte.Parse).ToArray()[0];
            var k = inputNK.Split(' ').Select(byte.Parse).ToArray()[1];
            string input = Console.ReadLine();
            var result = input.Split(' ').Select(byte.Parse).ToArray();
            byte numberOfPassedParticipants = 0;
            for (byte i = 0; i < n; i++)
            {
                if (result.Length >= (k - 1) && result[i] >= result[k - 1] && result[i] > 0)
                {
                    numberOfPassedParticipants++;
                }
            }
            Console.WriteLine(numberOfPassedParticipants);
        }
    }
}
