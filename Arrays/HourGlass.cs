using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    public class HourGlass
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for(int i=0; i<6; i++)
            {
                arr[i] = Array.ConvertAll(
                            Console.ReadLine().Split(' '), 
                            stringValue => Convert.ToInt32(stringValue));
            }

            Console.WriteLine(GetHourGlassMaxSum(arr));
        }

        public static int GetHourGlassMaxSum(int[][] arr)
        {
            var hourGlassSum = new List<int>();

            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                            arr[i + 1][j + 1] +
                             arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    hourGlassSum.Add(sum);
                }
            }

            return hourGlassSum.Max();
        }
    }
}
