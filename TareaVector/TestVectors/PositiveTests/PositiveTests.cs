using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaVector;
using System;
using Fundacion.Jala.AppVector;

namespace TestVectors.PositiveTests
{
    [TestClass]
    public class PositiveTests
    {
        [TestMethod]
        public void AddVector()
        {
            var vectorA = new VectorOperations(2, 4);
            var vectorB = new VectorOperations(2, 3);
            var resultSum = vectorA.Add(vectorB);
            Assert.AreEqual(resultSum.X, 4);
            Assert.AreEqual(resultSum.Y, 7);
        }

        [TestMethod]
        public void PropVector()
        {
            var vectorA = new VectorOperations(1, 2);
            var vectorB = new VectorOperations(2, 3);
            var resultProp = vectorA.Prop(vectorB);
            Assert.AreEqual(resultProp, 8);
        }

        [TestMethod]
        public void LengthTest()
        {
            var vectorA = new VectorOperations(1, 2);
            var vectorB = new VectorOperations(2, 1);
            var resultSum = vectorA.Add(vectorB);
            var lengthVec = resultSum.LengthVector();
            var expectedResult = Math.Sqrt(18);
            Assert.AreEqual(lengthVec, expectedResult);
        }
    }
}
