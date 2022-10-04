using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using FluentAssertions;
using System;

namespace ClassLibrary.Test
{
    [TestClass]
    public class MathLibTest
    {
        [TestMethod]
        public void SquareFromString()
        {
            // AAA - Arrange, Act, Assert

            int actual = MathLib.SquareFromString("3");

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Add1_2()
        {
            MathLib.Add(1, 2).Should().Be("three");
        }

        [TestMethod]
        public void PowerTo()
        {
            2.ToPower(10).Should().Be(1024);
        }

        [TestMethod]
        public void PowerTo2()
        {
            ExtMethods.ToPower(2, 10).Should().Be(1024);
        }

        [TestMethod]
        public void IsPalindrome()
        {
            ("Bob".ToString() + "").IsPalindrome().Should().Be(true);
        }

        [TestMethod]
        public void LanguageTest1()
        {
            int[] list = { 3, 4 };

            // Java int[] list, list2 OR int list[], x, y;

            foreach (var q in list) // like in Java ReAD only
            {
                // not legal q = 0;
            }

            for (int i = 0; i < list.Length; i++) // like in Java ReAD only
            {
                list[i] = 0;
            }
            list[0].Should().Be(0);
        }


        [TestMethod]
        public void Verbatim()
        {
            var s = @"http:\\www.example.com";
            s.Should().Be("http:\\\\www.example.com");
        }


        [TestMethod]
        public void StringInterpolation()
        {
            int id = 12345;
            var name = "Bob";
            var s = "Your name is" + name + "Your Id is" + id;
            s = $"Your name is {name} Your Id is {id}";
            s.Should().Be("Your name is Bob Your Id is 12345");
        }


        [TestMethod]
        public void Decimal_FloatingPoint()
        {
            var doubleVal = 123.45; // floats and doubles although they have greater range than int, they are only approximate

            int x = int.MaxValue - 99;
            float f = (float)(x);

            //  ((long)x).Should().Be( (long)f);

            var x2 = 0.1; // doles not have closed binary fractional form

            // NEVER USE floats or doubles for money

            decimal d = 144.234M; // BigInteger, BigNumber

            double f1 = 1.0, f2 = 1.0 / 3.0;
            f2 *= 3;

            var delta = 0.0000000001;
            System.Math.Abs(f1 - f2).Should().BeLessThan(delta);
            Assert.AreEqual(f1, f2, 0.001);

            /*
            if (f1 == f2)
            {

            }
            */

            const double Tolerance = 0.000001;
            if (System.Math.Abs(f1 - f2) < Tolerance)
            {

            }

        }
        [TestMethod]
        public void MethodCalling()
        {
            var x = MathLib.Add(2, 3);
            x = MathLib.Add(b: 3, a: 2);
        }

        [TestMethod]
        public void Fraction()
        {
            new Fraction(0,1);
            new Fraction(d: 6);
        }


        [TestMethod]
        public void Swap()
        {
            int a = 3, b = 2;
            MathLib.Swap(ref a, ref b);
            a.Should().Be(2);
        }

        [TestMethod]
        public void SwapString()
        {
            string a = "1", b = "2";
            MathLib.Swap(ref a, ref b);
            a.Should().Be("2");
        }
        // Passing a Reference, Plain Old pass an Object like a String
        // Pass a reference (or value) BY value
        // Passing By Reference = Alias


        [TestMethod]
        public void OutIn()
        {
            // out is used to state that the parameter passed must be modified by the method.

            //Int.Try
            
        }

        (int, int) Coord()
        {
            return (1, 2);
        }

        [TestMethod]
        public void Tuples()
        {
            string z = "";
            (int,int) x = (4, 5);
            x = new ValueTuple<int, int>(5, 6);
            x.Item1.Should().Be(5);

            var y = new Tuple<int, int>(1,2);
            x.Item1.Should().Be(5);

            Coord().Item1.Should().Be(1);
            Coord().Item2.Should().Be(2);
        }

        [TestMethod]
        public void NullableTypes()
        {
            int? ageFromDatabase = 3;
            //ageFromDatabase = null;
            Nullable<int> x = null;
            x.HasValue.Should().BeFalse();
            ageFromDatabase.Value.Should().Be(3);

            int q = ageFromDatabase ?? 0; // ISNULL = COALESCE(Title, "")
            String s = (new Random().NextDouble() > 0.99) ? "Bob" : null;

            String name = s ?? "";
            name.Should().Be("");
            s = "Bob";
            var q2 = s?.ToCharArray();
            q2[1].Should().Be('o');
            s[1].Should().Be('o');
        }

        [TestMethod]
        public void DateTime_Timespan_enum_DateTimeOffset()
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Now.AddDays(1.5);

            var diff = (dt2 - dt1);
            diff.Days.Should().Be(1);
            diff.Hours.Should().Be(12);
            diff.TotalHours.Should().BeApproximately(36.0,0.00001);

            DateTimeOffset dateTimeOffset = DateTimeOffset.Now;

           
        }

        [TestMethod]
        public void GeometryProps()
        {
            Geometry geom = new Geometry();
            geom.Radius = 1.0;
            geom.Diameter.Should().BeApproximately(2.0,0.001);
        }
        

        [TestMethod]
        public void FractionProps()
        {
            var f1 = new Fraction(2,3);
            f1.Numerator.Should().Be(2);

            var f2 = new Fraction 
            { 
                Numerator = 0, Denominator = 9 
            };

            // L-Value = R-value
            // 5 = x; BAD NEWS
            // x = y; x lvalue, y rvalue getting it
            //f1.Numerator = 8; // setter
            //f1.Numerator.Should().Be(8);

            var x = f1.Numerator;
        }

        // Op Loading extend intuitive behavior of operatoes like +,*,-,++ to User Defined classes
        // Precednce rules Cannot be changed
        // Cannot create new operators (e.g. +-)
        [TestMethod]
        public void OpOverloading()
        {
            Fraction
                _1_2 = new Fraction(1, 2),
                _3_8 = new Fraction
                {
                    Numerator = 3,
                    Denominator = 8
                },
                _2_4 = new Fraction(2,4);

            var f1 = _1_2 * _3_8;
            f1.Should().Be(new Fraction(3,16));
            (-_1_2).Should().Be(new Fraction(-1, 2));
            (_1_2 > _3_8).Should().BeTrue();
            (_1_2 >= _2_4).Should().BeTrue();

            var f2 = (_1_2 * _1_2) * _1_2; // 1/8

            int a =  (int) f2;
            var _2 = (int)new Fraction(8, 3);
            _2.Should().Be(2);
            ((double)new Fraction(8, 3))
                .Should().BeApproximately(8.0/3.0,0.00001);


            Fraction f4 = (Fraction) 5;
            f4.Should().Be(new Fraction(5, 1));
        }

    }
    class Student
    {
        private readonly int id; // const wont work here since it must be known at compile time and cannot be set in ctor
        Student(int id)
        {
            this.id = id;
        }
    }
    class Test
    {
        const double TaxRate = 8.25;
        // similar to a #define in C++
        const double Pi = 3.14; // compile time replacement...does not require memory access at run time

        readonly double E = 2.71828; // a variable that cannot change in your program

        double circum = 2 * Pi * 5; // replaced at compile time with =>  2 * 3.14 * 5; circum is set to its value at compile time, sincve all info is known

        // 1. readonly variables can be different for each object and set in ctor (like a Java final variable)
        // 2. readonly allows for greater flexibilty if the value in one module changes, the dependendt modeules do not need a re-compile as they will with const
    }


}