﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaIntervale
{
    public static class IntegerIntervalReader
    {
        // private members usually are placed after the public ones
        // methods are usually placed in the order of their call
        private static bool ReadLimit(out int limit, string message)
        {
            Console.WriteLine(message);
            return Int32.TryParse(Console.ReadLine(), out limit);
        }

        public static IntegerInterval ReadInterval()
        {
            int lowerLimit;
            int upperLimit;

            while (true)
            {
                bool isLowerLimitValid = ReadLimit(out lowerLimit, "Limita interval 1: ");
                bool isUpperLimitValid = ReadLimit(out upperLimit, "Limita interval 2: ");

                if (isLowerLimitValid && isUpperLimitValid)
                    break;
                else Console.WriteLine("Input incorect! Incearca din nou.");
            }

            return new IntegerInterval(lowerLimit, upperLimit);
        }
    }
}
