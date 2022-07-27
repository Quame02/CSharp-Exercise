using System;

namespace Chapter_2
{
    class Program
    {
        // public static int   Add(int a , int b)
        // {
        //     return a+ b;
        // }
        
        static void Main(string[] args)
        {
            

            //Console.WriteLine( Add(5,6));
            Console.WriteLine("-------CHAPTER 6-------");
            Console.WriteLine(" ");
            Console.WriteLine("1. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");
            Console.Write("Input any number of your choice: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("2. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.");
            Console.Write("Input any number of your choice: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            if (i%3!=0  ||  i%7!=0)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("3. Write a program that reads from the console a series of integers and prints the smallest and largest of them.");
            Console.Write("Enter series of integer values: ");
            int integers = int.Parse(Console.ReadLine());
            int[] newInt =  new int[integers];

            for (int i = 0; i <= newInt.Length; i++)
            {
                Console.WriteLine($"{Math.Max(i())}");
            }

             Console.WriteLine("4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).");
              Console.WriteLine("Print all 52 cards of a deck");

            for (int suit = 1; suit <= 4; suit++)
            {
                switch (suit)
                {
                    case 1:
                        Console.Write("Cards of Club: ");
                        break;
                    case 2:
                        Console.Write("Cards of Heart: ");
                        break;
                    case 3:
                        Console.Write("Cards of Spades: ");
                        break;
                    case 4:
                        Console.Write("Cards of Diamond: ");
                        break;
                    default:
                        Console.Write("Not a suit");
                        break;
                }
            }

                for (int card = 2; card <= 14; card++)
                {
                    switch(card)
                    {
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            Console.Write(" {0},", card);
                            break;
                        case 11:
                            Console.Write(" J,");
                            break;
                        case 12:
                            Console.Write(" Q,");
                            break;
                        case 13:
                            Console.Write(" K,");
                            break;
                        case 14:
                            Console.WriteLine(" A");
                            break;
                        default:
                            Console.Write("Not a card");
                            break;
                    }

                }   
            Console.WriteLine("5. Write a program that reads from the console number N and print the sumof the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,13, 21, 34, 55, 89, 144, 233, 377, …");
            Console.WriteLine("");
            int t1 = 0;
            int t2 = 1;
            Console.Write("Enter Nth term: ");
            int NthTerm = int.Parse(Console.ReadLine());
            int term;

            for (int i = 0; i <= NthTerm; i++)
            {
                //Console.Write("{0}", t1 );
                Console.Write($"  {t1}");
                term = t1 + t2;
                t1 = t2;
                t2 = term;
            }

            Console.WriteLine("6. Write a program that calculates N!/K! for given N and K (1<K<N).");
            Console.WriteLine(" ");
            //Calculating for N!.
            int number1, factorial1 = 1;
            Console.Write("Enter the value for N: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 < 0)
            {
                Console.WriteLine("Can't find the factorial of negative number!");
            }
            else if (number1 <= 1)
            {
                Console.WriteLine("{0}! = {1}", number1, factorial1);
            }
            else
            {
              for (int counter = number1; counter >= 2; counter--)
              {
                  factorial1 = factorial1 * counter;
              }Console.WriteLine("{0}! = {1}", number1, factorial1);
            }
             //Calculating for K!.
            int number2, factorial2 = 1;
            Console.Write("Enter the value for K: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            for (int counter = number2; counter >= 2; counter--)
              {
                  factorial2 = factorial2 * counter;
              }
              Console.WriteLine("{0}! = {1}", number2, factorial2);
              //Dividing the two factorials.
              int result = factorial1/factorial2;
              Console.WriteLine($"the division of the two factorial is \"{result}\" ");

            Console.WriteLine("7. Write a program that calculates N!*K!/(N-K)! for given N and K(1<K<N).");
            Console.WriteLine(" ");
            //Calculating N!
            int number1, factorial1 = 1;
            Console.Write("Enter the value for N: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 < 0)
            {
                Console.WriteLine("Can't find the factorial of negative number!");
            }
            else if (number1 <= 1)
            {
                Console.WriteLine("{0}! = {1}", number1, factorial1);
            }
            else
            {
              for (int counter = number1; counter >= 2; counter--)
              {
                  factorial1 = factorial1 * counter;
              }Console.WriteLine("{0}! = {1}", number1, factorial1);
            }
             //Calculating K!
            int number2, factorial2 = 1;
            Console.Write("Enter the value for K: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            for (int counter = number2; counter >= 2; counter--)
              {
                  factorial2 = factorial2 * counter;
              }
              Console.WriteLine("{0}! = {1}", number2, factorial2);
              //Multiplying the two factorials
              int result = factorial1 * factorial2;
              Console.WriteLine($"the Multiplication of the two factorial is \"{result}\" ");
              Console.WriteLine("---------");

             //Calculating for (N - K)!
              int result2;
              result2 = number1 - number2;
              int factorial3 = 1;

            for (int counter = result2; counter >= 2; counter--)
              {
                  factorial3 = factorial3 * counter;
              }Console.WriteLine("{0}! = {1}", result2, factorial3);
             Console.WriteLine("----------");

             // N!*K!/(N-K)!
             int overallResult = result/factorial3;
             Console.WriteLine($"The overall result is {overallResult}.");

             Console.WriteLine("8. In combinatorics, the Catalan numbers are calculated by the following formula:.........");
             Console.WriteLine(" ");
             Console.Write("Enter an integer: ");
             int N = int.Parse(Console.ReadLine());
             int multipliedN = 2*N;
             int multipliedFactorialN = 1;
             long Nfactorial = 1;
             int AddedN = N + 1;
             long AddedFactorial = 1;

             do
             {
                 multipliedFactorialN *= multipliedN;
                 multipliedN--;
             } while (multipliedN>0);
             
             do
             {
                 AddedFactorial *= AddedN;
                 AddedN--;
             } while (AddedN>0);

             do
             {
                 Nfactorial *= N;
                 N--;
             } while(N>0);

             long CatalanNumber = (multipliedFactorialN/AddedFactorial*Nfactorial);
             Console.WriteLine(CatalanNumber);
             Console.WriteLine("---------------");
             Console.WriteLine("9. Write a program that for a given integers n and x, calculates the sum:.......");
             Console.WriteLine(" ");
             double S = 1;
             double sequence;
             Console.Write("Enter an integer X: ");
             int X = int.Parse(Console.ReadLine());
             long factorialn = 1;

             for (int k=0; k < 5;)
             {
                 k++;
                do
                {
                    factorialn*=k;
                    k--;
                } while(k<0);
                k++;
                sequence = factorialn/Math.Pow(X,k);
                S += sequence;
             }
             Console.WriteLine(S);

            Console.WriteLine("10. Write a program that reads from the console a positive integer numberN (N < 20) and prints a matrix of numbers as on the figures below:N = 3 N = 41 2 32 3 43 4 51 2 3 42 3 4 53 4 5 64 5 6 7");
            Console.Write("Enter the numbers of the rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the columns:");
            int columns = int.Parse(Console.ReadLine());
            int[,] spiral = new int[rows, columns];
            Console.WriteLine("Enter the cells of the matrix:");
            for (int row = 0; row< rows; row++)
            {
            for (int col = 0; col < columns; col++)
            {
              Console.Write("matrix[{0},{1}] = ", row, col); 
              spiral[row, col] = int.Parse(Console.ReadLine());
            }
            }
            for (int row =0; row < spiral.GetLength(0); row++)
            {
            for (int col = 0; col < spiral.GetLength(1); col++)
            {
              Console.Write($" {spiral[row, col]}");
            }
              Console.WriteLine();
            }

            Console.WriteLine("11. Write a program that calculates with how many zeroes the factorial ofa given number ends. Examples:.....");
            Console.WriteLine(" ");
            Console.Write("Enter an integer value: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i=5; n/i >1;)
            {
                count += n/i;
                i*=5;
            }
            Console.WriteLine($"the number of zeros in {n}! is {count}");

            Console.WriteLine("12. Write a program that converts a given number from decimal to binary notation(numeral system).");
            Console.WriteLine(" ");
            Console.Write("Enter a decimal Number: ");
            int Decimal = Convert.ToInt32(Console.ReadLine());
            string ConvertedNo = Convert.ToString(Decimal,2);
            Console.WriteLine($"The binary number of {Decimal} is {ConvertedNo}");

            Console.WriteLine("13. Write a program that converts a given number from binary to decimal notation.");
            Console.WriteLine(" ");
            Console.Write("Enter a binary Number: ");
            string Binary = Console.ReadLine();
            int BinaryConvert = Convert.ToInt32(Binary,2);
            Console.WriteLine("the decimal Number of  "+Binary+ " is "+ BinaryConvert );

            Console.WriteLine("14. Write a program that converts a given number from decimal to hexadecimal notation.");
            Console.WriteLine(" ");
            Console.Write("Enter a decimal number: ");
            int Integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the hexadecimal number of {0} is {0:X}",Integer);

            Console.WriteLine("15. Write a program that converts a given number from hexadecimal to decimal notation.");
            Console.WriteLine(" ");
            Console.Write("Enter an hexadecimal number: ");
            string hexadecimal = Console.ReadLine();
            int DecimalInt = Convert.ToInt32(hexadecimal,16);
            Console.WriteLine("The hexadeciaml number of {0} is {1}",hexadecimal,DecimalInt);

            Console.WriteLine("16. Write a program that by a given integer N prints the numbers from 1 to N in random order.");
            Console.WriteLine(" ");
            Console.Write("Enter any Number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random numbers = new Random();
            for (int i = 1; i <= N; i++)
            {
              
              Console.WriteLine(numbers.Next(i,N));
            }

            Console.WriteLine("17. Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM). You may use the formula LCM(a, b) = |a*b| / GCD(a, b).");
             Console.WriteLine(" ");
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             while (a!=b)
            {
              if (a>b)
              {
                a-=b;
              } 
              else
              {
                b-=a;
              }
            }
              Console.WriteLine("the gcd of both number is "+a);

              


        }
    }
}
