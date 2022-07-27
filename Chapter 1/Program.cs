using System;

namespace Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------CHAPTER 1-------");

            
            Console.WriteLine("******CHAPTER2 (Question 6)*******");
              Console.WriteLine(" ");
              bool isMale = true!;
              Console.Write(isMale);
              
              Console.WriteLine("***************CHAPTER2 (Question7)***************");
              Console.WriteLine(" ");
              string firstWord = "Hello";
              string secondWord = "Word!!!";
              object concatenationOfTheTwoStringVariables = firstWord+ " " +secondWord;
              Console.WriteLine(concatenationOfTheTwoStringVariables);

              Console.WriteLine("******CHAPTER2 (Question 8)*******");
              Console.WriteLine(" ");

              Console.WriteLine(" ");
              string firstWord = "Hello";
              string secondWord = "Word!!!";
              object concatenateString = firstWord+ " " +secondWord;
              string initialize =Convert.ToString(concatenateString);   // or we use concatenate.ToString
              Console.WriteLine(initialize);
              
              Console.WriteLine("******CHAPTER2 (Question 9)*******");
              Console.WriteLine(" ");

              string first = "The \"use\" of Quotations causes difficulties.";
              string second = "\"The \"use\" of Quotations causes difficulties.\"";
              Console.WriteLine(first);
              Console.WriteLine(second);

              Console.WriteLine("******CHAPTER2 (Question 10)*******");
              Console.WriteLine(" ");
              
              Console.WriteLine(" o  o        o");
              Console.WriteLine("o     o   o    o");
              Console.WriteLine(" o      o     o");
              Console.WriteLine("   o         o");
              Console.WriteLine("     o     o");
              Console.WriteLine("        o");

              Console.WriteLine("******CHAPTER2 (Question 11)*******");
              Console.WriteLine(" ");

              Console.WriteLine("@");
              Console.WriteLine("@  @");
              Console.WriteLine("@   @");
              Console.WriteLine("@    @");
              Console.WriteLine("@     @");
              Console.WriteLine("@ @ @  @");
              
              Console.WriteLine("******CHAPTER2 (Question 12)*******");
              Console.WriteLine(" ");

              Console.Write("Enter first name:");
              Console.ReadLine();
              Console.Write("Enter last name:");
              Console.ReadLine();
              Console.Write("Enter your age:");
              int age = Convert.ToInt32(Console.ReadLine());
              Console.Write("M or F:");
              char gender = Convert.ToChar(Console.ReadLine());
              Console.Write("Input your phone number:");
              long phoneNumber = long.Parse(Console.ReadLine());
              Console.WriteLine("Successful!");

              Console.WriteLine("******CHAPTER2 (Question 13)*******");
              Console.WriteLine(" ");

              int num1 = 5;
              int num2 = 7;

              int newNum = num1;
              num1 = num2;
              num2 = newNum;
              Console.WriteLine(num2);
        }
    }
}
