﻿using System.Collections.Generic;

namespace ProjectEulerCSharp.Helpers
{
    public static class Maths
    {
        public static IEnumerable<int> IntegerSequence(int startNumber, int endNumber)
        {
            while (startNumber <= endNumber)
                yield return startNumber++;
        }

        /// <summary>
        /// Calculates the sum of an arithmetic progression
        /// http://en.wikipedia.org/wiki/Arithmetic_progression#Sum
        /// </summary>
        public static int ArithmeticSeries(int firstTerm, int increment, int termCount)
        {
            int lastTerm = increment * (termCount - 1) + firstTerm;
            decimal sum = ((decimal)termCount / 2) * (firstTerm + lastTerm);
            return (int)sum;
        }
    }
}
