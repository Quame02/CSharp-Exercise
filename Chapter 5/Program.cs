using System;

namespace Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------CHAPTER 5--------");
            Console.WriteLine("1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.");
            Console.Write("Enter value for first integer: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for second integer: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());

            if (integer1 > integer2)
            {
                Console.WriteLine(integer1 = integer2);
            }
            else
            {
                Console.WriteLine("Void");
            }

            Console.WriteLine("2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.");

            Console.WriteLine("3. Write a program that finds the biggest of three integers, using nested if statements.");
            Console.Write("Enter first integer value: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer value: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third integer value: ");
            int integer3 = Convert.ToInt32(Console.ReadLine());

            if (integer1 > integer2 && integer1 > integer3)
            {
                Console.WriteLine(integer1);
            }
            else
            {
                if (integer2 > integer1 && integer2 > integer3)
                {
                    Console.WriteLine(integer2);
                }
                else
                {
                    Console.WriteLine(integer3);
                }

            }

            Console.WriteLine("4. Sort 3 real numbers in descending order. Use nested if statements.");
            Console.Write("input first number: ");
            string number1 = Console.ReadLine();
            Console.Write("input second number: ");
            string number2 = Console.ReadLine();
            Console.Write("input last number: ");
            string number3 = Console.ReadLine();

            if (number1 == number2 && number2 != number3)
            {
                Console.WriteLine($"{number3},{number2},{number1}");
            }
            else
            {
                if (number2 != number1 && number2 != number3)
                {
                    Console.WriteLine($"{number2},{number3},{number1}");
                }
                else
                {
                    Console.WriteLine($"{number1},{number3},{number2}");
                }
            }

            Console.WriteLine("5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.");
            Console.Write("Input 0,9 integers: ");
            int numbers = int.Parse(Console.ReadLine());
            switch (numbers)
            {
            case 0 = "zer0":
            case 1 = "one":
            case 2 = "two":
              Console.WriteLine(numbers);
            }

            Console.WriteLine("6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.");
            Console.Write("input the coefficient of \"a\": ");
            int CoA = int.Parse(Console.ReadLine());
            Console.Write("input the coefficient of \"b\": ");
            int CoB = int.Parse(Console.ReadLine());
            Console.Write("input the coefficient of \"c\": ");
            int CoC = int.Parse(Console.ReadLine());

            double D = Math.Pow(CoB,2) - 4 * CoA * CoC;
            Console.WriteLine($"Discriminant = {D}");

            double x;
            double x2;

            if (D < 0)
            {
                Console.WriteLine("The equation has no real roots!");
            }
            else if (D == 0)
            {
                x = -CoB/2 * CoA;
                Console.WriteLine($"The root of the equation is : {x}");
            }
            else if (D > 0)
            {
                x = -CoB + Math.Sqrt(CoB * CoB - (D))/2 * CoA;
                x2 = -CoB - Math.Sqrt(CoB * CoB - (D))/2 * CoA;
                Console.WriteLine($"The equation as two distinct real roots which are : {Math.Round(x,3)} & {Math.Round(x2,3)}");
            }

            Console.WriteLine("7. Write a program that finds the greatest of given 5 numbers.");
            Console.Write("input 5 numbers: ");
            string fiveNumbers = Console.ReadLine();
            string [] greater = new string [fiveNumbers];
           // for (string i = 0; i <= greater; i++)
            {
                Console.WriteLine(i.max);
            }

            Console.WriteLine("8. Write a program that, depending on the users choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends \"*\" at the end. Print the result at the console. Use switch statement.");
            Console.WriteLine(" ");
            Console.Write("Enter any variable: ");
            var variable = Console.ReadLine();
            Console.Write("Enter an input: ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (variable)
            {
                case "int":
                case "double":
                  Console.WriteLine($"{input + 1}");break;
                case "string":
                  Console.WriteLine($"{input}*"); break;
                default:
                  Console.WriteLine("Invalid input!"); break;
            
            }

            Console.WriteLine("9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0");
            Console.WriteLine(" ");
            Console.WriteLine("10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:- If the score is between 1 and 3, the program multiplies it by 10.- If the score is between 4 and 6, the program multiplies it by 100.- If the score is between 7 and 9, the program multiplies it by 1000.- If the score is 0 or more than 9, the program prints an error message."); 
             Console.Write("Enter random score:");
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3)
            {
             Console.WriteLine(score*10);
            }
            else if (score >=4 && score <=6)
            {
              Console.WriteLine(score*100);
            }
            else if (score >=7 && score<=9)
            {
              Console.WriteLine(score*1000);
            }
            else if (score == 0 || score>9)
            { 
              Console.WriteLine("Error message!!!");
            }

            Console.WriteLine("11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:- 0 --> \"Zero\"- 12 --> \"Twelve\"- 98 --> \"Ninety eight\"- 273 --> \"Two hundred seventy three\"- 400 --> \"Four hundred\"- 501 --> \"Five hundred and one\"- 711 --> \"Seven hundred and eleven\"");
            
            

            


        }
    }
}
