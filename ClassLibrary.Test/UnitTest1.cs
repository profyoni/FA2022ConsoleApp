using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using FluentAssertions;

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

            int x = int.MaxValue-99;
            float f = (float)(x);

          //  ((long)x).Should().Be( (long)f);

            var x2 = 0.1; // doles not have closed binary fractional form

            // NEVER USE floats or doubles for money

            decimal d = 144.234M; // BigInteger, BigNumber

            double f1 = 1.0, f2 = 0.99999999999999999999999999;

            var delta = 0.0000000001;
            System.Math.Abs(f1 - f2).Should().BeLessThan(delta);
            Assert.AreEqual(f1, f2, 0.001);


        }

    }
}