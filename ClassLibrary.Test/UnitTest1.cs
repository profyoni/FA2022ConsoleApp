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
    }
}