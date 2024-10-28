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
            Console.WriteLine($"\nSummary of all values of the array: {summ}");
            return summ;
        }
        public static double ArrElemMid(int[] arr)
        {
            
            double mid = ArrElemSumm(arr) / arr.Length;
            Console.WriteLine($"\nMiddle value of the array: {mid}");
            return mid;
            
        }

        public static void ArrPNElemSumm(int[] arr, out int posSumm, out int negSumm) 
        {
            posSumm = 0; negSumm = 0 ;
            foreach (int el in arr)
            {
                if (el > 0) posSumm += el;
                else negSumm += el;
            }
            Console.WriteLine($"\nSumm of positive numbers of the array: {posSumm}");
            Console.WriteLine($"Summ of negative numbers of the array: {negSumm}");

        }

        public static void ArrEOElemSumm(int[] arr, out int evenSumm, out int oddSumm)
        {
            evenSumm = 0; oddSumm = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                if ((i+1)%2 == 0) evenSumm += arr[i];
                else oddSumm += arr[i];
            }
            Console.WriteLine($"\nSumm of values with even index of the array: {evenSumm}");
            Console.WriteLine($"Summ of values with odd index of the array: {oddSumm}");

        }
        public static void ArrHigestValue(int[] arr, out int minValueIndex, out int maxValueIndex) 
        {
            int maxTemp = arr[0], minTemp = arr[0];
            minValueIndex = maxValueIndex = 0;
            
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
            Console.WriteLine($"\nMin value: array[{minValueIndex}] = {minTemp}");
            Console.WriteLine($"Max value: array[{maxValueIndex}] = {maxTemp}");

        }

        public static int ArrMinMaxMulti(int[] arr) 
        {
            int minIndex, maxIndex;
            ArrHigestValue(arr, out minIndex, out maxIndex);
            int multi = arr[minIndex];
            for (int i = minIndex + 1; i <= maxIndex; i++) 
            {
                multi *= arr[i];
            }
            Console.WriteLine($"\nMultiplication of values between min and max values: {multi}");
            return multi;
            
        }



        static void Main(string[] args)
        {
            int[] arr = InputedArray();
            ArrElemMid(arr);
            int posSumm, negSumm;
            ArrPNElemSumm(arr, out posSumm, out negSumm);
            int evenSumm, oddSumm;
            ArrEOElemSumm(arr, out evenSumm, out oddSumm);

            ArrMinMaxMulti(arr);




        }
    }
}
