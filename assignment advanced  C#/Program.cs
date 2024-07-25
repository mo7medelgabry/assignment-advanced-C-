using assignment_advanced__C_.genarics;
using System;

namespace assignment_advanced__C_
{
    internal class Program

    {
        //#region 1
        //static void Main()
        //{
        //    int[] array = { 99,30,7,10,3,50};
        //    sorting(array);
        //    Console.WriteLine( string.Join(", ", array));
        //}
        //static void  sorting(int[] arr)
        //{
        //    int n = arr.Length;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        bool swapped = false;

        //        for (int j = 0; j < n - i - 1; j++)
        //        {
        //            if (arr[j] > arr[j + 1])
        //            {

        //                int temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;


        //                swapped = true;
        //            }
        //        }
        //        if (!swapped)
        //        {
        //            break;
        //        }
        //    }
        //}
        //#endregion

        #region 2
        public static void Main(string[] args)
        {
            Range<int> intRange = new Range<int>(2, 20);
            Console.WriteLine(  intRange.IsInRange(10));
            Console.WriteLine( intRange.Length());

            Range<double> doubleRange = new Range<double>(3.5, 12.4);
            Console.WriteLine( doubleRange.IsInRange(15));
            Console.WriteLine( doubleRange.Length());

        }
        #endregion






    }
}
