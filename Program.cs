using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Our goal is to find the highest number in the given array, and to print it to the console window.

            //Initialize an array with 5 numbers.
            int[] myArray = new int[5] { 3, 26, 4, 99, 21 };

            //Initialize the highestNumber value that will hold our highest number as it is found while looping through the array.
            int highestNumber = 0;

            //Loop through the array comparing values to the previous highest number, replacing the highestNumber value whenever a larger number is found.
            for (int i = 0; i < myArray.Length; i++)
                if (myArray[i] > highestNumber)
                    highestNumber = myArray[i];
            
            //Write the highest number to the console window.
            Console.WriteLine(highestNumber);

            Console.ReadLine();
        }
    }
}
