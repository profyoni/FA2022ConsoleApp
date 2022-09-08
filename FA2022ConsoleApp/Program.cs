// See https://aka.ms/new-console-template for more information
using System; // == import



class Fraction { }
public class MyProgram
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a number and I will square it");

        Console.WriteLine(ClassLibrary1.MathLib.SquareFromString(Console.ReadLine()));

        // Lots of COOL syntactic sugar
        // Extension Methods = appears like a instance method, but is really not
        // static class (in Java exists as a static inner class)

        var x = new Fraction();

        // if (boolean expr) , else, for, while, do while
        int[] list = {3,4};

        // Java int[] list, list2 OR int list[], x, y;

        foreach (var q in list) // like in Java ReAD only
        {
            Console.WriteLine(q);
        }
    }


}
