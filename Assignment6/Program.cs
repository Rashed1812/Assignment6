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

        }
    }
}
