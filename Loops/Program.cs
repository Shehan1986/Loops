using System;
using System.Formats.Asn1;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num1;
            string ans = "";

            WriteLine("Enter the number ");
            num1 = int.Parse(ReadLine());
            do
            {
                if ((num1 % 3 == 0) && (num1 % 5 == 0))
                {
                    WriteLine("FizzBuzz");
                }
                else if (num1 % 3 == 0)
                {
                    WriteLine("Fizz");
                }
                else if (num1 % 5 == 0)
                {
                    WriteLine("Buzz");
                }
                else
                {
                    WriteLine(num1.ToString());

                }

                Write("Do you want to plqy again? Yes/No");
                ans = ReadLine().ToLower();

            } while (ans == "yes");
            //do while loop

            WriteLine("DO While Loop");

            int d = 0;
            do
            { 
                WriteLine(d++);

            } while (d <= 10);
            
            
            //while loop
            //valid entry condition
            //valid exit condition
            //may or may 


            double res = 0;
            Write("Enter Number: ");
            double value_2 = double.Parse(ReadLine());
            res = value_2;
            Write("Choose an option + - * / = ");
            char op = char.Parse(ReadLine());
           
            if (op == '+' || op == '-' || op == '*' || op == '/' || op == '=')
            {

                while (op != '=')
                {
                    Write("Enter Number: ");
                    value_2 = double.Parse(ReadLine());

                    switch (op)
                    {
                        case '+':
                            res = res + value_2;
                            break;
                        case '-':
                            res = res - value_2;
                            break;
                        case '*':
                            res = res * value_2;
                            break;
                        case '/':
                            res = res / value_2;
                            break;
                    }
                    Write("Choose an option + - * / = ");
                    op = char.Parse(ReadLine());

                    WriteLine($"Result is {res}");
                }
            }
            else
                WriteLine("Wrong option!    ");

            //read numbers from users until user enter 0
            //print the sum and avarage

            double sumTot = 0;
            int countTot = 1;
            double enteredNumberWhile = 0;
            int z = 1;
            Write($"Enter number: ");
            enteredNumberWhile = double.Parse(ReadLine());
            sumTot += enteredNumberWhile;
            while (0 != enteredNumberWhile)
            {
                Write($"Enter number: ");
                enteredNumberWhile = double.Parse(ReadLine());
                sumTot += enteredNumberWhile;
                countTot = z;
                z++;
            }
            WriteLine($"Sum of given numbers is {sumTot}");
            WriteLine($"Avarage of given numbers is {sumTot / countTot}");


            //print numbers 1 to 10
            int r = 1;
            while (r<=10)
            {
                WriteLine(r);
                r++;

            }

            //print numbers 1 to 10
            int s = 10;
            while (s >= 0)
            {
                WriteLine(s--);
                // s--;

            }








            Write("Enter Start Count: ");
            int rowsStar = int.Parse(ReadLine()); ;
            int spaceStar = rowsStar;

            for (int i = 1; i <= rowsStar; i++)
            {
                // Print stars
                if (i == 1 || i == rowsStar)
                {
                    for (int m = 0; m < rowsStar; m++)
                    {
                        Write("* ");
                    }
                    WriteLine();
                }
                else {
                    Write("* ");
                    for (int y = 1; y <= rowsStar-2; y++)
                    {
                        Write("  ");
                    }
                    Write("* ");
                    WriteLine();
                }
            }

            //spaceStar--;
            //for (int j = 1; j <= spaceStar; j++)
            //{
            //    Write("*    *");
            //}

            
     

            int rows = 5;
            int space = rows;

            for (int i = rows; i > 0; i--)
            {
                space--;
                for (int j = 1; j <= space; j++)
                {
                    Write(" ");
                }

                // Print stars
                for (int k = 0; k < (rows - i); k++)
                {
                    Write("* ");
                }

                WriteLine();
            }


            for (int i = 5; i > 0; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Write(k);
                }

                WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Write(k);
                }

                WriteLine();
            }

            //nested loop -- multification table

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    Write($"{i*j}\t");
                }
                WriteLine(); WriteLine();
            }

            //nested loop

            for (int i = 0; i <5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    Write(i);
                }
                WriteLine();
            }
            //Read 10 numbers from user and print count of even numbers
            //while loop
            int x = 0; // initialization
            int evanCount2 = 0;
            int givenNumber2 = 0;
            while (x < 10) // condition
            {
                Write($"Enter number {x}: ");
                givenNumber2 = int.Parse(ReadLine());
                if ((givenNumber2 % 2) == 0)
                    evanCount2++;
                
                x++; // increment
            }
            WriteLine($"Entered even number count is {evanCount2}");

            ReadKey();

            //for loop
            int evanCount = 0;
            double givenNumber = 0;
            for (int i = 1; i <= 10; i++)
            {
                Write($"Enter number {i}: ");
                givenNumber = double.Parse(ReadLine());
                if ((givenNumber % 2) == 0)
                    evanCount++;
            }
            WriteLine($"Entered even number count is {evanCount}");
          
            WriteLine("***************************************************************");

            //Read 10 numbers fom user and print sum and avarage of those numbers
            double sum = 0;
            int count = 1;
            double enteredNumber = 0;
            for (int i = 1; i <= 10; i++)
            {
                Write($"Enter number {i}: ");
                enteredNumber = double.Parse(ReadLine());
                sum += enteredNumber;
                count = i;
            }
            WriteLine($"Sum of given numbers is {sum}");
            WriteLine($"Avarage of given numbers is {sum / count}");

            WriteLine("***************************************************************");
            //Read 10 numbers fom user and print them
            for (int i = 1; i <= 10; i++)
            {
                Write($"Enter number {i}: ");
                
                WriteLine($"Number is {double.Parse(ReadLine())}");
            }


            WriteLine("***************************************************************");
            //Read 10 numbers fom user and print them
            double number;
            for (int i = 1; i <= 10; i++)
            {
                Write($"Enter number {i}: ");
                number = double.Parse(ReadLine());
                WriteLine(number);
            }

            WriteLine("***************************************************************");

            // pirnt the odd numbers between 0 10
            WriteLine("Even numbers between 0 to 10");
            for (int i = 1; i < 10; i = i + 2)// this is exicuting only 6 time
            {
                WriteLine(i);
            }


            WriteLine("***************************************************************");


            for (int i = 0; i <= 10; i++)
            {
                if ((i % 2) != 0) // if((i % 2) == 1)
                    WriteLine(i);
            }

            // pirnt the even numbers between 0 10
            WriteLine("Even numbers between 0 to 10");
            for (int i = 0; i <= 10; i = i + 2)// this is exicuting only 6 time
            {
                WriteLine(i);
            }
            
            
            WriteLine("***************************************************************");


            for (int i = 0; i <= 10; i++)
            {
                if((i % 2) == 0)
                 WriteLine(i);
            }

            


            WriteLine("Print one to ten using for loop: ");
            for (int i = 1; i <= 12; i++)
            {
                int result = 5 * i;
                WriteLine($"5 X {i} = {result}");
            }
            WriteLine("***************************************************************");



            //int i = 0;
            //for (; i <= 10;)
            //{
            //    WriteLine(i);
            //    i++;
            //}

            WriteLine("Print one to ten using for loop: ");
            for (int i = 1 ; i <= 10; i++)
            {
                WriteLine(i);
            }
            WriteLine("***************************************************************");

            WriteLine("Print ten to one using for loop: ");
            for (int i = 10; i > 0; i--)
            {
                WriteLine(i);
            }
            WriteLine("***************************************************************");

            //WriteLine("Using for loop: ");
            //for (sbyte i = 1; i <= 5; i--)
            //{
            //    WriteLine(i);
            //}
            //WriteLine();



            ReadKey();   
        }
    }
}
