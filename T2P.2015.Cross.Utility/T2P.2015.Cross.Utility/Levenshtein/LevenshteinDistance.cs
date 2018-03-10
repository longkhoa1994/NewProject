using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Utility.Levenshtein
{
    public class LevenshteinDistance
    {
        public static int Compute(string from, string to)
        {
            if (from == null)
            {
                from = string.Empty;
            }
            if (to == null)
            {
                to = string.Empty;
            }

            int fromLeng = from.Length;
            int toLeng = to.Length;
            int[,] d = new int[fromLeng + 1, toLeng + 1];

            //Step 1
            if (fromLeng == 0)
            {
                return toLeng;
            }
            if (toLeng == 0)
            {
                return fromLeng;
            }

            //Step 2
            for (int i = 0; i <= fromLeng; d[i, 0] = i++)
            {

            }
            for (int j = 0; j <= toLeng; d[0, j] = j++)
            {

            }
            // Step 3
            for (int i = 1; i <= fromLeng; i++)
            {
                //Step 4
                for (int j = 1; j <= toLeng; j++)
                {
                    // Step 5
                    int cost = (to[j - 1].ToString().ToLower() == from[i - 1].ToString().ToLower()) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[fromLeng, toLeng];
        }

        public static double CalculateRount(double input, int n)
        {
            return Math.Round(input, n, MidpointRounding.AwayFromZero);
        }

        public static double CalculatePersentageSimilarity(string from, string to)
        {
            if (from == null)
            {
                from = string.Empty;
            }
            if (to == null)
            {
                to = string.Empty;
            }
            from = from.Trim();
            to = to.Trim();

            if (from.ToLower() == to.ToLower())
            {
                return 100.0;
            }

            int stepToSame = Compute(from, to);
            double persentage = (1.0 - ((double)stepToSame / (double)Math.Max(from.Length, to.Length))) * 100;
            return CalculateRount(persentage, 2);
        }
    }
}
