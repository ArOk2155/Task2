using System;

namespace Lesson2_2022_06_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCapitalizationOfNumber(86));
        }


        //1.	The user enters 2 numbers (A and B). If A > B, result is A+B, if A=B, result is A * B, if A < B, result is A-B.
        static int Condition1(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }


        //2.	The user enters 2 numbers (X and Y). Determine which quarter the point with coordinates (X, Y) belongs to.
        static int GetCoordinateQuater(int x, int y)
        {
            int result = 0;
            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x > 0 && y < 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x < 0 && y > 0)
            {
                result = 4;
            }

            return result;
        }


        //3.	The user enters 3 numbers (A, B and C). Print them to the console in ascending order.
        static (int min, int mid, int max) GetAscendingOrder(int a, int b, int c)
        {
            int min = 0;
            int mid = 0;
            int max = 0;
            
            int flag = ComparingTwoNumbers(a, b);
            flag += 10 * ComparingTwoNumbers(a, c);
            flag += 100 * ComparingTwoNumbers(b, c);

            switch (flag)
            {
                case 0:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 1:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 2:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 10:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 11:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 12:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 20:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 21:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 22:
                    min = a;
                    mid = b;
                    max = c;
                    break;
                case 112:
                    Console.WriteLine(flag);
                    break;
                case 201:
                    min = a;
                    mid = c;
                    max = b;
                    break;
                default:
                    Console.WriteLine(flag);
                    break;
            }
            
            return (min, mid, max);
        }

        static int ComparingTwoNumbers(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x < y)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }


        //4.	The user enters 3 numbers (A, B and C). Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.




        //5.	The user enters a two-digit number. Print the capitalization of this number to the console. For example, typing "25" will print "twenty-five" to the console.
        static string GetCapitalizationOfNumber(int a)
        {
            int intNum = a / 10;
            int divisionRemainder = a % 10;
            string firstNum = "";
            string secondNum = "";

            if (intNum == 1)
            {
                switch (divisionRemainder)
                {
                    case 0:
                        firstNum = "ten";
                        break;
                    case 1:
                        firstNum = "eleven";
                        break;
                    case 2:
                        firstNum = "twelve";
                        break;
                    case 3:
                        firstNum = "thirteen";
                        break;
                    case 4:
                        firstNum = "fourteen";
                        break;
                    case 5:
                        firstNum = "fifteen";
                        break;
                    case 6:
                        firstNum = "sixteen";
                        break;
                    case 7:
                        firstNum = "seventeen";
                        break;
                    case 8:
                        firstNum = "eighteen";
                        break;
                    case 9:
                        firstNum = "nineteen";
                        break;
                }
            }
            else
            {
                switch (intNum)
                {
                    case 2:
                        firstNum = "twenty";
                        break;
                    case 3:
                        firstNum = "thirty";
                        break;
                    case 4:
                        firstNum = "fourty";
                        break;
                    case 5:
                        firstNum = "fifty";
                        break;
                    case 6:
                        firstNum = "sixty";
                        break;
                    case 7:
                        firstNum = "seventy";
                        break;
                    case 8:
                        firstNum = "eighty";
                        break;
                    case 9:
                        firstNum = "ninety";
                        break;
                }
                switch (divisionRemainder)
                {
                    case 1:
                        secondNum = "one";
                        break;
                    case 2:
                        secondNum = "two";
                        break;
                    case 3:
                        secondNum = "three";
                        break;
                    case 4:
                        secondNum = "four";
                        break;
                    case 5:
                        secondNum = "five";
                        break;
                    case 6:
                        secondNum = "six";
                        break;
                    case 7:
                        secondNum = "seven";
                        break;
                    case 8:
                        secondNum = "eight";
                        break;
                    case 9:
                        secondNum = "nine";
                        break;
                }
            }

            return (firstNum + " " + secondNum);
        }
    }   
}
