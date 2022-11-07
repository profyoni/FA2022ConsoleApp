using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    class Base
    {
        public virtual int foo()
        {
            return 1;
        }

        public int bar() // not virtual
        {
            return 3;
        }
    }

    class Derived : Base
    {

        public int foo()
        {
            return 2;
        }

        public int bar2()
        {
            return 4;
        }

        public override String ToString()
        {
            return "custom Derived Data";
        }
    }


    [TestClass]
    public class LanguageTest368
    {
        [TestMethod]
        public void Polymorphism()
        {
            Base b = new Base();
            b.foo().Should().Be(1);

            Derived d = new Derived();
            d.foo().Should().Be(2); ;

            b = (Base)new Derived(); // no polymorphism
            b.foo().Should().Be(1);

            try
            {
                d = (Derived)new Base(); // class cast exception
                d.foo();
            }
            catch (InvalidCastException cce)
            {
                return;
            }
            //Fail("Should have thrown a CCE");
        }
        internal class PolymorphismTest


        {
        }
    }
}
