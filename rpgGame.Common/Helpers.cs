using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame
{
    public static class Helpers
    {
        /// <summary>
        /// Generates a random number between the low and the high values
        /// </summary>
        /// <param name="Low"></param>
        /// <param name="High"></param>
        /// <returns></returns>
        public static int RandNumber(this int Low, int High)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
            return rndNum.Next(Low, High);
        }
        /// <summary>
        /// Multiples by both int values
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int MultiplyStats(this int first, int second)
        {
            return first * second;
        }
        /// <summary>
        /// Multiples by double with an int value
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static double MultiplyStats(this int first, double second)
        {
            return first * second;
        }
    }
}
