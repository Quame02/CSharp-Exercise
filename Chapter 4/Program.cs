using System;

namespace Chapter_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------CHAPTER 4-------");

            Console.WriteLine("***********CHAPTER 4************");
             Console.WriteLine("**CH4 (Ques 1)**");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads from the console three numbers of type int and prints their sum.");
             Console.Write("Enter first integer:");
             int firstInteger = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter second integer:");
             int secondInteger = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter third integer:");
             int thirdInteger = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($" sum = {firstInteger + secondInteger + thirdInteger}");

             Console.WriteLine("**CH 4 (Ques 2)**");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads from the console the radius \"r\" of a circle and prints its perimeter and area.");
             Console.Write("From your input value for radius, find the perimeter and area of a circle. R equals =");
             double R = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("HINT: Perimeter = 2PIr while that of Area is = PI r^2");
             double Perimeter = 2* Math.PI *R;
             double Area = Math.PI* R * R;
             Console.WriteLine($"The perimeter and area of the circle is {Math.Round(Perimeter,3)} && {Math.Round(Area,3)} respectively.");

             Console.WriteLine("**CH 4 (Ques 3)**");
             Console.WriteLine(" ");
             Console.WriteLine("A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.");
             string companyName;
            string companyAddress;
            ulong companyPhoneNumber;
            ulong companyFaxNumber;
            string companyWebSite;
            string managerName;
            string managerSurname;
            ulong managerPhoneNumber;

            Console.WriteLine("Enter the company name, address, phone number, fax number and website: ");
            companyName = Console.ReadLine();
            companyAddress = Console.ReadLine();
            ulong.TryParse(Console.ReadLine(), out companyPhoneNumber);
            ulong.TryParse(Console.ReadLine(), out companyFaxNumber);
            companyWebSite = Console.ReadLine();

            Console.WriteLine("Enter the manager name, surname and phone number: ");
            managerName = Console.ReadLine();
            managerSurname = Console.ReadLine();
            ulong.TryParse(Console.ReadLine(), out managerPhoneNumber);

            Console.WriteLine("Company Name: {1}{0}Company Address: {2}{0}Company Phone Number: {3:(00)0000-0000}{0}" +
                "Company Fax Number: {4:(00)0000-0000}{0}Company Website: {5}{0}Company Manager Name: {6} {7}{0}" +
                "Manager Phone Number: {8:(00)0000-0000}", Environment.NewLine, companyName, companyAddress, 
                companyPhoneNumber, companyFaxNumber, companyWebSite, managerName, managerSurname, managerPhoneNumber);


             Console.WriteLine("**CH 4 (Ques 4)**");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.");
             int number1;
            float number2;
            float number3;

            Console.WriteLine("Enter 3 numbers:");
            int.TryParse(Console.ReadLine(), out number1);
            float.TryParse(Console.ReadLine(), out number2);
            float.TryParse(Console.ReadLine(), out number3);

            Console.WriteLine("{0,-10:X}{1,-10:0.00}{2,-10:-0.00}", number1, number2, number3);

             Console.WriteLine("**CH 4 (Ques 5)**");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.");
             Console.WriteLine("Enter first integer");
             int integer1 =Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second integer");
             int integer2 = Convert.ToInt32(Console.ReadLine());
             While(integer1 <= integer2)
            { 
              integer1++;
              if (integer1 % 5==0)
             {
                Console.WriteLine(integer1);
             }
            }

              Console.WriteLine($"Answer equals {integer1}");

              Console.WriteLine("**CH 4 (Ques 6)**");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.");
             Console.Write("Enter first number: ");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter second number: ");
             int num2 = Convert.ToInt32(Console.ReadLine());

             if (num1>num2)
             {
               Console.WriteLine(num1);
             }
             else
             {
               Console.WriteLine(num2);
             }

             Console.WriteLine("--CH4 (Ques 7)--");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.");
             Console.WriteLine("Given integer numbers of value 5,6,7,8,9...Write a programe that print their sum.");
             Console.Write("Enter number: ");
             Console.

             Console.WriteLine("--CH4 (Ques 8)--");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads five numbers from the console and prints the greatest of them.");
             Console.Write("Enter first number: ");
             int firstNumber = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter second number: ");
             int secondNumber = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter third number: ");
             int thirdNumber = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter fourth number: ");
             int fourthNumber = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter fifth number: ");
             int fifthNumber = Convert.ToInt32(Console.ReadLine());

             if (firstNumber>secondNumber && firstNumber>thirdNumber && firstNumber>fourthNumber && firstNumber>fifthNumber)
             {
               Console.WriteLine(firstNumber);
             }
             else if (secondNumber>firstNumber && secondNumber>thirdNumber && secondNumber>fourthNumber && secondNumber>fifthNumber)
             {
               Console.WriteLine(secondNumber);
             }
             else if (thirdNumber>firstNumber && thirdNumber>secondNumber && thirdNumber>fourthNumber && thirdNumber>fifthNumber)
             {
               Console.WriteLine(thirdNumber);
             }
             else if (fourthNumber>firstNumber && fourthNumber>secondNumber && fourthNumber>thirdNumber && fourthNumber>fifthNumber)
             {
               Console.WriteLine(fourthNumber);
             }
             else
             {
               Console.WriteLine(fifthNumber);
             }
             Console.WriteLine("Gosh this is so stressful!!! I want an easier method!.");

             
             Console.WriteLine("--CH4 (Ques 9)--");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.");
             int[] number;
            int quantity;
            long sum = 0;

            do
            {   
                Console.WriteLine("Enter how much numbers you want to sum: ");
            } while (!int.TryParse(Console.ReadLine(), out quantity));

            number = new int[quantity];

            for (int i = 0; i <= number.Length - 1; i++)
            {
                do
                {
                    Console.WriteLine("Enter an integer ({0} of {1})", i + 1, quantity);
                } while (!int.TryParse(Console.ReadLine(), out number[i]));

                sum += number[i];
            }

            Console.WriteLine("Sum: {0}", sum);

             Console.WriteLine("--CH4 (Ques 10)--");
             Console.WriteLine(" ");
             Console.WriteLine("Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.");
             uint number;

            do
            {
                Console.WriteLine("Enter an positive integer: ");
            } while (!uint.TryParse(Console.ReadLine(), out number));

            Console.WriteLine("Printing 1 to {0}: ", number);
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--CH4 (Ques 11)--");
            Console.WriteLine(" ");
            Console.WriteLine("Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …");
             uint fibonacciSequence = 100;
            //using decimal due to the largest values
            decimal previous = 0;
            decimal actual = 1;
            decimal aux = 0;

            Console.WriteLine("Printing first {0} numbers of Fibonacci sequence:");
            Console.WriteLine(previous);
            Console.WriteLine(actual);
            for (uint i = 3; i <= fibonacciSequence - 3; i++)
            {
                aux = previous + actual;
                Console.WriteLine(aux);
                previous = actual;
                actual = aux;
            }

            Console.WriteLine("--CH4 (Ques 12)--");
            Console.WriteLine(" ");
            Console.WriteLine("Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …");
            float sum = 0;
            float sumTest = 1;
            float fraction = 2F; 

            while (Math.Abs(sumTest - sum) > 0.001)
            {
                sum = sumTest;
                if (fraction % 2 == 0)
                {
                    sumTest = sum + (1 / fraction);
                } else
                {
                    sumTest = sum - (1 / fraction);
                }
                fraction++;
            }

            Console.WriteLine("Result: {0}", sum);

        }
    }
}
