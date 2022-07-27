using System;

namespace Chapter_8
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("CHAPTER 8");
           Console.WriteLine("-------");
           Console.WriteLine(" ");


           Console.WriteLine("1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.");
           Console.Write("Conversion of 151 to binary is: ");
           //first conversion
           int firstConvert = 151;
           //Binary Equivalent
           string binaryEq1 = Convert.ToString(firstConvert,2); 
           Console.WriteLine(binaryEq1);
           Console.WriteLine("------");
           Console.Write("Conversion of 35 to binary is: ");
           //second conversion
           int secondConvert = 35;
           //Binary Equivalent
           string binaryEq2 = Convert.ToString(secondConvert,2); 
           Console.WriteLine(binaryEq2);
           Console.WriteLine("------");
           Console.Write("Conversion of 43 to binary is: ");
           //first conversion
           int thirdConvert = 43;
           //Binary Equivalent
           string binaryEq3 = Convert.ToString(thirdConvert,2); 
           Console.WriteLine(binaryEq3);
           Console.WriteLine("------");
           Console.Write("Conversion of 251 to binary is: ");
           //fourth conversion
           int fourthConvert = 251;
           //Binary Equivalent
           string binaryEq4 = Convert.ToString(fourthConvert,2); 
           Console.WriteLine(binaryEq4);
           Console.WriteLine("------");
           Console.Write("Conversion of 1023 to binary is: ");
           //fifth conversion
           int fifthConvert = 1023;
           //Binary Equivalent
           string binaryEq5 = Convert.ToString(fifthConvert,2); 
           Console.WriteLine(binaryEq5);
           Console.WriteLine("------");
           Console.Write("Conversion of 1024 to binary is: ");
           //sixth conversion
           int sixthConvert = 1024;
           //Binary Equivalent
           string binaryEq6 = Convert.ToString(sixthConvert,2); 
           Console.WriteLine(binaryEq6);
           Console.WriteLine("------");

           Console.WriteLine("2. Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.");
           string BinaryToHexa = "1111010110011110";
           string result = Convert.ToString(Convert.ToInt32(BinaryToHexa,2),16);
           Console.WriteLine($"The conversion of 1111010110011110 to hexadecimal is: {result}");
           Console.WriteLine("--------");

           string BinaryToDecimal = "1111010110011110";
           int result2 = Convert.ToInt32(BinaryToDecimal,2);
           Console.WriteLine($"The conversion of 1111010110011110 to decimal is: {result2}");

           Console.WriteLine("3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.");
           string hexaToBinary = "2A3E";
           string binary = Convert.ToString(Convert.ToInt32(hexaToBinary,16),2);
           Console.WriteLine($"The Binary conversion of {hexaToBinary} is {binary}");

           string hexaToDecimal = "2A3E";
           int decimal0 = Convert.ToInt32(hexaToDecimal,16);
           Console.WriteLine($"The Decimal conversion of {hexaToDecimal} is {decimal0}");
           Console.WriteLine("------");

           string hexaToBinary1 = "FA";
           string binary1 = Convert.ToString(Convert.ToInt32(hexaToBinary1,16),2);
           Console.WriteLine($"The Binary conversion of {hexaToBinary1} is {binary1}");

           string hexaToDecimal1 = "FA";
           int decimal1 = Convert.ToInt32(hexaToDecimal1,16);
           Console.WriteLine($"The Decimal conversion of {hexaToDecimal1} is {decimal1}");
           Console.WriteLine("------");

           string hexaToBinary2 = "FFFF";
           string binary2 = Convert.ToString(Convert.ToInt32(hexaToBinary2,16),2);
           Console.WriteLine($"The Binary conversion of {hexaToBinary2} is {binary2}");

           string hexaToDecimal2 = "FFFF";
           int decimal2 = Convert.ToInt32(hexaToDecimal2,16);
           Console.WriteLine($"The Decimal conversion of {hexaToDecimal2} is {decimal2}");
           Console.WriteLine("------");

           string hexaToBinary3 = "5A0E9";
           string binary3 = Convert.ToString(Convert.ToInt32(hexaToBinary3,16),2);
           Console.WriteLine($"The Binary conversion of {hexaToBinary3} is {binary3}");

           string hexaToDecimal3 = "5A0E9";
           int decimal3 = Convert.ToInt32(hexaToDecimal3,16);
           Console.WriteLine($"The Decimal conversion of {hexaToDecimal3} is {decimal3}");
           Console.WriteLine("------");

           Console.WriteLine("4. Write a program that converts a decimal number to binary one.");
           Console.Write("Enter a decimal number: ");
           int decimalNumber = Convert.ToInt32(Console.ReadLine());
           string decimalToBinary = Convert.ToString(decimalNumber,2);
           Console.WriteLine($"The Binary conversion of {decimalNumber} is {decimalToBinary}");
           Console.WriteLine("-----");

           Console.WriteLine("5. Write a program that converts a binary number to decimal one.");
           Console.Write("Enter a Binary number: ");
           string binaryNumber = Console.ReadLine();
           int binaryToDecimal = Convert.ToInt32(binaryNumber,2);
           Console.WriteLine($"The decimal conversion of {binaryNumber} is {binaryToDecimal}");
           Console.WriteLine("-------");

           Console.WriteLine("6. Write a program that converts a decimal number to hexadecimal one.");
           Console.WriteLine(" ");
           Console.Write("Enter a decimal number: ");
           int Integerr = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("the hexadecimal number of {0} is {0:X}",Integerr);
           Console.WriteLine("------");

           Console.WriteLine("7. Write a program that converts a hexadecimal number to decimal one.");
           Console.Write("Enter hexadecimal number: ");
           string hexaadecimal = Console.ReadLine();
           int hexaaToDecimal = Convert.ToInt32(hexaadecimal,16);
           Console.WriteLine($"The decimal conversion of {hexaadecimal} is {hexaaToDecimal}.");
           Console.WriteLine("--------");

           Console.WriteLine("8. Write a program that converts a hexadecimal number to binary one.");
           Console.Write("Enter hexadecimal number: ");
           string hexadecimaall = Console.ReadLine();
           string hexaToBinaryy = Convert.ToString(Convert.ToInt32(hexadecimaall,16),2);
           Console.WriteLine($"The binary conversion of {hexadecimaall} is {hexaToBinaryy}.");
           Console.WriteLine("--------");

           Console.WriteLine("9. Write a program that converts a binary number to hexadecimal one.");
           Console.Write("Enter the binary number: ");
           string binaryy = Console.ReadLine();
           string hexadecimall = Convert.ToString(Convert.ToInt32(binaryy,2),16);
           Console.WriteLine($"The hexadecimal conversion of {binaryy} is {hexadecimall}.");
           Console.WriteLine("-------");

           Console.WriteLine("10. Write a program that converts a binary number to decimal using the Horner scheme.");
           int deci = 0;
           Console.Write("Enter binary number: ");
           string binaryi = Console.ReadLine();
           int length = binaryi.Length;
           int power = length-1;

           for (int i = 0; i < length; i++)
           {
               deci += (int)
               (int.Parse(binaryi[i].ToString()) * Math.Pow(2,power));
               power--;
           }
           Console.WriteLine("Result is {0}.", deci);

           Console.WriteLine("11. Write a program that converts Roman digits to Arabic ones.");
           int result = 0;
           Console.Write("Enter Roman number: ");
           string s = Console.ReadLine();
           string[] chars = s.Select(c => c.ToString()).ToArray();

           for (int i = 0; i < chars.Length; i++)
           {
               if (chars[i] == "m" || chars[i] == "M") result += 1000;
               if (chars[i] == "d" || chars [i] == "D") result += 500;
               if (chars[i] == "c" || chars [i] == "C")
               {  result += 500;
               if (i < chars.Length-1)
               {
                if (chars[i + 1] == "d" || chars[i + 1] == "D") result -= 200;
                if (chars[i + 1] == "m" || chars[i + 1] == "M") result -= 200;
               }
               } 
                if (chars[i] == "l" || chars[i] == "L") result += 50;
                if (chars[i] == "x" || chars[i] == "X") 
               {
                    result += 10;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "l" || chars[i + 1] == "L") result -= 20;
                        if (chars[i + 1] == "c" || chars[i + 1] == "C") result -= 20;
                    }
                }
                if (chars[i] == "v" || chars[i] == "V") result += 5;
                if (chars[i] == "i" || chars[i] == "I")
                {
                  result++;
                    if (i < chars.Length - 1)
                    {
                        if (chars[i + 1] == "v" || chars[i + 1] == "V") result -= 2;
                        if (chars[i + 1] == "x" || chars[i + 1] == "X") result -= 2;
                    }
                }
            }

              Console.WriteLine("Arabic number is " + result);
              Console.WriteLine("-----");

              Console.WriteLine("13. Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N from an S-based numeral system to a D based numeral system.");
              int S, D;

              Console.Write("Enter N: ");
              string N = Console.ReadLine();
            
             do
             {
              Console.Write("Enter S (S == 2, 8, 10 or 16): ");
             S = Int32.Parse(Console.ReadLine());
             } while (S != 2 && S != 8 && S != 10 && S != 16);

             do
             {
              Console.Write("Enter D (D == 2, 8, 10 or 16): ");
                D = Int32.Parse(Console.ReadLine());
             } while (D != 2 && D != 8 && D != 10 && D != 16);

             N = Convert.ToString(Convert.ToInt32(N, S), D);

             Console.WriteLine($"Result is {N}.");









           



           
            
        }

    }
}
