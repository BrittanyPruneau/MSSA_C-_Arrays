using System;
using System.Security.Cryptography.X509Certificates;

namespace ExCArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a Method that accepts an array of ints as a parameter, and returns the sum of all of the values in that array. The return type should be an int.
            // Array a: 0, 2, 4, 6, 8, 10
            // Array b: 1, 3, 5, 7, 9
            // Array c: 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9

            

            int[] a = new[] { 0, 2, 4, 6, 8, 10 };
            int[] b = new int[] { 1, 3, 5, 7, 9};
            a = b;
            b[2] = 90;
            b[1] = 91;
            int theSum = SumArray(a);
            Console.WriteLine("The sum of the array is: {0}", theSum);

            // Write a Method that takes an array of ints as a parameter, and returns the average 
            // of all of the values in that array. The return type should be a double.
            double average = AverageArray(a);
            Console.WriteLine("The average of the array is: {0}", average);


            // Write a Method that accepts an array of ints as a parameter, and prints out the values 
            // in that array in reverse order. The return type should be void.
            ReverseArray(a);

            // max
            int maxOfTheArray = MaxArray(a);
            Console.WriteLine("The max of the array is : {0}", maxOfTheArray);

            //Rotating the array to the left two spaces
            Console.WriteLine("Rotated the Array to the left:");
            int[] Original = new int[] { 0, 2, 4, 6, 8, 10 };
            int numberOfSpacesToTheLeft = 2;
            RotateLeft(Original, numberOfSpacesToTheLeft);
            PrintingRotatedArray(Original, Original.Length);
            Console.WriteLine("");

            //Rotating the array to the right 2 spaces
            Console.WriteLine("Rotated the Array to the right:");
            int numberOfSpacesToTheRight = 2;
            int[] Original2 = new int[] { 0, 2, 4, 6, 8, 10 };
            RotateRight(Original2, numberOfSpacesToTheRight);
            PrintingRotatedArray(Original2, Original.Length);

            // Sorting an array 
            int[] b2 = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Sort(b2);

            //foreach (int bint in returnedArray)
            //{
            //    Console.Write(" {0}", bint);
            //}

        }

        static void Sort (int [] b2)
        {
            //SORTING THE ARRAY OF INTEGERS
            Console.WriteLine(" ");
          
            int temporary = 0;
            for (int i = 0; i < b2.Length; i++)
            {
                for (int j = i + 1; j < b2.Length; j++)
                {
                    if (b2[i] > b2[j])
                    {
                        temporary = b2[j];
                        b2[j] = b2[i];
                        b2[i] = temporary;
                    }
                }
            }
            Console.WriteLine(" The sorted array");
            int[] b3 = b2;
            foreach (int bint in b3)
            {
                Console.Write("  {0}", bint);
            }
            
            


        }



        static void RotateLeft( int[] Original, int numberOfSpacesToTheLeft)
        {
            int length = Original.Length; 
            for (int i = 0; i<numberOfSpacesToTheLeft; i++)  
            {
                int temporaryVariable = Original[0];
                for (int j = 1; j<length; j++)
                {
                    Original[j - 1] = Original[j];
                               // Console.WriteLine("Showing {0}", Original[j - 1]);  just sused this to make sure I was moving the integers in the correct direction. 
                }
                Original[length-1] = temporaryVariable;
                // Console.WriteLine("The temporary variable we are placing at the end is now {0}", temporaryVariable);
                // just used this to make sure 
                //  I was moving the last value in the array to the first value in the array.
            }
        }

        static void RotateRight(int[] Original, int numberOfSpacesToTheRight)
        {
            int length = Original.Length; 
            for (int i = 0; i < numberOfSpacesToTheRight; i++)
            {
                int temporaryVariable = Original[length-1];
                for (int j = length-1; j > 0; j--)
                {
                    Original[j] = Original[j-1];
                            // Console.WriteLine("Showing {0}", Original[j - 1]);  just used this to make sure I was moving the integers in the correct direction. 
                }
                Original[0] = temporaryVariable;
                 // Console.WriteLine("The temporary variable we are placing at the end is now {0}", temporaryVariable);  
                 // just used this to make sure 
                 //  I was moving the last value in the array to the first value in the array.
            }
        }

        static void PrintingRotatedArray(int[] Original, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(Original[i] + " ");

            }
        }
            static int SumArray(int[] a)
            {
                int sum = 0;
                foreach (int b in a)
                {
                    sum += b;
                }
                //Console.WriteLine(sum);
                return sum;
            }

            static double AverageArray(int[] a)
            {
                int sum = 0;
                foreach (int b in a)
                {
                    sum += b;
                }
                double average = sum/a.Length;
                //Console.WriteLine(sum);
                return average;
            }

            static void ReverseArray(int[] a)
            {
                int[] reversedArray = new int[a.Length];
                int j = 0;
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    reversedArray[j] = a[i];
                    j++;
                }
            Console.WriteLine("The reversed array:  ");
                foreach (int s in reversedArray)
                {
                    Console.Write("  {0}", s);
                }
            Console.WriteLine(" ");
            }

            static int MaxArray(int[] a)
            {
                int max = 0;
                // to find the max value I want to compare the values of values next to each other and keep the bigger one until i've filtered the entire array. 
                for(int i = 0; i<a.Length-1; i++)
                {
                    if (a[i] > a[i + 1] && a[i] > max)
                    {

                        max = a[i];
                    }
                    else if (a[i] < a[i+1] && a[i+1] > max)
                    {
                        max = a[i + 1];
                    }
                }
                
                return max;
            
            }
          

        }
      }
    

