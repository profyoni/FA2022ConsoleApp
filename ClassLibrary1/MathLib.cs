﻿using Humanizer;


namespace ClassLibrary1 // ~ package
{
    public class MathLib // internal accessible in this project= assembly
    {
        public static int SquareFromString(String s)
        {
            int x = Convert.ToInt32(s);
            int squaredX = (int)Math.Pow(x, 2);
            return squaredX;
        }

        /// <summary>
        /// Adds two numbers and returns them as a English string
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static String Add(int a, int b)
        {
            int val =  a + b;
            return val.ToWords();
        }

        // Datatypes
        // Java 8 primitves, all else classes (byte, short, int, long, float, char, bool, double,
        // primitive value is passed, not the address
        // primitives are created on stack (int x;), Objects on heap (new Zigwig())

        // C# Value-types = struct (include primitives and user define value types) VS Reference Types - class

        public int Types()
        {
            var x = "9.0f"; // implicit typing

            return 0;
        }
    }
}