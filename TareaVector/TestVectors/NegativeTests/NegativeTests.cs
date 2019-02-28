using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TareaVector;

namespace TestVectors.NegativeTests
{
    [TestClass]
    public class NegativeTests
    {
        [TestMethod]
        public void ValidDataVector()
        {
            string[] testArgs = { "2,4", "2,3", "1,4" };
            var operation = DataAdapter.Instance;
            Assert.ThrowsException<ArgumentException>(() => operation.ValidateInput(testArgs));
        }


        [TestMethod]
        public void ValidTypeVector()
        {
            string[] testArg = { "2,4", "2,a" };
            var operation = DataAdapter.Instance;
            var vectorA = operation.VectorA;
            var vectorB = operation.VectorB;
            Exception ex = Assert.ThrowsException<ArgumentException>(() => operation.ValidateInput(testArg));
            Assert.AreEqual("the vector data is not numbers", ex.Message);
        }

    }
}
