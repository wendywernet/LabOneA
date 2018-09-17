using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag1 = true;
            int r = 0;
            string firstNumber ="";
            string numberOneA;
            string numberOneB;
            string numberOneC;
            int number1A;
            int number1B;
            int number1C;
            int number1;
            int number2;
            int number3;

            //while loop to enter first correct integer
            while (flag1)
            {
                Console.WriteLine("Please enter an integer number between 100 and 999:");
                if (int.TryParse(Console.ReadLine(), out r))
                {
                    if (r < 100 || r > 999)
                    {
                        Console.WriteLine("Invalid entry, try again");
                    }
                    else
                    {
                        flag1 = false;
                        firstNumber = Convert.ToString(r);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry, try again");
                }
            }
        {
            bool flag2 = true;
            int s = 0;
            string secondNumber = "";
            string numberTwoA;
            string numberTwoB;
            string numberTwoC;
            int number2A;
            int number2B;
            int number2C;

                //while loop to enter 2nd correct integer
            while (flag2)
            {
                Console.WriteLine("enter another integer number between 100 and 999");
                if (int.TryParse(Console.ReadLine(), out s))
                {
                    if (s<100 || s>999)
                    {
                            Console.WriteLine("Invalid entry, try again");
                    }  
                    else
                    {
                            flag2 = false;
                            secondNumber=Convert.ToString(s);
                    }
                }
                else
                {
                        Console.WriteLine("invalid entry, try again");
                }
            }
            //convert to substring
                numberOneA = firstNumber.Substring(0, 1);
                numberOneB = firstNumber.Substring(1, 1);
                numberOneC = firstNumber.Substring(2, 1);
                numberTwoA = secondNumber.Substring(0, 1);
                numberTwoB = secondNumber.Substring(1, 1);
                numberTwoC = secondNumber.Substring(2, 1);
            //convert from string back to integer, in order to add
                number1A = Convert.ToInt32(numberOneA);
                number1B = Convert.ToInt32(numberOneB);
                number1C = Convert.ToInt32(numberOneC);
                number2A = Convert.ToInt32(numberTwoA);
                number2B = Convert.ToInt32(numberTwoB);
                number2C = Convert.ToInt32(numberTwoC);
            //add corresponding numbers together
                number1 = number1A + number2A;
                number2 = number1B + number2B;
                number3 = number1C + number2C;

            //condition statement if numbers are equal
                if (number1 == number2 && number2== number3)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
        }
        }
    }
}
