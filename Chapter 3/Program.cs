using System;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----CHAPTER 3-----");
            Console.WriteLine(" ");
            Console.WriteLine("********CHAPTER 3 (Question 1)********");
              Console.WriteLine(" ");
              Console.WriteLine("Write an expression that checks whether an integer is odd or even");
              Console.Write("Enter an integer:");
              int input = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine($"if the number is {input % 2 ==0} then it's an even number");
              Console.WriteLine($"But if the number is {input % 2 !=0}? then it's an odd number");
             //var result = input % 2 ==0? true : false;
             //Console.WriteLine(result);*/

             Console.WriteLine("*****CHAPTER 3 (Question 2)*****");
             Console.WriteLine(" ");
             Console.WriteLine("Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.");
             Console.Write("Enter a number of type integer:");
             int input = Convert.ToInt32(Console.ReadLine());
             var result = input % 5 ==0 && input % 7 ==0? true : false;
             Console.WriteLine(result);

             Console.WriteLine("*****CHAPTER 3 (Question 3)*****");
             Console.WriteLine(" ");
             Console.WriteLine("Write an expression that looks for a given integer if its third digit (right to left) is 7.");
             Console.Write("Enter an integer: ");
             string number = Console.ReadLine();
            
             Console.WriteLine("The third digit " + (number.Length <= 3 && number[number.Length - 3].Equals('7') ? "is" 
                : "isn't") + " 7.");
             Console.WriteLine("OR");

             if(number[0] == ('7'))     //if(number[number.Length - 3] == ('7'))
             { 
               Console.WriteLine("The third digit is 7.");
             }
             else
            {
              Console.WriteLine("The third digit isn't 7.");
            }

            // Console.WriteLine("*****CHAPTER 3 (Question 4)");
            // Console.WriteLine(" ");
            // Console.WriteLine("Write an expression that checks whether the third bit in a given integer is 1 or 0");


             Console.WriteLine("*****CHAPTER 3 (Question 5)");
             Console.WriteLine(" ");
             Console.WriteLine("Write an expression that calculates the area of a trapezoid by given sides a, b and height h.");
             Console.Write("Enter the value for a:");
             int a = int.Parse(Console.ReadLine());
             Console.Write("Enter the value for b:");
             int b = int.Parse(Console.ReadLine());
             Console.Write("Enter the value for c:");
             int h = int.Parse(Console.ReadLine());
             double Area = 0.5 *((a + b)*h);
             Console.WriteLine($"The area of the trapezoid is :{Area}");

             Console.WriteLine("*****CHAPTER 3 (Question 6)");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.");
             Console.Write("Enter value for side:");
             int side = int.Parse(Console.ReadLine());
             Console.Write("Enter value for height:");
             int height = int.Parse(Console.ReadLine());
             double Area = side*height;
             double perimeter = 2*(side + height);
             Console.WriteLine($"The Perimeter and Area of the Rectangle is : {Area} and {perimeter}");

             Console.WriteLine("*****CHAPTER 3 (Question 7)*****");
             Console.WriteLine(" ");
             Console.WriteLine("The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.");
             Console.Write("Enter weight: ");
             int weightGiven = Convert.ToInt32(Console.ReadLine());
             double weightCalc = weightGiven * 0.17;
             Console.WriteLine($"The weight of man on the moon is: {weightCalc}.");

             Console.WriteLine("*****CHAPTER 3 (Question 8)*****");
             Console.WriteLine(" ");
             Console.WriteLine("Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.");
             Console.WriteLine("Enter value for x:");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter value for y:");
              int y = Convert.ToInt32(Console.ReadLine());
              double d = (x*x + y*y);
              bool isInside = (x*x + y*y <= d)? true : false;
              Console.WriteLine("The point O({0},{1}) is inside K((0,0)5)?:{2}", x,y,isInside);

             Console.WriteLine("*****CHAPTER 3 (Question 9)*****");
             Console.WriteLine(" ");
             Console.WriteLine("Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.");
             Console.WriteLine;
             
             Console.WriteLine("*****CHAPTER 3 (Question 10)*****");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:- Calculates the sum of the digits (in our example 2+0+1+1 = 4).- Prints on the console the number in reversed order: dcba (in our example 1102).- Puts the last digit in the first position: dabc (in our example 1201).- Exchanges the second and the third digits: acbd (in our example 2101).");
             Console.Write("Enter a four digit number: ");
             string num = Console.ReadLine();
             int firstNumber = Convert.ToInt32(num[0].ToString());
             int secondNumber = Convert.ToInt32(num[1].ToString());
             int thirdNumber = Convert.ToInt32(num[2].ToString());
             int fourthNumber = Convert.ToInt32(num[3].ToString());

             Console.WriteLine($" {firstNumber + secondNumber + thirdNumber + fourthNumber}");
             Console.WriteLine($" {fourthNumber}{thirdNumber}{secondNumber}{firstNumber}");
             Console.WriteLine($" {fourthNumber}{secondNumber}{thirdNumber}{firstNumber}");
             Console.WriteLine($" {firstNumber}{thirdNumber}{secondNumber}{fourthNumber}");
             Console.WriteLine();

             

              Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                //int number = 6;
                switch (number)
              {
              case 2:
              case 3:
              case 5:
              case 7:
              case 10:
              Console.WriteLine("The number is not prime!"); break;
              case 1:
              case 4:
              case 6:
              case 8:
              case 9:
              Console.WriteLine("The number is prime!"); break;
              default:
              Console.WriteLine("Unknown number!"); break;
              }

        }
    }
}
