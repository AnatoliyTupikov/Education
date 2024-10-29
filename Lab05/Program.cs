using System.Security.Cryptography;

namespace Lab05
{
    internal class Program
    {
        
        public static int[] InputedArray() 
        {
            int arrLength;            
            while (true)
            {
                Console.WriteLine("\nInput an array length:");
                if (!Int32.TryParse(Console.ReadLine(), out arrLength) || arrLength < 0)
                {
                    Console.WriteLine($"\nWrong format data!\nYou need input a positive integer.\nTry again!");
                    continue;
                }
                break;            
            }
            int[] arr = new int[arrLength];
            
            for (int i = 0; i < arrLength; i++) 
            {
                int el;
                while (true)
                {
                    Console.WriteLine($"\nInput {i + 1} element of the array:");
                    if (!Int32.TryParse(Console.ReadLine(), out el))
                    {
                        Console.WriteLine($"\nWrong format data!\nYou need input an integer.\nTry again!");
                        continue;
                    }
                    break;
                }
                arr[i] = el;
            }
            return arr;
        }

        public static int ArrElemSumm(int[] arr)
        {
            int summ = 0;
            foreach (int el in arr) summ += el;
            return summ;
        }
        public static double ArrElemMid(int[] arr)
        {
            
            double mid =  (double)ArrElemSumm(arr) / arr.Length;
            return mid;
            
        }

        public static (int posSumm, int negSumm) ArrPNElemSumm(int[] arr)//, out int posSumm, out int negSumm) 
        {
            int pSumm = 0; int nSumm = 0 ;
            foreach (int el in arr)
            {
                if (el > 0) pSumm += el;
                else nSumm += el;
            }
            return (pSumm, nSumm);
            //Console.WriteLine($"\nSumm of positive numbers of the array: {posSumm}");
            //Console.WriteLine($"Summ of negative numbers of the array: {negSumm}");

        }

        public static (int evenSumm, int oddSumm) ArrEOElemSumm(int[] arr)
        {
            int evenSumm = 0; 
            int oddSumm = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                if ((i+1)%2 == 0) evenSumm += arr[i];
                else oddSumm += arr[i];
            }
            return (evenSumm, oddSumm);
            

        }
        public static (int minIndex, int maxIndex) ArrHigestValue(int[] arr) 
        {
            int maxTemp = arr[0], minTemp = arr[0];
            int minValueIndex = 0; int maxValueIndex = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxTemp < arr[i])
                {
                    maxValueIndex = i; maxTemp = arr[i];
                }
                if (minTemp > arr[i])
                {
                    minValueIndex = i; minTemp = arr[i];
                }
            }
            return (minValueIndex ,maxValueIndex);
            

        }

        public static int ArrMinMaxMulti(int[] arr) 
        {
            
            var tempind = ArrHigestValue(arr);
           
            if (tempind.minIndex > tempind.maxIndex) tempind = (tempind.maxIndex, tempind.minIndex); 

            int multi = arr[tempind.minIndex];
            for (int i = tempind.minIndex + 1; i <= tempind.maxIndex; i++) 
            {
                multi *= arr[i];
            }
            
            return multi;
            
        }



        static void Main(string[] args)
        {
            int[] arr = InputedArray();
            
            Console.WriteLine($"\nSummary of all values of the array: {ArrElemSumm(arr)}");
          
            Console.WriteLine($"\nMiddle value of the array: {ArrElemMid(arr)}");


            var posneg = ArrPNElemSumm(arr);
            Console.WriteLine($"\nSumm of positive numbers of the array: {posneg.posSumm}");
            Console.WriteLine($"Summ of negative numbers of the array: {posneg.negSumm}");
            

            var evenodd = ArrEOElemSumm(arr);
            Console.WriteLine($"\nSumm of values with even position of the array: {evenodd.evenSumm}");
            Console.WriteLine($"Summ of values with odd position of the array: {evenodd.oddSumm}");


            var minmax = ArrHigestValue(arr);
            Console.WriteLine($"\nIndex of Min value: {minmax.minIndex}");
            Console.WriteLine($"Index of Max value:{minmax.maxIndex}");

            
            Console.WriteLine($"\nMultiplication of values between min and max values: {ArrMinMaxMulti(arr)}");



        }
    }
}
