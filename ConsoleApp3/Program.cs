using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region q1
            Console.Write("enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion


            #region q2
            Console.Write("enter an integer ");
            int number2 = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
            #endregion


            #region q3
            Console.Write("enter three integers ");
            string input = Console.ReadLine();

            int num1 = int.Parse(input[0].ToString());
            int num2 = int.Parse(input[1].ToString());
            int num3 = int.Parse(input[2].ToString());


            int max = num1;
            if (num2 > max) max = num2;
            if (num3 > max) max = num3;


            int min = num1;
            if (num2 < min) min = num2;
            if (num3 < min) min = num3;

            Console.WriteLine("Max element = " + max);
            Console.WriteLine("Min element = " + min);

            #endregion



            #region q4
            Console.Write("enter an integer ");
            int number3 = int.Parse(Console.ReadLine());

            if (number3 % 2 == 0)
            {
                Console.WriteLine(" even ");
            }
            else
            {
                Console.WriteLine(" odd ");
            }
            #endregion



            #region q5
            Console.Write("enter a  capital character ");
            char ch = Char.Parse(Console.ReadLine());


            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            #endregion



            #region Q6
            Console.Write("enter an integer ");
            int number7 = int.Parse(Console.ReadLine());


            for (int i1 = 1; i1 <= 12; i1++)
            {
                Console.WriteLine(number7 * i1);
            }
            #endregion


            #region q7
            Console.Write("enter a number ");
            int number8 = int.Parse(Console.ReadLine());

            int i = 2;
            while (i <= number8)
            {
                Console.WriteLine(i);
                i += 2;
            }
            #endregion


            #region q8
            Console.Write("enter the number ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("enter the power");
            int p = int.Parse(Console.ReadLine());


            int result = 1;
            for (int i2 = 1; i2 <= p; i2++)
            {
                result *= n;
            }

            Console.WriteLine(" the result is " + result);

            #endregion



            #region q9
            Console.Write("Enter the month number ");
            int month = int.Parse(Console.ReadLine());

            int days = 0;


            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;


                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;


                case 2:
                    days = 28;
                    break;

                default:
                    Console.WriteLine("Invalid month number");
                    return;


            }

            Console.WriteLine($"Days in month {month}: {days}");
            #endregion


            #region q10
            Console.Write("Enter the time  ");
            double timeTaken = double.Parse(Console.ReadLine());


            if (timeTaken >= 2 && timeTaken <= 3)
            {
                Console.WriteLine("Highly efficient.");
            }
            else if (timeTaken > 3 && timeTaken <= 4)
            {
                Console.WriteLine("Increase your speed.");
            }
            else if (timeTaken > 4 && timeTaken <= 5)
            {
                Console.WriteLine("You need training to enhance your speed.");
            }
            else if (timeTaken > 5)
            {
                Console.WriteLine("You are required to leave the company.");
            } 
            #endregion
        }




    }
}

    

 


