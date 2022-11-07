using Humanizer;


// Java package ~ C# Project / Compilation Unit
// default access package, default access is internal
namespace ClassLibrary1 // ~ package
{
    // top level classes can be public or internal
    internal static class ExtMethods // all methods must be static
    {
        public static int ToPower(this int x, int y)
        {
            return (int)System.Math.Pow(x, y);
        }

        public static bool IsPalindrome(this String s)
        {
            return s == "Bob";
        }
    }
    public class MathLib // internal accessible in this project= assembly
    {
        public static int SquareFromString(String s)
        {
            int x = Convert.ToInt32(s);
            int squaredX = (int)System.Math.Pow(x, 2);
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

            String s = "Bob";
            s.LastIndexOf("a");
/*
            Object o = Reflection.CreateObject(String.class);
            Reflection.CallMethod(o, "LastIndexOf", "AA")
*/
            return val.ToWords();
        }

        public static void Swap(ref int x, ref int y)
        {
            int t = x ^ y;
            x = x ^ t;
            y = y ^ t;
        }


        public static void Swap(ref String x, ref String y)
        {
            var t =x;
            x = y;
            y = t;
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

    class Geometry
    {
        // auto-property
        public double Radius { get; set; } // hidden field
        public double Diameter { 
            get { 
                return Radius * 2; }
        }
        public double Area { get { return Radius * Radius * Math.PI; } }

        public Geometry()
        {
            Radius = 9;
            // Diameter = 8; not legal--there is no setter
        }

    }
    public class Math
    {
        public const double PI = 3.14;
        public const int SIZE = 10;
        public int Square = SIZE * SIZE;
    }
    public class Fraction
    {
        public override bool Equals(Object o)
        {
            if (o == null) return false;
            if (!(o is Fraction)) return false;
            Fraction other = (Fraction)o;


            return this == other;
        }

        private readonly int d;
        public int Numerator { get; init; } // default prop
        // hidden field that stores Numerator
        public int Denominator
        {
            get
            {
                return d;
            }
            init
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator must not be 0");
                }
                d = value;
            }
        }

        public Fraction(int n = 0, int d = 1)
        {
            Numerator = n;
            Denominator = d;
        }

        public override String ToString()
        {
            return $"[{Numerator}/{Denominator}]";
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Numerator,
                f1.Denominator * f2.Denominator);
        }
        // TODO Stub
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction();
        }

        public static Fraction operator -(Fraction f1)
        {
            return new Fraction(-f1.Numerator, f1.Denominator);
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator > f2.Numerator * f1.Denominator;
        }
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return !(f1 < f2);
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator < f2.Numerator * f1.Denominator;
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return !(f1 > f2);
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denominator == f2.Numerator * f1.Denominator;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        // implicit used when conversion involves no loss of data/precision == it is perfectly safe
        public static explicit operator int(Fraction f)
        {
            return f.Numerator / f.Denominator;
        }
        public static explicit operator double(Fraction f)
        {
            return ((double)f.Numerator / f.Denominator);
        }

        public static implicit operator Fraction(int v)
        {
            return new Fraction(v);
        }
        // Property replacement for getNumerator, setNumrator
        // encapsulation / protecting our private data
        // properies are much more powerful syntactic sugar
        // ORM's depend on properties = POCO
        // Built-In Tooling = PopertyGrid
        // Properties are methods disguised as Fields (Instance Variables)


        public int this[String v]
        {
            get { return v == "0" ? Numerator : Denominator; }

            init
            {
                if (v == "0")
                    Numerator = value;
                else Denominator = value;
            }
        }
    }

}
