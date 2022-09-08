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
            ExtMethods.ToPower(2,10).Should().Be(1024);
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

            for(int i=0;i<list.Length; i++) // like in Java ReAD only
            {
                list[i] = 0;
            }
            list[0].Should().Be(0);
        }
    }
}