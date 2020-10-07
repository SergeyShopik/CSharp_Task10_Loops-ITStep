using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using C_sharp_task10_library;

namespace C_sharp_task10_loops_iterative_algs
{
    [TestClass]
    public class Task10Test
    {
        [TestMethod]
        public void HeadsOrTailsTest_1000Throws_HeadsPlusTailsEquals1000()
        {
            int expected = 1000;
            List<int> headsAndTails = new List<int>();
            headsAndTails = Task10.CountHeadsAndTails(expected);//[0] contains heads, [1] - tails
            int actual = headsAndTails[0] + headsAndTails[1];

            Assert.AreEqual(expected, actual);
        }
        //----------------------------------------------------------------------------------------------
        [TestMethod]
        public void CountDigitsInNumberTest_1234_4()
        {
            int expected = 4;
            int actual = Task10.CountDigitsInNumber(1234);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReverseNumberTest_1234000_4321()
        {
            int expected = 4321;
            int actual = Task10.ReverseNumber(1234000);

            Assert.AreEqual(expected, actual);
        }
        //----------------------------------------------------------------------------------------------
        [TestMethod]
        public void IsPrimeNumberTest_19_true()
        {
            bool expected = true;
            bool actual = Task10.IsPrimeNumber(19);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsPrimeNumberTest_4_false()
        {
            bool expected = false;
            bool actual = Task10.IsPrimeNumber(4);

            Assert.AreEqual(expected, actual);
        }
        //----------------------------------------------------------------------------------------------
        [TestMethod]
        public void CalculateFactorialTest_5_120()
        {
            int expected = 120;
            int actual = Task10.CalculateFactorial(5);

            Assert.AreEqual(expected, actual);
        }
        //----------------------------------------------------------------------------------------------
        [TestMethod]
        public void FindAllNumberDivisorsTest_28_5()
        {
            int expected = 5;
            List<int> temp = Task10.FindAllNumberDivisors(28);

            int actual = temp.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsPerfectNumberTest_8128_true()
        {
            bool expected = true;
            bool actual = Task10.IsPerfectNumber(8128);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //result consists of 9 elements each representing quantity of respective digit in a number
        public void CalculateDifferentDigitsInNumberTest_223400334_list0023200000()
        {
            List<int> expected = new List<int> { 2, 0, 2, 3, 2, 0, 0, 0, 0, 0 };
            List<int> actual = new List<int>(10);
            actual = Task10.CalculateDiffernetDigitsInNumber(223400334);

            Assert.AreEqual(expected, actual);
        }
    }
}
