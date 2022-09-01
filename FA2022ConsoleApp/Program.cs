// See https://aka.ms/new-console-template for more information
using System; // == import




public class MyProgram
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a number and I will square it");

        Console.WriteLine(ClassLibrary1.MathLib.SquareFromString(Console.ReadLine()));
    }
}
