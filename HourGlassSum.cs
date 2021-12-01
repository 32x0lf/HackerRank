using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<int>> TempArr = new List<List<int>>();

            for(int i=0;i < 6; i++)
            {
                TempArr.Add(Console.ReadLine().TrimEnd().Split(' ').Select(x => Convert.ToInt32(x)).ToList());
            }



            int result = Result.hourglassSum(TempArr);
        }
    }

    class Result
    {

        /*
         * Complete the 'hourglassSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int hourglassSum(List<List<int>> arr)
        {
            int sum = 0;
            List<int> listsum = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                for(int j=0; j < 4; j++)
                {
                    sum = 0;
                    for (int ii = 0; ii < 3; ii++)
                    {
                        sum += Convert.ToInt32(arr[i][ii + j]);
                    }

                    sum += arr[i + 1][j + 1];

                    for (int ii = 0; ii < 3; ii++)
                    {
                        sum += Convert.ToInt32(arr[i + 2][ii + j]);
                    }

                    listsum.Add(sum);
                }
            }

            sum = listsum.Max();
            return sum;
        }

    }
}
