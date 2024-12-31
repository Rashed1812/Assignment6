using System;
using System.Collections.Generic;
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

            //Console.Write("Enter Number To Know If This Number Is Prime: ");
            //int.TryParse(Console.ReadLine(), out int Num);

            //if (Num < 0) { Console.WriteLine("Invalid input , Enter Positive Number"); }

            //else
            //{
            //    bool result = IsPrime(Num);
            //    Console.WriteLine(result);
            //}

            //static bool IsPrime(int PrimeNum)
            //{
            //    for (int i = 2; i < PrimeNum; i++)
            //    {
            //        if (PrimeNum % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}
            //IsPrime(Num);


            #endregion

            #region 4.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //Console.Write("Enter Number of Elements You Want To Get Max And Min: ");
            //int.TryParse(Console.ReadLine(), out int elements);

            //int[] nums = new int[elements];
            //int min = 0;
            //int max = 0;
            //Console.WriteLine("Enter The Numbers Of Array: ");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //static void MinMaxArray(int[] nums , ref int min , ref int max)
            //{
            //    min = nums.Min();
            //    max = nums.Max();
            //    Console.WriteLine($"Min Number In Array Is: {min}");
            //    Console.WriteLine($"Max Number In Array Is: {max}");
            //}
            //MinMaxArray(nums ,ref min ,ref max);

            #endregion

            #region 5.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Enter Number To Get Factorial: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (num < 0) { Console.WriteLine("Invalid input , Enter Positive Number"); }
            //else { GetFactorial(num); }

            //static void GetFactorial(Int64 FactorialNum) 
            //{
            //    int result = 1;
            //    for (int i = 1; i <= FactorialNum; i++)
            //    {
            //        result *= i;
            //    }
            //    Console.WriteLine($"The Factorial of {FactorialNum} is {result}");
            //}

            #endregion

            #region 6.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example

            ////passing by value
            //static int SumNumbersArray(int[] nums) 
            //{
            //    nums[0] = 100;
            //    int sum = 0;
            //    for (int i = 0; i < nums.Length; i++) 
            //    {
            //        sum += nums[i];
            //    }
            //    return sum;
            //}
            //int[] numbers = {1,2,3,4,5,6,7};
            //int total = SumNumbersArray(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(total);

            ////passing by ref
            //static int SumNumbersArray(ref int[] nums)
            //{
            //    nums[0] = 100;
            //    int sum = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        sum += nums[i];
            //    }
            //    return sum;
            //}
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //int total = SumNumbersArray(ref numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(total);

            #endregion

            #region 7.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //Console.Write("Enter First Number To Get Result Of Summation And Subtracting: ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.Write("Enter Second Number To Get Result Of Summation And Subtracting: ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //static (int sum, int sub)  SummationAndSubtracting (int first, int second) 
            //{
            //    int sum = first + second;
            //    int sub = first - second;
            //    return (sum, sub);
            //}
            //var (sum, sub) = SummationAndSubtracting(num1, num2);

            //Console.WriteLine($"The Summation Of Numbers {num1} + {num2} = {sum}");
            //Console.WriteLine($"The Subtracting Of Numbers {num1} - {num2} = {sub}");

            #endregion
        }
    }
}
