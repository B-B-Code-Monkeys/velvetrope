using System;
using System.Collections.Generic;
using System.Text;

namespace VelvetRope.Common
{
    public static class Guard
    {
        public static void IsNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);
        }

        public static void IsNotNullOrEmpty(string argumentValue, string argumentName)
        {
            if (string.IsNullOrEmpty(argumentValue))
                throw new ArgumentNullException(argumentName);
        }

        public static void IsNotLessThanOrEqualToZero(int argumentValue, string argumentName)
        {
            if (argumentValue <= 0)
                throw new ArgumentException($"Argument '{argumentName}' cannot be less than or equal to zero");
        }

        public static void IsNotMoreThan(int maxValue, int argumentValue, string argumentName)
        {
            if (argumentValue > maxValue)
                throw new ArgumentException($"Argument '{argumentName}' cannot exceed {maxValue}");
        }

    }
}
