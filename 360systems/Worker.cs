using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _360systems
{
    public static class Worker
    {
        public static int[] InitialDefaultArray()
        {
            int[] output = new int[1000000];

            try
            {
                output = Enumerable.Range(1, 1000000).ToArray();

                //output[1] = 21;
                //output[2] = 1121;
                //output[3] = 100013;
                //output[4] = 202010;
                output[5] = 99999;
            }
            catch (Exception ex)
            {
                ErrorHandler.DefaultHandler(ex);
            }
            return output;
        }

        public static string GetDuplicates(int[] _input)
        {
            string output = "";
            List<int> values = new List<int>();

            try
            {
                values = _input.ToList();
                List<int> duplicates = values.GroupBy(x => x)
                                            .Where(g => g.Count() > 1)
                                            .Select(g => g.Key)
                                            .ToList();

                foreach (int duplicate in duplicates)
                {
                    output += duplicate.ToString() + " ";
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DefaultHandler(ex);
            }
            return output;
        }
    }
}