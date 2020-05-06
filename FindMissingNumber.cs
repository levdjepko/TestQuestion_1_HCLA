using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestion_1_HCLA
{
    class FindMissingNumber
    {
        static int FindWhatIsMissing(int[] inputArray, int n)
        {
            //total expected sum of all the consecutive numbers from 0 to n
            int total = (n + 1) * (n + 2) / 2;
            //substract all the numbers that actually are in the array
            for (int i = 0; i <= n; i++)
            {
                total = total - inputArray[i];
            }
            //the remaining is the only number that has not been in the array, thus never was encountered during the for loop
            return total;
        }

        static void Main(string[] args)
        {
            int [] sampleArray = { 0, 1, 2, 4, 3, 6 , 7, 8, 9 , 10}; // in this example 5 is missing

            Console.WriteLine(FindWhatIsMissing(sampleArray, sampleArray.Length - 1));
        }
    }
}
