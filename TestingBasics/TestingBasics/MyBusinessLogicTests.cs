using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTestsSample
{
    [TestClass]
    public class MyBusinessLogicTests
    {
        [TestMethod]
        public void NormalResultTest()
        {
            //arrange
            var myBizLogic = new MyBusinessLogic();

            //act

            var result = myBizLogic.CalculateAdditionResult(1, 2);
            
            //assert

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [DataRow(1,2,3)]
        [DataRow(10, 1, 10)]
        [DataRow(1, -2, 0)]
        [DataRow(10, 1, 11)]

        public void DataDrivenTest(int x, int y, int answer)
        {
            //arrange
            var myBizLogic = new MyBusinessLogic();

            //act

           var  result = myBizLogic.CalculateAdditionResult(x, y);

            //assert

            Assert.AreEqual(answer, result);

        }
    }
}
