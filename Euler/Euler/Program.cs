using System;

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

		for (int i = upper; i>= lower; i--) //loop from highest numbers downward
		{
			for (int j = i; j >= lower; j--)
			{
				int product = i*j;
				if (product<max_product)
					break;
				int n = product;
				int reverse = 0;

				while (n != 0)
				{
					reverse = reverse*10 + n % 10;
					n /= 10;
				}

				if (product == reverse && product>max_product)
					max_product = product;
			}			
		}
		return max_product;
	}
	//James Gibson G18G0723
	//this method produces the sum of al the multiples of 3 and 5 under 1000.
	public staticint Multiples_of_3_and_5()
	{
		int total
		for(int i = 0; i<1000;i++;)
		{
			if (i%3==0)
			{
				total = total +i;
			}
			else if(i%5==0)
			{
				total=total + i;
			}
		}
		return total;
	}
	public static sumSquareDiff()
	{ //MPHO's work'
		int sum = 0;
		int prod = 0;

		for(int i=0; i<10;i++)
		{
			sum += i**2;
			product += i;
		}
		product = product**2;
		return (product-sum);
	}
	
        static void Main(string[] args)
        {
            Console.WriteLine(Largest_Palindrome_Product());
			Console.WriteLine("Multiples of 3 and 5 under 1000: " + staticint Multiples_of_3_and_5());
			Console.WriteLine("Smum of diff squares is: " + sumSquareDiff());
        }
    }
}
