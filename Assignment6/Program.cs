using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
            ////passing by value
            ////in passing by value CLR create a new Place to store (X , Y) <Parameters> And A ,B Will be same value Because No one Going Fro they Location In memory
            //static void Function1(int x, int y)
            //{
            //    int z = x;
            //    x = y;
            //    y = z;
            //}

            //int A = 3, B = 5;
            //Console.WriteLine("Before");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //Function1(A, B);
            //Console.WriteLine("After");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");



            ////Passing by Ref
            ////Any change in Parameters will be affect in Original Variable Because Copy Location of Orignal Var to Parameters
            //static void Function2(ref int x, ref int y)
            //{
            //    int z = x;
            //    x = y;
            //    y = z;
            //}

            //int num1 = 3, num2 = 5;
            //Console.WriteLine("Before");
            //Console.WriteLine($"Num1 = {num1}");
            //Console.WriteLine($"Num2 = {num2}");

            //Function2(ref num1, ref num2);
            //Console.WriteLine("After");
            //Console.WriteLine($"Num1 = {num1}");
            //Console.WriteLine($"Num2 = {num2}");

            #endregion

            #region 2.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7
            //Console.Write("Enter Number To Know Sum Of Individual Digits: ");
            //int.TryParse(Console.ReadLine(), out int digits);

            //if (digits < 0) { Console.WriteLine("Invalid input , Enter Positive Number"); }
            //else { IndividualDigits(digits); }

            //static void IndividualDigits (int num) 
            //{
            //    int sum = 0;
            //    while (num > 0)
            //    {
            //        sum += num % 10;
            //        num /= 10;
            //    }
            //    Console.WriteLine($"The sum of the digits of the number {num} is: {sum}");
            //}
            #endregion

            #region 3.reate a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //    Console.Write("Enter Number To Know If This Number Is Prime: ");
            //    int.TryParse(Console.ReadLine(), out int Num);

            //    if (Num < 0) { Console.WriteLine("Invalid input , Enter Positive Number"); }

            //    else
            //    { 
            //       bool result = IsPrime(Num);
            //       Console.WriteLine(result); 
            //    }

            //    static bool IsPrime(int PrimeNum)
            //    {
            //        for (int i = 2; i < PrimeNum; i++)
            //        {
            //            if (PrimeNum % i == 0)
            //            {
            //                return false;
            //            }
            //        }
            //        return true;
            //    }
            //}

            #endregion
        }
    }
}
