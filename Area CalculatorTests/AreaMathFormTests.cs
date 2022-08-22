using Microsoft.VisualStudio.TestTools.UnitTesting;
using Area_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator.Tests
{
    [TestClass()]
    public class AreaMathFormTests
    {
        [TestMethod()]
        public void SqureAreaTest()
        {
            decimal length = (decimal)4.555;
            var result_expected = length * length;
            var result_real= AreaMathForm.SqureArea(length);
            Assert.IsTrue(result_expected == result_real);
        }
        [TestMethod()]
        public void SqureAreaTestType()
        {
            decimal length = (decimal)4.555;
            var result = AreaMathForm.SqureArea(length);
            Assert.IsInstanceOfType(result,typeof(decimal));
        }

        [TestMethod()]
        public void RecAreaTest()
        {
            decimal length = (decimal)4.555;
            decimal width = (decimal)2.5;
            var result_expected = length * width;
            var result_real= AreaMathForm.RecArea(length, width);
            Assert.IsTrue(result_expected == result_real);
        }
        [TestMethod()]
        public void RecAreaTestType()
        {
            decimal length = (decimal)4.555;
            decimal width = (decimal)2.5;
            var result= AreaMathForm.RecArea(length, width);
            Assert.IsInstanceOfType(result, typeof(decimal));
        }
        [TestMethod()]
        public void TriAreaTest()
        {
            decimal width = (decimal)4.555;
            decimal height = (decimal)2.5;
            var result_expected =width*height/2;
            var result_real = AreaMathForm.TriArea(width,height);
            Assert.IsTrue(result_expected == result_real);
        }
        [TestMethod()]
        public void TriAreaTestType()
        {
            decimal width = (decimal)4.555;
            decimal height = (decimal)2.5;
            var result = AreaMathForm.TriArea(width, height);
            Assert.IsInstanceOfType(result, typeof(decimal));
        }

        [TestMethod()]
        public void RoundAreaTest()
        {
            decimal diam = (decimal)4.555;
            var result_expected =(decimal)3.1415926*(diam/2)*(diam/2);
            var result_real = AreaMathForm.RoundArea(diam);
            Assert.IsTrue(result_expected == result_real);
        }
        [TestMethod()]
        public void RoundAreaTestType()
        {
            decimal diam = (decimal)4.555;
            var result = AreaMathForm.RoundArea(diam);
            Assert.IsInstanceOfType(result, typeof(decimal));
        }
    }
}