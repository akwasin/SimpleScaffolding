using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTesting.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void additionTest_correctCalculation()
        {
            Program testOne = new Program();
            var actual = testOne.addition(5, 1);
            var estimated = 6;
            Assert.AreEqual(actual, estimated);
        }

        [TestMethod()]
        public void additionTest_notStringResult()
        {
            Program testTwo = new Program();
            var actual = testTwo.addition(5, 1);
            var estimated = "sex";
            Assert.AreNotEqual(actual,estimated);
        }

        [TestMethod()]
        public void additionTest_notAcceptDecimal()
        {
            Program testThree = new Program();
            var actual = testThree.addition(5, 1);
            var estimated = 6.0;
            Assert.AreNotSame(actual,estimated);
        }

        [TestMethod()]
        public void additionTest_notAcceptSpaceBefore()
        {
            Program testFour = new Program();
            var actual = testFour.addition(5, 1);
            var estimated = "" + 6;
            Assert.AreNotSame(actual,estimated);
        }

        /*
         Check that method addition works
         Check that it doesnt return a string
         Check that it doesnt return a decimal
         Check that it doesnt return empty string + int

        All tests passed so far
         */
    }
}