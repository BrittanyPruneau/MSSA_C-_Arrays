using System;

namespace QuizArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[10]; 
            for(int i = 0; i<numberArray.Length; i++)
            {
                Console.WriteLine("Enter a number");
               int j = Int32.Parse(Console.ReadLine());
                numberArray[i] = j; 
            }
            Console.WriteLine("Using a for loop :  "); 
            for(int k = 0; k<numberArray.Length; k++)
            {
                Console.WriteLine(numberArray[k]); 
            }
            Console.WriteLine("Now using a foreach loop :  "); 
            foreach(int numb in numberArray)
            {
                Console.WriteLine(numb); 
            }

            Console.WriteLine("Now i'm going to ask you how many numbers you want to input, prompt you to input those numbers one by one and then print those numbers you entered");
            Console.WriteLine("How many numbers would you like to input? ");
            int size = Int32.Parse(Console.ReadLine());
            int[] Numbers2 = new int[size]; 
            for(int l = 0; l<Numbers2.Length; l++)
            {
                Console.WriteLine("Enter a number");
                int j = Int32.Parse(Console.ReadLine());
                Numbers2[l] = j;
            }
            Console.WriteLine("Now printing all the numbers you input : ");
            foreach(int numb in Numbers2)
            {
                Console.WriteLine(numb); 
            }

        }
    }
}

// practice 
 // create an array of 26 char. 
 // char[] alphabet = new char[26];
//Console.WriteLine("Enter your favorite character");
//char favchar = Console.ReadLine()[0];
//Console.WriteLine(favchar);
////char uppercase = Char.ToUpper(favchar);
////Console.WriteLine(uppercase); 

//int j = 0;
//for (char i = 'a'; i <= 'z'; i++)
//{
//    alphabet[j] = i;
//    Console.WriteLine(alphabet[j]);

//    if (alphabet[j] == favchar)
//    {
//        char uppercase = Char.ToUpper(favchar);
//        alphabet[j] = uppercase;
//    }
//    j++;