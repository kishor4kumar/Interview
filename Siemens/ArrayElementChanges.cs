using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Given array of size n, find out the changes 
 *  required to make whole array elements to min element in the array
 *  Input
 *  5
 *  1,3,4,2,1
 *  Expected Output
 *  3
 */

namespace Siemens
{
    public class ArrayElementChanges
    {
        //Driver program
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);

            if(n != arr.Length)
            {
                Console.WriteLine("Invalid input, I'm exiting.");
                return;
            }

            Console.WriteLine(Solve(arr));
        }

        public static int Solve(int[] arr)
        {
            var minValue = arr.Min();
            var changesRequired = 0;

            foreach(var n in arr)
            {
                if(n != minValue)
                {
                    changesRequired++;
                }
            }

            return changesRequired;
        }
    }
}
