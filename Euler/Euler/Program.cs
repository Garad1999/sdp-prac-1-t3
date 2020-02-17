using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {

        //Marc Marais
        //Euler lowest-number 4
        //Largest Palindrome Product 
        public static int Largest_Palindrome_Product()
        {
            int upper = 999;
            int lower = 100;

            int max_product = 0; //initialize result storage

            for (int i = upper; i >= lower; i--) //loop from highest numbers downward
            {
                for (int j = i; j >= lower; j--)
                {
                    int product = i * j;
                    if (product < max_product)
                        break;
                    int n = product;
                    int reverse = 0;

                    while (n != 0)
                    {
                        reverse = reverse * 10 + n % 10;
                        n /= 10;
                    }

                    if (product == reverse && product > max_product)
                        max_product = product;
                }
            }
            return max_product;
        }
        //James Gibson G18G0723
        //this method produces the sum of all the multiples of 3 and 5 under 1000.
        public static int Multiples_of_3_and_5()
        {
            int total = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    total = total + i;
                }
                else if (i % 5 == 0)
                {
                    total = total + i;
                }
            }
            return total;
        }
        public static int sumSquareDiff()
        { //MPHO's work'
            int sum = 0;
            int product = 0;

            for (int i = 0; i <= 100; i++) //needed to go up to 100, just modified it to represent this *Garad
            {
                sum += (i * i); //couldnt run the (i * * 2) on my version of visual studio *Garad
                product += i;
            }
            product = product * product;    //couldnt run the (Product * * 2) on my version of visual studio *Garad
            return (product - sum);
        }

        public static int EvenFibonicciSumming()
        //Garad Watkins, G18w8475  
        //Euler problem 2.
        {
            int SummedUpValues = 2;
            int FibonnaciNumber = 0;
            int fibnum = 1;
            int fibnum2 = 2;
            bool checker = true;
            while (checker)  //while loop controlled by checker
            {
                if (FibonnaciNumber > 4000000) //4 Million limited
                {
                    checker = false; //Checker for the while loop
                }
                else
                {
                    FibonnaciNumber = fibnum + fibnum2;
                    fibnum = fibnum2;
                    fibnum2 = FibonnaciNumber;
                    if (FibonnaciNumber % 2 == 0)   //IF the Number is even it is added to SummedUpValues
                    {
                        SummedUpValues += FibonnaciNumber;
                    }
                }
            }
            return SummedUpValues;
        }



        public static void Main(String[] args)
        {
            Console.WriteLine("Largest Palindrome Product: " + Largest_Palindrome_Product());
            Console.WriteLine("Multiples of 3 and 5 under 1000: " + Multiples_of_3_and_5());
            Console.WriteLine("Sum of diff squares is: " + sumSquareDiff());
            Console.WriteLine("Sum of all even Fibonacci numbers: " + EvenFibonicciSumming());
            Console.ReadLine();
        }

    }
}

