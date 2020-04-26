using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject2
{
    class UnitTestSumNumbers
    {
        /// <summary>
        /// Тест сложения двух чисел
        /// </summary>
        [TestMethod]
        public void TestMethodSumNumbers()
        {
            // arrange
            int par1 = 5;
            int par2 = 7;
            int result = 12;

            // act
            var actual = Class.Add(par1, par2);

            // assert
            Assert.AreEqual(result, actual);
        }
    }
}
