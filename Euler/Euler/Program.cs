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
        static void Main(string[] args)
        {
            Console.WriteLine(Largest_Palindrome_Product());
        }
    }
}
