using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaVector;

namespace TestVectors
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] testArgs = { "2,4", "2,3" };
            var operation = DataAdapter.Instance;
            operation.ValidateInput(testArgs);
            var vectorA = operation.VectorA;
            var vectorB = operation.VectorB;
            var resultSum = vectorA.Add(vectorB);
            Assert.AreEqual(4, 4);
        }
    }
}
